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
		public CrmNumber customizationlevel
		{
			get
			{
				return this.customizationlevelField;
			}
			set
			{
				this.customizationlevelField = value;
				base.RaisePropertyChanged("customizationlevel");
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
		public Key sdkmessageprocessingstepsecureconfigid
		{
			get
			{
				return this.sdkmessageprocessingstepsecureconfigidField;
			}
			set
			{
				this.sdkmessageprocessingstepsecureconfigidField = value;
				base.RaisePropertyChanged("sdkmessageprocessingstepsecureconfigid");
			}
		}
		[XmlElement(Order = 7)]
		public UniqueIdentifier sdkmessageprocessingstepsecureconfigidunique
		{
			get
			{
				return this.sdkmessageprocessingstepsecureconfigiduniqueField;
			}
			set
			{
				this.sdkmessageprocessingstepsecureconfigiduniqueField = value;
				base.RaisePropertyChanged("sdkmessageprocessingstepsecureconfigidunique");
			}
		}
		[XmlElement(Order = 8)]
		public string secureconfig
		{
			get
			{
				return this.secureconfigField;
			}
			set
			{
				this.secureconfigField = value;
				base.RaisePropertyChanged("secureconfig");
			}
		}
	}
}
