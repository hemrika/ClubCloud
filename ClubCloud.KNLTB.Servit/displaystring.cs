using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class displaystring : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private string customcommentField;
		private string customdisplaystringField;
		private Key displaystringidField;
		private string displaystringkeyField;
		private CrmNumber formatparametersField;
		private CrmNumber languagecodeField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup organizationidField;
		private string publisheddisplaystringField;
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
		public string customcomment
		{
			get
			{
				return this.customcommentField;
			}
			set
			{
				this.customcommentField = value;
				base.RaisePropertyChanged("customcomment");
			}
		}
		[XmlElement(Order = 3)]
		public string customdisplaystring
		{
			get
			{
				return this.customdisplaystringField;
			}
			set
			{
				this.customdisplaystringField = value;
				base.RaisePropertyChanged("customdisplaystring");
			}
		}
		[XmlElement(Order = 4)]
		public Key displaystringid
		{
			get
			{
				return this.displaystringidField;
			}
			set
			{
				this.displaystringidField = value;
				base.RaisePropertyChanged("displaystringid");
			}
		}
		[XmlElement(Order = 5)]
		public string displaystringkey
		{
			get
			{
				return this.displaystringkeyField;
			}
			set
			{
				this.displaystringkeyField = value;
				base.RaisePropertyChanged("displaystringkey");
			}
		}
		[XmlElement(Order = 6)]
		public CrmNumber formatparameters
		{
			get
			{
				return this.formatparametersField;
			}
			set
			{
				this.formatparametersField = value;
				base.RaisePropertyChanged("formatparameters");
			}
		}
		[XmlElement(Order = 7)]
		public CrmNumber languagecode
		{
			get
			{
				return this.languagecodeField;
			}
			set
			{
				this.languagecodeField = value;
				base.RaisePropertyChanged("languagecode");
			}
		}
		[XmlElement(Order = 8)]
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
		[XmlElement(Order = 9)]
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
		[XmlElement(Order = 10)]
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
		[XmlElement(Order = 11)]
		public string publisheddisplaystring
		{
			get
			{
				return this.publisheddisplaystringField;
			}
			set
			{
				this.publisheddisplaystringField = value;
				base.RaisePropertyChanged("publisheddisplaystring");
			}
		}
	}
}
