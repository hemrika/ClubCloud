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
		public string sgt_alg_betaling
		{
			get
			{
				return this.sgt_alg_betalingField;
			}
			set
			{
				this.sgt_alg_betalingField = value;
				base.RaisePropertyChanged("sgt_alg_betaling");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public Key sgt_alg_ideal_betalingid
		{
			get
			{
				return this.sgt_alg_ideal_betalingidField;
			}
			set
			{
				this.sgt_alg_ideal_betalingidField = value;
				base.RaisePropertyChanged("sgt_alg_ideal_betalingid");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
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

		[XmlElement] //[XmlElement(Order=12)]
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

		[XmlElement] //[XmlElement(Order=13)]
		public string sgt_bondsnummer
		{
			get
			{
				return this.sgt_bondsnummerField;
			}
			set
			{
				this.sgt_bondsnummerField = value;
				base.RaisePropertyChanged("sgt_bondsnummer");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public CrmDateTime sgt_datum_en_tijd_betaling
		{
			get
			{
				return this.sgt_datum_en_tijd_betalingField;
			}
			set
			{
				this.sgt_datum_en_tijd_betalingField = value;
				base.RaisePropertyChanged("sgt_datum_en_tijd_betaling");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public CrmDateTime sgt_datum_en_tijd_verwerking
		{
			get
			{
				return this.sgt_datum_en_tijd_verwerkingField;
			}
			set
			{
				this.sgt_datum_en_tijd_verwerkingField = value;
				base.RaisePropertyChanged("sgt_datum_en_tijd_verwerking");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public Lookup sgt_examenid
		{
			get
			{
				return this.sgt_examenidField;
			}
			set
			{
				this.sgt_examenidField = value;
				base.RaisePropertyChanged("sgt_examenid");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public Lookup sgt_formulierid
		{
			get
			{
				return this.sgt_formulieridField;
			}
			set
			{
				this.sgt_formulieridField = value;
				base.RaisePropertyChanged("sgt_formulierid");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public CrmDateTime sgt_ingangsdatum
		{
			get
			{
				return this.sgt_ingangsdatumField;
			}
			set
			{
				this.sgt_ingangsdatumField = value;
				base.RaisePropertyChanged("sgt_ingangsdatum");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
		public Lookup sgt_ingedeeldegroepid
		{
			get
			{
				return this.sgt_ingedeeldegroepidField;
			}
			set
			{
				this.sgt_ingedeeldegroepidField = value;
				base.RaisePropertyChanged("sgt_ingedeeldegroepid");
			}
		}

		[XmlElement] //[XmlElement(Order=20)]
		public Lookup sgt_licentieid
		{
			get
			{
				return this.sgt_licentieidField;
			}
			set
			{
				this.sgt_licentieidField = value;
				base.RaisePropertyChanged("sgt_licentieid");
			}
		}

		[XmlElement] //[XmlElement(Order=21)]
		public string sgt_naamideal
		{
			get
			{
				return this.sgt_naamidealField;
			}
			set
			{
				this.sgt_naamidealField = value;
				base.RaisePropertyChanged("sgt_naamideal");
			}
		}

		[XmlElement] //[XmlElement(Order=22)]
		public Lookup sgt_opleiding
		{
			get
			{
				return this.sgt_opleidingField;
			}
			set
			{
				this.sgt_opleidingField = value;
				base.RaisePropertyChanged("sgt_opleiding");
			}
		}

		[XmlElement] //[XmlElement(Order=23)]
		public string sgt_ordernummer
		{
			get
			{
				return this.sgt_ordernummerField;
			}
			set
			{
				this.sgt_ordernummerField = value;
				base.RaisePropertyChanged("sgt_ordernummer");
			}
		}

		[XmlElement] //[XmlElement(Order=24)]
		public string sgt_referentieideal
		{
			get
			{
				return this.sgt_referentieidealField;
			}
			set
			{
				this.sgt_referentieidealField = value;
				base.RaisePropertyChanged("sgt_referentieideal");
			}
		}

		[XmlElement] //[XmlElement(Order=25)]
		public string sgt_rekeningnummerideal
		{
			get
			{
				return this.sgt_rekeningnummeridealField;
			}
			set
			{
				this.sgt_rekeningnummeridealField = value;
				base.RaisePropertyChanged("sgt_rekeningnummerideal");
			}
		}

		[XmlElement] //[XmlElement(Order=26)]
		public Picklist sgt_status
		{
			get
			{
				return this.sgt_statusField;
			}
			set
			{
				this.sgt_statusField = value;
				base.RaisePropertyChanged("sgt_status");
			}
		}

		[XmlElement] //[XmlElement(Order=27)]
		public string sgt_statusideal
		{
			get
			{
				return this.sgt_statusidealField;
			}
			set
			{
				this.sgt_statusidealField = value;
				base.RaisePropertyChanged("sgt_statusideal");
			}
		}

		[XmlElement] //[XmlElement(Order=28)]
		public Lookup sgt_volledigenaamid
		{
			get
			{
				return this.sgt_volledigenaamidField;
			}
			set
			{
				this.sgt_volledigenaamidField = value;
				base.RaisePropertyChanged("sgt_volledigenaamid");
			}
		}

		[XmlElement] //[XmlElement(Order=29)]
		public Lookup sgt_voorkeur1id
		{
			get
			{
				return this.sgt_voorkeur1idField;
			}
			set
			{
				this.sgt_voorkeur1idField = value;
				base.RaisePropertyChanged("sgt_voorkeur1id");
			}
		}

		[XmlElement] //[XmlElement(Order=30)]
		public Lookup sgt_voorkeur2id
		{
			get
			{
				return this.sgt_voorkeur2idField;
			}
			set
			{
				this.sgt_voorkeur2idField = value;
				base.RaisePropertyChanged("sgt_voorkeur2id");
			}
		}

		[XmlElement] //[XmlElement(Order=31)]
		public Lookup sgt_voorkeur3id
		{
			get
			{
				return this.sgt_voorkeur3idField;
			}
			set
			{
				this.sgt_voorkeur3idField = value;
				base.RaisePropertyChanged("sgt_voorkeur3id");
			}
		}

		[XmlElement] //[XmlElement(Order=32)]
		public Lookup sgt_voorkeur4id
		{
			get
			{
				return this.sgt_voorkeur4idField;
			}
			set
			{
				this.sgt_voorkeur4idField = value;
				base.RaisePropertyChanged("sgt_voorkeur4id");
			}
		}

		[XmlElement] //[XmlElement(Order=33)]
		public Lookup sgt_voorkeur5id
		{
			get
			{
				return this.sgt_voorkeur5idField;
			}
			set
			{
				this.sgt_voorkeur5idField = value;
				base.RaisePropertyChanged("sgt_voorkeur5id");
			}
		}

		[XmlElement] //[XmlElement(Order=34)]
		public Sgt_alg_IDEAL_betalingStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=35)]
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

		[XmlElement] //[XmlElement(Order=36)]
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

		[XmlElement] //[XmlElement(Order=37)]
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

		[XmlElement] //[XmlElement(Order=38)]
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

		public sgt_alg_ideal_betaling()
		{
		}
	}
}