using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
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
		[XmlElement(Order = 0)]
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
		[XmlElement(Order = 1)]
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
		[XmlElement(Order = 2)]
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
		[XmlElement(Order = 3)]
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
		[XmlElement(Order = 4)]
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
		[XmlElement(Order = 5)]
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
		[XmlElement(Order = 6)]
		public Lookup organizationid
		{
			get
			{
				return this.organizationidField;
			}
			set
			{
				this.organizationidField = value;
				base.RaisePropertyChanged("organizationid");
			}
		}
		[XmlElement(Order = 7)]
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
		[XmlElement(Order = 8)]
		public CrmBoolean sgt_aantal_categorie_spelers
		{
			get
			{
				return this.sgt_aantal_categorie_spelersField;
			}
			set
			{
				this.sgt_aantal_categorie_spelersField = value;
				base.RaisePropertyChanged("sgt_aantal_categorie_spelers");
			}
		}
		[XmlElement(Order = 9)]
		public CrmNumber sgt_aantal_dagen_resultaten_tonen
		{
			get
			{
				return this.sgt_aantal_dagen_resultaten_tonenField;
			}
			set
			{
				this.sgt_aantal_dagen_resultaten_tonenField = value;
				base.RaisePropertyChanged("sgt_aantal_dagen_resultaten_tonen");
			}
		}
		[XmlElement(Order = 10)]
		public CrmBoolean sgt_aantal_deelnemers
		{
			get
			{
				return this.sgt_aantal_deelnemersField;
			}
			set
			{
				this.sgt_aantal_deelnemersField = value;
				base.RaisePropertyChanged("sgt_aantal_deelnemers");
			}
		}
		[XmlElement(Order = 11)]
		public CrmNumber sgt_aantal_jaar_zelfde_hs
		{
			get
			{
				return this.sgt_aantal_jaar_zelfde_hsField;
			}
			set
			{
				this.sgt_aantal_jaar_zelfde_hsField = value;
				base.RaisePropertyChanged("sgt_aantal_jaar_zelfde_hs");
			}
		}
		[XmlElement(Order = 12)]
		public Picklist sgt_acceptatie
		{
			get
			{
				return this.sgt_acceptatieField;
			}
			set
			{
				this.sgt_acceptatieField = value;
				base.RaisePropertyChanged("sgt_acceptatie");
			}
		}
		[XmlElement(Order = 13)]
		public string sgt_afmeldings_procedure
		{
			get
			{
				return this.sgt_afmeldings_procedureField;
			}
			set
			{
				this.sgt_afmeldings_procedureField = value;
				base.RaisePropertyChanged("sgt_afmeldings_procedure");
			}
		}
		[XmlElement(Order = 14)]
		public Picklist sgt_arbitrageniveau
		{
			get
			{
				return this.sgt_arbitrageniveauField;
			}
			set
			{
				this.sgt_arbitrageniveauField = value;
				base.RaisePropertyChanged("sgt_arbitrageniveau");
			}
		}
		[XmlElement(Order = 15)]
		public string sgt_beschrijving
		{
			get
			{
				return this.sgt_beschrijvingField;
			}
			set
			{
				this.sgt_beschrijvingField = value;
				base.RaisePropertyChanged("sgt_beschrijving");
			}
		}
		[XmlElement(Order = 16)]
		public string sgt_bijzonderheden
		{
			get
			{
				return this.sgt_bijzonderhedenField;
			}
			set
			{
				this.sgt_bijzonderhedenField = value;
				base.RaisePropertyChanged("sgt_bijzonderheden");
			}
		}
		[XmlElement(Order = 17)]
		public Lookup sgt_combi_toernooisoortid
		{
			get
			{
				return this.sgt_combi_toernooisoortidField;
			}
			set
			{
				this.sgt_combi_toernooisoortidField = value;
				base.RaisePropertyChanged("sgt_combi_toernooisoortid");
			}
		}
		[XmlElement(Order = 18)]
		public CrmBoolean sgt_combinatie_toernooi
		{
			get
			{
				return this.sgt_combinatie_toernooiField;
			}
			set
			{
				this.sgt_combinatie_toernooiField = value;
				base.RaisePropertyChanged("sgt_combinatie_toernooi");
			}
		}
		[XmlElement(Order = 19)]
		public CrmBoolean sgt_controle_dubbel
		{
			get
			{
				return this.sgt_controle_dubbelField;
			}
			set
			{
				this.sgt_controle_dubbelField = value;
				base.RaisePropertyChanged("sgt_controle_dubbel");
			}
		}
		[XmlElement(Order = 20)]
		public CrmBoolean sgt_controle_op_leeftijdscategorie
		{
			get
			{
				return this.sgt_controle_op_leeftijdscategorieField;
			}
			set
			{
				this.sgt_controle_op_leeftijdscategorieField = value;
				base.RaisePropertyChanged("sgt_controle_op_leeftijdscategorie");
			}
		}
		[XmlElement(Order = 21)]
		public CrmBoolean sgt_controle_op_speelsterkte_categorie
		{
			get
			{
				return this.sgt_controle_op_speelsterkte_categorieField;
			}
			set
			{
				this.sgt_controle_op_speelsterkte_categorieField = value;
				base.RaisePropertyChanged("sgt_controle_op_speelsterkte_categorie");
			}
		}
		[XmlElement(Order = 22)]
		public CrmBoolean sgt_dagtoernooi
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
		[XmlElement(Order = 23)]
		public Lookup sgt_default_ranglijst_to_id
		{
			get
			{
				return this.sgt_default_ranglijst_to_idField;
			}
			set
			{
				this.sgt_default_ranglijst_to_idField = value;
				base.RaisePropertyChanged("sgt_default_ranglijst_to_id");
			}
		}
		[XmlElement(Order = 24)]
		public CrmBoolean sgt_dss
		{
			get
			{
				return this.sgt_dssField;
			}
			set
			{
				this.sgt_dssField = value;
				base.RaisePropertyChanged("sgt_dss");
			}
		}
		[XmlElement(Order = 25)]
		public CrmBoolean sgt_email_bij_acceptatie
		{
			get
			{
				return this.sgt_email_bij_acceptatieField;
			}
			set
			{
				this.sgt_email_bij_acceptatieField = value;
				base.RaisePropertyChanged("sgt_email_bij_acceptatie");
			}
		}
		[XmlElement(Order = 26)]
		public CrmBoolean sgt_email_bij_inschrijving_wijzigen_annuleren
		{
			get
			{
				return this.sgt_email_bij_inschrijving_wijzigen_annulerenField;
			}
			set
			{
				this.sgt_email_bij_inschrijving_wijzigen_annulerenField = value;
				base.RaisePropertyChanged("sgt_email_bij_inschrijving_wijzigen_annuleren");
			}
		}
		[XmlElement(Order = 27)]
		public CrmBoolean sgt_email_bij_niet_accepteren
		{
			get
			{
				return this.sgt_email_bij_niet_accepterenField;
			}
			set
			{
				this.sgt_email_bij_niet_accepterenField = value;
				base.RaisePropertyChanged("sgt_email_bij_niet_accepteren");
			}
		}
		[XmlElement(Order = 28)]
		public CrmBoolean sgt_email_bij_uitnodigen_jn
		{
			get
			{
				return this.sgt_email_bij_uitnodigen_jnField;
			}
			set
			{
				this.sgt_email_bij_uitnodigen_jnField = value;
				base.RaisePropertyChanged("sgt_email_bij_uitnodigen_jn");
			}
		}
		[XmlElement(Order = 29)]
		public CrmBoolean sgt_email_inschrijf_termijn_verstreken
		{
			get
			{
				return this.sgt_email_inschrijf_termijn_verstrekenField;
			}
			set
			{
				this.sgt_email_inschrijf_termijn_verstrekenField = value;
				base.RaisePropertyChanged("sgt_email_inschrijf_termijn_verstreken");
			}
		}
		[XmlElement(Order = 30)]
		public CrmBoolean sgt_geboortejaar_weergeven
		{
			get
			{
				return this.sgt_geboortejaar_weergevenField;
			}
			set
			{
				this.sgt_geboortejaar_weergevenField = value;
				base.RaisePropertyChanged("sgt_geboortejaar_weergeven");
			}
		}
		[XmlElement(Order = 31)]
		public CrmMoney sgt_handlingsfee_maximum
		{
			get
			{
				return this.sgt_handlingsfee_maximumField;
			}
			set
			{
				this.sgt_handlingsfee_maximumField = value;
				base.RaisePropertyChanged("sgt_handlingsfee_maximum");
			}
		}
		[XmlElement(Order = 32)]
		public CrmMoney sgt_handlingsfee_maximum_base
		{
			get
			{
				return this.sgt_handlingsfee_maximum_baseField;
			}
			set
			{
				this.sgt_handlingsfee_maximum_baseField = value;
				base.RaisePropertyChanged("sgt_handlingsfee_maximum_base");
			}
		}
		[XmlElement(Order = 33)]
		public CrmDecimal sgt_handlingsfee_percentage
		{
			get
			{
				return this.sgt_handlingsfee_percentageField;
			}
			set
			{
				this.sgt_handlingsfee_percentageField = value;
				base.RaisePropertyChanged("sgt_handlingsfee_percentage");
			}
		}
		[XmlElement(Order = 34)]
		public CrmBoolean sgt_handlingsfee_toepassen
		{
			get
			{
				return this.sgt_handlingsfee_toepassenField;
			}
			set
			{
				this.sgt_handlingsfee_toepassenField = value;
				base.RaisePropertyChanged("sgt_handlingsfee_toepassen");
			}
		}
		[XmlElement(Order = 35)]
		public CrmBoolean sgt_incomplete_inschrijving_dubbelspel
		{
			get
			{
				return this.sgt_incomplete_inschrijving_dubbelspelField;
			}
			set
			{
				this.sgt_incomplete_inschrijving_dubbelspelField = value;
				base.RaisePropertyChanged("sgt_incomplete_inschrijving_dubbelspel");
			}
		}
		[XmlElement(Order = 36)]
		public Lookup sgt_inschrijfmethodeid
		{
			get
			{
				return this.sgt_inschrijfmethodeidField;
			}
			set
			{
				this.sgt_inschrijfmethodeidField = value;
				base.RaisePropertyChanged("sgt_inschrijfmethodeid");
			}
		}
		[XmlElement(Order = 37)]
		public CrmBoolean sgt_inschrijven_dubbel_via_mijnknltb
		{
			get
			{
				return this.sgt_inschrijven_dubbel_via_mijnknltbField;
			}
			set
			{
				this.sgt_inschrijven_dubbel_via_mijnknltbField = value;
				base.RaisePropertyChanged("sgt_inschrijven_dubbel_via_mijnknltb");
			}
		}
		[XmlElement(Order = 38)]
		public CrmBoolean sgt_inschrijven_dubbel_via_organisator
		{
			get
			{
				return this.sgt_inschrijven_dubbel_via_organisatorField;
			}
			set
			{
				this.sgt_inschrijven_dubbel_via_organisatorField = value;
				base.RaisePropertyChanged("sgt_inschrijven_dubbel_via_organisator");
			}
		}
		[XmlElement(Order = 39)]
		public CrmBoolean sgt_inschrijven_dubbel_via_vereniging
		{
			get
			{
				return this.sgt_inschrijven_dubbel_via_verenigingField;
			}
			set
			{
				this.sgt_inschrijven_dubbel_via_verenigingField = value;
				base.RaisePropertyChanged("sgt_inschrijven_dubbel_via_vereniging");
			}
		}
		[XmlElement(Order = 40)]
		public CrmBoolean sgt_inschrijven_enkel_via_mijnknltb
		{
			get
			{
				return this.sgt_inschrijven_enkel_via_mijnknltbField;
			}
			set
			{
				this.sgt_inschrijven_enkel_via_mijnknltbField = value;
				base.RaisePropertyChanged("sgt_inschrijven_enkel_via_mijnknltb");
			}
		}
		[XmlElement(Order = 41)]
		public CrmBoolean sgt_inschrijven_enkel_via_toernooiorganisator
		{
			get
			{
				return this.sgt_inschrijven_enkel_via_toernooiorganisatorField;
			}
			set
			{
				this.sgt_inschrijven_enkel_via_toernooiorganisatorField = value;
				base.RaisePropertyChanged("sgt_inschrijven_enkel_via_toernooiorganisator");
			}
		}
		[XmlElement(Order = 42)]
		public CrmBoolean sgt_inschrijven_enkel_via_vereniging
		{
			get
			{
				return this.sgt_inschrijven_enkel_via_verenigingField;
			}
			set
			{
				this.sgt_inschrijven_enkel_via_verenigingField = value;
				base.RaisePropertyChanged("sgt_inschrijven_enkel_via_vereniging");
			}
		}
		[XmlElement(Order = 43)]
		public Picklist sgt_inschrijven_op_toernooi
		{
			get
			{
				return this.sgt_inschrijven_op_toernooiField;
			}
			set
			{
				this.sgt_inschrijven_op_toernooiField = value;
				base.RaisePropertyChanged("sgt_inschrijven_op_toernooi");
			}
		}
		[XmlElement(Order = 44)]
		public Picklist sgt_keuze_of_inschrijving
		{
			get
			{
				return this.sgt_keuze_of_inschrijvingField;
			}
			set
			{
				this.sgt_keuze_of_inschrijvingField = value;
				base.RaisePropertyChanged("sgt_keuze_of_inschrijving");
			}
		}
		[XmlElement(Order = 45)]
		public CrmBoolean sgt_kwalificanten
		{
			get
			{
				return this.sgt_kwalificantenField;
			}
			set
			{
				this.sgt_kwalificantenField = value;
				base.RaisePropertyChanged("sgt_kwalificanten");
			}
		}
		[XmlElement(Order = 46)]
		public string sgt_meervoudsnaam
		{
			get
			{
				return this.sgt_meervoudsnaamField;
			}
			set
			{
				this.sgt_meervoudsnaamField = value;
				base.RaisePropertyChanged("sgt_meervoudsnaam");
			}
		}
		[XmlElement(Order = 47)]
		public Picklist sgt_methode_automatisch_accepteren
		{
			get
			{
				return this.sgt_methode_automatisch_accepterenField;
			}
			set
			{
				this.sgt_methode_automatisch_accepterenField = value;
				base.RaisePropertyChanged("sgt_methode_automatisch_accepteren");
			}
		}
		[XmlElement(Order = 48)]
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
		[XmlElement(Order = 49)]
		public CrmBoolean sgt_ondergrond
		{
			get
			{
				return this.sgt_ondergrondField;
			}
			set
			{
				this.sgt_ondergrondField = value;
				base.RaisePropertyChanged("sgt_ondergrond");
			}
		}
		[XmlElement(Order = 50)]
		public CrmMoney sgt_ot_bijdrage_circuit
		{
			get
			{
				return this.sgt_ot_bijdrage_circuitField;
			}
			set
			{
				this.sgt_ot_bijdrage_circuitField = value;
				base.RaisePropertyChanged("sgt_ot_bijdrage_circuit");
			}
		}
		[XmlElement(Order = 51)]
		public CrmMoney sgt_ot_bijdrage_circuit_base
		{
			get
			{
				return this.sgt_ot_bijdrage_circuit_baseField;
			}
			set
			{
				this.sgt_ot_bijdrage_circuit_baseField = value;
				base.RaisePropertyChanged("sgt_ot_bijdrage_circuit_base");
			}
		}
		[XmlElement(Order = 52)]
		public CrmMoney sgt_ot_handlingsfee
		{
			get
			{
				return this.sgt_ot_handlingsfeeField;
			}
			set
			{
				this.sgt_ot_handlingsfeeField = value;
				base.RaisePropertyChanged("sgt_ot_handlingsfee");
			}
		}
		[XmlElement(Order = 53)]
		public CrmMoney sgt_ot_handlingsfee_base
		{
			get
			{
				return this.sgt_ot_handlingsfee_baseField;
			}
			set
			{
				this.sgt_ot_handlingsfee_baseField = value;
				base.RaisePropertyChanged("sgt_ot_handlingsfee_base");
			}
		}
		[XmlElement(Order = 54)]
		public CrmMoney sgt_ot_inschrijfbijdrage
		{
			get
			{
				return this.sgt_ot_inschrijfbijdrageField;
			}
			set
			{
				this.sgt_ot_inschrijfbijdrageField = value;
				base.RaisePropertyChanged("sgt_ot_inschrijfbijdrage");
			}
		}
		[XmlElement(Order = 55)]
		public CrmMoney sgt_ot_inschrijfbijdrage_base
		{
			get
			{
				return this.sgt_ot_inschrijfbijdrage_baseField;
			}
			set
			{
				this.sgt_ot_inschrijfbijdrage_baseField = value;
				base.RaisePropertyChanged("sgt_ot_inschrijfbijdrage_base");
			}
		}
		[XmlElement(Order = 56)]
		public CrmMoney sgt_ot_restitutiebedrag_bc_annuleren
		{
			get
			{
				return this.sgt_ot_restitutiebedrag_bc_annulerenField;
			}
			set
			{
				this.sgt_ot_restitutiebedrag_bc_annulerenField = value;
				base.RaisePropertyChanged("sgt_ot_restitutiebedrag_bc_annuleren");
			}
		}
		[XmlElement(Order = 57)]
		public CrmMoney sgt_ot_restitutiebedrag_bc_annuleren_base
		{
			get
			{
				return this.sgt_ot_restitutiebedrag_bc_annuleren_baseField;
			}
			set
			{
				this.sgt_ot_restitutiebedrag_bc_annuleren_baseField = value;
				base.RaisePropertyChanged("sgt_ot_restitutiebedrag_bc_annuleren_base");
			}
		}
		[XmlElement(Order = 58)]
		public CrmMoney sgt_ot_restitutiebedrag_bc_dispensatie
		{
			get
			{
				return this.sgt_ot_restitutiebedrag_bc_dispensatieField;
			}
			set
			{
				this.sgt_ot_restitutiebedrag_bc_dispensatieField = value;
				base.RaisePropertyChanged("sgt_ot_restitutiebedrag_bc_dispensatie");
			}
		}
		[XmlElement(Order = 59)]
		public CrmMoney sgt_ot_restitutiebedrag_bc_dispensatie_base
		{
			get
			{
				return this.sgt_ot_restitutiebedrag_bc_dispensatie_baseField;
			}
			set
			{
				this.sgt_ot_restitutiebedrag_bc_dispensatie_baseField = value;
				base.RaisePropertyChanged("sgt_ot_restitutiebedrag_bc_dispensatie_base");
			}
		}
		[XmlElement(Order = 60)]
		public CrmMoney sgt_ot_restitutiebedrag_hf_annuleren
		{
			get
			{
				return this.sgt_ot_restitutiebedrag_hf_annulerenField;
			}
			set
			{
				this.sgt_ot_restitutiebedrag_hf_annulerenField = value;
				base.RaisePropertyChanged("sgt_ot_restitutiebedrag_hf_annuleren");
			}
		}
		[XmlElement(Order = 61)]
		public CrmMoney sgt_ot_restitutiebedrag_hf_annuleren_base
		{
			get
			{
				return this.sgt_ot_restitutiebedrag_hf_annuleren_baseField;
			}
			set
			{
				this.sgt_ot_restitutiebedrag_hf_annuleren_baseField = value;
				base.RaisePropertyChanged("sgt_ot_restitutiebedrag_hf_annuleren_base");
			}
		}
		[XmlElement(Order = 62)]
		public CrmMoney sgt_ot_restitutiebedrag_ib_annuleren
		{
			get
			{
				return this.sgt_ot_restitutiebedrag_ib_annulerenField;
			}
			set
			{
				this.sgt_ot_restitutiebedrag_ib_annulerenField = value;
				base.RaisePropertyChanged("sgt_ot_restitutiebedrag_ib_annuleren");
			}
		}
		[XmlElement(Order = 63)]
		public CrmMoney sgt_ot_restitutiebedrag_ib_annuleren_base
		{
			get
			{
				return this.sgt_ot_restitutiebedrag_ib_annuleren_baseField;
			}
			set
			{
				this.sgt_ot_restitutiebedrag_ib_annuleren_baseField = value;
				base.RaisePropertyChanged("sgt_ot_restitutiebedrag_ib_annuleren_base");
			}
		}
		[XmlElement(Order = 64)]
		public CrmMoney sgt_ot_restitutiebedrag_ib_dispensatie
		{
			get
			{
				return this.sgt_ot_restitutiebedrag_ib_dispensatieField;
			}
			set
			{
				this.sgt_ot_restitutiebedrag_ib_dispensatieField = value;
				base.RaisePropertyChanged("sgt_ot_restitutiebedrag_ib_dispensatie");
			}
		}
		[XmlElement(Order = 65)]
		public CrmMoney sgt_ot_restitutiebedrag_ib_dispensatie_base
		{
			get
			{
				return this.sgt_ot_restitutiebedrag_ib_dispensatie_baseField;
			}
			set
			{
				this.sgt_ot_restitutiebedrag_ib_dispensatie_baseField = value;
				base.RaisePropertyChanged("sgt_ot_restitutiebedrag_ib_dispensatie_base");
			}
		}
		[XmlElement(Order = 66)]
		public CrmBoolean sgt_prijzengeld
		{
			get
			{
				return this.sgt_prijzengeldField;
			}
			set
			{
				this.sgt_prijzengeldField = value;
				base.RaisePropertyChanged("sgt_prijzengeld");
			}
		}
		[XmlElement(Order = 67)]
		public CrmBoolean sgt_ranglijst_positie_weergeven
		{
			get
			{
				return this.sgt_ranglijst_positie_weergevenField;
			}
			set
			{
				this.sgt_ranglijst_positie_weergevenField = value;
				base.RaisePropertyChanged("sgt_ranglijst_positie_weergeven");
			}
		}
		[XmlElement(Order = 68)]
		public CrmBoolean sgt_ranglijst_verplicht_voor_inschrijving
		{
			get
			{
				return this.sgt_ranglijst_verplicht_voor_inschrijvingField;
			}
			set
			{
				this.sgt_ranglijst_verplicht_voor_inschrijvingField = value;
				base.RaisePropertyChanged("sgt_ranglijst_verplicht_voor_inschrijving");
			}
		}
		[XmlElement(Order = 69)]
		public CrmBoolean sgt_ranglijsttoernooien
		{
			get
			{
				return this.sgt_ranglijsttoernooienField;
			}
			set
			{
				this.sgt_ranglijsttoernooienField = value;
				base.RaisePropertyChanged("sgt_ranglijsttoernooien");
			}
		}
		[XmlElement(Order = 70)]
		public CrmBoolean sgt_schema_grootte
		{
			get
			{
				return this.sgt_schema_grootteField;
			}
			set
			{
				this.sgt_schema_grootteField = value;
				base.RaisePropertyChanged("sgt_schema_grootte");
			}
		}
		[XmlElement(Order = 71)]
		public CrmBoolean sgt_soort_bal
		{
			get
			{
				return this.sgt_soort_balField;
			}
			set
			{
				this.sgt_soort_balField = value;
				base.RaisePropertyChanged("sgt_soort_bal");
			}
		}
		[XmlElement(Order = 72)]
		public string sgt_sourcekey
		{
			get
			{
				return this.sgt_sourcekeyField;
			}
			set
			{
				this.sgt_sourcekeyField = value;
				base.RaisePropertyChanged("sgt_sourcekey");
			}
		}
		[XmlElement(Order = 73)]
		public CrmBoolean sgt_special_exempts
		{
			get
			{
				return this.sgt_special_exemptsField;
			}
			set
			{
				this.sgt_special_exemptsField = value;
				base.RaisePropertyChanged("sgt_special_exempts");
			}
		}
		[XmlElement(Order = 74)]
		public CrmBoolean sgt_speler_moet_rechten_hebben
		{
			get
			{
				return this.sgt_speler_moet_rechten_hebbenField;
			}
			set
			{
				this.sgt_speler_moet_rechten_hebbenField = value;
				base.RaisePropertyChanged("sgt_speler_moet_rechten_hebben");
			}
		}
		[XmlElement(Order = 75)]
		public Lookup sgt_telmethode_id
		{
			get
			{
				return this.sgt_telmethode_idField;
			}
			set
			{
				this.sgt_telmethode_idField = value;
				base.RaisePropertyChanged("sgt_telmethode_id");
			}
		}
		[XmlElement(Order = 76)]
		public CrmBoolean sgt_toe_interfaces
		{
			get
			{
				return this.sgt_toe_interfacesField;
			}
			set
			{
				this.sgt_toe_interfacesField = value;
				base.RaisePropertyChanged("sgt_toe_interfaces");
			}
		}
		[XmlElement("sgt_toe_toernooisoort", Order = 77)]
		public string sgt_toe_toernooisoort1
		{
			get
			{
				return this.sgt_toe_toernooisoort1Field;
			}
			set
			{
				this.sgt_toe_toernooisoort1Field = value;
				base.RaisePropertyChanged("sgt_toe_toernooisoort1");
			}
		}
		[XmlElement(Order = 78)]
		public Key sgt_toe_toernooisoortid
		{
			get
			{
				return this.sgt_toe_toernooisoortidField;
			}
			set
			{
				this.sgt_toe_toernooisoortidField = value;
				base.RaisePropertyChanged("sgt_toe_toernooisoortid");
			}
		}
		[XmlElement(Order = 79)]
		public CrmBoolean sgt_toernooi
		{
			get
			{
				return this.sgt_toernooiField;
			}
			set
			{
				this.sgt_toernooiField = value;
				base.RaisePropertyChanged("sgt_toernooi");
			}
		}
		[XmlElement(Order = 80)]
		public Lookup sgt_toernooi_groepid
		{
			get
			{
				return this.sgt_toernooi_groepidField;
			}
			set
			{
				this.sgt_toernooi_groepidField = value;
				base.RaisePropertyChanged("sgt_toernooi_groepid");
			}
		}
		[XmlElement(Order = 81)]
		public Picklist sgt_type_categoriespeler
		{
			get
			{
				return this.sgt_type_categoriespelerField;
			}
			set
			{
				this.sgt_type_categoriespelerField = value;
				base.RaisePropertyChanged("sgt_type_categoriespeler");
			}
		}
		[XmlElement(Order = 82)]
		public Picklist sgt_type_leeftijd_bepaling
		{
			get
			{
				return this.sgt_type_leeftijd_bepalingField;
			}
			set
			{
				this.sgt_type_leeftijd_bepalingField = value;
				base.RaisePropertyChanged("sgt_type_leeftijd_bepaling");
			}
		}
		[XmlElement(Order = 83)]
		public string sgt_verkorte_code
		{
			get
			{
				return this.sgt_verkorte_codeField;
			}
			set
			{
				this.sgt_verkorte_codeField = value;
				base.RaisePropertyChanged("sgt_verkorte_code");
			}
		}
		[XmlElement(Order = 84)]
		public CrmBoolean sgt_wildcards
		{
			get
			{
				return this.sgt_wildcardsField;
			}
			set
			{
				this.sgt_wildcardsField = value;
				base.RaisePropertyChanged("sgt_wildcards");
			}
		}
		[XmlElement(Order = 85)]
		public Sgt_toe_toernooisoortStateInfo statecode
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
		[XmlElement(Order = 86)]
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
		[XmlElement(Order = 87)]
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
		[XmlElement(Order = 88)]
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
		[XmlElement(Order = 89)]
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
	}
}
