using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class annualfiscalcalendar : BusinessEntity
	{
		private CrmMoney annualField;
		private CrmMoney annual_baseField;
		private Lookup businessunitidField;
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmDateTime effectiveonField;
		private CrmDecimal exchangerateField;
		private CrmNumber fiscalperiodtypeField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup salespersonidField;
		private CrmNumber timezoneruleversionnumberField;
		private Lookup transactioncurrencyidField;
		private Key userfiscalcalendaridField;
		private CrmNumber utcconversiontimezonecodeField;
		public CrmMoney annual
		{
			get
			{
				return this.annualField;
			}
			set
			{
				this.annualField = value;
			}
		}
		public CrmMoney annual_base
		{
			get
			{
				return this.annual_baseField;
			}
			set
			{
				this.annual_baseField = value;
			}
		}
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
