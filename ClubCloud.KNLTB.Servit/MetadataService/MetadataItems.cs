using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.MetadataService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), Flags, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public enum MetadataItems
	{
		EntitiesOnly = 1,
		IncludeAttributes = 2,
		IncludePrivileges = 4,
		IncludeRelationships = 8,
		All = 16
	}
}
