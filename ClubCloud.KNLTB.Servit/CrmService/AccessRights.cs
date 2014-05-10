using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), Flags, XmlType(Namespace = "http://schemas.microsoft.com/crm/2006/CoreTypes")]
	[Serializable]
	public enum AccessRights
	{
		ReadAccess = 1,
		WriteAccess = 2,
		AppendAccess = 4,
		AppendToAccess = 8,
		CreateAccess = 16,
		DeleteAccess = 32,
		ShareAccess = 64,
		AssignAccess = 128
	}
}
