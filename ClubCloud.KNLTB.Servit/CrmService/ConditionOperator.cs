using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), XmlType(Namespace = "http://schemas.microsoft.com/crm/2006/Query")]
	[Serializable]
	public enum ConditionOperator
	{
		Equal,
		NotEqual,
		GreaterThan,
		LessThan,
		GreaterEqual,
		LessEqual,
		Like,
		NotLike,
		In,
		NotIn,
		Between,
		NotBetween,
		Null,
		NotNull,
		Yesterday,
		Today,
		Tomorrow,
		Last7Days,
		Next7Days,
		LastWeek,
		ThisWeek,
		NextWeek,
		LastMonth,
		ThisMonth,
		NextMonth,
		On,
		OnOrBefore,
		OnOrAfter,
		LastYear,
		ThisYear,
		NextYear,
		LastXHours,
		NextXHours,
		LastXDays,
		NextXDays,
		LastXWeeks,
		NextXWeeks,
		LastXMonths,
		NextXMonths,
		LastXYears,
		NextXYears,
		EqualUserId,
		NotEqualUserId,
		EqualBusinessId,
		NotEqualBusinessId,
		EqualUserLanguage,
		NotOn,
		OlderThanXMonths
	}
}
