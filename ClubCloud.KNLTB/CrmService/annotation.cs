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

		[XmlElement] //[XmlElement(Order=0)]
		public Key annotationid
		{
			get
			{
				return this.annotationidField;
			}
			set
			{
				this.annotationidField = value;
				base.RaisePropertyChanged("annotationid");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
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

		[XmlElement] //[XmlElement(Order=2)]
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

		[XmlElement] //[XmlElement(Order=3)]
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

		[XmlElement] //[XmlElement(Order=4)]
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

		[XmlElement] //[XmlElement(Order=5)]
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
		public CrmBoolean isdocument
		{
			get
			{
				return this.isdocumentField;
			}
			set
			{
				this.isdocumentField = value;
				base.RaisePropertyChanged("isdocument");
			}
		}

		[XmlElement] //[XmlElement(Order=8)]
		public string langid
		{
			get
			{
				return this.langidField;
			}
			set
			{
				this.langidField = value;
				base.RaisePropertyChanged("langid");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
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
		public string notetext
		{
			get
			{
				return this.notetextField;
			}
			set
			{
				this.notetextField = value;
				base.RaisePropertyChanged("notetext");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public Lookup objectid
		{
			get
			{
				return this.objectidField;
			}
			set
			{
				this.objectidField = value;
				base.RaisePropertyChanged("objectid");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
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

		[XmlElement] //[XmlElement(Order=15)]
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

		[XmlElement] //[XmlElement(Order=16)]
		public Owner ownerid
		{
			get
			{
				return this.owneridField;
			}
			set
			{
				this.owneridField = value;
				base.RaisePropertyChanged("ownerid");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public Lookup owningbusinessunit
		{
			get
			{
				return this.owningbusinessunitField;
			}
			set
			{
				this.owningbusinessunitField = value;
				base.RaisePropertyChanged("owningbusinessunit");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public string stepid
		{
			get
			{
				return this.stepidField;
			}
			set
			{
				this.stepidField = value;
				base.RaisePropertyChanged("stepid");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
		public string subject
		{
			get
			{
				return this.subjectField;
			}
			set
			{
				this.subjectField = value;
				base.RaisePropertyChanged("subject");
			}
		}

		public annotation()
		{
		}
	}
}