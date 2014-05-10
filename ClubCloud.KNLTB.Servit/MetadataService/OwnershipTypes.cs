using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.MetadataService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), Flags, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public enum OwnershipTypes
	{
		None = 1,
		UserOwned = 2,
		TeamOwned = 4,
		BusinessOwned = 8,
		OrgOwned = 16,
		BusinessParented = 32
	}
}
