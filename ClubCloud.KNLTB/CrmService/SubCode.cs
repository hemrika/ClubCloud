using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440")]
	[Serializable]
	[XmlType(Namespace="http://schemas.microsoft.com/crm/2006/Scheduling")]
	public enum SubCode
	{
		Unspecified,
		Schedulable,
		Committed,
		Uncommitted,
		Break,
		Holiday,
		Vacation,
		Appointment,
		ResourceStartTime,
		ResourceServiceRestriction,
		ResourceCapacity,
		ServiceRestriction,
		ServiceCost
	}
}