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

		[XmlElement] //[XmlElement(Order=0)]
		public string @abstract
		{
			get
			{
				return this.abstractField;
			}
			set
			{
				this.abstractField = value;
				base.RaisePropertyChanged("abstract");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public string attacheddocumenturl
		{
			get
			{
				return this.attacheddocumenturlField;
			}
			set
			{
				this.attacheddocumenturlField = value;
				base.RaisePropertyChanged("attacheddocumenturl");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public string authorname
		{
			get
			{
				return this.authornameField;
			}
			set
			{
				this.authornameField = value;
				base.RaisePropertyChanged("authorname");
			}
		}

		[XmlElement] //[XmlElement(Order=3)]
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

		[XmlElement] //[XmlElement(Order=4)]
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

		[XmlElement] //[XmlElement(Order=5)]
		public string documentbody
		{
			get
			{
				return this.documentbodyField;
			}
			set
			{
				this.documentbodyField = value;
				base.RaisePropertyChanged("documentbody");
			}
		}

		[XmlElement] //[XmlElement(Order=6)]
		public string filename
		{
			get
			{
				return this.filenameField;
			}
			set
			{
				this.filenameField = value;
				base.RaisePropertyChanged("filename");
			}
		}

		[XmlElement] //[XmlElement(Order=7)]
		public CrmNumber filesize
		{
			get
			{
				return this.filesizeField;
			}
			set
			{
				this.filesizeField = value;
				base.RaisePropertyChanged("filesize");
			}
		}

		[XmlElement] //[XmlElement(Order=8)]
		public Picklist filetypecode
		{
			get
			{
				return this.filetypecodeField;
			}
			set
			{
				this.filetypecodeField = value;
				base.RaisePropertyChanged("filetypecode");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
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

		[XmlElement] //[XmlElement(Order=10)]
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

		[XmlElement] //[XmlElement(Order=11)]
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

		[XmlElement] //[XmlElement(Order=12)]
		public string mimetype
		{
			get
			{
				return this.mimetypeField;
			}
			set
			{
				this.mimetypeField = value;
				base.RaisePropertyChanged("mimetype");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
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

		[XmlElement] //[XmlElement(Order=14)]
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

		[XmlElement] //[XmlElement(Order=15)]
		public UniqueIdentifier organizationid
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

		[XmlElement] //[XmlElement(Order=16)]
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

		[XmlElement] //[XmlElement(Order=17)]
		public Lookup salesliteratureid
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

		[XmlElement] //[XmlElement(Order=18)]
		public Key salesliteratureitemid
		{
			get
			{
				return this.salesliteratureitemidField;
			}
			set
			{
				this.salesliteratureitemidField = value;
				base.RaisePropertyChanged("salesliteratureitemid");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
		public string title
		{
			get
			{
				return this.titleField;
			}
			set
			{
				this.titleField = value;
				base.RaisePropertyChanged("title");
			}
		}

		public salesliteratureitem()
		{
		}
	}
}