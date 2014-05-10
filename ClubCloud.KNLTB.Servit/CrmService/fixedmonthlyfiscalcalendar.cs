using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
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
		public Lookup businessunitid
		{
			get
			{
				return this.businessunitidField;
			}
			set
			{
				this.businessunitidField = value;
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
		public CrmDateTime effectiveon
		{
			get
			{
				return this.effectiveonField;
			}
			set
			{
				this.effectiveonField = value;
			}
		}
		public CrmDecimal exchangerate
		{
			get
			{
				return this.exchangerateField;
			}
			set
			{
				this.exchangerateField = value;
			}
		}
		public CrmNumber fiscalperiodtype
		{
			get
			{
				return this.fiscalperiodtypeField;
			}
			set
			{
				this.fiscalperiodtypeField = value;
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
		public CrmMoney period1
		{
			get
			{
				return this.period1Field;
			}
			set
			{
				this.period1Field = value;
			}
		}
		public CrmMoney period1_base
		{
			get
			{
				return this.period1_baseField;
			}
			set
			{
				this.period1_baseField = value;
			}
		}
		public CrmMoney period10
		{
			get
			{
				return this.period10Field;
			}
			set
			{
				this.period10Field = value;
			}
		}
		public CrmMoney period10_base
		{
			get
			{
				return this.period10_baseField;
			}
			set
			{
				this.period10_baseField = value;
			}
		}
		public CrmMoney period11
		{
			get
			{
				return this.period11Field;
			}
			set
			{
				this.period11Field = value;
			}
		}
		public CrmMoney period11_base
		{
			get
			{
				return this.period11_baseField;
			}
			set
			{
				this.period11_baseField = value;
			}
		}
		public CrmMoney period12
		{
			get
			{
				return this.period12Field;
			}
			set
			{
				this.period12Field = value;
			}
		}
		public CrmMoney period12_base
		{
			get
			{
				return this.period12_baseField;
			}
			set
			{
				this.period12_baseField = value;
			}
		}
		public CrmMoney period13
		{
			get
			{
				return this.period13Field;
			}
			set
			{
				this.period13Field = value;
			}
		}
		public CrmMoney period13_base
		{
			get
			{
				return this.period13_baseField;
			}
			set
			{
				this.period13_baseField = value;
			}
		}
		public CrmMoney period2
		{
			get
			{
				return this.period2Field;
			}
			set
			{
				this.period2Field = value;
			}
		}
		public CrmMoney period2_base
		{
			get
			{
				return this.period2_baseField;
			}
			set
			{
				this.period2_baseField = value;
			}
		}
		public CrmMoney period3
		{
			get
			{
				return this.period3Field;
			}
			set
			{
				this.period3Field = value;
			}
		}
		public CrmMoney period3_base
		{
			get
			{
				return this.period3_baseField;
			}
			set
			{
				this.period3_baseField = value;
			}
		}
		public CrmMoney period4
		{
			get
			{
				return this.period4Field;
			}
			set
			{
				this.period4Field = value;
			}
		}
		public CrmMoney period4_base
		{
			get
			{
				return this.period4_baseField;
			}
			set
			{
				this.period4_baseField = value;
			}
		}
		public CrmMoney period5
		{
			get
			{
				return this.period5Field;
			}
			set
			{
				this.period5Field = value;
			}
		}
		public CrmMoney period5_base
		{
			get
			{
				return this.period5_baseField;
			}
			set
			{
				this.period5_baseField = value;
			}
		}
		public CrmMoney period6
		{
			get
			{
				return this.period6Field;
			}
			set
			{
				this.period6Field = value;
			}
		}
		public CrmMoney period6_base
		{
			get
			{
				return this.period6_baseField;
			}
			set
			{
				this.period6_baseField = value;
			}
		}
		public CrmMoney period7
		{
			get
			{
				return this.period7Field;
			}
			set
			{
				this.period7Field = value;
			}
		}
		public CrmMoney period7_base
		{
			get
			{
				return this.period7_baseField;
			}
			set
			{
				this.period7_baseField = value;
			}
		}
		public CrmMoney period8
		{
			get
			{
				return this.period8Field;
			}
			set
			{
				this.period8Field = value;
			}
		}
		public CrmMoney period8_base
		{
			get
			{
				return this.period8_baseField;
			}
			set
			{
				this.period8_baseField = value;
			}
		}
		public CrmMoney period9
		{
			get
			{
				return this.period9Field;
			}
			set
			{
				this.period9Field = value;
			}
		}
		public CrmMoney period9_base
		{
			get
			{
				return this.period9_baseField;
			}
			set
			{
				this.period9_baseField = value;
			}
		}
		public Lookup salespersonid
		{
			get
			{
				return this.salespersonidField;
			}
			set
			{
				this.salespersonidField = value;
			}
		}
		public CrmNumber timezoneruleversionnumber
		{
			get
			{
				return this.timezoneruleversionnumberField;
			}
			set
			{
				this.timezoneruleversionnumberField = value;
			}
		}
		public Lookup transactioncurrencyid
		{
			get
			{
				return this.transactioncurrencyidField;
			}
			set
			{
				this.transactioncurrencyidField = value;
			}
		}
		public Key userfiscalcalendarid
		{
			get
			{
				return this.userfiscalcalendaridField;
			}
			set
			{
				this.userfiscalcalendaridField = value;
			}
		}
		public CrmNumber utcconversiontimezonecode
		{
			get
			{
				return this.utcconversiontimezonecodeField;
			}
			set
			{
				this.utcconversiontimezonecodeField = value;
			}
		}
	}
}
