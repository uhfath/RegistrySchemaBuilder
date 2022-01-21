using Microsoft.VisualBasic;
using Microsoft.Win32;
using System.Text;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace RegistrySchemaBuilder;

internal static class Program
{
	private const string FileNamePattern = "{0}_reg.xsd";
	private static readonly DateTime ActivePeriod = DateTime.Today;

	private static readonly IEnumerable<string> FileTypes = new[]
	{
		"C",
		"H",
		"L",
		"T",
		"V",
		"X",
	};

	static readonly IDictionary<string, string> FileTypesChangeMap = new Dictionary<string, string>
	{
		{ "X", "D" }
	};

	private static XmlSchemaSet LoadSchema(string filePath)
	{
		var validationErrors = new StringBuilder();

		var schemaSet = new XmlSchemaSet();
		schemaSet.Add("", filePath);
		schemaSet.ValidationEventHandler += (s, e) =>
		{
			validationErrors.AppendLine($"{s}: {e.Message}");
		};
		schemaSet.Compile();

		if (validationErrors.Length > 0)
		{
			Console.Error.WriteLine("Ошибка валидации схемы");
			Console.Error.WriteLine(validationErrors);

			throw new XmlSchemaValidationException("Schema invalid");
		}

		return schemaSet;
	}

	private static XDocument LoadDocument(string filePath, XmlSchemaSet schemaSet)
	{
		var validationErrors = new StringBuilder();

		var document = XDocument.Load(filePath, LoadOptions.SetLineInfo);
		document.Validate(schemaSet, (s, e) =>
		{
			validationErrors.AppendLine($"{s}: {e.Message}");
		}, true);

		if (validationErrors.Length > 0)
		{
			Console.Error.WriteLine("Ошибка валидации документа");
			Console.Error.WriteLine(validationErrors);

			throw new XmlSchemaValidationException("Document invalid");
		}

		return document;
	}

	private static IDictionary<string, IEnumerable<RegistryRecord>> BuildRecords(XDocument document)
	{
		var deserializer = new XmlSerializer(typeof(Q018.packet));
		var packet = (Q018.packet)deserializer.Deserialize(document.CreateReader());

		return packet.zap
			.Where(z => FileTypes.Contains(z.TYPE_D))
			.Where(z => ActivePeriod >= DateTime.ParseExact(z.DATEBEG, "dd.MM.yyyy", null))
			.Where(z => ActivePeriod <= DateTime.ParseExact(string.IsNullOrWhiteSpace(z.DATEEND) ? "31.12.9999" : z.DATEEND, "dd.MM.yyyy", null))
			.OrderBy(z => z.IDZAP)
			.Select(z => new
			{
				Zap = z,
				IsStruct = z.FORM_E == "S",
				Path = z.ID_EL.Split(new[] { Constants.PathSeparator }, StringSplitOptions.RemoveEmptyEntries),
			})
			.Select(z => new RegistryRecord
			{
				Zap = z.Zap,
				IsStruct = z.IsStruct,
				ParentPath = string.Join(Constants.PathSeparator, z.Path.Take(z.Path.Count() - 1)),
				Path = string.Join(Constants.PathSeparator, z.Path),
				Element = z.IsStruct ? SchemaElements.CreateParentElement(z.Zap) : SchemaElements.CreateChildElement(z.Zap),
			})
			.GroupBy(z => z.Zap.TYPE_D)
			.ToDictionary(g => g.Key, g => g.ToArray().AsEnumerable());
	}

	private static XmlSchema BuildSchema(IEnumerable<RegistryRecord> records)
	{
		var missingParents = new StringBuilder();

		var schema = new XmlSchema();
		foreach (var record in records)
		{
			if (string.IsNullOrWhiteSpace(record.ParentPath))
			{
				schema.Items.Add(record.Element);
			}
			else
			{
				var parent = records
					.Where(z => z.IsStruct)
					.Where(z => z.Path == record.ParentPath)
					.SingleOrDefault();

				if (parent == null)
				{
					missingParents.AppendLine($"{record.ParentPath}, {record.Zap.TYPE_D}");
				}
				else
				{
					var complex = (XmlSchemaComplexType)parent.Element.SchemaType;
					var sequence = (XmlSchemaSequence)complex.Particle;
					sequence.Items.Add(record.Element);
				}
			}
		}

		if (missingParents.Length > 0)
		{
			Console.Error.WriteLine("Missing root elements");
			Console.Error.WriteLine(missingParents);
			throw new XmlSchemaValidationException("Missing roots");
		}

		return schema;
	}

	private static int Main(string[] args)
	{
		Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

		if (args.Length < 2)
		{
			Console.WriteLine("Пропущены обязательные параметры");
			Console.WriteLine("RegistrySchemaBuilder \"schema_Q018.xsd\" \"source_Q018.xml\" \"output_destination_folder\"");

			return 1;
		}

		var sourceSchema = args[0];
		var sourceDocument = args[1];
		var outputDir = args[2];

		var schemaSet = LoadSchema(sourceSchema);
		var document = LoadDocument(sourceDocument, schemaSet);
		var records = BuildRecords(document);

		foreach (var record in records)
		{
			var schema = BuildSchema(record.Value);
			var fileType = FileTypesChangeMap.TryGetValue(record.Key, out var _fileType) ? _fileType : record.Key;
			var fileName = string.Format(FileNamePattern, fileType);
			var filePath = Path.Combine(outputDir, fileName);

			Directory.CreateDirectory(Path.GetDirectoryName(filePath));
			using var writer = new StreamWriter(filePath, false, Encoding.UTF8);
			schema.Write(writer);
		}

		return 0;
	}
}
