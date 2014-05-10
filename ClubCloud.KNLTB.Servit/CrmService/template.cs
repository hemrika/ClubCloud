using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class template : BusinessEntity
	{
		private string bodyField;
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private string descriptionField;
		private CrmNumber generationtypecodeField;
		private CrmNumber importsequencenumberField;
		private CrmBoolean ispersonalField;
		private CrmNumber languagecodeField;
		private string mimetypeField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private string presentationxmlField;
		private string subjectField;
		private string subjectpresentationxmlField;
		private Key templateidField;
		private EntityNameReference templatetypecodeField;
		private string titleField;
		public string body
		{
			get
			{
				return this.bodyField;
			}
			set
			{
				this.bodyField = value;
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
		public CrmNumber generationtypecode
		{
			get
			{
				return this.generationtypecodeField;
			}
			set
			{
				this.generationtypecodeField = value;
			}
		}
		public CrmNumber importsequencenumber
		{
			get
			{
				return this.importsequencenumberField;
			}
			set
			{
				this.importsequencenumberField = value;
			}
		}
		public CrmBoolean ispersonal
		{
			get
			{
				return this.ispersonalField;
			}
			set
			{
				this.ispersonalField = value;
			}
		}
		public CrmNumber languagecode
		{
			get
			{
				return this.languagecodeField;
			}
			set
			{
				this.languagecodeField = value;
			}
		}
		public string mimetype
		{
			get
			{
				return this.mimetypeField;
			}
			set
			{
				this.mimetypeField = value;
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
		public Owner ownerid
		{
			get
			{
				return this.owneridField;
			}
			set
			{
				this.owneridField = value;
			}
		}
		public Lookup owningbusinessunit
		{
			get
			{
				return this.owningbusinessunitField;
			}
			set
			{
				this.owningbusinessunitField = value;
			}
		}
		public string presentationxml
		{
			get
			{
				return this.presentationxmlField;
			}
			set
			{
				this.presentationxmlField = value;
			}
		}
		public string subject
		{
			get
			{
				return this.subjectField;
			}
			set
			{
				this.subjectField = value;
			}
		}
		public string subjectpresentationxml
		{
			get
			{
				return this.subjectpresentationxmlField;
			}
			set
			{
				this.subjectpresentationxmlField = value;
			}
		}
		public Key templateid
		{
			get
			{
				return this.templateidField;
			}
			set
			{
				this.templateidField = value;
			}
		}
		public EntityNameReference templatetypecode
		{
			get
			{
				return this.templatetypecodeField;
			}
			set
			{
				this.templatetypecodeField = value;
			}
		}
		public string title
		{
			get
			{
				return this.titleField;
			}
			set
			{
				this.titleField = value;
			}
		}
	}
}
