using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class organizationui : BusinessEntity
	{
		private CrmNumber customizationlevelField;
		private string fieldxmlField;
		private Key formidField;
		private UniqueIdentifier formiduniqueField;
		private string formxmlField;
		private string gridiconField;
		private CrmBoolean inproductionField;
		private string largeentityiconField;
		private EntityNameReference objecttypecodeField;
		private Lookup organizationidField;
		private string outlookshortcuticonField;
		private string previewcolumnsetxmlField;
		private string previewxmlField;
		private CrmNumber versionField;
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
		public string fieldxml
		{
			get
			{
				return this.fieldxmlField;
			}
			set
			{
				this.fieldxmlField = value;
			}
		}
		public Key formid
		{
			get
			{
				return this.formidField;
			}
			set
			{
				this.formidField = value;
			}
		}
		public UniqueIdentifier formidunique
		{
			get
			{
				return this.formiduniqueField;
			}
			set
			{
				this.formiduniqueField = value;
			}
		}
		public string formxml
		{
			get
			{
				return this.formxmlField;
			}
			set
			{
				this.formxmlField = value;
			}
		}
		public string gridicon
		{
			get
			{
				return this.gridiconField;
			}
			set
			{
				this.gridiconField = value;
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
		public string largeentityicon
		{
			get
			{
				return this.largeentityiconField;
			}
			set
			{
				this.largeentityiconField = value;
			}
		}
		public EntityNameReference objecttypecode
		{
			get
			{
				return this.objecttypecodeField;
			}
			set
			{
				this.objecttypecodeField = value;
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
		public string outlookshortcuticon
		{
			get
			{
				return this.outlookshortcuticonField;
			}
			set
			{
				this.outlookshortcuticonField = value;
			}
		}
		public string previewcolumnsetxml
		{
			get
			{
				return this.previewcolumnsetxmlField;
			}
			set
			{
				this.previewcolumnsetxmlField = value;
			}
		}
		public string previewxml
		{
			get
			{
				return this.previewxmlField;
			}
			set
			{
				this.previewxmlField = value;
			}
		}
		public CrmNumber version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
			}
		}
	}
}
