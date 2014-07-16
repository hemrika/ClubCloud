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
		public Key sgt_alg_ideal_betaling_gebeurtenisid
		{
			get
			{
				return this.sgt_alg_ideal_betaling_gebeurtenisidField;
			}
			set
			{
				this.sgt_alg_ideal_betaling_gebeurtenisidField = value;
				base.RaisePropertyChanged("sgt_alg_ideal_betaling_gebeurtenisid");
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

		[XmlElement] //[XmlElement(Order=13)]
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

		[XmlElement] //[XmlElement(Order=14)]
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

		[XmlElement] //[XmlElement(Order=15)]
		public Lookup sgt_gebeurtenisid
		{
			get
			{
				return this.sgt_gebeurtenisidField;
			}
			set
			{
				this.sgt_gebeurtenisidField = value;
				base.RaisePropertyChanged("sgt_gebeurtenisid");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
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

		[XmlElement] //[XmlElement(Order=17)]
		public string sgt_name
		{
			get
			{
				return this.sgt_nameField;
			}
			set
			{
				this.sgt_nameField = value;
				base.RaisePropertyChanged("sgt_name");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
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

		[XmlElement] //[XmlElement(Order=19)]
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

		[XmlElement] //[XmlElement(Order=20)]
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

		[XmlElement] //[XmlElement(Order=21)]
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

		[XmlElement] //[XmlElement(Order=22)]
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

		[XmlElement] //[XmlElement(Order=23)]
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

		[XmlElement] //[XmlElement(Order=24)]
		public Sgt_alg_ideal_betaling_gebeurtenisStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=25)]
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

		[XmlElement] //[XmlElement(Order=26)]
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

		[XmlElement] //[XmlElement(Order=27)]
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

		[XmlElement] //[XmlElement(Order=28)]
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

		public sgt_alg_ideal_betaling_gebeurtenis()
		{
		}
	}
}