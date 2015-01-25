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
		public string data
		{
			get
			{
				return this.dataField;
			}
			set
			{
				this.dataField = value;
				base.RaisePropertyChanged("data");
			}
		}

		[XmlElement] //[XmlElement(Order=3)]
		public CrmBoolean haserror
		{
			get
			{
				return this.haserrorField;
			}
			set
			{
				this.haserrorField = value;
				base.RaisePropertyChanged("haserror");
			}
		}

		[XmlElement] //[XmlElement(Order=4)]
		public Key importdataid
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

		[XmlElement] //[XmlElement(Order=5)]
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

		[XmlElement] //[XmlElement(Order=6)]
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

		[XmlElement] //[XmlElement(Order=7)]
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

		[XmlElement] //[XmlElement(Order=8)]
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

		[XmlElement] //[XmlElement(Order=9)]
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

		[XmlElement] //[XmlElement(Order=10)]
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

		[XmlElement] //[XmlElement(Order=11)]
		public UniqueIdentifier recordid
		{
			get
			{
				return this.recordidField;
			}
			set
			{
				this.recordidField = value;
				base.RaisePropertyChanged("recordid");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public ImportDataStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=13)]
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

		public importdata()
		{
		}
	}
}