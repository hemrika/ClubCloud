using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sdkmessageprocessingstepimage : BusinessEntity
	{
		private string attributesField;
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber customizationlevelField;
		private string entityaliasField;
		private Picklist imagetypeField;
		private string messagepropertynameField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup organizationidField;
		private string relatedattributenameField;
		private Lookup sdkmessageprocessingstepidField;
		private Key sdkmessageprocessingstepimageidField;
		private UniqueIdentifier sdkmessageprocessingstepimageiduniqueField;
		[XmlElement(Order = 0)]
		public string attributes
		{
			get
			{
				return this.attributesField;
			}
			set
			{
				this.attributesField = value;
				base.RaisePropertyChanged("attributes");
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
		[XmlElement(Order = 4)]
		public string entityalias
		{
			get
			{
				return this.entityaliasField;
			}
			set
			{
				this.entityaliasField = value;
				base.RaisePropertyChanged("entityalias");
			}
		}
		[XmlElement(Order = 5)]
		public Picklist imagetype
		{
			get
			{
				return this.imagetypeField;
			}
			set
			{
				this.imagetypeField = value;
				base.RaisePropertyChanged("imagetype");
			}
		}
		[XmlElement(Order = 6)]
		public string messagepropertyname
		{
			get
			{
				return this.messagepropertynameField;
			}
			set
			{
				this.messagepropertynameField = value;
				base.RaisePropertyChanged("messagepropertyname");
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
		public string relatedattributename
		{
			get
			{
				return this.relatedattributenameField;
			}
			set
			{
				this.relatedattributenameField = value;
				base.RaisePropertyChanged("relatedattributename");
			}
		}
		[XmlElement(Order = 11)]
		public Lookup sdkmessageprocessingstepid
		{
			get
			{
				return this.sdkmessageprocessingstepidField;
			}
			set
			{
				this.sdkmessageprocessingstepidField = value;
				base.RaisePropertyChanged("sdkmessageprocessingstepid");
			}
		}
		[XmlElement(Order = 12)]
		public Key sdkmessageprocessingstepimageid
		{
			get
			{
				return this.sdkmessageprocessingstepimageidField;
			}
			set
			{
				this.sdkmessageprocessingstepimageidField = value;
				base.RaisePropertyChanged("sdkmessageprocessingstepimageid");
			}
		}
		[XmlElement(Order = 13)]
		public UniqueIdentifier sdkmessageprocessingstepimageidunique
		{
			get
			{
				return this.sdkmessageprocessingstepimageiduniqueField;
			}
			set
			{
				this.sdkmessageprocessingstepimageiduniqueField = value;
				base.RaisePropertyChanged("sdkmessageprocessingstepimageidunique");
			}
		}
	}
}
