using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
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
		[XmlElement(Order = 0)]
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
		[XmlElement(Order = 1)]
		public string fieldxml
		{
			get
			{
				return this.fieldxmlField;
			}
			set
			{
				this.fieldxmlField = value;
				base.RaisePropertyChanged("fieldxml");
			}
		}
		[XmlElement(Order = 2)]
		public Key formid
		{
			get
			{
				return this.formidField;
			}
			set
			{
				this.formidField = value;
				base.RaisePropertyChanged("formid");
			}
		}
		[XmlElement(Order = 3)]
		public UniqueIdentifier formidunique
		{
			get
			{
				return this.formiduniqueField;
			}
			set
			{
				this.formiduniqueField = value;
				base.RaisePropertyChanged("formidunique");
			}
		}
		[XmlElement(Order = 4)]
		public string formxml
		{
			get
			{
				return this.formxmlField;
			}
			set
			{
				this.formxmlField = value;
				base.RaisePropertyChanged("formxml");
			}
		}
		[XmlElement(Order = 5)]
		public string gridicon
		{
			get
			{
				return this.gridiconField;
			}
			set
			{
				this.gridiconField = value;
				base.RaisePropertyChanged("gridicon");
			}
		}
		[XmlElement(Order = 6)]
		public CrmBoolean inproduction
		{
			get
			{
				return this.inproductionField;
			}
			set
			{
				this.inproductionField = value;
				base.RaisePropertyChanged("inproduction");
			}
		}
		[XmlElement(Order = 7)]
		public string largeentityicon
		{
			get
			{
				return this.largeentityiconField;
			}
			set
			{
				this.largeentityiconField = value;
				base.RaisePropertyChanged("largeentityicon");
			}
		}
		[XmlElement(Order = 8)]
		public EntityNameReference objecttypecode
		{
			get
			{
				return this.objecttypecodeField;
			}
			set
			{
				this.objecttypecodeField = value;
				base.RaisePropertyChanged("objecttypecode");
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
		public string outlookshortcuticon
		{
			get
			{
				return this.outlookshortcuticonField;
			}
			set
			{
				this.outlookshortcuticonField = value;
				base.RaisePropertyChanged("outlookshortcuticon");
			}
		}
		[XmlElement(Order = 11)]
		public string previewcolumnsetxml
		{
			get
			{
				return this.previewcolumnsetxmlField;
			}
			set
			{
				this.previewcolumnsetxmlField = value;
				base.RaisePropertyChanged("previewcolumnsetxml");
			}
		}
		[XmlElement(Order = 12)]
		public string previewxml
		{
			get
			{
				return this.previewxmlField;
			}
			set
			{
				this.previewxmlField = value;
				base.RaisePropertyChanged("previewxml");
			}
		}
		[XmlElement(Order = 13)]
		public CrmNumber version
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
