using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.MetadataService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public enum AttributeType
	{
		Boolean,
		Customer,
		DateTime,
		Decimal,
		Float,
		Integer,
		Internal,
		Lookup,
		Memo,
		Money,
		Owner,
		PartyList,
		Picklist,
		PrimaryKey,
		State,
		Status,
		String,
		UniqueIdentifier,
		Virtual,
		CalendarRules
	}
}
