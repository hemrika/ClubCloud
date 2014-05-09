using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_toe_prijzengeld : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmDecimal exchangerateField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup organizationidField;
		private CrmDateTime overriddencreatedonField;
		private string sgt_beschrijvingField;
		private Picklist sgt_geslachtField;
		private CrmMoney sgt_max_prijzengeldField;
		private CrmMoney sgt_max_prijzengeld_baseField;
		private CrmMoney sgt_min_prijzengeldField;
		private CrmMoney sgt_min_prijzengeld_baseField;
		private string sgt_omschrijvingField;
		private Picklist sgt_spelsoortField;
		private string sgt_toe_prijzengeld1Field;
		private Key sgt_toe_prijzengeldidField;
		private Lookup sgt_toernooisoortidField;
		private string sgt_verkorte_codeField;
		private Lookup sgt_zwaarteidField;
		private Sgt_toe_prijzengeldStateInfo statecodeField;
		private Status statuscodeField;
		private CrmNumber timezoneruleversionnumberField;
		private Lookup transactioncurrencyidField;
		private CrmNumber utcconversiontimezonecodeField;
		[XmlElement(Order = 0)]
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
		[XmlElement(Order = 1)]
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
		[XmlElement(Order = 2)]
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
		[XmlElement(Order = 3)]
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
		[XmlElement(Order = 4)]
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
		[XmlElement(Order = 5)]
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
		[XmlElement(Order = 6)]
		public Lookup organizationid
		{
			get
			{
				return this.organizationidField;
			}
			set
			{
				this.organizationidField = value;
				base.RaisePropertyChanged("organizationid");
			}
		}
		[XmlElement(Order = 7)]
		public CrmDateTime overriddencreatedon
		{
			get
			{
				return this.overriddencreatedonField;
			}
			set
			{
				this.overriddencreatedonField = value;
				base.RaisePropertyChanged("overriddencreatedon");
			}
		}
		[XmlElement(Order = 8)]
		public string sgt_beschrijving
		{
			get
			{
				return this.sgt_beschrijvingField;
			}
			set
			{
				this.sgt_beschrijvingField = value;
				base.RaisePropertyChanged("sgt_beschrijving");
			}
		}
		[XmlElement(Order = 9)]
		public Picklist sgt_geslacht
		{
			get
			{
				return this.sgt_geslachtField;
			}
			set
			{
				this.sgt_geslachtField = value;
				base.RaisePropertyChanged("sgt_geslacht");
			}
		}
		[XmlElement(Order = 10)]
		public CrmMoney sgt_max_prijzengeld
		{
			get
			{
				return this.sgt_max_prijzengeldField;
			}
			set
			{
				this.sgt_max_prijzengeldField = value;
				base.RaisePropertyChanged("sgt_max_prijzengeld");
			}
		}
		[XmlElement(Order = 11)]
		public CrmMoney sgt_max_prijzengeld_base
		{
			get
			{
				return this.sgt_max_prijzengeld_baseField;
			}
			set
			{
				this.sgt_max_prijzengeld_baseField = value;
				base.RaisePropertyChanged("sgt_max_prijzengeld_base");
			}
		}
		[XmlElement(Order = 12)]
		public CrmMoney sgt_min_prijzengeld
		{
			get
			{
				return this.sgt_min_prijzengeldField;
			}
			set
			{
				this.sgt_min_prijzengeldField = value;
				base.RaisePropertyChanged("sgt_min_prijzengeld");
			}
		}
		[XmlElement(Order = 13)]
		public CrmMoney sgt_min_prijzengeld_base
		{
			get
			{
				return this.sgt_min_prijzengeld_baseField;
			}
			set
			{
				this.sgt_min_prijzengeld_baseField = value;
				base.RaisePropertyChanged("sgt_min_prijzengeld_base");
			}
		}
		[XmlElement(Order = 14)]
		public string sgt_omschrijving
		{
			get
			{
				return this.sgt_omschrijvingField;
			}
			set
			{
				this.sgt_omschrijvingField = value;
				base.RaisePropertyChanged("sgt_omschrijving");
			}
		}
		[XmlElement(Order = 15)]
		public Picklist sgt_spelsoort
		{
			get
			{
				return this.sgt_spelsoortField;
			}
			set
			{
				this.sgt_spelsoortField = value;
				base.RaisePropertyChanged("sgt_spelsoort");
			}
		}
		[XmlElement("sgt_toe_prijzengeld", Order = 16)]
		public string sgt_toe_prijzengeld1
		{
			get
			{
				return this.sgt_toe_prijzengeld1Field;
			}
			set
			{
				this.sgt_toe_prijzengeld1Field = value;
				base.RaisePropertyChanged("sgt_toe_prijzengeld1");
			}
		}
		[XmlElement(Order = 17)]
		public Key sgt_toe_prijzengeldid
		{
			get
			{
				return this.sgt_toe_prijzengeldidField;
			}
			set
			{
				this.sgt_toe_prijzengeldidField = value;
				base.RaisePropertyChanged("sgt_toe_prijzengeldid");
			}
		}
		[XmlElement(Order = 18)]
		public Lookup sgt_toernooisoortid
		{
			get
			{
				return this.sgt_toernooisoortidField;
			}
			set
			{
				this.sgt_toernooisoortidField = value;
				base.RaisePropertyChanged("sgt_toernooisoortid");
			}
		}
		[XmlElement(Order = 19)]
		public string sgt_verkorte_code
		{
			get
			{
				return this.sgt_verkorte_codeField;
			}
			set
			{
				this.sgt_verkorte_codeField = value;
				base.RaisePropertyChanged("sgt_verkorte_code");
			}
		}
		[XmlElement(Order = 20)]
		public Lookup sgt_zwaarteid
		{
			get
			{
				return this.sgt_zwaarteidField;
			}
			set
			{
				this.sgt_zwaarteidField = value;
				base.RaisePropertyChanged("sgt_zwaarteid");
			}
		}
		[XmlElement(Order = 21)]
		public Sgt_toe_prijzengeldStateInfo statecode
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
		[XmlElement(Order = 22)]
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
		[XmlElement(Order = 23)]
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
		[XmlElement(Order = 24)]
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
		[XmlElement(Order = 25)]
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
