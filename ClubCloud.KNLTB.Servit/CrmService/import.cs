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
	public class import : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private string emailaddressField;

		private Key importidField;

		private CrmBoolean isimportField;

		private Picklist modecodeField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private string nameField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private CrmBoolean sendnotificationField;

		private CrmNumber sequenceField;

		private ImportStateInfo statecodeField;

		private Status statuscodeField;

		[XmlElement] //[XmlElement(Order=0)]
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

		[XmlElement] //[XmlElement(Order=1)]
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

		[XmlElement] //[XmlElement(Order=2)]
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

		[XmlElement] //[XmlElement(Order=3)]
		public Key importid
		{
			get
			{
				return this.importidField;
			}
			set
			{
				this.importidField = value;
				base.RaisePropertyChanged("importid");
			}
		}

		[XmlElement] //[XmlElement(Order=4)]
		public CrmBoolean isimport
		{
			get
			{
				return this.isimportField;
			}
			set
			{
				this.isimportField = value;
				base.RaisePropertyChanged("isimport");
			}
		}

		[XmlElement] //[XmlElement(Order=5)]
		public Picklist modecode
		{
			get
			{
				return this.modecodeField;
			}
			set
			{
				this.modecodeField = value;
				base.RaisePropertyChanged("modecode");
			}
		}

		[XmlElement] //[XmlElement(Order=6)]
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

		[XmlElement] //[XmlElement(Order=7)]
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

		[XmlElement] //[XmlElement(Order=8)]
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

		[XmlElement] //[XmlElement(Order=9)]
		public Owner ownerid
		{
			get
			{
				return this.owneridField;
			}
			set
			{
				this.owneridField = value;
				base.RaisePropertyChanged("ownerid");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public Lookup owningbusinessunit
		{
			get
			{
				return this.owningbusinessunitField;
			}
			set
			{
				this.owningbusinessunitField = value;
				base.RaisePropertyChanged("owningbusinessunit");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public CrmBoolean sendnotification
		{
			get
			{
				return this.sendnotificationField;
			}
			set
			{
				this.sendnotificationField = value;
				base.RaisePropertyChanged("sendnotification");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public CrmNumber sequence
		{
			get
			{
				return this.sequenceField;
			}
			set
			{
				this.sequenceField = value;
				base.RaisePropertyChanged("sequence");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public ImportStateInfo statecode
		{
			get
			{
				return this.statecodeField;
			}
			set
			{
				this.statecodeField = value;
				base.RaisePropertyChanged("statecode");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public Status statuscode
		{
			get
			{
				return this.statuscodeField;
			}
			set
			{
				this.statuscodeField = value;
				base.RaisePropertyChanged("statuscode");
			}
		}

		public import()
		{
		}
	}
}