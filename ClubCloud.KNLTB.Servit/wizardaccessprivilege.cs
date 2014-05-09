using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class wizardaccessprivilege : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private string entitynameField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup organizationidField;
		private string privilegenameField;
		private Lookup webwizardidField;
		private Key wizardaccessprivilegeidField;
		[XmlElement(Order = 0)]
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
		[XmlElement(Order = 1)]
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
		[XmlElement(Order = 2)]
		public string entityname
		{
			get
			{
				return this.entitynameField;
			}
			set
			{
				this.entitynameField = value;
				base.RaisePropertyChanged("entityname");
			}
		}
		[XmlElement(Order = 3)]
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
		[XmlElement(Order = 4)]
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
		[XmlElement(Order = 5)]
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
		[XmlElement(Order = 6)]
		public string privilegename
		{
			get
			{
				return this.privilegenameField;
			}
			set
			{
				this.privilegenameField = value;
				base.RaisePropertyChanged("privilegename");
			}
		}
		[XmlElement(Order = 7)]
		public Lookup webwizardid
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
		[XmlElement(Order = 8)]
		public Key wizardaccessprivilegeid
		{
			get
			{
				return this.wizardaccessprivilegeidField;
			}
			set
			{
				this.wizardaccessprivilegeidField = value;
				base.RaisePropertyChanged("wizardaccessprivilegeid");
			}
		}
	}
}
