using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[Flags]
	[GeneratedCode("System.Xml", "4.0.30319.33440")]
	[Serializable]
	[XmlType(Namespace="http://schemas.microsoft.com/crm/2006/CoreTypes")]
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