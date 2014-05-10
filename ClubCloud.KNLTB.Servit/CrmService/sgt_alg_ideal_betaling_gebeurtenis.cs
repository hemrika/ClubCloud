using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_alg_ideal_betaling_gebeurtenis : BusinessEntity
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
		private Key sgt_alg_ideal_betaling_gebeurtenisidField;
		private CrmMoney sgt_bedragField;
		private CrmMoney sgt_bedrag_baseField;
		private string sgt_bondsnummerField;
		private CrmDateTime sgt_datum_en_tijd_betalingField;
		private CrmDateTime sgt_datum_en_tijd_verwerkingField;
		private Lookup sgt_gebeurtenisidField;
		private string sgt_naamidealField;
		private string sgt_nameField;
		private string sgt_ordernummerField;
		private string sgt_referentieidealField;
		private string sgt_rekeningnummeridealField;
		private Picklist sgt_statusField;
		private string sgt_statusidealField;
		private Lookup sgt_volledigenaamidField;
		private Sgt_alg_ideal_betaling_gebeurtenisStateInfo statecodeField;
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
		public Key sgt_alg_ideal_betaling_gebeurtenisid
		{
			get
			{
				return this.sgt_alg_ideal_betaling_gebeurtenisidField;
			}
			set
			{
				this.sgt_alg_ideal_betaling_gebeurtenisidField = value;
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
		public Lookup sgt_gebeurtenisid
		{
			get
			{
				return this.sgt_gebeurtenisidField;
			}
			set
			{
				this.sgt_gebeurtenisidField = value;
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
		public string sgt_name
		{
			get
			{
				return this.sgt_nameField;
			}
			set
			{
				this.sgt_nameField = value;
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
		public Sgt_alg_ideal_betaling_gebeurtenisStateInfo statecode
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
