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
	public class fixedmonthlyfiscalcalendar : BusinessEntity
	{
		private Lookup businessunitidField;

		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmDateTime effectiveonField;

		private CrmDecimal exchangerateField;

		private CrmNumber fiscalperiodtypeField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmMoney period1Field;

		private CrmMoney period1_baseField;

		private CrmMoney period10Field;

		private CrmMoney period10_baseField;

		private CrmMoney period11Field;

		private CrmMoney period11_baseField;

		private CrmMoney period12Field;

		private CrmMoney period12_baseField;

		private CrmMoney period13Field;

		private CrmMoney period13_baseField;

		private CrmMoney period2Field;

		private CrmMoney period2_baseField;

		private CrmMoney period3Field;

		private CrmMoney period3_baseField;

		private CrmMoney period4Field;

		private CrmMoney period4_baseField;

		private CrmMoney period5Field;

		private CrmMoney period5_baseField;

		private CrmMoney period6Field;

		private CrmMoney period6_baseField;

		private CrmMoney period7Field;

		private CrmMoney period7_baseField;

		private CrmMoney period8Field;

		private CrmMoney period8_baseField;

		private CrmMoney period9Field;

		private CrmMoney period9_baseField;

		private Lookup salespersonidField;

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

		[XmlElement] //[XmlElement(Order=6)]
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

		[XmlElement] //[XmlElement(Order=7)]
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

		[XmlElement] //[XmlElement(Order=8)]
		public CrmMoney period1
		{
			get
			{
				return this.period1Field;
			}
			set
			{
				this.period1Field = value;
				base.RaisePropertyChanged("period1");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public CrmMoney period1_base
		{
			get
			{
				return this.period1_baseField;
			}
			set
			{
				this.period1_baseField = value;
				base.RaisePropertyChanged("period1_base");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public CrmMoney period10
		{
			get
			{
				return this.period10Field;
			}
			set
			{
				this.period10Field = value;
				base.RaisePropertyChanged("period10");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public CrmMoney period10_base
		{
			get
			{
				return this.period10_baseField;
			}
			set
			{
				this.period10_baseField = value;
				base.RaisePropertyChanged("period10_base");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public CrmMoney period11
		{
			get
			{
				return this.period11Field;
			}
			set
			{
				this.period11Field = value;
				base.RaisePropertyChanged("period11");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public CrmMoney period11_base
		{
			get
			{
				return this.period11_baseField;
			}
			set
			{
				this.period11_baseField = value;
				base.RaisePropertyChanged("period11_base");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public CrmMoney period12
		{
			get
			{
				return this.period12Field;
			}
			set
			{
				this.period12Field = value;
				base.RaisePropertyChanged("period12");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public CrmMoney period12_base
		{
			get
			{
				return this.period12_baseField;
			}
			set
			{
				this.period12_baseField = value;
				base.RaisePropertyChanged("period12_base");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public CrmMoney period13
		{
			get
			{
				return this.period13Field;
			}
			set
			{
				this.period13Field = value;
				base.RaisePropertyChanged("period13");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public CrmMoney period13_base
		{
			get
			{
				return this.period13_baseField;
			}
			set
			{
				this.period13_baseField = value;
				base.RaisePropertyChanged("period13_base");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public CrmMoney period2
		{
			get
			{
				return this.period2Field;
			}
			set
			{
				this.period2Field = value;
				base.RaisePropertyChanged("period2");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
		public CrmMoney period2_base
		{
			get
			{
				return this.period2_baseField;
			}
			set
			{
				this.period2_baseField = value;
				base.RaisePropertyChanged("period2_base");
			}
		}

		[XmlElement] //[XmlElement(Order=20)]
		public CrmMoney period3
		{
			get
			{
				return this.period3Field;
			}
			set
			{
				this.period3Field = value;
				base.RaisePropertyChanged("period3");
			}
		}

		[XmlElement] //[XmlElement(Order=21)]
		public CrmMoney period3_base
		{
			get
			{
				return this.period3_baseField;
			}
			set
			{
				this.period3_baseField = value;
				base.RaisePropertyChanged("period3_base");
			}
		}

		[XmlElement] //[XmlElement(Order=22)]
		public CrmMoney period4
		{
			get
			{
				return this.period4Field;
			}
			set
			{
				this.period4Field = value;
				base.RaisePropertyChanged("period4");
			}
		}

		[XmlElement] //[XmlElement(Order=23)]
		public CrmMoney period4_base
		{
			get
			{
				return this.period4_baseField;
			}
			set
			{
				this.period4_baseField = value;
				base.RaisePropertyChanged("period4_base");
			}
		}

		[XmlElement] //[XmlElement(Order=24)]
		public CrmMoney period5
		{
			get
			{
				return this.period5Field;
			}
			set
			{
				this.period5Field = value;
				base.RaisePropertyChanged("period5");
			}
		}

		[XmlElement] //[XmlElement(Order=25)]
		public CrmMoney period5_base
		{
			get
			{
				return this.period5_baseField;
			}
			set
			{
				this.period5_baseField = value;
				base.RaisePropertyChanged("period5_base");
			}
		}

		[XmlElement] //[XmlElement(Order=26)]
		public CrmMoney period6
		{
			get
			{
				return this.period6Field;
			}
			set
			{
				this.period6Field = value;
				base.RaisePropertyChanged("period6");
			}
		}

		[XmlElement] //[XmlElement(Order=27)]
		public CrmMoney period6_base
		{
			get
			{
				return this.period6_baseField;
			}
			set
			{
				this.period6_baseField = value;
				base.RaisePropertyChanged("period6_base");
			}
		}

		[XmlElement] //[XmlElement(Order=28)]
		public CrmMoney period7
		{
			get
			{
				return this.period7Field;
			}
			set
			{
				this.period7Field = value;
				base.RaisePropertyChanged("period7");
			}
		}

		[XmlElement] //[XmlElement(Order=29)]
		public CrmMoney period7_base
		{
			get
			{
				return this.period7_baseField;
			}
			set
			{
				this.period7_baseField = value;
				base.RaisePropertyChanged("period7_base");
			}
		}

		[XmlElement] //[XmlElement(Order=30)]
		public CrmMoney period8
		{
			get
			{
				return this.period8Field;
			}
			set
			{
				this.period8Field = value;
				base.RaisePropertyChanged("period8");
			}
		}

		[XmlElement] //[XmlElement(Order=31)]
		public CrmMoney period8_base
		{
			get
			{
				return this.period8_baseField;
			}
			set
			{
				this.period8_baseField = value;
				base.RaisePropertyChanged("period8_base");
			}
		}

		[XmlElement] //[XmlElement(Order=32)]
		public CrmMoney period9
		{
			get
			{
				return this.period9Field;
			}
			set
			{
				this.period9Field = value;
				base.RaisePropertyChanged("period9");
			}
		}

		[XmlElement] //[XmlElement(Order=33)]
		public CrmMoney period9_base
		{
			get
			{
				return this.period9_baseField;
			}
			set
			{
				this.period9_baseField = value;
				base.RaisePropertyChanged("period9_base");
			}
		}

		[XmlElement] //[XmlElement(Order=34)]
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

		[XmlElement] //[XmlElement(Order=35)]
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

		[XmlElement] //[XmlElement(Order=36)]
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

		[XmlElement] //[XmlElement(Order=37)]
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

		[XmlElement] //[XmlElement(Order=38)]
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

		public fixedmonthlyfiscalcalendar()
		{
		}
	}
}