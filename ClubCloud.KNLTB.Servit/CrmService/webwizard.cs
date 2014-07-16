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
	public class webwizard : BusinessEntity
	{
		private string accessprivilegesField;

		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmBoolean isstaticpagesequenceField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private string nameField;

		private Lookup organizationidField;

		private CrmNumber startpagesequencenumberField;

		private string titleresourcestringField;

		private Key webwizardidField;

		private CrmNumber wizardpageheightField;

		private CrmNumber wizardpagewidthField;

		[XmlElement] //[XmlElement(Order=0)]
		public string accessprivileges
		{
			get
			{
				return this.accessprivilegesField;
			}
			set
			{
				this.accessprivilegesField = value;
				base.RaisePropertyChanged("accessprivileges");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
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

		[XmlElement] //[XmlElement(Order=2)]
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

		[XmlElement] //[XmlElement(Order=3)]
		public CrmBoolean isstaticpagesequence
		{
			get
			{
				return this.isstaticpagesequenceField;
			}
			set
			{
				this.isstaticpagesequenceField = value;
				base.RaisePropertyChanged("isstaticpagesequence");
			}
		}

		[XmlElement] //[XmlElement(Order=4)]
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

		[XmlElement] //[XmlElement(Order=5)]
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

		[XmlElement] //[XmlElement(Order=6)]
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

		[XmlElement] //[XmlElement(Order=7)]
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

		[XmlElement] //[XmlElement(Order=8)]
		public CrmNumber startpagesequencenumber
		{
			get
			{
				return this.startpagesequencenumberField;
			}
			set
			{
				this.startpagesequencenumberField = value;
				base.RaisePropertyChanged("startpagesequencenumber");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public string titleresourcestring
		{
			get
			{
				return this.titleresourcestringField;
			}
			set
			{
				this.titleresourcestringField = value;
				base.RaisePropertyChanged("titleresourcestring");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public Key webwizardid
		{
			get
			{
				return this.webwizardidField;
			}
			set
			{
				this.webwizardidField = value;
				base.RaisePropertyChanged("webwizardid");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public CrmNumber wizardpageheight
		{
			get
			{
				return this.wizardpageheightField;
			}
			set
			{
				this.wizardpageheightField = value;
				base.RaisePropertyChanged("wizardpageheight");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public CrmNumber wizardpagewidth
		{
			get
			{
				return this.wizardpagewidthField;
			}
			set
			{
				this.wizardpagewidthField = value;
				base.RaisePropertyChanged("wizardpagewidth");
			}
		}

		public webwizard()
		{
		}
	}
}