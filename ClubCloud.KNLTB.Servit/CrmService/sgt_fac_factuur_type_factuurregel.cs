using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
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
		public CrmNumber importsequencenumber
		{
			get
			{
				return this.importsequencenumberField;
			}
			set
			{
				this.importsequencenumberField = value;
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
		public CrmDateTime overriddencreatedon
		{
			get
			{
				return this.overriddencreatedonField;
			}
			set
			{
				this.overriddencreatedonField = value;
			}
		}
		public Owner ownerid
		{
			get
			{
				return this.owneridField;
			}
			set
			{
				this.owneridField = value;
			}
		}
		public Lookup owningbusinessunit
		{
			get
			{
				return this.owningbusinessunitField;
			}
			set
			{
				this.owningbusinessunitField = value;
			}
		}
		public CrmDecimal sgt_aantal_negatief
		{
			get
			{
				return this.sgt_aantal_negatiefField;
			}
			set
			{
				this.sgt_aantal_negatiefField = value;
			}
		}
		public CrmMoney sgt_bedrag
		{
			get
			{
				return this.sgt_bedragField;
			}
			set
			{
				this.sgt_bedragField = value;
			}
		}
		public CrmMoney sgt_bedrag_base
		{
			get
			{
				return this.sgt_bedrag_baseField;
			}
			set
			{
				this.sgt_bedrag_baseField = value;
			}
		}
		public CrmMoney sgt_belastingen
		{
			get
			{
				return this.sgt_belastingenField;
			}
			set
			{
				this.sgt_belastingenField = value;
			}
		}
		public CrmMoney sgt_belastingen_base
		{
			get
			{
				return this.sgt_belastingen_baseField;
			}
			set
			{
				this.sgt_belastingen_baseField = value;
			}
		}
		public Lookup sgt_btwcodeid
		{
			get
			{
				return this.sgt_btwcodeidField;
			}
			set
			{
				this.sgt_btwcodeidField = value;
			}
		}
		public Key sgt_fac_factuur_type_factuurregelid
		{
			get
			{
				return this.sgt_fac_factuur_type_factuurregelidField;
			}
			set
			{
				this.sgt_fac_factuur_type_factuurregelidField = value;
			}
		}
		public string sgt_fac_name
		{
			get
			{
				return this.sgt_fac_nameField;
			}
			set
			{
				this.sgt_fac_nameField = value;
			}
		}
		public Lookup sgt_factuur_typeid
		{
			get
			{
				return this.sgt_factuur_typeidField;
			}
			set
			{
				this.sgt_factuur_typeidField = value;
			}
		}
		public Lookup sgt_grootboekcodeid
		{
			get
			{
				return this.sgt_grootboekcodeidField;
			}
			set
			{
				this.sgt_grootboekcodeidField = value;
			}
		}
		public CrmMoney sgt_korting
		{
			get
			{
				return this.sgt_kortingField;
			}
			set
			{
				this.sgt_kortingField = value;
			}
		}
		public CrmMoney sgt_korting_base
		{
			get
			{
				return this.sgt_korting_baseField;
			}
			set
			{
				this.sgt_korting_baseField = value;
			}
		}
		public CrmMoney sgt_prijs_per_eenheid
		{
			get
			{
				return this.sgt_prijs_per_eenheidField;
			}
			set
			{
				this.sgt_prijs_per_eenheidField = value;
			}
		}
		public CrmMoney sgt_prijs_per_eenheid_base
		{
			get
			{
				return this.sgt_prijs_per_eenheid_baseField;
			}
			set
			{
				this.sgt_prijs_per_eenheid_baseField = value;
			}
		}
		public Picklist sgt_productcode
		{
			get
			{
				return this.sgt_productcodeField;
			}
			set
			{
				this.sgt_productcodeField = value;
			}
		}
		public Lookup sgt_productid
		{
			get
			{
				return this.sgt_productidField;
			}
			set
			{
				this.sgt_productidField = value;
			}
		}
		public string sgt_toe_te_voegen_product
		{
			get
			{
				return this.sgt_toe_te_voegen_productField;
			}
			set
			{
				this.sgt_toe_te_voegen_productField = value;
			}
		}
		public Sgt_fac_factuur_type_factuurregelStateInfo statecode
		{
			get
			{
				return this.statecodeField;
			}
			set
			{
				this.statecodeField = value;
			}
		}
		public Status statuscode
		{
			get
			{
				return this.statuscodeField;
			}
			set
			{
				this.statuscodeField = value;
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
