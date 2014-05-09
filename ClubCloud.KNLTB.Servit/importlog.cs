using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class importlog : BusinessEntity
	{
		private string additionalinfoField;
		private string columnvalueField;
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private string errordescriptionField;
		private CrmNumber errornumberField;
		private string headercolumnField;
		private Lookup importdataidField;
		private Lookup importfileidField;
		private Key importlogidField;
		private CrmNumber linenumberField;
		private Picklist logphasecodeField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private CrmNumber sequencenumberField;
		private ImportLogStateInfo statecodeField;
		private Status statuscodeField;
		[XmlElement(Order = 0)]
		public string additionalinfo
		{
			get
			{
				return this.additionalinfoField;
			}
			set
			{
				this.additionalinfoField = value;
				base.RaisePropertyChanged("additionalinfo");
			}
		}
		[XmlElement(Order = 1)]
		public string columnvalue
		{
			get
			{
				return this.columnvalueField;
			}
			set
			{
				this.columnvalueField = value;
				base.RaisePropertyChanged("columnvalue");
			}
		}
		[XmlElement(Order = 2)]
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
		[XmlElement(Order = 3)]
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
		[XmlElement(Order = 4)]
		public string errordescription
		{
			get
			{
				return this.errordescriptionField;
			}
			set
			{
				this.errordescriptionField = value;
				base.RaisePropertyChanged("errordescription");
			}
		}
		[XmlElement(Order = 5)]
		public CrmNumber errornumber
		{
			get
			{
				return this.errornumberField;
			}
			set
			{
				this.errornumberField = value;
				base.RaisePropertyChanged("errornumber");
			}
		}
		[XmlElement(Order = 6)]
		public string headercolumn
		{
			get
			{
				return this.headercolumnField;
			}
			set
			{
				this.headercolumnField = value;
				base.RaisePropertyChanged("headercolumn");
			}
		}
		[XmlElement(Order = 7)]
		public Lookup importdataid
		{
			get
			{
				return this.importdataidField;
			}
			set
			{
				this.importdataidField = value;
				base.RaisePropertyChanged("importdataid");
			}
		}
		[XmlElement(Order = 8)]
		public Lookup importfileid
		{
			get
			{
				return this.importfileidField;
			}
			set
			{
				this.importfileidField = value;
				base.RaisePropertyChanged("importfileid");
			}
		}
		[XmlElement(Order = 9)]
		public Key importlogid
		{
			get
			{
				return this.importlogidField;
			}
			set
			{
				this.importlogidField = value;
				base.RaisePropertyChanged("importlogid");
			}
		}
		[XmlElement(Order = 10)]
		public CrmNumber linenumber
		{
			get
			{
				return this.linenumberField;
			}
			set
			{
				this.linenumberField = value;
				base.RaisePropertyChanged("linenumber");
			}
		}
		[XmlElement(Order = 11)]
		public Picklist logphasecode
		{
			get
			{
				return this.logphasecodeField;
			}
			set
			{
				this.logphasecodeField = value;
				base.RaisePropertyChanged("logphasecode");
			}
		}
		[XmlElement(Order = 12)]
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
		[XmlElement(Order = 13)]
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
		[XmlElement(Order = 14)]
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
		[XmlElement(Order = 15)]
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
		[XmlElement(Order = 16)]
		public CrmNumber sequencenumber
		{
			get
			{
				return this.sequencenumberField;
			}
			set
			{
				this.sequencenumberField = value;
				base.RaisePropertyChanged("sequencenumber");
			}
		}
		[XmlElement(Order = 17)]
		public ImportLogStateInfo statecode
		{
			get
			{
				return this.statecodeField;
			}
			set
			{
				this.statecodeField = value;
				base.RaisePropertyChanged("statecode");
			}
		}
		[XmlElement(Order = 18)]
		public Status statuscode
		{
			get
			{
				return this.statuscodeField;
			}
			set
			{
				this.statuscodeField = value;
				base.RaisePropertyChanged("statuscode");
			}
		}
	}
}
