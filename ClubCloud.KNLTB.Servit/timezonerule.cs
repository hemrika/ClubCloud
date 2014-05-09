using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class timezonerule : BusinessEntity
	{
		private CrmNumber biasField;
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber daylightbiasField;
		private CrmNumber daylightdayField;
		private CrmNumber daylightdayofweekField;
		private CrmNumber daylighthourField;
		private CrmNumber daylightminuteField;
		private CrmNumber daylightmonthField;
		private CrmNumber daylightsecondField;
		private CrmNumber daylightyearField;
		private CrmDateTime effectivedatetimeField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup organizationidField;
		private CrmNumber standardbiasField;
		private CrmNumber standarddayField;
		private CrmNumber standarddayofweekField;
		private CrmNumber standardhourField;
		private CrmNumber standardminuteField;
		private CrmNumber standardmonthField;
		private CrmNumber standardsecondField;
		private CrmNumber standardyearField;
		private Lookup timezonedefinitionidField;
		private Key timezoneruleidField;
		private CrmNumber timezoneruleversionnumberField;
		[XmlElement(Order = 0)]
		public CrmNumber bias
		{
			get
			{
				return this.biasField;
			}
			set
			{
				this.biasField = value;
				base.RaisePropertyChanged("bias");
			}
		}
		[XmlElement(Order = 1)]
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
		[XmlElement(Order = 2)]
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
		[XmlElement(Order = 3)]
		public CrmNumber daylightbias
		{
			get
			{
				return this.daylightbiasField;
			}
			set
			{
				this.daylightbiasField = value;
				base.RaisePropertyChanged("daylightbias");
			}
		}
		[XmlElement(Order = 4)]
		public CrmNumber daylightday
		{
			get
			{
				return this.daylightdayField;
			}
			set
			{
				this.daylightdayField = value;
				base.RaisePropertyChanged("daylightday");
			}
		}
		[XmlElement(Order = 5)]
		public CrmNumber daylightdayofweek
		{
			get
			{
				return this.daylightdayofweekField;
			}
			set
			{
				this.daylightdayofweekField = value;
				base.RaisePropertyChanged("daylightdayofweek");
			}
		}
		[XmlElement(Order = 6)]
		public CrmNumber daylighthour
		{
			get
			{
				return this.daylighthourField;
			}
			set
			{
				this.daylighthourField = value;
				base.RaisePropertyChanged("daylighthour");
			}
		}
		[XmlElement(Order = 7)]
		public CrmNumber daylightminute
		{
			get
			{
				return this.daylightminuteField;
			}
			set
			{
				this.daylightminuteField = value;
				base.RaisePropertyChanged("daylightminute");
			}
		}
		[XmlElement(Order = 8)]
		public CrmNumber daylightmonth
		{
			get
			{
				return this.daylightmonthField;
			}
			set
			{
				this.daylightmonthField = value;
				base.RaisePropertyChanged("daylightmonth");
			}
		}
		[XmlElement(Order = 9)]
		public CrmNumber daylightsecond
		{
			get
			{
				return this.daylightsecondField;
			}
			set
			{
				this.daylightsecondField = value;
				base.RaisePropertyChanged("daylightsecond");
			}
		}
		[XmlElement(Order = 10)]
		public CrmNumber daylightyear
		{
			get
			{
				return this.daylightyearField;
			}
			set
			{
				this.daylightyearField = value;
				base.RaisePropertyChanged("daylightyear");
			}
		}
		[XmlElement(Order = 11)]
		public CrmDateTime effectivedatetime
		{
			get
			{
				return this.effectivedatetimeField;
			}
			set
			{
				this.effectivedatetimeField = value;
				base.RaisePropertyChanged("effectivedatetime");
			}
		}
		[XmlElement(Order = 12)]
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
		[XmlElement(Order = 13)]
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
		[XmlElement(Order = 14)]
		public Lookup organizationid
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
		[XmlElement(Order = 15)]
		public CrmNumber standardbias
		{
			get
			{
				return this.standardbiasField;
			}
			set
			{
				this.standardbiasField = value;
				base.RaisePropertyChanged("standardbias");
			}
		}
		[XmlElement(Order = 16)]
		public CrmNumber standardday
		{
			get
			{
				return this.standarddayField;
			}
			set
			{
				this.standarddayField = value;
				base.RaisePropertyChanged("standardday");
			}
		}
		[XmlElement(Order = 17)]
		public CrmNumber standarddayofweek
		{
			get
			{
				return this.standarddayofweekField;
			}
			set
			{
				this.standarddayofweekField = value;
				base.RaisePropertyChanged("standarddayofweek");
			}
		}
		[XmlElement(Order = 18)]
		public CrmNumber standardhour
		{
			get
			{
				return this.standardhourField;
			}
			set
			{
				this.standardhourField = value;
				base.RaisePropertyChanged("standardhour");
			}
		}
		[XmlElement(Order = 19)]
		public CrmNumber standardminute
		{
			get
			{
				return this.standardminuteField;
			}
			set
			{
				this.standardminuteField = value;
				base.RaisePropertyChanged("standardminute");
			}
		}
		[XmlElement(Order = 20)]
		public CrmNumber standardmonth
		{
			get
			{
				return this.standardmonthField;
			}
			set
			{
				this.standardmonthField = value;
				base.RaisePropertyChanged("standardmonth");
			}
		}
		[XmlElement(Order = 21)]
		public CrmNumber standardsecond
		{
			get
			{
				return this.standardsecondField;
			}
			set
			{
				this.standardsecondField = value;
				base.RaisePropertyChanged("standardsecond");
			}
		}
		[XmlElement(Order = 22)]
		public CrmNumber standardyear
		{
			get
			{
				return this.standardyearField;
			}
			set
			{
				this.standardyearField = value;
				base.RaisePropertyChanged("standardyear");
			}
		}
		[XmlElement(Order = 23)]
		public Lookup timezonedefinitionid
		{
			get
			{
				return this.timezonedefinitionidField;
			}
			set
			{
				this.timezonedefinitionidField = value;
				base.RaisePropertyChanged("timezonedefinitionid");
			}
		}
		[XmlElement(Order = 24)]
		public Key timezoneruleid
		{
			get
			{
				return this.timezoneruleidField;
			}
			set
			{
				this.timezoneruleidField = value;
				base.RaisePropertyChanged("timezoneruleid");
			}
		}
		[XmlElement(Order = 25)]
		public CrmNumber timezoneruleversionnumber
		{
			get
			{
				return this.timezoneruleversionnumberField;
			}
			set
			{
				this.timezoneruleversionnumberField = value;
				base.RaisePropertyChanged("timezoneruleversionnumber");
			}
		}
	}
}
