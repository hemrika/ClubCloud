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
	public class subscriptionsyncinfo : BusinessEntity
	{
		private CrmNumber datasizeField;

		private CrmNumber deleteobjectcountField;

		private CrmDateTime endtimeField;

		private CrmNumber insertobjectcountField;

		private CrmDateTime starttimeField;

		private Lookup subscriptionidField;

		private CrmNumber subscriptionsyncinfoidField;

		private CrmBoolean syncresultField;

		private CrmNumber timezoneruleversionnumberField;

		private CrmNumber utcconversiontimezonecodeField;

		[XmlElement] //[XmlElement(Order=0)]
		public CrmNumber datasize
		{
			get
			{
				return this.datasizeField;
			}
			set
			{
				this.datasizeField = value;
				base.RaisePropertyChanged("datasize");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public CrmNumber deleteobjectcount
		{
			get
			{
				return this.deleteobjectcountField;
			}
			set
			{
				this.deleteobjectcountField = value;
				base.RaisePropertyChanged("deleteobjectcount");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public CrmDateTime endtime
		{
			get
			{
				return this.endtimeField;
			}
			set
			{
				this.endtimeField = value;
				base.RaisePropertyChanged("endtime");
			}
		}

		[XmlElement] //[XmlElement(Order=3)]
		public CrmNumber insertobjectcount
		{
			get
			{
				return this.insertobjectcountField;
			}
			set
			{
				this.insertobjectcountField = value;
				base.RaisePropertyChanged("insertobjectcount");
			}
		}

		[XmlElement] //[XmlElement(Order=4)]
		public CrmDateTime starttime
		{
			get
			{
				return this.starttimeField;
			}
			set
			{
				this.starttimeField = value;
				base.RaisePropertyChanged("starttime");
			}
		}

		[XmlElement] //[XmlElement(Order=5)]
		public Lookup subscriptionid
		{
			get
			{
				return this.subscriptionidField;
			}
			set
			{
				this.subscriptionidField = value;
				base.RaisePropertyChanged("subscriptionid");
			}
		}

		[XmlElement] //[XmlElement(Order=6)]
		public CrmNumber subscriptionsyncinfoid
		{
			get
			{
				return this.subscriptionsyncinfoidField;
			}
			set
			{
				this.subscriptionsyncinfoidField = value;
				base.RaisePropertyChanged("subscriptionsyncinfoid");
			}
		}

		[XmlElement] //[XmlElement(Order=7)]
		public CrmBoolean syncresult
		{
			get
			{
				return this.syncresultField;
			}
			set
			{
				this.syncresultField = value;
				base.RaisePropertyChanged("syncresult");
			}
		}

		[XmlElement] //[XmlElement(Order=8)]
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

		[XmlElement] //[XmlElement(Order=9)]
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

		public subscriptionsyncinfo()
		{
		}
	}
}