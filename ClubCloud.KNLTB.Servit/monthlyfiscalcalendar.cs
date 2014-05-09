using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class monthlyfiscalcalendar : BusinessEntity
	{
		private Lookup businessunitidField;
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmDateTime effectiveonField;
		private CrmDecimal exchangerateField;
		private CrmNumber fiscalperiodtypeField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmMoney month1Field;
		private CrmMoney month1_baseField;
		private CrmMoney month10Field;
		private CrmMoney month10_baseField;
		private CrmMoney month11Field;
		private CrmMoney month11_baseField;
		private CrmMoney month12Field;
		private CrmMoney month12_baseField;
		private CrmMoney month2Field;
		private CrmMoney month2_baseField;
		private CrmMoney month3Field;
		private CrmMoney month3_baseField;
		private CrmMoney month4Field;
		private CrmMoney month4_baseField;
		private CrmMoney month5Field;
		private CrmMoney month5_baseField;
		private CrmMoney month6Field;
		private CrmMoney month6_baseField;
		private CrmMoney month7Field;
		private CrmMoney month7_baseField;
		private CrmMoney month8Field;
		private CrmMoney month8_baseField;
		private CrmMoney month9Field;
		private CrmMoney month9_baseField;
		private Lookup salespersonidField;
		private CrmNumber timezoneruleversionnumberField;
		private Lookup transactioncurrencyidField;
		private Key userfiscalcalendaridField;
		private CrmNumber utcconversiontimezonecodeField;
		[XmlElement(Order = 0)]
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
		[XmlElement(Order = 1)]
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
		[XmlElement(Order = 2)]
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
		[XmlElement(Order = 3)]
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
		[XmlElement(Order = 4)]
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
		[XmlElement(Order = 5)]
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
		[XmlElement(Order = 6)]
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
		[XmlElement(Order = 7)]
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
		[XmlElement(Order = 8)]
		public CrmMoney month1
		{
			get
			{
				return this.month1Field;
			}
			set
			{
				this.month1Field = value;
				base.RaisePropertyChanged("month1");
			}
		}
		[XmlElement(Order = 9)]
		public CrmMoney month1_base
		{
			get
			{
				return this.month1_baseField;
			}
			set
			{
				this.month1_baseField = value;
				base.RaisePropertyChanged("month1_base");
			}
		}
		[XmlElement(Order = 10)]
		public CrmMoney month10
		{
			get
			{
				return this.month10Field;
			}
			set
			{
				this.month10Field = value;
				base.RaisePropertyChanged("month10");
			}
		}
		[XmlElement(Order = 11)]
		public CrmMoney month10_base
		{
			get
			{
				return this.month10_baseField;
			}
			set
			{
				this.month10_baseField = value;
				base.RaisePropertyChanged("month10_base");
			}
		}
		[XmlElement(Order = 12)]
		public CrmMoney month11
		{
			get
			{
				return this.month11Field;
			}
			set
			{
				this.month11Field = value;
				base.RaisePropertyChanged("month11");
			}
		}
		[XmlElement(Order = 13)]
		public CrmMoney month11_base
		{
			get
			{
				return this.month11_baseField;
			}
			set
			{
				this.month11_baseField = value;
				base.RaisePropertyChanged("month11_base");
			}
		}
		[XmlElement(Order = 14)]
		public CrmMoney month12
		{
			get
			{
				return this.month12Field;
			}
			set
			{
				this.month12Field = value;
				base.RaisePropertyChanged("month12");
			}
		}
		[XmlElement(Order = 15)]
		public CrmMoney month12_base
		{
			get
			{
				return this.month12_baseField;
			}
			set
			{
				this.month12_baseField = value;
				base.RaisePropertyChanged("month12_base");
			}
		}
		[XmlElement(Order = 16)]
		public CrmMoney month2
		{
			get
			{
				return this.month2Field;
			}
			set
			{
				this.month2Field = value;
				base.RaisePropertyChanged("month2");
			}
		}
		[XmlElement(Order = 17)]
		public CrmMoney month2_base
		{
			get
			{
				return this.month2_baseField;
			}
			set
			{
				this.month2_baseField = value;
				base.RaisePropertyChanged("month2_base");
			}
		}
		[XmlElement(Order = 18)]
		public CrmMoney month3
		{
			get
			{
				return this.month3Field;
			}
			set
			{
				this.month3Field = value;
				base.RaisePropertyChanged("month3");
			}
		}
		[XmlElement(Order = 19)]
		public CrmMoney month3_base
		{
			get
			{
				return this.month3_baseField;
			}
			set
			{
				this.month3_baseField = value;
				base.RaisePropertyChanged("month3_base");
			}
		}
		[XmlElement(Order = 20)]
		public CrmMoney month4
		{
			get
			{
				return this.month4Field;
			}
			set
			{
				this.month4Field = value;
				base.RaisePropertyChanged("month4");
			}
		}
		[XmlElement(Order = 21)]
		public CrmMoney month4_base
		{
			get
			{
				return this.month4_baseField;
			}
			set
			{
				this.month4_baseField = value;
				base.RaisePropertyChanged("month4_base");
			}
		}
		[XmlElement(Order = 22)]
		public CrmMoney month5
		{
			get
			{
				return this.month5Field;
			}
			set
			{
				this.month5Field = value;
				base.RaisePropertyChanged("month5");
			}
		}
		[XmlElement(Order = 23)]
		public CrmMoney month5_base
		{
			get
			{
				return this.month5_baseField;
			}
			set
			{
				this.month5_baseField = value;
				base.RaisePropertyChanged("month5_base");
			}
		}
		[XmlElement(Order = 24)]
		public CrmMoney month6
		{
			get
			{
				return this.month6Field;
			}
			set
			{
				this.month6Field = value;
				base.RaisePropertyChanged("month6");
			}
		}
		[XmlElement(Order = 25)]
		public CrmMoney month6_base
		{
			get
			{
				return this.month6_baseField;
			}
			set
			{
				this.month6_baseField = value;
				base.RaisePropertyChanged("month6_base");
			}
		}
		[XmlElement(Order = 26)]
		public CrmMoney month7
		{
			get
			{
				return this.month7Field;
			}
			set
			{
				this.month7Field = value;
				base.RaisePropertyChanged("month7");
			}
		}
		[XmlElement(Order = 27)]
		public CrmMoney month7_base
		{
			get
			{
				return this.month7_baseField;
			}
			set
			{
				this.month7_baseField = value;
				base.RaisePropertyChanged("month7_base");
			}
		}
		[XmlElement(Order = 28)]
		public CrmMoney month8
		{
			get
			{
				return this.month8Field;
			}
			set
			{
				this.month8Field = value;
				base.RaisePropertyChanged("month8");
			}
		}
		[XmlElement(Order = 29)]
		public CrmMoney month8_base
		{
			get
			{
				return this.month8_baseField;
			}
			set
			{
				this.month8_baseField = value;
				base.RaisePropertyChanged("month8_base");
			}
		}
		[XmlElement(Order = 30)]
		public CrmMoney month9
		{
			get
			{
				return this.month9Field;
			}
			set
			{
				this.month9Field = value;
				base.RaisePropertyChanged("month9");
			}
		}
		[XmlElement(Order = 31)]
		public CrmMoney month9_base
		{
			get
			{
				return this.month9_baseField;
			}
			set
			{
				this.month9_baseField = value;
				base.RaisePropertyChanged("month9_base");
			}
		}
		[XmlElement(Order = 32)]
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
		[XmlElement(Order = 33)]
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
		[XmlElement(Order = 34)]
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
		[XmlElement(Order = 35)]
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
		[XmlElement(Order = 36)]
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
	}
}
