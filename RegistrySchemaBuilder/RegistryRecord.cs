using System.Xml.Schema;

namespace RegistrySchemaBuilder;

public class RegistryRecord
{
	public Q018.packetZap Zap { get; set; }
	public bool IsStruct { get; set; }
	public string ParentPath { get; set; }
	public string Path { get; set; }
	public XmlSchemaElement Element { get; set; }
}
