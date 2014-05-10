using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
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
		public string customcomment
		{
			get
			{
				return this.customcommentField;
			}
			set
			{
				this.customcommentField = value;
			}
		}
		public string customdisplaystring
		{
			get
			{
				return this.customdisplaystringField;
			}
			set
			{
				this.customdisplaystringField = value;
			}
		}
		public Key displaystringid
		{
			get
			{
				return this.displaystringidField;
			}
			set
			{
				this.displaystringidField = value;
			}
		}
		public string displaystringkey
		{
			get
			{
				return this.displaystringkeyField;
			}
			set
			{
				this.displaystringkeyField = value;
			}
		}
		public CrmNumber formatparameters
		{
			get
			{
				return this.formatparametersField;
			}
			set
			{
				this.formatparametersField = value;
			}
		}
		public CrmNumber languagecode
		{
			get
			{
				return this.languagecodeField;
			}
			set
			{
				this.languagecodeField = value;
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
		public string publisheddisplaystring
		{
			get
			{
				return this.publisheddisplaystringField;
			}
			set
			{
				this.publisheddisplaystringField = value;
			}
		}
	}
}
