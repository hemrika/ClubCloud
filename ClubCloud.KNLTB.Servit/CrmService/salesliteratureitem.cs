using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class salesliteratureitem : BusinessEntity
	{
		private string abstractField;
		private string attacheddocumenturlField;
		private string authornameField;
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private string documentbodyField;
		private string filenameField;
		private CrmNumber filesizeField;
		private Picklist filetypecodeField;
		private CrmNumber importsequencenumberField;
		private CrmBoolean iscustomerviewableField;
		private string keywordsField;
		private string mimetypeField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private UniqueIdentifier organizationidField;
		private CrmDateTime overriddencreatedonField;
		private Lookup salesliteratureidField;
		private Key salesliteratureitemidField;
		private string titleField;
		public string @abstract
		{
			get
			{
				return this.abstractField;
			}
			set
			{
				this.abstractField = value;
			}
		}
		public string attacheddocumenturl
		{
			get
			{
				return this.attacheddocumenturlField;
			}
			set
			{
				this.attacheddocumenturlField = value;
			}
		}
		public string authorname
		{
			get
			{
				return this.authornameField;
			}
			set
			{
				this.authornameField = value;
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
		public Picklist filetypecode
		{
			get
			{
				return this.filetypecodeField;
			}
			set
			{
				this.filetypecodeField = value;
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
		public CrmBoolean iscustomerviewable
		{
			get
			{
				return this.iscustomerviewableField;
			}
			set
			{
				this.iscustomerviewableField = value;
			}
		}
		public string keywords
		{
			get
			{
				return this.keywordsField;
			}
			set
			{
				this.keywordsField = value;
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
		public UniqueIdentifier organizationid
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
		public Lookup salesliteratureid
		{
			get
			{
				return this.salesliteratureidField;
			}
			set
			{
				this.salesliteratureidField = value;
			}
		}
		public Key salesliteratureitemid
		{
			get
			{
				return this.salesliteratureitemidField;
			}
			set
			{
				this.salesliteratureitemidField = value;
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
