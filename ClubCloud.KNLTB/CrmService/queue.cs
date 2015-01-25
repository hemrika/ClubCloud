using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[GeneratedCode("System.Xml", "4.0.30319.33440")]
	[Serializable]
	[XmlType(Namespace="http://schemas.microsoft.com/crm/2007/WebServices")]
	public class queue : BusinessEntity
	{
		private CrmBoolean allowemailcredentialsField;

		private Lookup businessunitidField;

		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private string descriptionField;

		private string emailaddressField;

		private string emailpasswordField;

		private string emailusernameField;

		private CrmBoolean ignoreunsolicitedemailField;

		private Picklist incomingemaildeliverymethodField;

		private Picklist incomingemailfilteringmethodField;

		private CrmBoolean isfaxqueueField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private string nameField;

		private Lookup organizationidField;

		private Picklist outgoingemaildeliverymethodField;

		private Lookup primaryuseridField;

		private Key queueidField;

		private CrmNumber queuesemanticsField;

		private Picklist queuetypecodeField;

		[XmlElement] //[XmlElement(Order=0)]
		public CrmBoolean allowemailcredentials
		{
			get
			{
				return this.allowemailcredentialsField;
			}
			set
			{
				this.allowemailcredentialsField = value;
				base.RaisePropertyChanged("allowemailcredentials");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public Lookup businessunitid
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

		[XmlElement] //[XmlElement(Order=2)]
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

		[XmlElement] //[XmlElement(Order=3)]
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

		[XmlElement] //[XmlElement(Order=4)]
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

		[XmlElement] //[XmlElement(Order=5)]
		public string emailaddress
		{
			get
			{
				return this.emailaddressField;
			}
			set
			{
				this.emailaddressField = value;
				base.RaisePropertyChanged("emailaddress");
			}
		}

		[XmlElement] //[XmlElement(Order=6)]
		public string emailpassword
		{
			get
			{
				return this.emailpasswordField;
			}
			set
			{
				this.emailpasswordField = value;
				base.RaisePropertyChanged("emailpassword");
			}
		}

		[XmlElement] //[XmlElement(Order=7)]
		public string emailusername
		{
			get
			{
				return this.emailusernameField;
			}
			set
			{
				this.emailusernameField = value;
				base.RaisePropertyChanged("emailusername");
			}
		}

		[XmlElement] //[XmlElement(Order=8)]
		public CrmBoolean ignoreunsolicitedemail
		{
			get
			{
				return this.ignoreunsolicitedemailField;
			}
			set
			{
				this.ignoreunsolicitedemailField = value;
				base.RaisePropertyChanged("ignoreunsolicitedemail");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public Picklist incomingemaildeliverymethod
		{
			get
			{
				return this.incomingemaildeliverymethodField;
			}
			set
			{
				this.incomingemaildeliverymethodField = value;
				base.RaisePropertyChanged("incomingemaildeliverymethod");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public Picklist incomingemailfilteringmethod
		{
			get
			{
				return this.incomingemailfilteringmethodField;
			}
			set
			{
				this.incomingemailfilteringmethodField = value;
				base.RaisePropertyChanged("incomingemailfilteringmethod");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public CrmBoolean isfaxqueue
		{
			get
			{
				return this.isfaxqueueField;
			}
			set
			{
				this.isfaxqueueField = value;
				base.RaisePropertyChanged("isfaxqueue");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
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

		[XmlElement] //[XmlElement(Order=13)]
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

		[XmlElement] //[XmlElement(Order=14)]
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

		[XmlElement] //[XmlElement(Order=15)]
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

		[XmlElement] //[XmlElement(Order=16)]
		public Picklist outgoingemaildeliverymethod
		{
			get
			{
				return this.outgoingemaildeliverymethodField;
			}
			set
			{
				this.outgoingemaildeliverymethodField = value;
				base.RaisePropertyChanged("outgoingemaildeliverymethod");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public Lookup primaryuserid
		{
			get
			{
				return this.primaryuseridField;
			}
			set
			{
				this.primaryuseridField = value;
				base.RaisePropertyChanged("primaryuserid");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public Key queueid
		{
			get
			{
				return this.queueidField;
			}
			set
			{
				this.queueidField = value;
				base.RaisePropertyChanged("queueid");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
		public CrmNumber queuesemantics
		{
			get
			{
				return this.queuesemanticsField;
			}
			set
			{
				this.queuesemanticsField = value;
				base.RaisePropertyChanged("queuesemantics");
			}
		}

		[XmlElement] //[XmlElement(Order=20)]
		public Picklist queuetypecode
		{
			get
			{
				return this.queuetypecodeField;
			}
			set
			{
				this.queuetypecodeField = value;
				base.RaisePropertyChanged("queuetypecode");
			}
		}

		public queue()
		{
		}
	}
}