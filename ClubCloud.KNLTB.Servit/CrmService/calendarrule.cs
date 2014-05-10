using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class calendarrule : BusinessEntity
	{
		private UniqueIdentifier businessunitidField;
		private Lookup calendaridField;
		private Key calendarruleidField;
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private string descriptionField;
		private CrmNumber durationField;
		private CrmDateTime effectiveintervalendField;
		private CrmDateTime effectiveintervalstartField;
		private CrmFloat effortField;
		private CrmDateTime endtimeField;
		private CrmNumber extentcodeField;
		private string groupdesignatorField;
		private Lookup innercalendaridField;
		private CrmBoolean ismodifiedField;
		private CrmBoolean isselectedField;
		private CrmBoolean issimpleField;
		private CrmBoolean isvariedField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private string nameField;
		private CrmNumber offsetField;
		private UniqueIdentifier organizationidField;
		private string patternField;
		private CrmNumber rankField;
		private Lookup serviceidField;
		private CrmDateTime starttimeField;
		private CrmNumber subcodeField;
		private CrmNumber timecodeField;
		private CrmNumber timezonecodeField;
		public UniqueIdentifier businessunitid
		{
			get
			{
				return this.businessunitidField;
			}
			set
			{
				this.businessunitidField = value;
			}
		}
		public Lookup calendarid
		{
			get
			{
				return this.calendaridField;
			}
			set
			{
				this.calendaridField = value;
			}
		}
		public Key calendarruleid
		{
			get
			{
				return this.calendarruleidField;
			}
			set
			{
				this.calendarruleidField = value;
			}
		}
		public Lookup createdby
		{
			get
			{
				return this.createdbyField;
			}
			set
			{
				this.createdbyField = value;
			}
		}
		public CrmDateTime createdon
		{
			get
			{
				return this.createdonField;
			}
			set
			{
				this.createdonField = value;
			}
		}
		public string description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
			}
		}
		public CrmNumber duration
		{
			get
			{
				return this.durationField;
			}
			set
			{
				this.durationField = value;
			}
		}
		public CrmDateTime effectiveintervalend
		{
			get
			{
				return this.effectiveintervalendField;
			}
			set
			{
				this.effectiveintervalendField = value;
			}
		}
		public CrmDateTime effectiveintervalstart
		{
			get
			{
				return this.effectiveintervalstartField;
			}
			set
			{
				this.effectiveintervalstartField = value;
			}
		}
		public CrmFloat effort
		{
			get
			{
				return this.effortField;
			}
			set
			{
				this.effortField = value;
			}
		}
		public CrmDateTime endtime
		{
			get
			{
				return this.endtimeField;
			}
			set
			{
				this.endtimeField = value;
			}
		}
		public CrmNumber extentcode
		{
			get
			{
				return this.extentcodeField;
			}
			set
			{
				this.extentcodeField = value;
			}
		}
		public string groupdesignator
		{
			get
			{
				return this.groupdesignatorField;
			}
			set
			{
				this.groupdesignatorField = value;
			}
		}
		public Lookup innercalendarid
		{
			get
			{
				return this.innercalendaridField;
			}
			set
			{
				this.innercalendaridField = value;
			}
		}
		public CrmBoolean ismodified
		{
			get
			{
				return this.ismodifiedField;
			}
			set
			{
				this.ismodifiedField = value;
			}
		}
		public CrmBoolean isselected
		{
			get
			{
				return this.isselectedField;
			}
			set
			{
				this.isselectedField = value;
			}
		}
		public CrmBoolean issimple
		{
			get
			{
				return this.issimpleField;
			}
			set
			{
				this.issimpleField = value;
			}
		}
		public CrmBoolean isvaried
		{
			get
			{
				return this.isvariedField;
			}
			set
			{
				this.isvariedField = value;
			}
		}
		public Lookup modifiedby
		{
			get
			{
				return this.modifiedbyField;
			}
			set
			{
				this.modifiedbyField = value;
			}
		}
		public CrmDateTime modifiedon
		{
			get
			{
				return this.modifiedonField;
			}
			set
			{
				this.modifiedonField = value;
			}
		}
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}
		public CrmNumber offset
		{
			get
			{
				return this.offsetField;
			}
			set
			{
				this.offsetField = value;
			}
		}
		public UniqueIdentifier organizationid
		{
			get
			{
				return this.organizationidField;
			}
			set
			{
				this.organizationidField = value;
			}
		}
		public string pattern
		{
			get
			{
				return this.patternField;
			}
			set
			{
				this.patternField = value;
			}
		}
		public CrmNumber rank
		{
			get
			{
				return this.rankField;
			}
			set
			{
				this.rankField = value;
			}
		}
		public Lookup serviceid
		{
			get
			{
				return this.serviceidField;
			}
			set
			{
				this.serviceidField = value;
			}
		}
		public CrmDateTime starttime
		{
			get
			{
				return this.starttimeField;
			}
			set
			{
				this.starttimeField = value;
			}
		}
		public CrmNumber subcode
		{
			get
			{
				return this.subcodeField;
			}
			set
			{
				this.subcodeField = value;
			}
		}
		public CrmNumber timecode
		{
			get
			{
				return this.timecodeField;
			}
			set
			{
				this.timecodeField = value;
			}
		}
		public CrmNumber timezonecode
		{
			get
			{
				return this.timezonecodeField;
			}
			set
			{
				this.timezonecodeField = value;
			}
		}
	}
}
