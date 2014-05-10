using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_alg_ideal_betaling : BusinessEntity
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
		private string sgt_alg_betalingField;
		private Key sgt_alg_ideal_betalingidField;
		private CrmMoney sgt_bedragField;
		private CrmMoney sgt_bedrag_baseField;
		private string sgt_bondsnummerField;
		private CrmDateTime sgt_datum_en_tijd_betalingField;
		private CrmDateTime sgt_datum_en_tijd_verwerkingField;
		private Lookup sgt_examenidField;
		private Lookup sgt_formulieridField;
		private CrmDateTime sgt_ingangsdatumField;
		private Lookup sgt_ingedeeldegroepidField;
		private Lookup sgt_licentieidField;
		private string sgt_naamidealField;
		private Lookup sgt_opleidingField;
		private string sgt_ordernummerField;
		private string sgt_referentieidealField;
		private string sgt_rekeningnummeridealField;
		private Picklist sgt_statusField;
		private string sgt_statusidealField;
		private Lookup sgt_volledigenaamidField;
		private Lookup sgt_voorkeur1idField;
		private Lookup sgt_voorkeur2idField;
		private Lookup sgt_voorkeur3idField;
		private Lookup sgt_voorkeur4idField;
		private Lookup sgt_voorkeur5idField;
		private Sgt_alg_IDEAL_betalingStateInfo statecodeField;
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
		public string sgt_alg_betaling
		{
			get
			{
				return this.sgt_alg_betalingField;
			}
			set
			{
				this.sgt_alg_betalingField = value;
			}
		}
		public Key sgt_alg_ideal_betalingid
		{
			get
			{
				return this.sgt_alg_ideal_betalingidField;
			}
			set
			{
				this.sgt_alg_ideal_betalingidField = value;
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
		public string sgt_bondsnummer
		{
			get
			{
				return this.sgt_bondsnummerField;
			}
			set
			{
				this.sgt_bondsnummerField = value;
			}
		}
		public CrmDateTime sgt_datum_en_tijd_betaling
		{
			get
			{
				return this.sgt_datum_en_tijd_betalingField;
			}
			set
			{
				this.sgt_datum_en_tijd_betalingField = value;
			}
		}
		public CrmDateTime sgt_datum_en_tijd_verwerking
		{
			get
			{
				return this.sgt_datum_en_tijd_verwerkingField;
			}
			set
			{
				this.sgt_datum_en_tijd_verwerkingField = value;
			}
		}
		public Lookup sgt_examenid
		{
			get
			{
				return this.sgt_examenidField;
			}
			set
			{
				this.sgt_examenidField = value;
			}
		}
		public Lookup sgt_formulierid
		{
			get
			{
				return this.sgt_formulieridField;
			}
			set
			{
				this.sgt_formulieridField = value;
			}
		}
		public CrmDateTime sgt_ingangsdatum
		{
			get
			{
				return this.sgt_ingangsdatumField;
			}
			set
			{
				this.sgt_ingangsdatumField = value;
			}
		}
		public Lookup sgt_ingedeeldegroepid
		{
			get
			{
				return this.sgt_ingedeeldegroepidField;
			}
			set
			{
				this.sgt_ingedeeldegroepidField = value;
			}
		}
		public Lookup sgt_licentieid
		{
			get
			{
				return this.sgt_licentieidField;
			}
			set
			{
				this.sgt_licentieidField = value;
			}
		}
		public string sgt_naamideal
		{
			get
			{
				return this.sgt_naamidealField;
			}
			set
			{
				this.sgt_naamidealField = value;
			}
		}
		public Lookup sgt_opleiding
		{
			get
			{
				return this.sgt_opleidingField;
			}
			set
			{
				this.sgt_opleidingField = value;
			}
		}
		public string sgt_ordernummer
		{
			get
			{
				return this.sgt_ordernummerField;
			}
			set
			{
				this.sgt_ordernummerField = value;
			}
		}
		public string sgt_referentieideal
		{
			get
			{
				return this.sgt_referentieidealField;
			}
			set
			{
				this.sgt_referentieidealField = value;
			}
		}
		public string sgt_rekeningnummerideal
		{
			get
			{
				return this.sgt_rekeningnummeridealField;
			}
			set
			{
				this.sgt_rekeningnummeridealField = value;
			}
		}
		public Picklist sgt_status
		{
			get
			{
				return this.sgt_statusField;
			}
			set
			{
				this.sgt_statusField = value;
			}
		}
		public string sgt_statusideal
		{
			get
			{
				return this.sgt_statusidealField;
			}
			set
			{
				this.sgt_statusidealField = value;
			}
		}
		public Lookup sgt_volledigenaamid
		{
			get
			{
				return this.sgt_volledigenaamidField;
			}
			set
			{
				this.sgt_volledigenaamidField = value;
			}
		}
		public Lookup sgt_voorkeur1id
		{
			get
			{
				return this.sgt_voorkeur1idField;
			}
			set
			{
				this.sgt_voorkeur1idField = value;
			}
		}
		public Lookup sgt_voorkeur2id
		{
			get
			{
				return this.sgt_voorkeur2idField;
			}
			set
			{
				this.sgt_voorkeur2idField = value;
			}
		}
		public Lookup sgt_voorkeur3id
		{
			get
			{
				return this.sgt_voorkeur3idField;
			}
			set
			{
				this.sgt_voorkeur3idField = value;
			}
		}
		public Lookup sgt_voorkeur4id
		{
			get
			{
				return this.sgt_voorkeur4idField;
			}
			set
			{
				this.sgt_voorkeur4idField = value;
			}
		}
		public Lookup sgt_voorkeur5id
		{
			get
			{
				return this.sgt_voorkeur5idField;
			}
			set
			{
				this.sgt_voorkeur5idField = value;
			}
		}
		public Sgt_alg_IDEAL_betalingStateInfo statecode
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
