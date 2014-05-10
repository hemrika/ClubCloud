using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.MetadataService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), Flags, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public enum DisplayMasks
	{
		None = 1,
		PrimaryName = 2,
		ObjectTypeCode = 4,
		ValidForAdvancedFind = 8,
		ValidForForm = 16,
		ValidForGrid = 32,
		RequiredForForm = 64,
		RequiredForGrid = 128
	}
}
