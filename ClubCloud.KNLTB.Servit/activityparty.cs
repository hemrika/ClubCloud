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
		[XmlElement(Order = 0)]
		public Lookup activityid
		{
			get
			{
				return this.activityidField;
			}
			set
			{
				this.activityidField = value;
				base.RaisePropertyChanged("activityid");
			}
		}
		[XmlElement(Order = 1)]
		public Key activitypartyid
		{
			get
			{
				return this.activitypartyidField;
			}
			set
			{
				this.activitypartyidField = value;
				base.RaisePropertyChanged("activitypartyid");
			}
		}
		[XmlElement(Order = 2)]
		public string addressused
		{
			get
			{
				return this.addressusedField;
			}
			set
			{
				this.addressusedField = value;
				base.RaisePropertyChanged("addressused");
			}
		}
		[XmlElement(Order = 3)]
		public CrmBoolean donotemail
		{
			get
			{
				return this.donotemailField;
			}
			set
			{
				this.donotemailField = value;
				base.RaisePropertyChanged("donotemail");
			}
		}
		[XmlElement(Order = 4)]
		public CrmBoolean donotfax
		{
			get
			{
				return this.donotfaxField;
			}
			set
			{
				this.donotfaxField = value;
				base.RaisePropertyChanged("donotfax");
			}
		}
		[XmlElement(Order = 5)]
		public CrmBoolean donotphone
		{
			get
			{
				return this.donotphoneField;
			}
			set
			{
				this.donotphoneField = value;
				base.RaisePropertyChanged("donotphone");
			}
		}
		[XmlElement(Order = 6)]
		public CrmBoolean donotpostalmail
		{
			get
			{
				return this.donotpostalmailField;
			}
			set
			{
				this.donotpostalmailField = value;
				base.RaisePropertyChanged("donotpostalmail");
			}
		}
		[XmlElement(Order = 7)]
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
		[XmlElement(Order = 8)]
		public string exchangeentryid
		{
			get
			{
				return this.exchangeentryidField;
			}
			set
			{
				this.exchangeentryidField = value;
				base.RaisePropertyChanged("exchangeentryid");
			}
		}
		[XmlElement(Order = 9)]
		public Picklist participationtypemask
		{
			get
			{
				return this.participationtypemaskField;
			}
			set
			{
				this.participationtypemaskField = value;
				base.RaisePropertyChanged("participationtypemask");
			}
		}
		[XmlElement(Order = 10)]
		public Lookup partyid
		{
			get
			{
				return this.partyidField;
			}
			set
			{
				this.partyidField = value;
				base.RaisePropertyChanged("partyid");
			}
		}
		[XmlElement(Order = 11)]
		public Lookup resourcespecid
		{
			get
			{
				return this.resourcespecidField;
			}
			set
			{
				this.resourcespecidField = value;
				base.RaisePropertyChanged("resourcespecid");
			}
		}
		[XmlElement(Order = 12)]
		public CrmDateTime scheduledend
		{
			get
			{
				return this.scheduledendField;
			}
			set
			{
				this.scheduledendField = value;
				base.RaisePropertyChanged("scheduledend");
			}
		}
		[XmlElement(Order = 13)]
		public CrmDateTime scheduledstart
		{
			get
			{
				return this.scheduledstartField;
			}
			set
			{
				this.scheduledstartField = value;
				base.RaisePropertyChanged("scheduledstart");
			}
		}
	}
}
