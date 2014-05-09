using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
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
		public CrmMoney quarter1
		{
			get
			{
				return this.quarter1Field;
			}
			set
			{
				this.quarter1Field = value;
				base.RaisePropertyChanged("quarter1");
			}
		}
		[XmlElement(Order = 9)]
		public CrmMoney quarter1_base
		{
			get
			{
				return this.quarter1_baseField;
			}
			set
			{
				this.quarter1_baseField = value;
				base.RaisePropertyChanged("quarter1_base");
			}
		}
		[XmlElement(Order = 10)]
		public CrmMoney quarter2
		{
			get
			{
				return this.quarter2Field;
			}
			set
			{
				this.quarter2Field = value;
				base.RaisePropertyChanged("quarter2");
			}
		}
		[XmlElement(Order = 11)]
		public CrmMoney quarter2_base
		{
			get
			{
				return this.quarter2_baseField;
			}
			set
			{
				this.quarter2_baseField = value;
				base.RaisePropertyChanged("quarter2_base");
			}
		}
		[XmlElement(Order = 12)]
		public CrmMoney quarter3
		{
			get
			{
				return this.quarter3Field;
			}
			set
			{
				this.quarter3Field = value;
				base.RaisePropertyChanged("quarter3");
			}
		}
		[XmlElement(Order = 13)]
		public CrmMoney quarter3_base
		{
			get
			{
				return this.quarter3_baseField;
			}
			set
			{
				this.quarter3_baseField = value;
				base.RaisePropertyChanged("quarter3_base");
			}
		}
		[XmlElement(Order = 14)]
		public CrmMoney quarter4
		{
			get
			{
				return this.quarter4Field;
			}
			set
			{
				this.quarter4Field = value;
				base.RaisePropertyChanged("quarter4");
			}
		}
		[XmlElement(Order = 15)]
		public CrmMoney quarter4_base
		{
			get
			{
				return this.quarter4_baseField;
			}
			set
			{
				this.quarter4_baseField = value;
				base.RaisePropertyChanged("quarter4_base");
			}
		}
		[XmlElement(Order = 16)]
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
		[XmlElement(Order = 17)]
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
		[XmlElement(Order = 18)]
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
		[XmlElement(Order = 19)]
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
		[XmlElement(Order = 20)]
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
