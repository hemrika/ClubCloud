using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class savedquery : BusinessEntity
	{
		private string columnsetxmlField;
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber customizationlevelField;
		private string descriptionField;
		private string fetchxmlField;
		private CrmBoolean inproductionField;
		private CrmBoolean iscustomizableField;
		private CrmBoolean isdefaultField;
		private CrmBoolean isprivateField;
		private CrmBoolean isquickfindqueryField;
		private CrmBoolean isuserdefinedField;
		private string layoutxmlField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private string nameField;
		private Lookup organizationidField;
		private string queryapiField;
		private CrmNumber queryappusageField;
		private CrmNumber querytypeField;
		private string returnedtypecodeField;
		private Key savedqueryidField;
		private UniqueIdentifier savedqueryiduniqueField;
		public string columnsetxml
		{
			get
			{
				return this.columnsetxmlField;
			}
			set
			{
				this.columnsetxmlField = value;
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
		public string description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
			}
		}
		public string fetchxml
		{
			get
			{
				return this.fetchxmlField;
			}
			set
			{
				this.fetchxmlField = value;
			}
		}
		public CrmBoolean inproduction
		{
			get
			{
				return this.inproductionField;
			}
			set
			{
				this.inproductionField = value;
			}
		}
		public CrmBoolean iscustomizable
		{
			get
			{
				return this.iscustomizableField;
			}
			set
			{
				this.iscustomizableField = value;
			}
		}
		public CrmBoolean isdefault
		{
			get
			{
				return this.isdefaultField;
			}
			set
			{
				this.isdefaultField = value;
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
		public CrmBoolean isquickfindquery
		{
			get
			{
				return this.isquickfindqueryField;
			}
			set
			{
				this.isquickfindqueryField = value;
			}
		}
		public CrmBoolean isuserdefined
		{
			get
			{
				return this.isuserdefinedField;
			}
			set
			{
				this.isuserdefinedField = value;
			}
		}
		public string layoutxml
		{
			get
			{
				return this.layoutxmlField;
			}
			set
			{
				this.layoutxmlField = value;
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
		public string queryapi
		{
			get
			{
				return this.queryapiField;
			}
			set
			{
				this.queryapiField = value;
			}
		}
		public CrmNumber queryappusage
		{
			get
			{
				return this.queryappusageField;
			}
			set
			{
				this.queryappusageField = value;
			}
		}
		public CrmNumber querytype
		{
			get
			{
				return this.querytypeField;
			}
			set
			{
				this.querytypeField = value;
			}
		}
		public string returnedtypecode
		{
			get
			{
				return this.returnedtypecodeField;
			}
			set
			{
				this.returnedtypecodeField = value;
			}
		}
		public Key savedqueryid
		{
			get
			{
				return this.savedqueryidField;
			}
			set
			{
				this.savedqueryidField = value;
			}
		}
		public UniqueIdentifier savedqueryidunique
		{
			get
			{
				return this.savedqueryiduniqueField;
			}
			set
			{
				this.savedqueryiduniqueField = value;
			}
		}
	}
}
