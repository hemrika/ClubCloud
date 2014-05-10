using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
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
		public string additionalinfo
		{
			get
			{
				return this.additionalinfoField;
			}
			set
			{
				this.additionalinfoField = value;
			}
		}
		public string columnvalue
		{
			get
			{
				return this.columnvalueField;
			}
			set
			{
				this.columnvalueField = value;
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
		public string errordescription
		{
			get
			{
				return this.errordescriptionField;
			}
			set
			{
				this.errordescriptionField = value;
			}
		}
		public CrmNumber errornumber
		{
			get
			{
				return this.errornumberField;
			}
			set
			{
				this.errornumberField = value;
			}
		}
		public string headercolumn
		{
			get
			{
				return this.headercolumnField;
			}
			set
			{
				this.headercolumnField = value;
			}
		}
		public Lookup importdataid
		{
			get
			{
				return this.importdataidField;
			}
			set
			{
				this.importdataidField = value;
			}
		}
		public Lookup importfileid
		{
			get
			{
				return this.importfileidField;
			}
			set
			{
				this.importfileidField = value;
			}
		}
		public Key importlogid
		{
			get
			{
				return this.importlogidField;
			}
			set
			{
				this.importlogidField = value;
			}
		}
		public CrmNumber linenumber
		{
			get
			{
				return this.linenumberField;
			}
			set
			{
				this.linenumberField = value;
			}
		}
		public Picklist logphasecode
		{
			get
			{
				return this.logphasecodeField;
			}
			set
			{
				this.logphasecodeField = value;
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
		public CrmNumber sequencenumber
		{
			get
			{
				return this.sequencenumberField;
			}
			set
			{
				this.sequencenumberField = value;
			}
		}
		public ImportLogStateInfo statecode
		{
			get
			{
				return this.statecodeField;
			}
			set
			{
				this.statecodeField = value;
			}
		}
		public Status statuscode
		{
			get
			{
				return this.statuscodeField;
			}
			set
			{
				this.statuscodeField = value;
			}
		}
	}
}
