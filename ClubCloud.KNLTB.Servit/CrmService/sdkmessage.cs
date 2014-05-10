using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sdkmessage : BusinessEntity
	{
		private CrmBoolean autotransactField;
		private CrmNumber availabilityField;
		private string categorynameField;
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber customizationlevelField;
		private CrmBoolean expandField;
		private CrmBoolean isprivateField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private string nameField;
		private Lookup organizationidField;
		private Key sdkmessageidField;
		private UniqueIdentifier sdkmessageiduniqueField;
		private CrmBoolean templateField;
		public CrmBoolean autotransact
		{
			get
			{
				return this.autotransactField;
			}
			set
			{
				this.autotransactField = value;
			}
		}
		public CrmNumber availability
		{
			get
			{
				return this.availabilityField;
			}
			set
			{
				this.availabilityField = value;
			}
		}
		public string categoryname
		{
			get
			{
				return this.categorynameField;
			}
			set
			{
				this.categorynameField = value;
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
		public CrmBoolean expand
		{
			get
			{
				return this.expandField;
			}
			set
			{
				this.expandField = value;
			}
		}
		public CrmBoolean isprivate
		{
			get
			{
				return this.isprivateField;
			}
			set
			{
				this.isprivateField = value;
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
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
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
		public Key sdkmessageid
		{
			get
			{
				return this.sdkmessageidField;
			}
			set
			{
				this.sdkmessageidField = value;
			}
		}
		public UniqueIdentifier sdkmessageidunique
		{
			get
			{
				return this.sdkmessageiduniqueField;
			}
			set
			{
				this.sdkmessageiduniqueField = value;
			}
		}
		public CrmBoolean template
		{
			get
			{
				return this.templateField;
			}
			set
			{
				this.templateField = value;
			}
		}
	}
}
