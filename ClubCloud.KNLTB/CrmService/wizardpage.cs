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
	public class wizardpage : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private Lookup organizationidField;

		private string pagedatatopostField;

		private CrmNumber pagesequencenumberField;

		private string pageurlField;

		private Lookup webwizardidField;

		private Key wizardpageidField;

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

		[XmlElement] //[XmlElement(Order=3)]
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

		[XmlElement] //[XmlElement(Order=4)]
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

		[XmlElement] //[XmlElement(Order=5)]
		public string pagedatatopost
		{
			get
			{
				return this.pagedatatopostField;
			}
			set
			{
				this.pagedatatopostField = value;
				base.RaisePropertyChanged("pagedatatopost");
			}
		}

		[XmlElement] //[XmlElement(Order=6)]
		public CrmNumber pagesequencenumber
		{
			get
			{
				return this.pagesequencenumberField;
			}
			set
			{
				this.pagesequencenumberField = value;
				base.RaisePropertyChanged("pagesequencenumber");
			}
		}

		[XmlElement] //[XmlElement(Order=7)]
		public string pageurl
		{
			get
			{
				return this.pageurlField;
			}
			set
			{
				this.pageurlField = value;
				base.RaisePropertyChanged("pageurl");
			}
		}

		[XmlElement] //[XmlElement(Order=8)]
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

		[XmlElement] //[XmlElement(Order=9)]
		public Key wizardpageid
		{
			get
			{
				return this.wizardpageidField;
			}
			set
			{
				this.wizardpageidField = value;
				base.RaisePropertyChanged("wizardpageid");
			}
		}

		public wizardpage()
		{
		}
	}
}