using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class importdata : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private string dataField;
		private CrmBoolean haserrorField;
		private Key importdataidField;
		private Lookup importfileidField;
		private CrmNumber linenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private UniqueIdentifier recordidField;
		private ImportDataStateInfo statecodeField;
		private Status statuscodeField;
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
		public string data
		{
			get
			{
				return this.dataField;
			}
			set
			{
				this.dataField = value;
			}
		}
		public CrmBoolean haserror
		{
			get
			{
				return this.haserrorField;
			}
			set
			{
				this.haserrorField = value;
			}
		}
		public Key importdataid
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
		public UniqueIdentifier recordid
		{
			get
			{
				return this.recordidField;
			}
			set
			{
				this.recordidField = value;
			}
		}
		public ImportDataStateInfo statecode
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
