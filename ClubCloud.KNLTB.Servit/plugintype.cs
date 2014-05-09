using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class plugintype : BusinessEntity
	{
		private string assemblynameField;
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private string cultureField;
		private CrmNumber customizationlevelField;
		private string friendlynameField;
		private CrmBoolean isworkflowactivityField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup organizationidField;
		private Lookup pluginassemblyidField;
		private Key plugintypeidField;
		private UniqueIdentifier plugintypeiduniqueField;
		private string publickeytokenField;
		private string typenameField;
		private string versionField;
		[XmlElement(Order = 0)]
		public string assemblyname
		{
			get
			{
				return this.assemblynameField;
			}
			set
			{
				this.assemblynameField = value;
				base.RaisePropertyChanged("assemblyname");
			}
		}
		[XmlElement(Order = 1)]
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
		[XmlElement(Order = 2)]
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
		[XmlElement(Order = 3)]
		public string culture
		{
			get
			{
				return this.cultureField;
			}
			set
			{
				this.cultureField = value;
				base.RaisePropertyChanged("culture");
			}
		}
		[XmlElement(Order = 4)]
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
		[XmlElement(Order = 5)]
		public string friendlyname
		{
			get
			{
				return this.friendlynameField;
			}
			set
			{
				this.friendlynameField = value;
				base.RaisePropertyChanged("friendlyname");
			}
		}
		[XmlElement(Order = 6)]
		public CrmBoolean isworkflowactivity
		{
			get
			{
				return this.isworkflowactivityField;
			}
			set
			{
				this.isworkflowactivityField = value;
				base.RaisePropertyChanged("isworkflowactivity");
			}
		}
		[XmlElement(Order = 7)]
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
		[XmlElement(Order = 8)]
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
		[XmlElement(Order = 9)]
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
		[XmlElement(Order = 10)]
		public Lookup pluginassemblyid
		{
			get
			{
				return this.pluginassemblyidField;
			}
			set
			{
				this.pluginassemblyidField = value;
				base.RaisePropertyChanged("pluginassemblyid");
			}
		}
		[XmlElement(Order = 11)]
		public Key plugintypeid
		{
			get
			{
				return this.plugintypeidField;
			}
			set
			{
				this.plugintypeidField = value;
				base.RaisePropertyChanged("plugintypeid");
			}
		}
		[XmlElement(Order = 12)]
		public UniqueIdentifier plugintypeidunique
		{
			get
			{
				return this.plugintypeiduniqueField;
			}
			set
			{
				this.plugintypeiduniqueField = value;
				base.RaisePropertyChanged("plugintypeidunique");
			}
		}
		[XmlElement(Order = 13)]
		public string publickeytoken
		{
			get
			{
				return this.publickeytokenField;
			}
			set
			{
				this.publickeytokenField = value;
				base.RaisePropertyChanged("publickeytoken");
			}
		}
		[XmlElement(Order = 14)]
		public string typename
		{
			get
			{
				return this.typenameField;
			}
			set
			{
				this.typenameField = value;
				base.RaisePropertyChanged("typename");
			}
		}
		[XmlElement(Order = 15)]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				base.RaisePropertyChanged("version");
			}
		}
	}
}
