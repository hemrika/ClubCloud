using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
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
		public string attributes
		{
			get
			{
				return this.attributesField;
			}
			set
			{
				this.attributesField = value;
			}
		}
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
		public string entityalias
		{
			get
			{
				return this.entityaliasField;
			}
			set
			{
				this.entityaliasField = value;
			}
		}
		public Picklist imagetype
		{
			get
			{
				return this.imagetypeField;
			}
			set
			{
				this.imagetypeField = value;
			}
		}
		public string messagepropertyname
		{
			get
			{
				return this.messagepropertynameField;
			}
			set
			{
				this.messagepropertynameField = value;
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
		public string relatedattributename
		{
			get
			{
				return this.relatedattributenameField;
			}
			set
			{
				this.relatedattributenameField = value;
			}
		}
		public Lookup sdkmessageprocessingstepid
		{
			get
			{
				return this.sdkmessageprocessingstepidField;
			}
			set
			{
				this.sdkmessageprocessingstepidField = value;
			}
		}
		public Key sdkmessageprocessingstepimageid
		{
			get
			{
				return this.sdkmessageprocessingstepimageidField;
			}
			set
			{
				this.sdkmessageprocessingstepimageidField = value;
			}
		}
		public UniqueIdentifier sdkmessageprocessingstepimageidunique
		{
			get
			{
				return this.sdkmessageprocessingstepimageiduniqueField;
			}
			set
			{
				this.sdkmessageprocessingstepimageiduniqueField = value;
			}
		}
	}
}
