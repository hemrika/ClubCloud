using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class annotation : BusinessEntity
	{
		private Key annotationidField;
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private string documentbodyField;
		private string filenameField;
		private CrmNumber filesizeField;
		private CrmNumber importsequencenumberField;
		private CrmBoolean isdocumentField;
		private string langidField;
		private string mimetypeField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private string notetextField;
		private Lookup objectidField;
		private EntityNameReference objecttypecodeField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private string stepidField;
		private string subjectField;
		public Key annotationid
		{
			get
			{
				return this.annotationidField;
			}
			set
			{
				this.annotationidField = value;
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
		public string documentbody
		{
			get
			{
				return this.documentbodyField;
			}
			set
			{
				this.documentbodyField = value;
			}
		}
		public string filename
		{
			get
			{
				return this.filenameField;
			}
			set
			{
				this.filenameField = value;
			}
		}
		public CrmNumber filesize
		{
			get
			{
				return this.filesizeField;
			}
			set
			{
				this.filesizeField = value;
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
		public CrmBoolean isdocument
		{
			get
			{
				return this.isdocumentField;
			}
			set
			{
				this.isdocumentField = value;
			}
		}
		public string langid
		{
			get
			{
				return this.langidField;
			}
			set
			{
				this.langidField = value;
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
		public string notetext
		{
			get
			{
				return this.notetextField;
			}
			set
			{
				this.notetextField = value;
			}
		}
		public Lookup objectid
		{
			get
			{
				return this.objectidField;
			}
			set
			{
				this.objectidField = value;
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
		public CrmDateTime overriddencreatedon
		{
			get
			{
				return this.overriddencreatedonField;
			}
			set
			{
				this.overriddencreatedonField = value;
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
		public string stepid
		{
			get
			{
				return this.stepidField;
			}
			set
			{
				this.stepidField = value;
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
	}
}
