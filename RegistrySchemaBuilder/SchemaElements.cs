using System.Globalization;
using System.Xml;
using System.Xml.Schema;

namespace RegistrySchemaBuilder;

public static class SchemaElements
{
	private static int GetDecimals(decimal n)
	{
		static int GetDecimalsFunc(decimal n, int decimals) =>
			n % 1 != 0 ? GetDecimalsFunc(n * 10, decimals + 1) : decimals;

		return GetDecimalsFunc(n, 0);
	}

	private static ulong PowerLong(ulong value, int power)
	{
		var result = 1UL;
		while (power-- > 0)
		{
			result *= value;
		}

		return result;
	}

	public static XmlSchemaElement CreateChildElement(Q018.packetZap zap)
	{
		var name = zap.ID_EL.Split(new[] { Constants.PathSeparator }, StringSplitOptions.RemoveEmptyEntries).Last();
		var isRequired = zap.TYPE_E.StartsWith("О");
		var isArray = zap.TYPE_E.EndsWith("М");
		var size = decimal.Parse(zap.MXLEN_E, CultureInfo.InvariantCulture);
		var isDecimal = Math.Floor(size) != size;

		var restriction = new XmlSchemaSimpleTypeRestriction();

		switch (zap.FORM_E)
		{
			case "T":
				restriction.BaseTypeName = new XmlQualifiedName("token", "http://www.w3.org/2001/XMLSchema");
				restriction.Facets.Add(new XmlSchemaMaxLengthFacet
				{
					Value = size.ToString(),
				});
				restriction.Facets.Add(new XmlSchemaMinLengthFacet
				{
					Value = "1",
				});

				break;
			case "D":
				restriction.BaseTypeName = new XmlQualifiedName("date", "http://www.w3.org/2001/XMLSchema");
				restriction.Facets.Add(new XmlSchemaMinInclusiveFacet
				{
					Value = "1900-01-01",
				});
				restriction.Facets.Add(new XmlSchemaMaxInclusiveFacet
				{
					Value = "2030-12-31",
				});

				break;

			case "N":
				restriction.BaseTypeName = isDecimal ? new XmlQualifiedName("decimal", "http://www.w3.org/2001/XMLSchema") : new XmlQualifiedName("long", "http://www.w3.org/2001/XMLSchema");
				restriction.Facets.Add(new XmlSchemaMinInclusiveFacet
				{
					Value = "0",
				});
				restriction.Facets.Add(new XmlSchemaMaxExclusiveFacet
				{
					Value = PowerLong(10, (int)Math.Truncate(size)).ToString(),
				});

				if (isDecimal)
				{
					var digits = GetDecimals(size);
					var decimals = size - Math.Truncate(size);
					var fraction = Math.Truncate(decimals * PowerLong(10, digits));

					restriction.Facets.Add(new XmlSchemaFractionDigitsFacet
					{
						Value = fraction.ToString(),
					});
				}

				break;
		}

		var element = new XmlSchemaElement
		{
			Name = name,
			MinOccursString = !isRequired ? "0" : null,
			MaxOccursString = isArray ? "unbounded" : null,
			SchemaType = new XmlSchemaSimpleType
			{
				Content = restriction,
			},
		};

		return element;
	}

	public static XmlSchemaElement CreateParentElement(Q018.packetZap zap)
	{
		var name = zap.ID_EL.Split(new[] { Constants.PathSeparator }, StringSplitOptions.RemoveEmptyEntries).Last();
		var isRequired = zap.TYPE_E.StartsWith("О");
		var isArray = zap.TYPE_E.EndsWith("М");

		var element = new XmlSchemaElement
		{
			Name = name,
			MinOccursString = !isRequired ? "0" : null,
			MaxOccursString = isArray ? "unbounded" : null,
			SchemaType = new XmlSchemaComplexType
			{
				Particle = new XmlSchemaSequence(),
			},
		};

		return element;
	}
}
