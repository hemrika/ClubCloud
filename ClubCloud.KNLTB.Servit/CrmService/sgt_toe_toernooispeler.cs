using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
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
		public string sgt_acceptatie_opmerking
		{
			get
			{
				return this.sgt_acceptatie_opmerkingField;
			}
			set
			{
				this.sgt_acceptatie_opmerkingField = value;
			}
		}
		public string sgt_achternaam_speler1
		{
			get
			{
				return this.sgt_achternaam_speler1Field;
			}
			set
			{
				this.sgt_achternaam_speler1Field = value;
			}
		}
		public string sgt_achternaam_speler2
		{
			get
			{
				return this.sgt_achternaam_speler2Field;
			}
			set
			{
				this.sgt_achternaam_speler2Field = value;
			}
		}
		public string sgt_adres_speler1
		{
			get
			{
				return this.sgt_adres_speler1Field;
			}
			set
			{
				this.sgt_adres_speler1Field = value;
			}
		}
		public string sgt_adres_speler2
		{
			get
			{
				return this.sgt_adres_speler2Field;
			}
			set
			{
				this.sgt_adres_speler2Field = value;
			}
		}
		public CrmBoolean sgt_altijd_accepteren
		{
			get
			{
				return this.sgt_altijd_accepterenField;
			}
			set
			{
				this.sgt_altijd_accepterenField = value;
			}
		}
		public string sgt_bondsnummer_speler1
		{
			get
			{
				return this.sgt_bondsnummer_speler1Field;
			}
			set
			{
				this.sgt_bondsnummer_speler1Field = value;
			}
		}
		public string sgt_bondsnummer_speler2
		{
			get
			{
				return this.sgt_bondsnummer_speler2Field;
			}
			set
			{
				this.sgt_bondsnummer_speler2Field = value;
			}
		}
		public CrmBoolean sgt_categoriespeler
		{
			get
			{
				return this.sgt_categoriespelerField;
			}
			set
			{
				this.sgt_categoriespelerField = value;
			}
		}
		public Lookup sgt_dagtoernooi
		{
			get
			{
				return this.sgt_dagtoernooiField;
			}
			set
			{
				this.sgt_dagtoernooiField = value;
			}
		}
		public CrmDateTime sgt_datum_ranglijst
		{
			get
			{
				return this.sgt_datum_ranglijstField;
			}
			set
			{
				this.sgt_datum_ranglijstField = value;
			}
		}
		public string sgt_email_speler1
		{
			get
			{
				return this.sgt_email_speler1Field;
			}
			set
			{
				this.sgt_email_speler1Field = value;
			}
		}
		public string sgt_email_speler2
		{
			get
			{
				return this.sgt_email_speler2Field;
			}
			set
			{
				this.sgt_email_speler2Field = value;
			}
		}
		public CrmDateTime sgt_geboortedatum_speler1
		{
			get
			{
				return this.sgt_geboortedatum_speler1Field;
			}
			set
			{
				this.sgt_geboortedatum_speler1Field = value;
			}
		}
		public CrmDateTime sgt_geboortedatum_speler2
		{
			get
			{
				return this.sgt_geboortedatum_speler2Field;
			}
			set
			{
				this.sgt_geboortedatum_speler2Field = value;
			}
		}
		public CrmBoolean sgt_geplaatst
		{
			get
			{
				return this.sgt_geplaatstField;
			}
			set
			{
				this.sgt_geplaatstField = value;
			}
		}
		public Picklist sgt_geslacht_speler1
		{
			get
			{
				return this.sgt_geslacht_speler1Field;
			}
			set
			{
				this.sgt_geslacht_speler1Field = value;
			}
		}
		public Picklist sgt_geslacht_speler2
		{
			get
			{
				return this.sgt_geslacht_speler2Field;
			}
			set
			{
				this.sgt_geslacht_speler2Field = value;
			}
		}
		public Picklist sgt_keuze_speler
		{
			get
			{
				return this.sgt_keuze_spelerField;
			}
			set
			{
				this.sgt_keuze_spelerField = value;
			}
		}
		public string sgt_plaats_speler1
		{
			get
			{
				return this.sgt_plaats_speler1Field;
			}
			set
			{
				this.sgt_plaats_speler1Field = value;
			}
		}
		public string sgt_plaats_speler2
		{
			get
			{
				return this.sgt_plaats_speler2Field;
			}
			set
			{
				this.sgt_plaats_speler2Field = value;
			}
		}
		public string sgt_positieschema1
		{
			get
			{
				return this.sgt_positieschema1Field;
			}
			set
			{
				this.sgt_positieschema1Field = value;
			}
		}
		public string sgt_positieschema2
		{
			get
			{
				return this.sgt_positieschema2Field;
			}
			set
			{
				this.sgt_positieschema2Field = value;
			}
		}
		public string sgt_positieschema3
		{
			get
			{
				return this.sgt_positieschema3Field;
			}
			set
			{
				this.sgt_positieschema3Field = value;
			}
		}
		public Lookup sgt_poule_schema1_id
		{
			get
			{
				return this.sgt_poule_schema1_idField;
			}
			set
			{
				this.sgt_poule_schema1_idField = value;
			}
		}
		public Lookup sgt_poule_schema2_id
		{
			get
			{
				return this.sgt_poule_schema2_idField;
			}
			set
			{
				this.sgt_poule_schema2_idField = value;
			}
		}
		public Lookup sgt_poule_schema3id
		{
			get
			{
				return this.sgt_poule_schema3idField;
			}
			set
			{
				this.sgt_poule_schema3idField = value;
			}
		}
		public Lookup sgt_ranglijstid
		{
			get
			{
				return this.sgt_ranglijstidField;
			}
			set
			{
				this.sgt_ranglijstidField = value;
			}
		}
		public Lookup sgt_ranglijstpositie_speler2id
		{
			get
			{
				return this.sgt_ranglijstpositie_speler2idField;
			}
			set
			{
				this.sgt_ranglijstpositie_speler2idField = value;
			}
		}
		public Lookup sgt_ranglijstpositieid
		{
			get
			{
				return this.sgt_ranglijstpositieidField;
			}
			set
			{
				this.sgt_ranglijstpositieidField = value;
			}
		}
		public string sgt_roepnaam_speler1
		{
			get
			{
				return this.sgt_roepnaam_speler1Field;
			}
			set
			{
				this.sgt_roepnaam_speler1Field = value;
			}
		}
		public string sgt_roepnaam_speler2
		{
			get
			{
				return this.sgt_roepnaam_speler2Field;
			}
			set
			{
				this.sgt_roepnaam_speler2Field = value;
			}
		}
		public CrmBoolean sgt_special_exempt
		{
			get
			{
				return this.sgt_special_exemptField;
			}
			set
			{
				this.sgt_special_exemptField = value;
			}
		}
		public Lookup sgt_special_exempt_aanvraag_2_id
		{
			get
			{
				return this.sgt_special_exempt_aanvraag_2_idField;
			}
			set
			{
				this.sgt_special_exempt_aanvraag_2_idField = value;
			}
		}
		public Lookup sgt_special_exempt_aanvraagid
		{
			get
			{
				return this.sgt_special_exempt_aanvraagidField;
			}
			set
			{
				this.sgt_special_exempt_aanvraagidField = value;
			}
		}
		public CrmNumber sgt_speelsterkte_dubbel
		{
			get
			{
				return this.sgt_speelsterkte_dubbelField;
			}
			set
			{
				this.sgt_speelsterkte_dubbelField = value;
			}
		}
		public CrmNumber sgt_speelsterkte_dubbel_speler2
		{
			get
			{
				return this.sgt_speelsterkte_dubbel_speler2Field;
			}
			set
			{
				this.sgt_speelsterkte_dubbel_speler2Field = value;
			}
		}
		public CrmNumber sgt_speelsterkte_enkel
		{
			get
			{
				return this.sgt_speelsterkte_enkelField;
			}
			set
			{
				this.sgt_speelsterkte_enkelField = value;
			}
		}
		public CrmNumber sgt_speelsterkte_enkel_speler2
		{
			get
			{
				return this.sgt_speelsterkte_enkel_speler2Field;
			}
			set
			{
				this.sgt_speelsterkte_enkel_speler2Field = value;
			}
		}
		public Lookup sgt_speler_2_geen_knltb_lidid
		{
			get
			{
				return this.sgt_speler_2_geen_knltb_lididField;
			}
			set
			{
				this.sgt_speler_2_geen_knltb_lididField = value;
			}
		}
		public Lookup sgt_speler_geen_knltb_lidid
		{
			get
			{
				return this.sgt_speler_geen_knltb_lididField;
			}
			set
			{
				this.sgt_speler_geen_knltb_lididField = value;
			}
		}
		public Lookup sgt_speler2id
		{
			get
			{
				return this.sgt_speler2idField;
			}
			set
			{
				this.sgt_speler2idField = value;
			}
		}
		public Lookup sgt_spelerid
		{
			get
			{
				return this.sgt_speleridField;
			}
			set
			{
				this.sgt_speleridField = value;
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
		public string sgt_telefoonnummer_speler1
		{
			get
			{
				return this.sgt_telefoonnummer_speler1Field;
			}
			set
			{
				this.sgt_telefoonnummer_speler1Field = value;
			}
		}
		public string sgt_telefoonnummer_speler2
		{
			get
			{
				return this.sgt_telefoonnummer_speler2Field;
			}
			set
			{
				this.sgt_telefoonnummer_speler2Field = value;
			}
		}
		[XmlElement("sgt_toe_toernooispeler")]
		public string sgt_toe_toernooispeler1
		{
			get
			{
				return this.sgt_toe_toernooispeler1Field;
			}
			set
			{
				this.sgt_toe_toernooispeler1Field = value;
			}
		}
		public Key sgt_toe_toernooispelerid
		{
			get
			{
				return this.sgt_toe_toernooispeleridField;
			}
			set
			{
				this.sgt_toe_toernooispeleridField = value;
			}
		}
		public CrmBoolean sgt_toegevoegd_door_tp
		{
			get
			{
				return this.sgt_toegevoegd_door_tpField;
			}
			set
			{
				this.sgt_toegevoegd_door_tpField = value;
			}
		}
		public Lookup sgt_toernooiafhandelingid
		{
			get
			{
				return this.sgt_toernooiafhandelingidField;
			}
			set
			{
				this.sgt_toernooiafhandelingidField = value;
			}
		}
		public Lookup sgt_toernooiid
		{
			get
			{
				return this.sgt_toernooiidField;
			}
			set
			{
				this.sgt_toernooiidField = value;
			}
		}
		public Lookup sgt_toernooionderdeelid
		{
			get
			{
				return this.sgt_toernooionderdeelidField;
			}
			set
			{
				this.sgt_toernooionderdeelidField = value;
			}
		}
		public string sgt_tussenvoegsel_speler1
		{
			get
			{
				return this.sgt_tussenvoegsel_speler1Field;
			}
			set
			{
				this.sgt_tussenvoegsel_speler1Field = value;
			}
		}
		public string sgt_tussenvoegsel_speler2
		{
			get
			{
				return this.sgt_tussenvoegsel_speler2Field;
			}
			set
			{
				this.sgt_tussenvoegsel_speler2Field = value;
			}
		}
		public Picklist sgt_type_inschrijving
		{
			get
			{
				return this.sgt_type_inschrijvingField;
			}
			set
			{
				this.sgt_type_inschrijvingField = value;
			}
		}
		public Picklist sgt_type_inschrijving_2
		{
			get
			{
				return this.sgt_type_inschrijving_2Field;
			}
			set
			{
				this.sgt_type_inschrijving_2Field = value;
			}
		}
		public Picklist sgt_uitnodiging_geaccepteerd
		{
			get
			{
				return this.sgt_uitnodiging_geaccepteerdField;
			}
			set
			{
				this.sgt_uitnodiging_geaccepteerdField = value;
			}
		}
		public string sgt_volgordenummer
		{
			get
			{
				return this.sgt_volgordenummerField;
			}
			set
			{
				this.sgt_volgordenummerField = value;
			}
		}
		public string sgt_voorletters_speler1
		{
			get
			{
				return this.sgt_voorletters_speler1Field;
			}
			set
			{
				this.sgt_voorletters_speler1Field = value;
			}
		}
		public string sgt_voorletters_speler2
		{
			get
			{
				return this.sgt_voorletters_speler2Field;
			}
			set
			{
				this.sgt_voorletters_speler2Field = value;
			}
		}
		public CrmBoolean sgt_wildcard
		{
			get
			{
				return this.sgt_wildcardField;
			}
			set
			{
				this.sgt_wildcardField = value;
			}
		}
		public Lookup sgt_wildcard_speler1_id
		{
			get
			{
				return this.sgt_wildcard_speler1_idField;
			}
			set
			{
				this.sgt_wildcard_speler1_idField = value;
			}
		}
		public Lookup sgt_wildcard_speler2_id
		{
			get
			{
				return this.sgt_wildcard_speler2_idField;
			}
			set
			{
				this.sgt_wildcard_speler2_idField = value;
			}
		}
		public CrmBoolean sgt_zelf_ingeschreven
		{
			get
			{
				return this.sgt_zelf_ingeschrevenField;
			}
			set
			{
				this.sgt_zelf_ingeschrevenField = value;
			}
		}
		public CrmBoolean sgt_zelf_ingeschreven_2
		{
			get
			{
				return this.sgt_zelf_ingeschreven_2Field;
			}
			set
			{
				this.sgt_zelf_ingeschreven_2Field = value;
			}
		}
		public Sgt_toe_toernooispelerStateInfo statecode
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
