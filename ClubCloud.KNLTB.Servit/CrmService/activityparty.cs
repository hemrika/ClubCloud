using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class activityparty : BusinessEntity
	{
		private Lookup activityidField;
		private Key activitypartyidField;
		private string addressusedField;
		private CrmBoolean donotemailField;
		private CrmBoolean donotfaxField;
		private CrmBoolean donotphoneField;
		private CrmBoolean donotpostalmailField;
		private CrmFloat effortField;
		private string exchangeentryidField;
		private Picklist participationtypemaskField;
		private Lookup partyidField;
		private Lookup resourcespecidField;
		private CrmDateTime scheduledendField;
		private CrmDateTime scheduledstartField;
		public Lookup activityid
		{
			get
			{
				return this.activityidField;
			}
			set
			{
				this.activityidField = value;
			}
		}
		public Key activitypartyid
		{
			get
			{
				return this.activitypartyidField;
			}
			set
			{
				this.activitypartyidField = value;
			}
		}
		public string addressused
		{
			get
			{
				return this.addressusedField;
			}
			set
			{
				this.addressusedField = value;
			}
		}
		public CrmBoolean donotemail
		{
			get
			{
				return this.donotemailField;
			}
			set
			{
				this.donotemailField = value;
			}
		}
		public CrmBoolean donotfax
		{
			get
			{
				return this.donotfaxField;
			}
			set
			{
				this.donotfaxField = value;
			}
		}
		public CrmBoolean donotphone
		{
			get
			{
				return this.donotphoneField;
			}
			set
			{
				this.donotphoneField = value;
			}
		}
		public CrmBoolean donotpostalmail
		{
			get
			{
				return this.donotpostalmailField;
			}
			set
			{
				this.donotpostalmailField = value;
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
		public string exchangeentryid
		{
			get
			{
				return this.exchangeentryidField;
			}
			set
			{
				this.exchangeentryidField = value;
			}
		}
		public Picklist participationtypemask
		{
			get
			{
				return this.participationtypemaskField;
			}
			set
			{
				this.participationtypemaskField = value;
			}
		}
		public Lookup partyid
		{
			get
			{
				return this.partyidField;
			}
			set
			{
				this.partyidField = value;
			}
		}
		public Lookup resourcespecid
		{
			get
			{
				return this.resourcespecidField;
			}
			set
			{
				this.resourcespecidField = value;
			}
		}
		public CrmDateTime scheduledend
		{
			get
			{
				return this.scheduledendField;
			}
			set
			{
				this.scheduledendField = value;
			}
		}
		public CrmDateTime scheduledstart
		{
			get
			{
				return this.scheduledstartField;
			}
			set
			{
				this.scheduledstartField = value;
			}
		}
	}
}
