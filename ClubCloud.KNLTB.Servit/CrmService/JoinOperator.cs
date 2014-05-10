using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), XmlType(Namespace = "http://schemas.microsoft.com/crm/2006/Query")]
	[Serializable]
	public enum JoinOperator
	{
		Inner,
		LeftOuter,
		Natural
	}
}
