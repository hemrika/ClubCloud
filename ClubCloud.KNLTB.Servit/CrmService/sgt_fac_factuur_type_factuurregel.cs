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
	public class sgt_fac_factuur_type_factuurregel : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmDecimal exchangerateField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private CrmDecimal sgt_aantal_negatiefField;

		private CrmMoney sgt_bedragField;

		private CrmMoney sgt_bedrag_baseField;

		private CrmMoney sgt_belastingenField;

		private CrmMoney sgt_belastingen_baseField;

		private Lookup sgt_btwcodeidField;

		private Key sgt_fac_factuur_type_factuurregelidField;

		private string sgt_fac_nameField;

		private Lookup sgt_factuur_typeidField;

		private Lookup sgt_grootboekcodeidField;

		private CrmMoney sgt_kortingField;

		private CrmMoney sgt_korting_baseField;

		private CrmMoney sgt_prijs_per_eenheidField;

		private CrmMoney sgt_prijs_per_eenheid_baseField;

		private Picklist sgt_productcodeField;

		private Lookup sgt_productidField;

		private string sgt_toe_te_voegen_productField;

		private Sgt_fac_factuur_type_factuurregelStateInfo statecodeField;

		private Status statuscodeField;

		private CrmNumber timezoneruleversionnumberField;

		private Lookup transactioncurrencyidField;

		private CrmNumber utcconversiontimezonecodeField;

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

		[XmlElement] //[XmlElement(Order=3)]
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

		[XmlElement] //[XmlElement(Order=4)]
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

		[XmlElement] //[XmlElement(Order=5)]
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

		[XmlElement] //[XmlElement(Order=6)]
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

		[XmlElement] //[XmlElement(Order=7)]
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

		[XmlElement] //[XmlElement(Order=8)]
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

		[XmlElement] //[XmlElement(Order=9)]
		public CrmDecimal sgt_aantal_negatief
		{
			get
			{
				return this.sgt_aantal_negatiefField;
			}
			set
			{
				this.sgt_aantal_negatiefField = value;
				base.RaisePropertyChanged("sgt_aantal_negatief");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public CrmMoney sgt_bedrag
		{
			get
			{
				return this.sgt_bedragField;
			}
			set
			{
				this.sgt_bedragField = value;
				base.RaisePropertyChanged("sgt_bedrag");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public CrmMoney sgt_bedrag_base
		{
			get
			{
				return this.sgt_bedrag_baseField;
			}
			set
			{
				this.sgt_bedrag_baseField = value;
				base.RaisePropertyChanged("sgt_bedrag_base");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public CrmMoney sgt_belastingen
		{
			get
			{
				return this.sgt_belastingenField;
			}
			set
			{
				this.sgt_belastingenField = value;
				base.RaisePropertyChanged("sgt_belastingen");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public CrmMoney sgt_belastingen_base
		{
			get
			{
				return this.sgt_belastingen_baseField;
			}
			set
			{
				this.sgt_belastingen_baseField = value;
				base.RaisePropertyChanged("sgt_belastingen_base");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public Lookup sgt_btwcodeid
		{
			get
			{
				return this.sgt_btwcodeidField;
			}
			set
			{
				this.sgt_btwcodeidField = value;
				base.RaisePropertyChanged("sgt_btwcodeid");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public Key sgt_fac_factuur_type_factuurregelid
		{
			get
			{
				return this.sgt_fac_factuur_type_factuurregelidField;
			}
			set
			{
				this.sgt_fac_factuur_type_factuurregelidField = value;
				base.RaisePropertyChanged("sgt_fac_factuur_type_factuurregelid");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public string sgt_fac_name
		{
			get
			{
				return this.sgt_fac_nameField;
			}
			set
			{
				this.sgt_fac_nameField = value;
				base.RaisePropertyChanged("sgt_fac_name");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public Lookup sgt_factuur_typeid
		{
			get
			{
				return this.sgt_factuur_typeidField;
			}
			set
			{
				this.sgt_factuur_typeidField = value;
				base.RaisePropertyChanged("sgt_factuur_typeid");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public Lookup sgt_grootboekcodeid
		{
			get
			{
				return this.sgt_grootboekcodeidField;
			}
			set
			{
				this.sgt_grootboekcodeidField = value;
				base.RaisePropertyChanged("sgt_grootboekcodeid");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
		public CrmMoney sgt_korting
		{
			get
			{
				return this.sgt_kortingField;
			}
			set
			{
				this.sgt_kortingField = value;
				base.RaisePropertyChanged("sgt_korting");
			}
		}

		[XmlElement] //[XmlElement(Order=20)]
		public CrmMoney sgt_korting_base
		{
			get
			{
				return this.sgt_korting_baseField;
			}
			set
			{
				this.sgt_korting_baseField = value;
				base.RaisePropertyChanged("sgt_korting_base");
			}
		}

		[XmlElement] //[XmlElement(Order=21)]
		public CrmMoney sgt_prijs_per_eenheid
		{
			get
			{
				return this.sgt_prijs_per_eenheidField;
			}
			set
			{
				this.sgt_prijs_per_eenheidField = value;
				base.RaisePropertyChanged("sgt_prijs_per_eenheid");
			}
		}

		[XmlElement] //[XmlElement(Order=22)]
		public CrmMoney sgt_prijs_per_eenheid_base
		{
			get
			{
				return this.sgt_prijs_per_eenheid_baseField;
			}
			set
			{
				this.sgt_prijs_per_eenheid_baseField = value;
				base.RaisePropertyChanged("sgt_prijs_per_eenheid_base");
			}
		}

		[XmlElement] //[XmlElement(Order=23)]
		public Picklist sgt_productcode
		{
			get
			{
				return this.sgt_productcodeField;
			}
			set
			{
				this.sgt_productcodeField = value;
				base.RaisePropertyChanged("sgt_productcode");
			}
		}

		[XmlElement] //[XmlElement(Order=24)]
		public Lookup sgt_productid
		{
			get
			{
				return this.sgt_productidField;
			}
			set
			{
				this.sgt_productidField = value;
				base.RaisePropertyChanged("sgt_productid");
			}
		}

		[XmlElement] //[XmlElement(Order=25)]
		public string sgt_toe_te_voegen_product
		{
			get
			{
				return this.sgt_toe_te_voegen_productField;
			}
			set
			{
				this.sgt_toe_te_voegen_productField = value;
				base.RaisePropertyChanged("sgt_toe_te_voegen_product");
			}
		}

		[XmlElement] //[XmlElement(Order=26)]
		public Sgt_fac_factuur_type_factuurregelStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=27)]
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

		[XmlElement] //[XmlElement(Order=28)]
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

		[XmlElement] //[XmlElement(Order=29)]
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

		[XmlElement] //[XmlElement(Order=30)]
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

		public sgt_fac_factuur_type_factuurregel()
		{
		}
	}
}