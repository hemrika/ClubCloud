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
	public class sgt_alg_lidmaatschap : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private string sgt_alg_bondsnummerField;

		private Key sgt_alg_lidmaatschapidField;

		private CrmBoolean sgt_autorisatie_gezetField;

		private CrmDateTime sgt_datum_laatste_noodpasField;

		private CrmDateTime sgt_datum_laatste_pasField;

		private CrmDateTime sgt_datum_opgezegdField;

		private string sgt_fusie_informatieField;

		private Lookup sgt_inschrijfformulier_testdagidField;

		private Lookup sgt_lididField;

		private CrmDateTime sgt_lidmaatschap_beeindigdField;

		private CrmDateTime sgt_lidmaatschap_vanafField;

		private string sgt_lidnummer_bij_verenigingField;

		private CrmBoolean sgt_nieuwe_pas_nodigField;

		private CrmBoolean sgt_noodpas_nodigField;

		private Lookup sgt_pastypeidField;

		private Lookup sgt_pb_mutatie_ledenidField;

		private Lookup sgt_soort_lidmaatschapidField;

		private CrmNumber sgt_speelsterkte_dubbelField;

		private CrmNumber sgt_speelsterkte_dubbel_aangevraagdField;

		private CrmNumber sgt_speelsterkte_enkelField;

		private CrmNumber sgt_speelsterkte_enkel_aangevraagdField;

		private Picklist sgt_statusField;

		private Lookup sgt_toernooiorganisatieidField;

		private Lookup sgt_verenigingidField;

		private string sgt_volgnummer_pasField;

		private CrmBoolean sgt_wedstrijdpasField;

		private Sgt_alg_lidmaatschapStateInfo statecodeField;

		private Status statuscodeField;

		private CrmNumber timezoneruleversionnumberField;

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

		[XmlElement] //[XmlElement(Order=3)]
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

		[XmlElement] //[XmlElement(Order=4)]
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

		[XmlElement] //[XmlElement(Order=5)]
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

		[XmlElement] //[XmlElement(Order=6)]
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

		[XmlElement] //[XmlElement(Order=7)]
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

		[XmlElement] //[XmlElement(Order=8)]
		public string sgt_alg_bondsnummer
		{
			get
			{
				return this.sgt_alg_bondsnummerField;
			}
			set
			{
				this.sgt_alg_bondsnummerField = value;
				base.RaisePropertyChanged("sgt_alg_bondsnummer");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public Key sgt_alg_lidmaatschapid
		{
			get
			{
				return this.sgt_alg_lidmaatschapidField;
			}
			set
			{
				this.sgt_alg_lidmaatschapidField = value;
				base.RaisePropertyChanged("sgt_alg_lidmaatschapid");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public CrmBoolean sgt_autorisatie_gezet
		{
			get
			{
				return this.sgt_autorisatie_gezetField;
			}
			set
			{
				this.sgt_autorisatie_gezetField = value;
				base.RaisePropertyChanged("sgt_autorisatie_gezet");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public CrmDateTime sgt_datum_laatste_noodpas
		{
			get
			{
				return this.sgt_datum_laatste_noodpasField;
			}
			set
			{
				this.sgt_datum_laatste_noodpasField = value;
				base.RaisePropertyChanged("sgt_datum_laatste_noodpas");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public CrmDateTime sgt_datum_laatste_pas
		{
			get
			{
				return this.sgt_datum_laatste_pasField;
			}
			set
			{
				this.sgt_datum_laatste_pasField = value;
				base.RaisePropertyChanged("sgt_datum_laatste_pas");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public CrmDateTime sgt_datum_opgezegd
		{
			get
			{
				return this.sgt_datum_opgezegdField;
			}
			set
			{
				this.sgt_datum_opgezegdField = value;
				base.RaisePropertyChanged("sgt_datum_opgezegd");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public string sgt_fusie_informatie
		{
			get
			{
				return this.sgt_fusie_informatieField;
			}
			set
			{
				this.sgt_fusie_informatieField = value;
				base.RaisePropertyChanged("sgt_fusie_informatie");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public Lookup sgt_inschrijfformulier_testdagid
		{
			get
			{
				return this.sgt_inschrijfformulier_testdagidField;
			}
			set
			{
				this.sgt_inschrijfformulier_testdagidField = value;
				base.RaisePropertyChanged("sgt_inschrijfformulier_testdagid");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public Lookup sgt_lidid
		{
			get
			{
				return this.sgt_lididField;
			}
			set
			{
				this.sgt_lididField = value;
				base.RaisePropertyChanged("sgt_lidid");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public CrmDateTime sgt_lidmaatschap_beeindigd
		{
			get
			{
				return this.sgt_lidmaatschap_beeindigdField;
			}
			set
			{
				this.sgt_lidmaatschap_beeindigdField = value;
				base.RaisePropertyChanged("sgt_lidmaatschap_beeindigd");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public CrmDateTime sgt_lidmaatschap_vanaf
		{
			get
			{
				return this.sgt_lidmaatschap_vanafField;
			}
			set
			{
				this.sgt_lidmaatschap_vanafField = value;
				base.RaisePropertyChanged("sgt_lidmaatschap_vanaf");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
		public string sgt_lidnummer_bij_vereniging
		{
			get
			{
				return this.sgt_lidnummer_bij_verenigingField;
			}
			set
			{
				this.sgt_lidnummer_bij_verenigingField = value;
				base.RaisePropertyChanged("sgt_lidnummer_bij_vereniging");
			}
		}

		[XmlElement] //[XmlElement(Order=20)]
		public CrmBoolean sgt_nieuwe_pas_nodig
		{
			get
			{
				return this.sgt_nieuwe_pas_nodigField;
			}
			set
			{
				this.sgt_nieuwe_pas_nodigField = value;
				base.RaisePropertyChanged("sgt_nieuwe_pas_nodig");
			}
		}

		[XmlElement] //[XmlElement(Order=21)]
		public CrmBoolean sgt_noodpas_nodig
		{
			get
			{
				return this.sgt_noodpas_nodigField;
			}
			set
			{
				this.sgt_noodpas_nodigField = value;
				base.RaisePropertyChanged("sgt_noodpas_nodig");
			}
		}

		[XmlElement] //[XmlElement(Order=22)]
		public Lookup sgt_pastypeid
		{
			get
			{
				return this.sgt_pastypeidField;
			}
			set
			{
				this.sgt_pastypeidField = value;
				base.RaisePropertyChanged("sgt_pastypeid");
			}
		}

		[XmlElement] //[XmlElement(Order=23)]
		public Lookup sgt_pb_mutatie_ledenid
		{
			get
			{
				return this.sgt_pb_mutatie_ledenidField;
			}
			set
			{
				this.sgt_pb_mutatie_ledenidField = value;
				base.RaisePropertyChanged("sgt_pb_mutatie_ledenid");
			}
		}

		[XmlElement] //[XmlElement(Order=24)]
		public Lookup sgt_soort_lidmaatschapid
		{
			get
			{
				return this.sgt_soort_lidmaatschapidField;
			}
			set
			{
				this.sgt_soort_lidmaatschapidField = value;
				base.RaisePropertyChanged("sgt_soort_lidmaatschapid");
			}
		}

		[XmlElement] //[XmlElement(Order=25)]
		public CrmNumber sgt_speelsterkte_dubbel
		{
			get
			{
				return this.sgt_speelsterkte_dubbelField;
			}
			set
			{
				this.sgt_speelsterkte_dubbelField = value;
				base.RaisePropertyChanged("sgt_speelsterkte_dubbel");
			}
		}

		[XmlElement] //[XmlElement(Order=26)]
		public CrmNumber sgt_speelsterkte_dubbel_aangevraagd
		{
			get
			{
				return this.sgt_speelsterkte_dubbel_aangevraagdField;
			}
			set
			{
				this.sgt_speelsterkte_dubbel_aangevraagdField = value;
				base.RaisePropertyChanged("sgt_speelsterkte_dubbel_aangevraagd");
			}
		}

		[XmlElement] //[XmlElement(Order=27)]
		public CrmNumber sgt_speelsterkte_enkel
		{
			get
			{
				return this.sgt_speelsterkte_enkelField;
			}
			set
			{
				this.sgt_speelsterkte_enkelField = value;
				base.RaisePropertyChanged("sgt_speelsterkte_enkel");
			}
		}

		[XmlElement] //[XmlElement(Order=28)]
		public CrmNumber sgt_speelsterkte_enkel_aangevraagd
		{
			get
			{
				return this.sgt_speelsterkte_enkel_aangevraagdField;
			}
			set
			{
				this.sgt_speelsterkte_enkel_aangevraagdField = value;
				base.RaisePropertyChanged("sgt_speelsterkte_enkel_aangevraagd");
			}
		}

		[XmlElement] //[XmlElement(Order=29)]
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

		[XmlElement] //[XmlElement(Order=30)]
		public Lookup sgt_toernooiorganisatieid
		{
			get
			{
				return this.sgt_toernooiorganisatieidField;
			}
			set
			{
				this.sgt_toernooiorganisatieidField = value;
				base.RaisePropertyChanged("sgt_toernooiorganisatieid");
			}
		}

		[XmlElement] //[XmlElement(Order=31)]
		public Lookup sgt_verenigingid
		{
			get
			{
				return this.sgt_verenigingidField;
			}
			set
			{
				this.sgt_verenigingidField = value;
				base.RaisePropertyChanged("sgt_verenigingid");
			}
		}

		[XmlElement] //[XmlElement(Order=32)]
		public string sgt_volgnummer_pas
		{
			get
			{
				return this.sgt_volgnummer_pasField;
			}
			set
			{
				this.sgt_volgnummer_pasField = value;
				base.RaisePropertyChanged("sgt_volgnummer_pas");
			}
		}

		[XmlElement] //[XmlElement(Order=33)]
		public CrmBoolean sgt_wedstrijdpas
		{
			get
			{
				return this.sgt_wedstrijdpasField;
			}
			set
			{
				this.sgt_wedstrijdpasField = value;
				base.RaisePropertyChanged("sgt_wedstrijdpas");
			}
		}

		[XmlElement] //[XmlElement(Order=34)]
		public Sgt_alg_lidmaatschapStateInfo statecode
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

		public sgt_alg_lidmaatschap()
		{
		}
	}
}