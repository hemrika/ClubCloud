using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sdkmessageprocessingstepsecureconfig : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber customizationlevelField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup organizationidField;
		private Key sdkmessageprocessingstepsecureconfigidField;
		private UniqueIdentifier sdkmessageprocessingstepsecureconfigiduniqueField;
		private string secureconfigField;
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
		public CrmNumber customizationlevel
		{
			get
			{
				return this.customizationlevelField;
			}
			set
			{
				this.customizationlevelField = value;
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
		public Key sdkmessageprocessingstepsecureconfigid
		{
			get
			{
				return this.sdkmessageprocessingstepsecureconfigidField;
			}
			set
			{
				this.sdkmessageprocessingstepsecureconfigidField = value;
			}
		}
		public UniqueIdentifier sdkmessageprocessingstepsecureconfigidunique
		{
			get
			{
				return this.sdkmessageprocessingstepsecureconfigiduniqueField;
			}
			set
			{
				this.sdkmessageprocessingstepsecureconfigiduniqueField = value;
			}
		}
		public string secureconfig
		{
			get
			{
				return this.secureconfigField;
			}
			set
			{
				this.secureconfigField = value;
			}
		}
	}
}
