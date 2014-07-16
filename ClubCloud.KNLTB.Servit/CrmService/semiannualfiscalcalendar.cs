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
	public class semiannualfiscalcalendar : BusinessEntity
	{
		private Lookup businessunitidField;

		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmDateTime effectiveonField;

		private CrmDecimal exchangerateField;

		private CrmMoney firsthalfField;

		private CrmMoney firsthalf_baseField;

		private CrmNumber fiscalperiodtypeField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private Lookup salespersonidField;

		private CrmMoney secondhalfField;

		private CrmMoney secondhalf_baseField;

		private CrmNumber timezoneruleversionnumberField;

		private Lookup transactioncurrencyidField;

		private Key userfiscalcalendaridField;

		private CrmNumber utcconversiontimezonecodeField;

		[XmlElement] //[XmlElement(Order=0)]
		public Lookup businessunitid
		{
			get
			{
				return this.businessunitidField;
			}
			set
			{
				this.businessunitidField = value;
				base.RaisePropertyChanged("businessunitid");
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
		public CrmDateTime effectiveon
		{
			get
			{
				return this.effectiveonField;
			}
			set
			{
				this.effectiveonField = value;
				base.RaisePropertyChanged("effectiveon");
			}
		}

		[XmlElement] //[XmlElement(Order=4)]
		public CrmDecimal exchangerate
		{
			get
			{
				return this.exchangerateField;
			}
			set
			{
				this.exchangerateField = value;
				base.RaisePropertyChanged("exchangerate");
			}
		}

		[XmlElement] //[XmlElement(Order=5)]
		public CrmMoney firsthalf
		{
			get
			{
				return this.firsthalfField;
			}
			set
			{
				this.firsthalfField = value;
				base.RaisePropertyChanged("firsthalf");
			}
		}

		[XmlElement] //[XmlElement(Order=6)]
		public CrmMoney firsthalf_base
		{
			get
			{
				return this.firsthalf_baseField;
			}
			set
			{
				this.firsthalf_baseField = value;
				base.RaisePropertyChanged("firsthalf_base");
			}
		}

		[XmlElement] //[XmlElement(Order=7)]
		public CrmNumber fiscalperiodtype
		{
			get
			{
				return this.fiscalperiodtypeField;
			}
			set
			{
				this.fiscalperiodtypeField = value;
				base.RaisePropertyChanged("fiscalperiodtype");
			}
		}

		[XmlElement] //[XmlElement(Order=8)]
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

		[XmlElement] //[XmlElement(Order=9)]
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

		[XmlElement] //[XmlElement(Order=10)]
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

		[XmlElement] //[XmlElement(Order=11)]
		public Lookup salespersonid
		{
			get
			{
				return this.salespersonidField;
			}
			set
			{
				this.salespersonidField = value;
				base.RaisePropertyChanged("salespersonid");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public CrmMoney secondhalf
		{
			get
			{
				return this.secondhalfField;
			}
			set
			{
				this.secondhalfField = value;
				base.RaisePropertyChanged("secondhalf");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public CrmMoney secondhalf_base
		{
			get
			{
				return this.secondhalf_baseField;
			}
			set
			{
				this.secondhalf_baseField = value;
				base.RaisePropertyChanged("secondhalf_base");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
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

		[XmlElement] //[XmlElement(Order=15)]
		public Lookup transactioncurrencyid
		{
			get
			{
				return this.transactioncurrencyidField;
			}
			set
			{
				this.transactioncurrencyidField = value;
				base.RaisePropertyChanged("transactioncurrencyid");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public Key userfiscalcalendarid
		{
			get
			{
				return this.userfiscalcalendaridField;
			}
			set
			{
				this.userfiscalcalendaridField = value;
				base.RaisePropertyChanged("userfiscalcalendarid");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
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

		public semiannualfiscalcalendar()
		{
		}
	}
}