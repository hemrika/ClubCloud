using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[GeneratedCode("System.Xml", "4.0.30319.33440")]
	[Serializable]
	[XmlType(Namespace="http://schemas.microsoft.com/crm/2007/WebServices")]
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

		[XmlElement] //[XmlElement(Order=0)]
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

		[XmlElement] //[XmlElement(Order=1)]
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

		[XmlElement] //[XmlElement(Order=2)]
		public string description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
				base.RaisePropertyChanged("description");
			}
		}

		[XmlElement] //[XmlElement(Order=3)]
		public Lookup employeecontactid
		{
			get
			{
				return this.employeecontactidField;
			}
			set
			{
				this.employeecontactidField = value;
				base.RaisePropertyChanged("employeecontactid");
			}
		}

		[XmlElement] //[XmlElement(Order=4)]
		public CrmDateTime expirationdate
		{
			get
			{
				return this.expirationdateField;
			}
			set
			{
				this.expirationdateField = value;
				base.RaisePropertyChanged("expirationdate");
			}
		}

		[XmlElement] //[XmlElement(Order=5)]
		public CrmBoolean hasattachments
		{
			get
			{
				return this.hasattachmentsField;
			}
			set
			{
				this.hasattachmentsField = value;
				base.RaisePropertyChanged("hasattachments");
			}
		}

		[XmlElement] //[XmlElement(Order=6)]
		public CrmNumber importsequencenumber
		{
			get
			{
				return this.importsequencenumberField;
			}
			set
			{
				this.importsequencenumberField = value;
				base.RaisePropertyChanged("importsequencenumber");
			}
		}

		[XmlElement] //[XmlElement(Order=7)]
		public CrmBoolean iscustomerviewable
		{
			get
			{
				return this.iscustomerviewableField;
			}
			set
			{
				this.iscustomerviewableField = value;
				base.RaisePropertyChanged("iscustomerviewable");
			}
		}

		[XmlElement] //[XmlElement(Order=8)]
		public string keywords
		{
			get
			{
				return this.keywordsField;
			}
			set
			{
				this.keywordsField = value;
				base.RaisePropertyChanged("keywords");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public Picklist literaturetypecode
		{
			get
			{
				return this.literaturetypecodeField;
			}
			set
			{
				this.literaturetypecodeField = value;
				base.RaisePropertyChanged("literaturetypecode");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
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

		[XmlElement] //[XmlElement(Order=11)]
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

		[XmlElement] //[XmlElement(Order=12)]
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
				base.RaisePropertyChanged("name");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
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

		[XmlElement] //[XmlElement(Order=14)]
		public CrmDateTime overriddencreatedon
		{
			get
			{
				return this.overriddencreatedonField;
			}
			set
			{
				this.overriddencreatedonField = value;
				base.RaisePropertyChanged("overriddencreatedon");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public Key salesliteratureid
		{
			get
			{
				return this.salesliteratureidField;
			}
			set
			{
				this.salesliteratureidField = value;
				base.RaisePropertyChanged("salesliteratureid");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public Lookup subjectid
		{
			get
			{
				return this.subjectidField;
			}
			set
			{
				this.subjectidField = value;
				base.RaisePropertyChanged("subjectid");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public CrmNumber timezoneruleversionnumber
		{
			get
			{
				return this.timezoneruleversionnumberField;
			}
			set
			{
				this.timezoneruleversionnumberField = value;
				base.RaisePropertyChanged("timezoneruleversionnumber");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public CrmNumber utcconversiontimezonecode
		{
			get
			{
				return this.utcconversiontimezonecodeField;
			}
			set
			{
				this.utcconversiontimezonecodeField = value;
				base.RaisePropertyChanged("utcconversiontimezonecode");
			}
		}

		public salesliterature()
		{
		}
	}
}