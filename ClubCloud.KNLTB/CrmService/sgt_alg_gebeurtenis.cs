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
	public class sgt_alg_gebeurtenis : BusinessEntity
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

		private string sgt_alg_gebeurtenis1Field;

		private Key sgt_alg_gebeurtenisidField;

		private Picklist sgt_alg_gespreksduurField;

		private Lookup sgt_alg_gespreksonderwerpidField;

		private Picklist sgt_alg_gesprokenoverField;

		private Picklist sgt_alg_webregistratieField;

		private Lookup sgt_basisorganisatieidField;

		private CrmMoney sgt_bedrag_deelnameField;

		private CrmMoney sgt_bedrag_deelname_baseField;

		private CrmMoney sgt_bijdrage_straattennisField;

		private CrmMoney sgt_bijdrage_straattennis_baseField;

		private Lookup sgt_campagneidField;

		private CrmDateTime sgt_controleaantalinschrijvingenField;

		private CrmDateTime sgt_datumgebeurtenisField;

		private CrmBoolean sgt_deelnemerslijst_tonenField;

		private Lookup sgt_districtidField;

		private Lookup sgt_dynamicformidField;

		private CrmDateTime sgt_einddatumgebeurtenisField;

		private CrmBoolean sgt_facturerenField;

		private Lookup sgt_gebeurtenistypeidField;

		private CrmBoolean sgt_ideal_betalingField;

		private Lookup sgt_locatieidField;

		private CrmNumber sgt_minimaleinschrijvingField;

		private string sgt_omschrijvingField;

		private Lookup sgt_onderwerp1idField;

		private Lookup sgt_onderwerp2idField;

		private Lookup sgt_onderwerp3idField;

		private Lookup sgt_onderwerp4idField;

		private Lookup sgt_onderwerp5idField;

		private Lookup sgt_persoonidField;

		private CrmDateTime sgt_sluitinginschirjvingField;

		private Lookup sgt_toernooionderdee_lidField;

		private Sgt_alg_gebeurtenisStateInfo statecodeField;

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

		[XmlElement("sgt_alg_gebeurtenis")] //, Order=9)]
		public string sgt_alg_gebeurtenis1
		{
			get
			{
				return this.sgt_alg_gebeurtenis1Field;
			}
			set
			{
				this.sgt_alg_gebeurtenis1Field = value;
				base.RaisePropertyChanged("sgt_alg_gebeurtenis1");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public Key sgt_alg_gebeurtenisid
		{
			get
			{
				return this.sgt_alg_gebeurtenisidField;
			}
			set
			{
				this.sgt_alg_gebeurtenisidField = value;
				base.RaisePropertyChanged("sgt_alg_gebeurtenisid");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public Picklist sgt_alg_gespreksduur
		{
			get
			{
				return this.sgt_alg_gespreksduurField;
			}
			set
			{
				this.sgt_alg_gespreksduurField = value;
				base.RaisePropertyChanged("sgt_alg_gespreksduur");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public Lookup sgt_alg_gespreksonderwerpid
		{
			get
			{
				return this.sgt_alg_gespreksonderwerpidField;
			}
			set
			{
				this.sgt_alg_gespreksonderwerpidField = value;
				base.RaisePropertyChanged("sgt_alg_gespreksonderwerpid");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public Picklist sgt_alg_gesprokenover
		{
			get
			{
				return this.sgt_alg_gesprokenoverField;
			}
			set
			{
				this.sgt_alg_gesprokenoverField = value;
				base.RaisePropertyChanged("sgt_alg_gesprokenover");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public Picklist sgt_alg_webregistratie
		{
			get
			{
				return this.sgt_alg_webregistratieField;
			}
			set
			{
				this.sgt_alg_webregistratieField = value;
				base.RaisePropertyChanged("sgt_alg_webregistratie");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public Lookup sgt_basisorganisatieid
		{
			get
			{
				return this.sgt_basisorganisatieidField;
			}
			set
			{
				this.sgt_basisorganisatieidField = value;
				base.RaisePropertyChanged("sgt_basisorganisatieid");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public CrmMoney sgt_bedrag_deelname
		{
			get
			{
				return this.sgt_bedrag_deelnameField;
			}
			set
			{
				this.sgt_bedrag_deelnameField = value;
				base.RaisePropertyChanged("sgt_bedrag_deelname");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public CrmMoney sgt_bedrag_deelname_base
		{
			get
			{
				return this.sgt_bedrag_deelname_baseField;
			}
			set
			{
				this.sgt_bedrag_deelname_baseField = value;
				base.RaisePropertyChanged("sgt_bedrag_deelname_base");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public CrmMoney sgt_bijdrage_straattennis
		{
			get
			{
				return this.sgt_bijdrage_straattennisField;
			}
			set
			{
				this.sgt_bijdrage_straattennisField = value;
				base.RaisePropertyChanged("sgt_bijdrage_straattennis");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
		public CrmMoney sgt_bijdrage_straattennis_base
		{
			get
			{
				return this.sgt_bijdrage_straattennis_baseField;
			}
			set
			{
				this.sgt_bijdrage_straattennis_baseField = value;
				base.RaisePropertyChanged("sgt_bijdrage_straattennis_base");
			}
		}

		[XmlElement] //[XmlElement(Order=20)]
		public Lookup sgt_campagneid
		{
			get
			{
				return this.sgt_campagneidField;
			}
			set
			{
				this.sgt_campagneidField = value;
				base.RaisePropertyChanged("sgt_campagneid");
			}
		}

		[XmlElement] //[XmlElement(Order=21)]
		public CrmDateTime sgt_controleaantalinschrijvingen
		{
			get
			{
				return this.sgt_controleaantalinschrijvingenField;
			}
			set
			{
				this.sgt_controleaantalinschrijvingenField = value;
				base.RaisePropertyChanged("sgt_controleaantalinschrijvingen");
			}
		}

		[XmlElement] //[XmlElement(Order=22)]
		public CrmDateTime sgt_datumgebeurtenis
		{
			get
			{
				return this.sgt_datumgebeurtenisField;
			}
			set
			{
				this.sgt_datumgebeurtenisField = value;
				base.RaisePropertyChanged("sgt_datumgebeurtenis");
			}
		}

		[XmlElement] //[XmlElement(Order=23)]
		public CrmBoolean sgt_deelnemerslijst_tonen
		{
			get
			{
				return this.sgt_deelnemerslijst_tonenField;
			}
			set
			{
				this.sgt_deelnemerslijst_tonenField = value;
				base.RaisePropertyChanged("sgt_deelnemerslijst_tonen");
			}
		}

		[XmlElement] //[XmlElement(Order=24)]
		public Lookup sgt_districtid
		{
			get
			{
				return this.sgt_districtidField;
			}
			set
			{
				this.sgt_districtidField = value;
				base.RaisePropertyChanged("sgt_districtid");
			}
		}

		[XmlElement] //[XmlElement(Order=25)]
		public Lookup sgt_dynamicformid
		{
			get
			{
				return this.sgt_dynamicformidField;
			}
			set
			{
				this.sgt_dynamicformidField = value;
				base.RaisePropertyChanged("sgt_dynamicformid");
			}
		}

		[XmlElement] //[XmlElement(Order=26)]
		public CrmDateTime sgt_einddatumgebeurtenis
		{
			get
			{
				return this.sgt_einddatumgebeurtenisField;
			}
			set
			{
				this.sgt_einddatumgebeurtenisField = value;
				base.RaisePropertyChanged("sgt_einddatumgebeurtenis");
			}
		}

		[XmlElement] //[XmlElement(Order=27)]
		public CrmBoolean sgt_factureren
		{
			get
			{
				return this.sgt_facturerenField;
			}
			set
			{
				this.sgt_facturerenField = value;
				base.RaisePropertyChanged("sgt_factureren");
			}
		}

		[XmlElement] //[XmlElement(Order=28)]
		public Lookup sgt_gebeurtenistypeid
		{
			get
			{
				return this.sgt_gebeurtenistypeidField;
			}
			set
			{
				this.sgt_gebeurtenistypeidField = value;
				base.RaisePropertyChanged("sgt_gebeurtenistypeid");
			}
		}

		[XmlElement] //[XmlElement(Order=29)]
		public CrmBoolean sgt_ideal_betaling
		{
			get
			{
				return this.sgt_ideal_betalingField;
			}
			set
			{
				this.sgt_ideal_betalingField = value;
				base.RaisePropertyChanged("sgt_ideal_betaling");
			}
		}

		[XmlElement] //[XmlElement(Order=30)]
		public Lookup sgt_locatieid
		{
			get
			{
				return this.sgt_locatieidField;
			}
			set
			{
				this.sgt_locatieidField = value;
				base.RaisePropertyChanged("sgt_locatieid");
			}
		}

		[XmlElement] //[XmlElement(Order=31)]
		public CrmNumber sgt_minimaleinschrijving
		{
			get
			{
				return this.sgt_minimaleinschrijvingField;
			}
			set
			{
				this.sgt_minimaleinschrijvingField = value;
				base.RaisePropertyChanged("sgt_minimaleinschrijving");
			}
		}

		[XmlElement] //[XmlElement(Order=32)]
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

		[XmlElement] //[XmlElement(Order=33)]
		public Lookup sgt_onderwerp1id
		{
			get
			{
				return this.sgt_onderwerp1idField;
			}
			set
			{
				this.sgt_onderwerp1idField = value;
				base.RaisePropertyChanged("sgt_onderwerp1id");
			}
		}

		[XmlElement] //[XmlElement(Order=34)]
		public Lookup sgt_onderwerp2id
		{
			get
			{
				return this.sgt_onderwerp2idField;
			}
			set
			{
				this.sgt_onderwerp2idField = value;
				base.RaisePropertyChanged("sgt_onderwerp2id");
			}
		}

		[XmlElement] //[XmlElement(Order=35)]
		public Lookup sgt_onderwerp3id
		{
			get
			{
				return this.sgt_onderwerp3idField;
			}
			set
			{
				this.sgt_onderwerp3idField = value;
				base.RaisePropertyChanged("sgt_onderwerp3id");
			}
		}

		[XmlElement] //[XmlElement(Order=36)]
		public Lookup sgt_onderwerp4id
		{
			get
			{
				return this.sgt_onderwerp4idField;
			}
			set
			{
				this.sgt_onderwerp4idField = value;
				base.RaisePropertyChanged("sgt_onderwerp4id");
			}
		}

		[XmlElement] //[XmlElement(Order=37)]
		public Lookup sgt_onderwerp5id
		{
			get
			{
				return this.sgt_onderwerp5idField;
			}
			set
			{
				this.sgt_onderwerp5idField = value;
				base.RaisePropertyChanged("sgt_onderwerp5id");
			}
		}

		[XmlElement] //[XmlElement(Order=38)]
		public Lookup sgt_persoonid
		{
			get
			{
				return this.sgt_persoonidField;
			}
			set
			{
				this.sgt_persoonidField = value;
				base.RaisePropertyChanged("sgt_persoonid");
			}
		}

		[XmlElement] //[XmlElement(Order=39)]
		public CrmDateTime sgt_sluitinginschirjving
		{
			get
			{
				return this.sgt_sluitinginschirjvingField;
			}
			set
			{
				this.sgt_sluitinginschirjvingField = value;
				base.RaisePropertyChanged("sgt_sluitinginschirjving");
			}
		}

		[XmlElement] //[XmlElement(Order=40)]
		public Lookup sgt_toernooionderdee_lid
		{
			get
			{
				return this.sgt_toernooionderdee_lidField;
			}
			set
			{
				this.sgt_toernooionderdee_lidField = value;
				base.RaisePropertyChanged("sgt_toernooionderdee_lid");
			}
		}

		[XmlElement] //[XmlElement(Order=41)]
		public Sgt_alg_gebeurtenisStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=42)]
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

		[XmlElement] //[XmlElement(Order=43)]
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

		[XmlElement] //[XmlElement(Order=44)]
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

		[XmlElement] //[XmlElement(Order=45)]
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

		public sgt_alg_gebeurtenis()
		{
		}
	}
}