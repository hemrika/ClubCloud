using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class salesliterature : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private string descriptionField;
		private Lookup employeecontactidField;
		private CrmDateTime expirationdateField;
		private CrmBoolean hasattachmentsField;
		private CrmNumber importsequencenumberField;
		private CrmBoolean iscustomerviewableField;
		private string keywordsField;
		private Picklist literaturetypecodeField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private string nameField;
		private Lookup organizationidField;
		private CrmDateTime overriddencreatedonField;
		private Key salesliteratureidField;
		private Lookup subjectidField;
		private CrmNumber timezoneruleversionnumberField;
		private CrmNumber utcconversiontimezonecodeField;
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
		public Lookup employeecontactid
		{
			get
			{
				return this.employeecontactidField;
			}
			set
			{
				this.employeecontactidField = value;
			}
		}
		public CrmDateTime expirationdate
		{
			get
			{
				return this.expirationdateField;
			}
			set
			{
				this.expirationdateField = value;
			}
		}
		public CrmBoolean hasattachments
		{
			get
			{
				return this.hasattachmentsField;
			}
			set
			{
				this.hasattachmentsField = value;
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
		public Picklist literaturetypecode
		{
			get
			{
				return this.literaturetypecodeField;
			}
			set
			{
				this.literaturetypecodeField = value;
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
		public Key salesliteratureid
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
		public Lookup subjectid
		{
			get
			{
				return this.subjectidField;
			}
			set
			{
				this.subjectidField = value;
			}
		}
		public CrmNumber timezoneruleversionnumber
		{
			get
			{
				return this.timezoneruleversionnumberField;
			}
			set
			{
				this.timezoneruleversionnumberField = value;
			}
		}
		public CrmNumber utcconversiontimezonecode
		{
			get
			{
				return this.utcconversiontimezonecodeField;
			}
			set
			{
				this.utcconversiontimezonecodeField = value;
			}
		}
	}
}
