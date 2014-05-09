using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class pluginassembly : BusinessEntity
	{
		private string contentField;
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private string cultureField;
		private CrmNumber customizationlevelField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private string nameField;
		private Lookup organizationidField;
		private string pathField;
		private Key pluginassemblyidField;
		private UniqueIdentifier pluginassemblyiduniqueField;
		private string publickeytokenField;
		private string sourcehashField;
		private Picklist sourcetypeField;
		private string versionField;
		[XmlElement(Order = 0)]
		public string content
		{
			get
			{
				return this.contentField;
			}
			set
			{
				this.contentField = value;
				base.RaisePropertyChanged("content");
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
		[XmlElement(Order = 6)]
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
		[XmlElement(Order = 7)]
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
		[XmlElement(Order = 8)]
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
		[XmlElement(Order = 9)]
		public string path
		{
			get
			{
				return this.pathField;
			}
			set
			{
				this.pathField = value;
				base.RaisePropertyChanged("path");
			}
		}
		[XmlElement(Order = 10)]
		public Key pluginassemblyid
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
		public UniqueIdentifier pluginassemblyidunique
		{
			get
			{
				return this.pluginassemblyiduniqueField;
			}
			set
			{
				this.pluginassemblyiduniqueField = value;
				base.RaisePropertyChanged("pluginassemblyidunique");
			}
		}
		[XmlElement(Order = 12)]
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
		[XmlElement(Order = 13)]
		public string sourcehash
		{
			get
			{
				return this.sourcehashField;
			}
			set
			{
				this.sourcehashField = value;
				base.RaisePropertyChanged("sourcehash");
			}
		}
		[XmlElement(Order = 14)]
		public Picklist sourcetype
		{
			get
			{
				return this.sourcetypeField;
			}
			set
			{
				this.sourcetypeField = value;
				base.RaisePropertyChanged("sourcetype");
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
