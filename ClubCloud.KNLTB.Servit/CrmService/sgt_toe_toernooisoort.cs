using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_toe_toernooisoort : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmDecimal exchangerateField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup organizationidField;
		private CrmDateTime overriddencreatedonField;
		private CrmBoolean sgt_aantal_categorie_spelersField;
		private CrmNumber sgt_aantal_dagen_resultaten_tonenField;
		private CrmBoolean sgt_aantal_deelnemersField;
		private CrmNumber sgt_aantal_jaar_zelfde_hsField;
		private Picklist sgt_acceptatieField;
		private string sgt_afmeldings_procedureField;
		private Picklist sgt_arbitrageniveauField;
		private string sgt_beschrijvingField;
		private string sgt_bijzonderhedenField;
		private Lookup sgt_combi_toernooisoortidField;
		private CrmBoolean sgt_combinatie_toernooiField;
		private CrmBoolean sgt_controle_dubbelField;
		private CrmBoolean sgt_controle_op_leeftijdscategorieField;
		private CrmBoolean sgt_controle_op_speelsterkte_categorieField;
		private CrmBoolean sgt_dagtoernooiField;
		private Lookup sgt_default_ranglijst_to_idField;
		private CrmBoolean sgt_dssField;
		private CrmBoolean sgt_email_bij_acceptatieField;
		private CrmBoolean sgt_email_bij_inschrijving_wijzigen_annulerenField;
		private CrmBoolean sgt_email_bij_niet_accepterenField;
		private CrmBoolean sgt_email_bij_uitnodigen_jnField;
		private CrmBoolean sgt_email_inschrijf_termijn_verstrekenField;
		private CrmBoolean sgt_geboortejaar_weergevenField;
		private CrmMoney sgt_handlingsfee_maximumField;
		private CrmMoney sgt_handlingsfee_maximum_baseField;
		private CrmDecimal sgt_handlingsfee_percentageField;
		private CrmBoolean sgt_handlingsfee_toepassenField;
		private CrmBoolean sgt_incomplete_inschrijving_dubbelspelField;
		private Lookup sgt_inschrijfmethodeidField;
		private CrmBoolean sgt_inschrijven_dubbel_via_mijnknltbField;
		private CrmBoolean sgt_inschrijven_dubbel_via_organisatorField;
		private CrmBoolean sgt_inschrijven_dubbel_via_verenigingField;
		private CrmBoolean sgt_inschrijven_enkel_via_mijnknltbField;
		private CrmBoolean sgt_inschrijven_enkel_via_toernooiorganisatorField;
		private CrmBoolean sgt_inschrijven_enkel_via_verenigingField;
		private Picklist sgt_inschrijven_op_toernooiField;
		private Picklist sgt_keuze_of_inschrijvingField;
		private CrmBoolean sgt_kwalificantenField;
		private string sgt_meervoudsnaamField;
		private Picklist sgt_methode_automatisch_accepterenField;
		private string sgt_omschrijvingField;
		private CrmBoolean sgt_ondergrondField;
		private CrmMoney sgt_ot_bijdrage_circuitField;
		private CrmMoney sgt_ot_bijdrage_circuit_baseField;
		private CrmMoney sgt_ot_handlingsfeeField;
		private CrmMoney sgt_ot_handlingsfee_baseField;
		private CrmMoney sgt_ot_inschrijfbijdrageField;
		private CrmMoney sgt_ot_inschrijfbijdrage_baseField;
		private CrmMoney sgt_ot_restitutiebedrag_bc_annulerenField;
		private CrmMoney sgt_ot_restitutiebedrag_bc_annuleren_baseField;
		private CrmMoney sgt_ot_restitutiebedrag_bc_dispensatieField;
		private CrmMoney sgt_ot_restitutiebedrag_bc_dispensatie_baseField;
		private CrmMoney sgt_ot_restitutiebedrag_hf_annulerenField;
		private CrmMoney sgt_ot_restitutiebedrag_hf_annuleren_baseField;
		private CrmMoney sgt_ot_restitutiebedrag_ib_annulerenField;
		private CrmMoney sgt_ot_restitutiebedrag_ib_annuleren_baseField;
		private CrmMoney sgt_ot_restitutiebedrag_ib_dispensatieField;
		private CrmMoney sgt_ot_restitutiebedrag_ib_dispensatie_baseField;
		private CrmBoolean sgt_prijzengeldField;
		private CrmBoolean sgt_ranglijst_positie_weergevenField;
		private CrmBoolean sgt_ranglijst_verplicht_voor_inschrijvingField;
		private CrmBoolean sgt_ranglijsttoernooienField;
		private CrmBoolean sgt_schema_grootteField;
		private CrmBoolean sgt_soort_balField;
		private string sgt_sourcekeyField;
		private CrmBoolean sgt_special_exemptsField;
		private CrmBoolean sgt_speler_moet_rechten_hebbenField;
		private Lookup sgt_telmethode_idField;
		private CrmBoolean sgt_toe_interfacesField;
		private string sgt_toe_toernooisoort1Field;
		private Key sgt_toe_toernooisoortidField;
		private CrmBoolean sgt_toernooiField;
		private Lookup sgt_toernooi_groepidField;
		private Picklist sgt_type_categoriespelerField;
		private Picklist sgt_type_leeftijd_bepalingField;
		private string sgt_verkorte_codeField;
		private CrmBoolean sgt_wildcardsField;
		private Sgt_toe_toernooisoortStateInfo statecodeField;
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
		public Lookup organizationid
		{
			get
			{
				return this.organizationidField;
			}
			set
			{
				this.organizationidField = value;
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
		public CrmBoolean sgt_aantal_categorie_spelers
		{
			get
			{
				return this.sgt_aantal_categorie_spelersField;
			}
			set
			{
				this.sgt_aantal_categorie_spelersField = value;
			}
		}
		public CrmNumber sgt_aantal_dagen_resultaten_tonen
		{
			get
			{
				return this.sgt_aantal_dagen_resultaten_tonenField;
			}
			set
			{
				this.sgt_aantal_dagen_resultaten_tonenField = value;
			}
		}
		public CrmBoolean sgt_aantal_deelnemers
		{
			get
			{
				return this.sgt_aantal_deelnemersField;
			}
			set
			{
				this.sgt_aantal_deelnemersField = value;
			}
		}
		public CrmNumber sgt_aantal_jaar_zelfde_hs
		{
			get
			{
				return this.sgt_aantal_jaar_zelfde_hsField;
			}
			set
			{
				this.sgt_aantal_jaar_zelfde_hsField = value;
			}
		}
		public Picklist sgt_acceptatie
		{
			get
			{
				return this.sgt_acceptatieField;
			}
			set
			{
				this.sgt_acceptatieField = value;
			}
		}
		public string sgt_afmeldings_procedure
		{
			get
			{
				return this.sgt_afmeldings_procedureField;
			}
			set
			{
				this.sgt_afmeldings_procedureField = value;
			}
		}
		public Picklist sgt_arbitrageniveau
		{
			get
			{
				return this.sgt_arbitrageniveauField;
			}
			set
			{
				this.sgt_arbitrageniveauField = value;
			}
		}
		public string sgt_beschrijving
		{
			get
			{
				return this.sgt_beschrijvingField;
			}
			set
			{
				this.sgt_beschrijvingField = value;
			}
		}
		public string sgt_bijzonderheden
		{
			get
			{
				return this.sgt_bijzonderhedenField;
			}
			set
			{
				this.sgt_bijzonderhedenField = value;
			}
		}
		public Lookup sgt_combi_toernooisoortid
		{
			get
			{
				return this.sgt_combi_toernooisoortidField;
			}
			set
			{
				this.sgt_combi_toernooisoortidField = value;
			}
		}
		public CrmBoolean sgt_combinatie_toernooi
		{
			get
			{
				return this.sgt_combinatie_toernooiField;
			}
			set
			{
				this.sgt_combinatie_toernooiField = value;
			}
		}
		public CrmBoolean sgt_controle_dubbel
		{
			get
			{
				return this.sgt_controle_dubbelField;
			}
			set
			{
				this.sgt_controle_dubbelField = value;
			}
		}
		public CrmBoolean sgt_controle_op_leeftijdscategorie
		{
			get
			{
				return this.sgt_controle_op_leeftijdscategorieField;
			}
			set
			{
				this.sgt_controle_op_leeftijdscategorieField = value;
			}
		}
		public CrmBoolean sgt_controle_op_speelsterkte_categorie
		{
			get
			{
				return this.sgt_controle_op_speelsterkte_categorieField;
			}
			set
			{
				this.sgt_controle_op_speelsterkte_categorieField = value;
			}
		}
		public CrmBoolean sgt_dagtoernooi
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
		public Lookup sgt_default_ranglijst_to_id
		{
			get
			{
				return this.sgt_default_ranglijst_to_idField;
			}
			set
			{
				this.sgt_default_ranglijst_to_idField = value;
			}
		}
		public CrmBoolean sgt_dss
		{
			get
			{
				return this.sgt_dssField;
			}
			set
			{
				this.sgt_dssField = value;
			}
		}
		public CrmBoolean sgt_email_bij_acceptatie
		{
			get
			{
				return this.sgt_email_bij_acceptatieField;
			}
			set
			{
				this.sgt_email_bij_acceptatieField = value;
			}
		}
		public CrmBoolean sgt_email_bij_inschrijving_wijzigen_annuleren
		{
			get
			{
				return this.sgt_email_bij_inschrijving_wijzigen_annulerenField;
			}
			set
			{
				this.sgt_email_bij_inschrijving_wijzigen_annulerenField = value;
			}
		}
		public CrmBoolean sgt_email_bij_niet_accepteren
		{
			get
			{
				return this.sgt_email_bij_niet_accepterenField;
			}
			set
			{
				this.sgt_email_bij_niet_accepterenField = value;
			}
		}
		public CrmBoolean sgt_email_bij_uitnodigen_jn
		{
			get
			{
				return this.sgt_email_bij_uitnodigen_jnField;
			}
			set
			{
				this.sgt_email_bij_uitnodigen_jnField = value;
			}
		}
		public CrmBoolean sgt_email_inschrijf_termijn_verstreken
		{
			get
			{
				return this.sgt_email_inschrijf_termijn_verstrekenField;
			}
			set
			{
				this.sgt_email_inschrijf_termijn_verstrekenField = value;
			}
		}
		public CrmBoolean sgt_geboortejaar_weergeven
		{
			get
			{
				return this.sgt_geboortejaar_weergevenField;
			}
			set
			{
				this.sgt_geboortejaar_weergevenField = value;
			}
		}
		public CrmMoney sgt_handlingsfee_maximum
		{
			get
			{
				return this.sgt_handlingsfee_maximumField;
			}
			set
			{
				this.sgt_handlingsfee_maximumField = value;
			}
		}
		public CrmMoney sgt_handlingsfee_maximum_base
		{
			get
			{
				return this.sgt_handlingsfee_maximum_baseField;
			}
			set
			{
				this.sgt_handlingsfee_maximum_baseField = value;
			}
		}
		public CrmDecimal sgt_handlingsfee_percentage
		{
			get
			{
				return this.sgt_handlingsfee_percentageField;
			}
			set
			{
				this.sgt_handlingsfee_percentageField = value;
			}
		}
		public CrmBoolean sgt_handlingsfee_toepassen
		{
			get
			{
				return this.sgt_handlingsfee_toepassenField;
			}
			set
			{
				this.sgt_handlingsfee_toepassenField = value;
			}
		}
		public CrmBoolean sgt_incomplete_inschrijving_dubbelspel
		{
			get
			{
				return this.sgt_incomplete_inschrijving_dubbelspelField;
			}
			set
			{
				this.sgt_incomplete_inschrijving_dubbelspelField = value;
			}
		}
		public Lookup sgt_inschrijfmethodeid
		{
			get
			{
				return this.sgt_inschrijfmethodeidField;
			}
			set
			{
				this.sgt_inschrijfmethodeidField = value;
			}
		}
		public CrmBoolean sgt_inschrijven_dubbel_via_mijnknltb
		{
			get
			{
				return this.sgt_inschrijven_dubbel_via_mijnknltbField;
			}
			set
			{
				this.sgt_inschrijven_dubbel_via_mijnknltbField = value;
			}
		}
		public CrmBoolean sgt_inschrijven_dubbel_via_organisator
		{
			get
			{
				return this.sgt_inschrijven_dubbel_via_organisatorField;
			}
			set
			{
				this.sgt_inschrijven_dubbel_via_organisatorField = value;
			}
		}
		public CrmBoolean sgt_inschrijven_dubbel_via_vereniging
		{
			get
			{
				return this.sgt_inschrijven_dubbel_via_verenigingField;
			}
			set
			{
				this.sgt_inschrijven_dubbel_via_verenigingField = value;
			}
		}
		public CrmBoolean sgt_inschrijven_enkel_via_mijnknltb
		{
			get
			{
				return this.sgt_inschrijven_enkel_via_mijnknltbField;
			}
			set
			{
				this.sgt_inschrijven_enkel_via_mijnknltbField = value;
			}
		}
		public CrmBoolean sgt_inschrijven_enkel_via_toernooiorganisator
		{
			get
			{
				return this.sgt_inschrijven_enkel_via_toernooiorganisatorField;
			}
			set
			{
				this.sgt_inschrijven_enkel_via_toernooiorganisatorField = value;
			}
		}
		public CrmBoolean sgt_inschrijven_enkel_via_vereniging
		{
			get
			{
				return this.sgt_inschrijven_enkel_via_verenigingField;
			}
			set
			{
				this.sgt_inschrijven_enkel_via_verenigingField = value;
			}
		}
		public Picklist sgt_inschrijven_op_toernooi
		{
			get
			{
				return this.sgt_inschrijven_op_toernooiField;
			}
			set
			{
				this.sgt_inschrijven_op_toernooiField = value;
			}
		}
		public Picklist sgt_keuze_of_inschrijving
		{
			get
			{
				return this.sgt_keuze_of_inschrijvingField;
			}
			set
			{
				this.sgt_keuze_of_inschrijvingField = value;
			}
		}
		public CrmBoolean sgt_kwalificanten
		{
			get
			{
				return this.sgt_kwalificantenField;
			}
			set
			{
				this.sgt_kwalificantenField = value;
			}
		}
		public string sgt_meervoudsnaam
		{
			get
			{
				return this.sgt_meervoudsnaamField;
			}
			set
			{
				this.sgt_meervoudsnaamField = value;
			}
		}
		public Picklist sgt_methode_automatisch_accepteren
		{
			get
			{
				return this.sgt_methode_automatisch_accepterenField;
			}
			set
			{
				this.sgt_methode_automatisch_accepterenField = value;
			}
		}
		public string sgt_omschrijving
		{
			get
			{
				return this.sgt_omschrijvingField;
			}
			set
			{
				this.sgt_omschrijvingField = value;
			}
		}
		public CrmBoolean sgt_ondergrond
		{
			get
			{
				return this.sgt_ondergrondField;
			}
			set
			{
				this.sgt_ondergrondField = value;
			}
		}
		public CrmMoney sgt_ot_bijdrage_circuit
		{
			get
			{
				return this.sgt_ot_bijdrage_circuitField;
			}
			set
			{
				this.sgt_ot_bijdrage_circuitField = value;
			}
		}
		public CrmMoney sgt_ot_bijdrage_circuit_base
		{
			get
			{
				return this.sgt_ot_bijdrage_circuit_baseField;
			}
			set
			{
				this.sgt_ot_bijdrage_circuit_baseField = value;
			}
		}
		public CrmMoney sgt_ot_handlingsfee
		{
			get
			{
				return this.sgt_ot_handlingsfeeField;
			}
			set
			{
				this.sgt_ot_handlingsfeeField = value;
			}
		}
		public CrmMoney sgt_ot_handlingsfee_base
		{
			get
			{
				return this.sgt_ot_handlingsfee_baseField;
			}
			set
			{
				this.sgt_ot_handlingsfee_baseField = value;
			}
		}
		public CrmMoney sgt_ot_inschrijfbijdrage
		{
			get
			{
				return this.sgt_ot_inschrijfbijdrageField;
			}
			set
			{
				this.sgt_ot_inschrijfbijdrageField = value;
			}
		}
		public CrmMoney sgt_ot_inschrijfbijdrage_base
		{
			get
			{
				return this.sgt_ot_inschrijfbijdrage_baseField;
			}
			set
			{
				this.sgt_ot_inschrijfbijdrage_baseField = value;
			}
		}
		public CrmMoney sgt_ot_restitutiebedrag_bc_annuleren
		{
			get
			{
				return this.sgt_ot_restitutiebedrag_bc_annulerenField;
			}
			set
			{
				this.sgt_ot_restitutiebedrag_bc_annulerenField = value;
			}
		}
		public CrmMoney sgt_ot_restitutiebedrag_bc_annuleren_base
		{
			get
			{
				return this.sgt_ot_restitutiebedrag_bc_annuleren_baseField;
			}
			set
			{
				this.sgt_ot_restitutiebedrag_bc_annuleren_baseField = value;
			}
		}
		public CrmMoney sgt_ot_restitutiebedrag_bc_dispensatie
		{
			get
			{
				return this.sgt_ot_restitutiebedrag_bc_dispensatieField;
			}
			set
			{
				this.sgt_ot_restitutiebedrag_bc_dispensatieField = value;
			}
		}
		public CrmMoney sgt_ot_restitutiebedrag_bc_dispensatie_base
		{
			get
			{
				return this.sgt_ot_restitutiebedrag_bc_dispensatie_baseField;
			}
			set
			{
				this.sgt_ot_restitutiebedrag_bc_dispensatie_baseField = value;
			}
		}
		public CrmMoney sgt_ot_restitutiebedrag_hf_annuleren
		{
			get
			{
				return this.sgt_ot_restitutiebedrag_hf_annulerenField;
			}
			set
			{
				this.sgt_ot_restitutiebedrag_hf_annulerenField = value;
			}
		}
		public CrmMoney sgt_ot_restitutiebedrag_hf_annuleren_base
		{
			get
			{
				return this.sgt_ot_restitutiebedrag_hf_annuleren_baseField;
			}
			set
			{
				this.sgt_ot_restitutiebedrag_hf_annuleren_baseField = value;
			}
		}
		public CrmMoney sgt_ot_restitutiebedrag_ib_annuleren
		{
			get
			{
				return this.sgt_ot_restitutiebedrag_ib_annulerenField;
			}
			set
			{
				this.sgt_ot_restitutiebedrag_ib_annulerenField = value;
			}
		}
		public CrmMoney sgt_ot_restitutiebedrag_ib_annuleren_base
		{
			get
			{
				return this.sgt_ot_restitutiebedrag_ib_annuleren_baseField;
			}
			set
			{
				this.sgt_ot_restitutiebedrag_ib_annuleren_baseField = value;
			}
		}
		public CrmMoney sgt_ot_restitutiebedrag_ib_dispensatie
		{
			get
			{
				return this.sgt_ot_restitutiebedrag_ib_dispensatieField;
			}
			set
			{
				this.sgt_ot_restitutiebedrag_ib_dispensatieField = value;
			}
		}
		public CrmMoney sgt_ot_restitutiebedrag_ib_dispensatie_base
		{
			get
			{
				return this.sgt_ot_restitutiebedrag_ib_dispensatie_baseField;
			}
			set
			{
				this.sgt_ot_restitutiebedrag_ib_dispensatie_baseField = value;
			}
		}
		public CrmBoolean sgt_prijzengeld
		{
			get
			{
				return this.sgt_prijzengeldField;
			}
			set
			{
				this.sgt_prijzengeldField = value;
			}
		}
		public CrmBoolean sgt_ranglijst_positie_weergeven
		{
			get
			{
				return this.sgt_ranglijst_positie_weergevenField;
			}
			set
			{
				this.sgt_ranglijst_positie_weergevenField = value;
			}
		}
		public CrmBoolean sgt_ranglijst_verplicht_voor_inschrijving
		{
			get
			{
				return this.sgt_ranglijst_verplicht_voor_inschrijvingField;
			}
			set
			{
				this.sgt_ranglijst_verplicht_voor_inschrijvingField = value;
			}
		}
		public CrmBoolean sgt_ranglijsttoernooien
		{
			get
			{
				return this.sgt_ranglijsttoernooienField;
			}
			set
			{
				this.sgt_ranglijsttoernooienField = value;
			}
		}
		public CrmBoolean sgt_schema_grootte
		{
			get
			{
				return this.sgt_schema_grootteField;
			}
			set
			{
				this.sgt_schema_grootteField = value;
			}
		}
		public CrmBoolean sgt_soort_bal
		{
			get
			{
				return this.sgt_soort_balField;
			}
			set
			{
				this.sgt_soort_balField = value;
			}
		}
		public string sgt_sourcekey
		{
			get
			{
				return this.sgt_sourcekeyField;
			}
			set
			{
				this.sgt_sourcekeyField = value;
			}
		}
		public CrmBoolean sgt_special_exempts
		{
			get
			{
				return this.sgt_special_exemptsField;
			}
			set
			{
				this.sgt_special_exemptsField = value;
			}
		}
		public CrmBoolean sgt_speler_moet_rechten_hebben
		{
			get
			{
				return this.sgt_speler_moet_rechten_hebbenField;
			}
			set
			{
				this.sgt_speler_moet_rechten_hebbenField = value;
			}
		}
		public Lookup sgt_telmethode_id
		{
			get
			{
				return this.sgt_telmethode_idField;
			}
			set
			{
				this.sgt_telmethode_idField = value;
			}
		}
		public CrmBoolean sgt_toe_interfaces
		{
			get
			{
				return this.sgt_toe_interfacesField;
			}
			set
			{
				this.sgt_toe_interfacesField = value;
			}
		}
		[XmlElement("sgt_toe_toernooisoort")]
		public string sgt_toe_toernooisoort1
		{
			get
			{
				return this.sgt_toe_toernooisoort1Field;
			}
			set
			{
				this.sgt_toe_toernooisoort1Field = value;
			}
		}
		public Key sgt_toe_toernooisoortid
		{
			get
			{
				return this.sgt_toe_toernooisoortidField;
			}
			set
			{
				this.sgt_toe_toernooisoortidField = value;
			}
		}
		public CrmBoolean sgt_toernooi
		{
			get
			{
				return this.sgt_toernooiField;
			}
			set
			{
				this.sgt_toernooiField = value;
			}
		}
		public Lookup sgt_toernooi_groepid
		{
			get
			{
				return this.sgt_toernooi_groepidField;
			}
			set
			{
				this.sgt_toernooi_groepidField = value;
			}
		}
		public Picklist sgt_type_categoriespeler
		{
			get
			{
				return this.sgt_type_categoriespelerField;
			}
			set
			{
				this.sgt_type_categoriespelerField = value;
			}
		}
		public Picklist sgt_type_leeftijd_bepaling
		{
			get
			{
				return this.sgt_type_leeftijd_bepalingField;
			}
			set
			{
				this.sgt_type_leeftijd_bepalingField = value;
			}
		}
		public string sgt_verkorte_code
		{
			get
			{
				return this.sgt_verkorte_codeField;
			}
			set
			{
				this.sgt_verkorte_codeField = value;
			}
		}
		public CrmBoolean sgt_wildcards
		{
			get
			{
				return this.sgt_wildcardsField;
			}
			set
			{
				this.sgt_wildcardsField = value;
			}
		}
		public Sgt_toe_toernooisoortStateInfo statecode
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
