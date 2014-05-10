using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
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
		public CrmNumber bias
		{
			get
			{
				return this.biasField;
			}
			set
			{
				this.biasField = value;
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
		public CrmNumber daylightbias
		{
			get
			{
				return this.daylightbiasField;
			}
			set
			{
				this.daylightbiasField = value;
			}
		}
		public CrmNumber daylightday
		{
			get
			{
				return this.daylightdayField;
			}
			set
			{
				this.daylightdayField = value;
			}
		}
		public CrmNumber daylightdayofweek
		{
			get
			{
				return this.daylightdayofweekField;
			}
			set
			{
				this.daylightdayofweekField = value;
			}
		}
		public CrmNumber daylighthour
		{
			get
			{
				return this.daylighthourField;
			}
			set
			{
				this.daylighthourField = value;
			}
		}
		public CrmNumber daylightminute
		{
			get
			{
				return this.daylightminuteField;
			}
			set
			{
				this.daylightminuteField = value;
			}
		}
		public CrmNumber daylightmonth
		{
			get
			{
				return this.daylightmonthField;
			}
			set
			{
				this.daylightmonthField = value;
			}
		}
		public CrmNumber daylightsecond
		{
			get
			{
				return this.daylightsecondField;
			}
			set
			{
				this.daylightsecondField = value;
			}
		}
		public CrmNumber daylightyear
		{
			get
			{
				return this.daylightyearField;
			}
			set
			{
				this.daylightyearField = value;
			}
		}
		public CrmDateTime effectivedatetime
		{
			get
			{
				return this.effectivedatetimeField;
			}
			set
			{
				this.effectivedatetimeField = value;
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
		public Lookup organizationid
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
		public CrmNumber standardbias
		{
			get
			{
				return this.standardbiasField;
			}
			set
			{
				this.standardbiasField = value;
			}
		}
		public CrmNumber standardday
		{
			get
			{
				return this.standarddayField;
			}
			set
			{
				this.standarddayField = value;
			}
		}
		public CrmNumber standarddayofweek
		{
			get
			{
				return this.standarddayofweekField;
			}
			set
			{
				this.standarddayofweekField = value;
			}
		}
		public CrmNumber standardhour
		{
			get
			{
				return this.standardhourField;
			}
			set
			{
				this.standardhourField = value;
			}
		}
		public CrmNumber standardminute
		{
			get
			{
				return this.standardminuteField;
			}
			set
			{
				this.standardminuteField = value;
			}
		}
		public CrmNumber standardmonth
		{
			get
			{
				return this.standardmonthField;
			}
			set
			{
				this.standardmonthField = value;
			}
		}
		public CrmNumber standardsecond
		{
			get
			{
				return this.standardsecondField;
			}
			set
			{
				this.standardsecondField = value;
			}
		}
		public CrmNumber standardyear
		{
			get
			{
				return this.standardyearField;
			}
			set
			{
				this.standardyearField = value;
			}
		}
		public Lookup timezonedefinitionid
		{
			get
			{
				return this.timezonedefinitionidField;
			}
			set
			{
				this.timezonedefinitionidField = value;
			}
		}
		public Key timezoneruleid
		{
			get
			{
				return this.timezoneruleidField;
			}
			set
			{
				this.timezoneruleidField = value;
			}
		}
		public CrmNumber timezoneruleversionnumber
		{
			get
			{
				return this.timezoneruleversionnumberField;
			}
			set
			{
				this.timezoneruleversionnumberField = value;
			}
		}
	}
}
