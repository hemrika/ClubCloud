using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class quarterlyfiscalcalendar : BusinessEntity
	{
		private Lookup businessunitidField;
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmDateTime effectiveonField;
		private CrmDecimal exchangerateField;
		private CrmNumber fiscalperiodtypeField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmMoney quarter1Field;
		private CrmMoney quarter1_baseField;
		private CrmMoney quarter2Field;
		private CrmMoney quarter2_baseField;
		private CrmMoney quarter3Field;
		private CrmMoney quarter3_baseField;
		private CrmMoney quarter4Field;
		private CrmMoney quarter4_baseField;
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
		public CrmMoney quarter1
		{
			get
			{
				return this.quarter1Field;
			}
			set
			{
				this.quarter1Field = value;
			}
		}
		public CrmMoney quarter1_base
		{
			get
			{
				return this.quarter1_baseField;
			}
			set
			{
				this.quarter1_baseField = value;
			}
		}
		public CrmMoney quarter2
		{
			get
			{
				return this.quarter2Field;
			}
			set
			{
				this.quarter2Field = value;
			}
		}
		public CrmMoney quarter2_base
		{
			get
			{
				return this.quarter2_baseField;
			}
			set
			{
				this.quarter2_baseField = value;
			}
		}
		public CrmMoney quarter3
		{
			get
			{
				return this.quarter3Field;
			}
			set
			{
				this.quarter3Field = value;
			}
		}
		public CrmMoney quarter3_base
		{
			get
			{
				return this.quarter3_baseField;
			}
			set
			{
				this.quarter3_baseField = value;
			}
		}
		public CrmMoney quarter4
		{
			get
			{
				return this.quarter4Field;
			}
			set
			{
				this.quarter4Field = value;
			}
		}
		public CrmMoney quarter4_base
		{
			get
			{
				return this.quarter4_baseField;
			}
			set
			{
				this.quarter4_baseField = value;
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
