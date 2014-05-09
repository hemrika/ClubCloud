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
		[XmlElement(Order = 0)]
		public UniqueIdentifier businessunitid
		{
			get
			{
				return this.businessunitidField;
			}
			set
			{
				this.businessunitidField = value;
				base.RaisePropertyChanged("businessunitid");
			}
		}
		[XmlElement(Order = 1)]
		public Lookup calendarid
		{
			get
			{
				return this.calendaridField;
			}
			set
			{
				this.calendaridField = value;
				base.RaisePropertyChanged("calendarid");
			}
		}
		[XmlElement(Order = 2)]
		public Key calendarruleid
		{
			get
			{
				return this.calendarruleidField;
			}
			set
			{
				this.calendarruleidField = value;
				base.RaisePropertyChanged("calendarruleid");
			}
		}
		[XmlElement(Order = 3)]
		public Lookup createdby
		{
			get
			{
				return this.createdbyField;
			}
			set
			{
				this.createdbyField = value;
				base.RaisePropertyChanged("createdby");
			}
		}
		[XmlElement(Order = 4)]
		public CrmDateTime createdon
		{
			get
			{
				return this.createdonField;
			}
			set
			{
				this.createdonField = value;
				base.RaisePropertyChanged("createdon");
			}
		}
		[XmlElement(Order = 5)]
		public string description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
				base.RaisePropertyChanged("description");
			}
		}
		[XmlElement(Order = 6)]
		public CrmNumber duration
		{
			get
			{
				return this.durationField;
			}
			set
			{
				this.durationField = value;
				base.RaisePropertyChanged("duration");
			}
		}
		[XmlElement(Order = 7)]
		public CrmDateTime effectiveintervalend
		{
			get
			{
				return this.effectiveintervalendField;
			}
			set
			{
				this.effectiveintervalendField = value;
				base.RaisePropertyChanged("effectiveintervalend");
			}
		}
		[XmlElement(Order = 8)]
		public CrmDateTime effectiveintervalstart
		{
			get
			{
				return this.effectiveintervalstartField;
			}
			set
			{
				this.effectiveintervalstartField = value;
				base.RaisePropertyChanged("effectiveintervalstart");
			}
		}
		[XmlElement(Order = 9)]
		public CrmFloat effort
		{
			get
			{
				return this.effortField;
			}
			set
			{
				this.effortField = value;
				base.RaisePropertyChanged("effort");
			}
		}
		[XmlElement(Order = 10)]
		public CrmDateTime endtime
		{
			get
			{
				return this.endtimeField;
			}
			set
			{
				this.endtimeField = value;
				base.RaisePropertyChanged("endtime");
			}
		}
		[XmlElement(Order = 11)]
		public CrmNumber extentcode
		{
			get
			{
				return this.extentcodeField;
			}
			set
			{
				this.extentcodeField = value;
				base.RaisePropertyChanged("extentcode");
			}
		}
		[XmlElement(Order = 12)]
		public string groupdesignator
		{
			get
			{
				return this.groupdesignatorField;
			}
			set
			{
				this.groupdesignatorField = value;
				base.RaisePropertyChanged("groupdesignator");
			}
		}
		[XmlElement(Order = 13)]
		public Lookup innercalendarid
		{
			get
			{
				return this.innercalendaridField;
			}
			set
			{
				this.innercalendaridField = value;
				base.RaisePropertyChanged("innercalendarid");
			}
		}
		[XmlElement(Order = 14)]
		public CrmBoolean ismodified
		{
			get
			{
				return this.ismodifiedField;
			}
			set
			{
				this.ismodifiedField = value;
				base.RaisePropertyChanged("ismodified");
			}
		}
		[XmlElement(Order = 15)]
		public CrmBoolean isselected
		{
			get
			{
				return this.isselectedField;
			}
			set
			{
				this.isselectedField = value;
				base.RaisePropertyChanged("isselected");
			}
		}
		[XmlElement(Order = 16)]
		public CrmBoolean issimple
		{
			get
			{
				return this.issimpleField;
			}
			set
			{
				this.issimpleField = value;
				base.RaisePropertyChanged("issimple");
			}
		}
		[XmlElement(Order = 17)]
		public CrmBoolean isvaried
		{
			get
			{
				return this.isvariedField;
			}
			set
			{
				this.isvariedField = value;
				base.RaisePropertyChanged("isvaried");
			}
		}
		[XmlElement(Order = 18)]
		public Lookup modifiedby
		{
			get
			{
				return this.modifiedbyField;
			}
			set
			{
				this.modifiedbyField = value;
				base.RaisePropertyChanged("modifiedby");
			}
		}
		[XmlElement(Order = 19)]
		public CrmDateTime modifiedon
		{
			get
			{
				return this.modifiedonField;
			}
			set
			{
				this.modifiedonField = value;
				base.RaisePropertyChanged("modifiedon");
			}
		}
		[XmlElement(Order = 20)]
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
				base.RaisePropertyChanged("name");
			}
		}
		[XmlElement(Order = 21)]
		public CrmNumber offset
		{
			get
			{
				return this.offsetField;
			}
			set
			{
				this.offsetField = value;
				base.RaisePropertyChanged("offset");
			}
		}
		[XmlElement(Order = 22)]
		public UniqueIdentifier organizationid
		{
			get
			{
				return this.organizationidField;
			}
			set
			{
				this.organizationidField = value;
				base.RaisePropertyChanged("organizationid");
			}
		}
		[XmlElement(Order = 23)]
		public string pattern
		{
			get
			{
				return this.patternField;
			}
			set
			{
				this.patternField = value;
				base.RaisePropertyChanged("pattern");
			}
		}
		[XmlElement(Order = 24)]
		public CrmNumber rank
		{
			get
			{
				return this.rankField;
			}
			set
			{
				this.rankField = value;
				base.RaisePropertyChanged("rank");
			}
		}
		[XmlElement(Order = 25)]
		public Lookup serviceid
		{
			get
			{
				return this.serviceidField;
			}
			set
			{
				this.serviceidField = value;
				base.RaisePropertyChanged("serviceid");
			}
		}
		[XmlElement(Order = 26)]
		public CrmDateTime starttime
		{
			get
			{
				return this.starttimeField;
			}
			set
			{
				this.starttimeField = value;
				base.RaisePropertyChanged("starttime");
			}
		}
		[XmlElement(Order = 27)]
		public CrmNumber subcode
		{
			get
			{
				return this.subcodeField;
			}
			set
			{
				this.subcodeField = value;
				base.RaisePropertyChanged("subcode");
			}
		}
		[XmlElement(Order = 28)]
		public CrmNumber timecode
		{
			get
			{
				return this.timecodeField;
			}
			set
			{
				this.timecodeField = value;
				base.RaisePropertyChanged("timecode");
			}
		}
		[XmlElement(Order = 29)]
		public CrmNumber timezonecode
		{
			get
			{
				return this.timezonecodeField;
			}
			set
			{
				this.timezonecodeField = value;
				base.RaisePropertyChanged("timezonecode");
			}
		}
	}
}
