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
	public class sgt_toe_toernooispeler : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private string sgt_acceptatie_opmerkingField;

		private string sgt_achternaam_speler1Field;

		private string sgt_achternaam_speler2Field;

		private string sgt_adres_speler1Field;

		private string sgt_adres_speler2Field;

		private CrmBoolean sgt_altijd_accepterenField;

		private string sgt_bondsnummer_speler1Field;

		private string sgt_bondsnummer_speler2Field;

		private CrmBoolean sgt_categoriespelerField;

		private Lookup sgt_dagtoernooiField;

		private CrmDateTime sgt_datum_ranglijstField;

		private string sgt_email_speler1Field;

		private string sgt_email_speler2Field;

		private CrmDateTime sgt_geboortedatum_speler1Field;

		private CrmDateTime sgt_geboortedatum_speler2Field;

		private CrmBoolean sgt_geplaatstField;

		private Picklist sgt_geslacht_speler1Field;

		private Picklist sgt_geslacht_speler2Field;

		private Picklist sgt_keuze_spelerField;

		private string sgt_plaats_speler1Field;

		private string sgt_plaats_speler2Field;

		private string sgt_positieschema1Field;

		private string sgt_positieschema2Field;

		private string sgt_positieschema3Field;

		private Lookup sgt_poule_schema1_idField;

		private Lookup sgt_poule_schema2_idField;

		private Lookup sgt_poule_schema3idField;

		private Lookup sgt_ranglijstidField;

		private Lookup sgt_ranglijstpositie_speler2idField;

		private Lookup sgt_ranglijstpositieidField;

		private string sgt_roepnaam_speler1Field;

		private string sgt_roepnaam_speler2Field;

		private CrmBoolean sgt_special_exemptField;

		private Lookup sgt_special_exempt_aanvraag_2_idField;

		private Lookup sgt_special_exempt_aanvraagidField;

		private CrmNumber sgt_speelsterkte_dubbelField;

		private CrmNumber sgt_speelsterkte_dubbel_speler2Field;

		private CrmNumber sgt_speelsterkte_enkelField;

		private CrmNumber sgt_speelsterkte_enkel_speler2Field;

		private Lookup sgt_speler_2_geen_knltb_lididField;

		private Lookup sgt_speler_geen_knltb_lididField;

		private Lookup sgt_speler2idField;

		private Lookup sgt_speleridField;

		private Picklist sgt_statusField;

		private string sgt_telefoonnummer_speler1Field;

		private string sgt_telefoonnummer_speler2Field;

		private string sgt_toe_toernooispeler1Field;

		private Key sgt_toe_toernooispeleridField;

		private CrmBoolean sgt_toegevoegd_door_tpField;

		private Lookup sgt_toernooiafhandelingidField;

		private Lookup sgt_toernooiidField;

		private Lookup sgt_toernooionderdeelidField;

		private string sgt_tussenvoegsel_speler1Field;

		private string sgt_tussenvoegsel_speler2Field;

		private Picklist sgt_type_inschrijvingField;

		private Picklist sgt_type_inschrijving_2Field;

		private Picklist sgt_uitnodiging_geaccepteerdField;

		private string sgt_volgordenummerField;

		private string sgt_voorletters_speler1Field;

		private string sgt_voorletters_speler2Field;

		private CrmBoolean sgt_wildcardField;

		private Lookup sgt_wildcard_speler1_idField;

		private Lookup sgt_wildcard_speler2_idField;

		private CrmBoolean sgt_zelf_ingeschrevenField;

		private CrmBoolean sgt_zelf_ingeschreven_2Field;

		private Sgt_toe_toernooispelerStateInfo statecodeField;

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
		public string sgt_acceptatie_opmerking
		{
			get
			{
				return this.sgt_acceptatie_opmerkingField;
			}
			set
			{
				this.sgt_acceptatie_opmerkingField = value;
				base.RaisePropertyChanged("sgt_acceptatie_opmerking");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public string sgt_achternaam_speler1
		{
			get
			{
				return this.sgt_achternaam_speler1Field;
			}
			set
			{
				this.sgt_achternaam_speler1Field = value;
				base.RaisePropertyChanged("sgt_achternaam_speler1");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public string sgt_achternaam_speler2
		{
			get
			{
				return this.sgt_achternaam_speler2Field;
			}
			set
			{
				this.sgt_achternaam_speler2Field = value;
				base.RaisePropertyChanged("sgt_achternaam_speler2");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public string sgt_adres_speler1
		{
			get
			{
				return this.sgt_adres_speler1Field;
			}
			set
			{
				this.sgt_adres_speler1Field = value;
				base.RaisePropertyChanged("sgt_adres_speler1");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public string sgt_adres_speler2
		{
			get
			{
				return this.sgt_adres_speler2Field;
			}
			set
			{
				this.sgt_adres_speler2Field = value;
				base.RaisePropertyChanged("sgt_adres_speler2");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public CrmBoolean sgt_altijd_accepteren
		{
			get
			{
				return this.sgt_altijd_accepterenField;
			}
			set
			{
				this.sgt_altijd_accepterenField = value;
				base.RaisePropertyChanged("sgt_altijd_accepteren");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public string sgt_bondsnummer_speler1
		{
			get
			{
				return this.sgt_bondsnummer_speler1Field;
			}
			set
			{
				this.sgt_bondsnummer_speler1Field = value;
				base.RaisePropertyChanged("sgt_bondsnummer_speler1");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public string sgt_bondsnummer_speler2
		{
			get
			{
				return this.sgt_bondsnummer_speler2Field;
			}
			set
			{
				this.sgt_bondsnummer_speler2Field = value;
				base.RaisePropertyChanged("sgt_bondsnummer_speler2");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public CrmBoolean sgt_categoriespeler
		{
			get
			{
				return this.sgt_categoriespelerField;
			}
			set
			{
				this.sgt_categoriespelerField = value;
				base.RaisePropertyChanged("sgt_categoriespeler");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public Lookup sgt_dagtoernooi
		{
			get
			{
				return this.sgt_dagtoernooiField;
			}
			set
			{
				this.sgt_dagtoernooiField = value;
				base.RaisePropertyChanged("sgt_dagtoernooi");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public CrmDateTime sgt_datum_ranglijst
		{
			get
			{
				return this.sgt_datum_ranglijstField;
			}
			set
			{
				this.sgt_datum_ranglijstField = value;
				base.RaisePropertyChanged("sgt_datum_ranglijst");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
		public string sgt_email_speler1
		{
			get
			{
				return this.sgt_email_speler1Field;
			}
			set
			{
				this.sgt_email_speler1Field = value;
				base.RaisePropertyChanged("sgt_email_speler1");
			}
		}

		[XmlElement] //[XmlElement(Order=20)]
		public string sgt_email_speler2
		{
			get
			{
				return this.sgt_email_speler2Field;
			}
			set
			{
				this.sgt_email_speler2Field = value;
				base.RaisePropertyChanged("sgt_email_speler2");
			}
		}

		[XmlElement] //[XmlElement(Order=21)]
		public CrmDateTime sgt_geboortedatum_speler1
		{
			get
			{
				return this.sgt_geboortedatum_speler1Field;
			}
			set
			{
				this.sgt_geboortedatum_speler1Field = value;
				base.RaisePropertyChanged("sgt_geboortedatum_speler1");
			}
		}

		[XmlElement] //[XmlElement(Order=22)]
		public CrmDateTime sgt_geboortedatum_speler2
		{
			get
			{
				return this.sgt_geboortedatum_speler2Field;
			}
			set
			{
				this.sgt_geboortedatum_speler2Field = value;
				base.RaisePropertyChanged("sgt_geboortedatum_speler2");
			}
		}

		[XmlElement] //[XmlElement(Order=23)]
		public CrmBoolean sgt_geplaatst
		{
			get
			{
				return this.sgt_geplaatstField;
			}
			set
			{
				this.sgt_geplaatstField = value;
				base.RaisePropertyChanged("sgt_geplaatst");
			}
		}

		[XmlElement] //[XmlElement(Order=24)]
		public Picklist sgt_geslacht_speler1
		{
			get
			{
				return this.sgt_geslacht_speler1Field;
			}
			set
			{
				this.sgt_geslacht_speler1Field = value;
				base.RaisePropertyChanged("sgt_geslacht_speler1");
			}
		}

		[XmlElement] //[XmlElement(Order=25)]
		public Picklist sgt_geslacht_speler2
		{
			get
			{
				return this.sgt_geslacht_speler2Field;
			}
			set
			{
				this.sgt_geslacht_speler2Field = value;
				base.RaisePropertyChanged("sgt_geslacht_speler2");
			}
		}

		[XmlElement] //[XmlElement(Order=26)]
		public Picklist sgt_keuze_speler
		{
			get
			{
				return this.sgt_keuze_spelerField;
			}
			set
			{
				this.sgt_keuze_spelerField = value;
				base.RaisePropertyChanged("sgt_keuze_speler");
			}
		}

		[XmlElement] //[XmlElement(Order=27)]
		public string sgt_plaats_speler1
		{
			get
			{
				return this.sgt_plaats_speler1Field;
			}
			set
			{
				this.sgt_plaats_speler1Field = value;
				base.RaisePropertyChanged("sgt_plaats_speler1");
			}
		}

		[XmlElement] //[XmlElement(Order=28)]
		public string sgt_plaats_speler2
		{
			get
			{
				return this.sgt_plaats_speler2Field;
			}
			set
			{
				this.sgt_plaats_speler2Field = value;
				base.RaisePropertyChanged("sgt_plaats_speler2");
			}
		}

		[XmlElement] //[XmlElement(Order=29)]
		public string sgt_positieschema1
		{
			get
			{
				return this.sgt_positieschema1Field;
			}
			set
			{
				this.sgt_positieschema1Field = value;
				base.RaisePropertyChanged("sgt_positieschema1");
			}
		}

		[XmlElement] //[XmlElement(Order=30)]
		public string sgt_positieschema2
		{
			get
			{
				return this.sgt_positieschema2Field;
			}
			set
			{
				this.sgt_positieschema2Field = value;
				base.RaisePropertyChanged("sgt_positieschema2");
			}
		}

		[XmlElement] //[XmlElement(Order=31)]
		public string sgt_positieschema3
		{
			get
			{
				return this.sgt_positieschema3Field;
			}
			set
			{
				this.sgt_positieschema3Field = value;
				base.RaisePropertyChanged("sgt_positieschema3");
			}
		}

		[XmlElement] //[XmlElement(Order=32)]
		public Lookup sgt_poule_schema1_id
		{
			get
			{
				return this.sgt_poule_schema1_idField;
			}
			set
			{
				this.sgt_poule_schema1_idField = value;
				base.RaisePropertyChanged("sgt_poule_schema1_id");
			}
		}

		[XmlElement] //[XmlElement(Order=33)]
		public Lookup sgt_poule_schema2_id
		{
			get
			{
				return this.sgt_poule_schema2_idField;
			}
			set
			{
				this.sgt_poule_schema2_idField = value;
				base.RaisePropertyChanged("sgt_poule_schema2_id");
			}
		}

		[XmlElement] //[XmlElement(Order=34)]
		public Lookup sgt_poule_schema3id
		{
			get
			{
				return this.sgt_poule_schema3idField;
			}
			set
			{
				this.sgt_poule_schema3idField = value;
				base.RaisePropertyChanged("sgt_poule_schema3id");
			}
		}

		[XmlElement] //[XmlElement(Order=35)]
		public Lookup sgt_ranglijstid
		{
			get
			{
				return this.sgt_ranglijstidField;
			}
			set
			{
				this.sgt_ranglijstidField = value;
				base.RaisePropertyChanged("sgt_ranglijstid");
			}
		}

		[XmlElement] //[XmlElement(Order=36)]
		public Lookup sgt_ranglijstpositie_speler2id
		{
			get
			{
				return this.sgt_ranglijstpositie_speler2idField;
			}
			set
			{
				this.sgt_ranglijstpositie_speler2idField = value;
				base.RaisePropertyChanged("sgt_ranglijstpositie_speler2id");
			}
		}

		[XmlElement] //[XmlElement(Order=37)]
		public Lookup sgt_ranglijstpositieid
		{
			get
			{
				return this.sgt_ranglijstpositieidField;
			}
			set
			{
				this.sgt_ranglijstpositieidField = value;
				base.RaisePropertyChanged("sgt_ranglijstpositieid");
			}
		}

		[XmlElement] //[XmlElement(Order=38)]
		public string sgt_roepnaam_speler1
		{
			get
			{
				return this.sgt_roepnaam_speler1Field;
			}
			set
			{
				this.sgt_roepnaam_speler1Field = value;
				base.RaisePropertyChanged("sgt_roepnaam_speler1");
			}
		}

		[XmlElement] //[XmlElement(Order=39)]
		public string sgt_roepnaam_speler2
		{
			get
			{
				return this.sgt_roepnaam_speler2Field;
			}
			set
			{
				this.sgt_roepnaam_speler2Field = value;
				base.RaisePropertyChanged("sgt_roepnaam_speler2");
			}
		}

		[XmlElement] //[XmlElement(Order=40)]
		public CrmBoolean sgt_special_exempt
		{
			get
			{
				return this.sgt_special_exemptField;
			}
			set
			{
				this.sgt_special_exemptField = value;
				base.RaisePropertyChanged("sgt_special_exempt");
			}
		}

		[XmlElement] //[XmlElement(Order=41)]
		public Lookup sgt_special_exempt_aanvraag_2_id
		{
			get
			{
				return this.sgt_special_exempt_aanvraag_2_idField;
			}
			set
			{
				this.sgt_special_exempt_aanvraag_2_idField = value;
				base.RaisePropertyChanged("sgt_special_exempt_aanvraag_2_id");
			}
		}

		[XmlElement] //[XmlElement(Order=42)]
		public Lookup sgt_special_exempt_aanvraagid
		{
			get
			{
				return this.sgt_special_exempt_aanvraagidField;
			}
			set
			{
				this.sgt_special_exempt_aanvraagidField = value;
				base.RaisePropertyChanged("sgt_special_exempt_aanvraagid");
			}
		}

		[XmlElement] //[XmlElement(Order=43)]
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

		[XmlElement] //[XmlElement(Order=44)]
		public CrmNumber sgt_speelsterkte_dubbel_speler2
		{
			get
			{
				return this.sgt_speelsterkte_dubbel_speler2Field;
			}
			set
			{
				this.sgt_speelsterkte_dubbel_speler2Field = value;
				base.RaisePropertyChanged("sgt_speelsterkte_dubbel_speler2");
			}
		}

		[XmlElement] //[XmlElement(Order=45)]
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

		[XmlElement] //[XmlElement(Order=46)]
		public CrmNumber sgt_speelsterkte_enkel_speler2
		{
			get
			{
				return this.sgt_speelsterkte_enkel_speler2Field;
			}
			set
			{
				this.sgt_speelsterkte_enkel_speler2Field = value;
				base.RaisePropertyChanged("sgt_speelsterkte_enkel_speler2");
			}
		}

		[XmlElement] //[XmlElement(Order=47)]
		public Lookup sgt_speler_2_geen_knltb_lidid
		{
			get
			{
				return this.sgt_speler_2_geen_knltb_lididField;
			}
			set
			{
				this.sgt_speler_2_geen_knltb_lididField = value;
				base.RaisePropertyChanged("sgt_speler_2_geen_knltb_lidid");
			}
		}

		[XmlElement] //[XmlElement(Order=48)]
		public Lookup sgt_speler_geen_knltb_lidid
		{
			get
			{
				return this.sgt_speler_geen_knltb_lididField;
			}
			set
			{
				this.sgt_speler_geen_knltb_lididField = value;
				base.RaisePropertyChanged("sgt_speler_geen_knltb_lidid");
			}
		}

		[XmlElement] //[XmlElement(Order=49)]
		public Lookup sgt_speler2id
		{
			get
			{
				return this.sgt_speler2idField;
			}
			set
			{
				this.sgt_speler2idField = value;
				base.RaisePropertyChanged("sgt_speler2id");
			}
		}

		[XmlElement] //[XmlElement(Order=50)]
		public Lookup sgt_spelerid
		{
			get
			{
				return this.sgt_speleridField;
			}
			set
			{
				this.sgt_speleridField = value;
				base.RaisePropertyChanged("sgt_spelerid");
			}
		}

		[XmlElement] //[XmlElement(Order=51)]
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

		[XmlElement] //[XmlElement(Order=52)]
		public string sgt_telefoonnummer_speler1
		{
			get
			{
				return this.sgt_telefoonnummer_speler1Field;
			}
			set
			{
				this.sgt_telefoonnummer_speler1Field = value;
				base.RaisePropertyChanged("sgt_telefoonnummer_speler1");
			}
		}

		[XmlElement] //[XmlElement(Order=53)]
		public string sgt_telefoonnummer_speler2
		{
			get
			{
				return this.sgt_telefoonnummer_speler2Field;
			}
			set
			{
				this.sgt_telefoonnummer_speler2Field = value;
				base.RaisePropertyChanged("sgt_telefoonnummer_speler2");
			}
		}

		[XmlElement("sgt_toe_toernooispeler")] //, Order=54)]
		public string sgt_toe_toernooispeler1
		{
			get
			{
				return this.sgt_toe_toernooispeler1Field;
			}
			set
			{
				this.sgt_toe_toernooispeler1Field = value;
				base.RaisePropertyChanged("sgt_toe_toernooispeler1");
			}
		}

		[XmlElement] //[XmlElement(Order=55)]
		public Key sgt_toe_toernooispelerid
		{
			get
			{
				return this.sgt_toe_toernooispeleridField;
			}
			set
			{
				this.sgt_toe_toernooispeleridField = value;
				base.RaisePropertyChanged("sgt_toe_toernooispelerid");
			}
		}

		[XmlElement] //[XmlElement(Order=56)]
		public CrmBoolean sgt_toegevoegd_door_tp
		{
			get
			{
				return this.sgt_toegevoegd_door_tpField;
			}
			set
			{
				this.sgt_toegevoegd_door_tpField = value;
				base.RaisePropertyChanged("sgt_toegevoegd_door_tp");
			}
		}

		[XmlElement] //[XmlElement(Order=57)]
		public Lookup sgt_toernooiafhandelingid
		{
			get
			{
				return this.sgt_toernooiafhandelingidField;
			}
			set
			{
				this.sgt_toernooiafhandelingidField = value;
				base.RaisePropertyChanged("sgt_toernooiafhandelingid");
			}
		}

		[XmlElement] //[XmlElement(Order=58)]
		public Lookup sgt_toernooiid
		{
			get
			{
				return this.sgt_toernooiidField;
			}
			set
			{
				this.sgt_toernooiidField = value;
				base.RaisePropertyChanged("sgt_toernooiid");
			}
		}

		[XmlElement] //[XmlElement(Order=59)]
		public Lookup sgt_toernooionderdeelid
		{
			get
			{
				return this.sgt_toernooionderdeelidField;
			}
			set
			{
				this.sgt_toernooionderdeelidField = value;
				base.RaisePropertyChanged("sgt_toernooionderdeelid");
			}
		}

		[XmlElement] //[XmlElement(Order=60)]
		public string sgt_tussenvoegsel_speler1
		{
			get
			{
				return this.sgt_tussenvoegsel_speler1Field;
			}
			set
			{
				this.sgt_tussenvoegsel_speler1Field = value;
				base.RaisePropertyChanged("sgt_tussenvoegsel_speler1");
			}
		}

		[XmlElement] //[XmlElement(Order=61)]
		public string sgt_tussenvoegsel_speler2
		{
			get
			{
				return this.sgt_tussenvoegsel_speler2Field;
			}
			set
			{
				this.sgt_tussenvoegsel_speler2Field = value;
				base.RaisePropertyChanged("sgt_tussenvoegsel_speler2");
			}
		}

		[XmlElement] //[XmlElement(Order=62)]
		public Picklist sgt_type_inschrijving
		{
			get
			{
				return this.sgt_type_inschrijvingField;
			}
			set
			{
				this.sgt_type_inschrijvingField = value;
				base.RaisePropertyChanged("sgt_type_inschrijving");
			}
		}

		[XmlElement] //[XmlElement(Order=63)]
		public Picklist sgt_type_inschrijving_2
		{
			get
			{
				return this.sgt_type_inschrijving_2Field;
			}
			set
			{
				this.sgt_type_inschrijving_2Field = value;
				base.RaisePropertyChanged("sgt_type_inschrijving_2");
			}
		}

		[XmlElement] //[XmlElement(Order=64)]
		public Picklist sgt_uitnodiging_geaccepteerd
		{
			get
			{
				return this.sgt_uitnodiging_geaccepteerdField;
			}
			set
			{
				this.sgt_uitnodiging_geaccepteerdField = value;
				base.RaisePropertyChanged("sgt_uitnodiging_geaccepteerd");
			}
		}

		[XmlElement] //[XmlElement(Order=65)]
		public string sgt_volgordenummer
		{
			get
			{
				return this.sgt_volgordenummerField;
			}
			set
			{
				this.sgt_volgordenummerField = value;
				base.RaisePropertyChanged("sgt_volgordenummer");
			}
		}

		[XmlElement] //[XmlElement(Order=66)]
		public string sgt_voorletters_speler1
		{
			get
			{
				return this.sgt_voorletters_speler1Field;
			}
			set
			{
				this.sgt_voorletters_speler1Field = value;
				base.RaisePropertyChanged("sgt_voorletters_speler1");
			}
		}

		[XmlElement] //[XmlElement(Order=67)]
		public string sgt_voorletters_speler2
		{
			get
			{
				return this.sgt_voorletters_speler2Field;
			}
			set
			{
				this.sgt_voorletters_speler2Field = value;
				base.RaisePropertyChanged("sgt_voorletters_speler2");
			}
		}

		[XmlElement] //[XmlElement(Order=68)]
		public CrmBoolean sgt_wildcard
		{
			get
			{
				return this.sgt_wildcardField;
			}
			set
			{
				this.sgt_wildcardField = value;
				base.RaisePropertyChanged("sgt_wildcard");
			}
		}

		[XmlElement] //[XmlElement(Order=69)]
		public Lookup sgt_wildcard_speler1_id
		{
			get
			{
				return this.sgt_wildcard_speler1_idField;
			}
			set
			{
				this.sgt_wildcard_speler1_idField = value;
				base.RaisePropertyChanged("sgt_wildcard_speler1_id");
			}
		}

		[XmlElement] //[XmlElement(Order=70)]
		public Lookup sgt_wildcard_speler2_id
		{
			get
			{
				return this.sgt_wildcard_speler2_idField;
			}
			set
			{
				this.sgt_wildcard_speler2_idField = value;
				base.RaisePropertyChanged("sgt_wildcard_speler2_id");
			}
		}

		[XmlElement] //[XmlElement(Order=71)]
		public CrmBoolean sgt_zelf_ingeschreven
		{
			get
			{
				return this.sgt_zelf_ingeschrevenField;
			}
			set
			{
				this.sgt_zelf_ingeschrevenField = value;
				base.RaisePropertyChanged("sgt_zelf_ingeschreven");
			}
		}

		[XmlElement] //[XmlElement(Order=72)]
		public CrmBoolean sgt_zelf_ingeschreven_2
		{
			get
			{
				return this.sgt_zelf_ingeschreven_2Field;
			}
			set
			{
				this.sgt_zelf_ingeschreven_2Field = value;
				base.RaisePropertyChanged("sgt_zelf_ingeschreven_2");
			}
		}

		[XmlElement] //[XmlElement(Order=73)]
		public Sgt_toe_toernooispelerStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=74)]
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

		[XmlElement] //[XmlElement(Order=75)]
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

		[XmlElement] //[XmlElement(Order=76)]
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

		public sgt_toe_toernooispeler()
		{
		}
	}
}