using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_top_geselecteerd_tennisser : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private string sgt_2e_sportField;
		private CrmBoolean sgt_aanhef_ouders_verzorgers_vanField;
		private CrmBoolean sgt_aanpassenField;
		private string sgt_achternaamField;
		private CrmBoolean sgt_adl_accuField;
		private CrmDecimal sgt_adl_gewichtField;
		private CrmBoolean sgt_adl_handmatig_bewogenField;
		private CrmBoolean sgt_adl_inklapbaarField;
		private CrmDecimal sgt_adl_omvang_breedteField;
		private CrmDecimal sgt_adl_omvang_hoogteField;
		private CrmDecimal sgt_adl_omvang_lengteField;
		private string sgt_adres_schoolField;
		private string sgt_bijzonderhedenField;
		private string sgt_contactpersoonField;
		private CrmDateTime sgt_datum_accoordField;
		private CrmDateTime sgt_datum_keuringField;
		private Lookup sgt_districtidField;
		private string sgt_emailField;
		private string sgt_extra_infoField;
		private CrmDateTime sgt_geboortedatumField;
		private Picklist sgt_geslachtField;
		private CrmDateTime sgt_heeft_les_sindsField;
		private string sgt_ipin_numberField;
		private Picklist sgt_keuzeField;
		private string sgt_klas_groepField;
		private Picklist sgt_klasseField;
		private string sgt_kledingsponsorField;
		private string sgt_maat_kostuumField;
		private Picklist sgt_maat_loopschoenField;
		private string sgt_maat_rok_shortField;
		private Picklist sgt_maat_tennisschoenField;
		private string sgt_maat_trainingspakField;
		private string sgt_maat_trui_poloField;
		private string sgt_meest_recente_competitie_deelnameField;
		private string sgt_naam_automatische_incassoField;
		private string sgt_naam_schoolField;
		private Picklist sgt_onderwijstypeField;
		private string sgt_opmerking_keuringField;
		private string sgt_opmerking_oudersField;
		private Lookup sgt_persoonidField;
		private Lookup sgt_predicaat_idField;
		private Lookup sgt_predicaatidField;
		private string sgt_rekening_automatische_incassoField;
		private string sgt_roepnaamField;
		private Picklist sgt_seizoenField;
		private Picklist sgt_soort_onderwijsField;
		private CrmBoolean sgt_speelhandField;
		private CrmBoolean sgt_sponsorpatch_op_shirtField;
		private CrmBoolean sgt_srs_accuField;
		private CrmDecimal sgt_srs_gewichtField;
		private CrmBoolean sgt_srs_handmatig_bewogenField;
		private CrmBoolean sgt_srs_inklapbaarField;
		private CrmDecimal sgt_srs_omvang_breedteField;
		private CrmDecimal sgt_srs_omvang_hoogteField;
		private CrmDecimal sgt_srs_omvang_lengteField;
		private Picklist sgt_status_contractField;
		private Picklist sgt_status_spelerField;
		private string sgt_telefoonField;
		private CrmBoolean sgt_termijnbetalingField;
		private string sgt_top_geselecteerd_tennisser1Field;
		private Key sgt_top_geselecteerd_tennisseridField;
		private string sgt_tussenvoegselField;
		private Lookup sgt_type_tennisseridField;
		private string sgt_woonplaats_automatische_incassoField;
		private Sgt_top_geselecteerd_tennisserStateInfo statecodeField;
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
		public string sgt_2e_sport
		{
			get
			{
				return this.sgt_2e_sportField;
			}
			set
			{
				this.sgt_2e_sportField = value;
			}
		}
		public CrmBoolean sgt_aanhef_ouders_verzorgers_van
		{
			get
			{
				return this.sgt_aanhef_ouders_verzorgers_vanField;
			}
			set
			{
				this.sgt_aanhef_ouders_verzorgers_vanField = value;
			}
		}
		public CrmBoolean sgt_aanpassen
		{
			get
			{
				return this.sgt_aanpassenField;
			}
			set
			{
				this.sgt_aanpassenField = value;
			}
		}
		public string sgt_achternaam
		{
			get
			{
				return this.sgt_achternaamField;
			}
			set
			{
				this.sgt_achternaamField = value;
			}
		}
		public CrmBoolean sgt_adl_accu
		{
			get
			{
				return this.sgt_adl_accuField;
			}
			set
			{
				this.sgt_adl_accuField = value;
			}
		}
		public CrmDecimal sgt_adl_gewicht
		{
			get
			{
				return this.sgt_adl_gewichtField;
			}
			set
			{
				this.sgt_adl_gewichtField = value;
			}
		}
		public CrmBoolean sgt_adl_handmatig_bewogen
		{
			get
			{
				return this.sgt_adl_handmatig_bewogenField;
			}
			set
			{
				this.sgt_adl_handmatig_bewogenField = value;
			}
		}
		public CrmBoolean sgt_adl_inklapbaar
		{
			get
			{
				return this.sgt_adl_inklapbaarField;
			}
			set
			{
				this.sgt_adl_inklapbaarField = value;
			}
		}
		public CrmDecimal sgt_adl_omvang_breedte
		{
			get
			{
				return this.sgt_adl_omvang_breedteField;
			}
			set
			{
				this.sgt_adl_omvang_breedteField = value;
			}
		}
		public CrmDecimal sgt_adl_omvang_hoogte
		{
			get
			{
				return this.sgt_adl_omvang_hoogteField;
			}
			set
			{
				this.sgt_adl_omvang_hoogteField = value;
			}
		}
		public CrmDecimal sgt_adl_omvang_lengte
		{
			get
			{
				return this.sgt_adl_omvang_lengteField;
			}
			set
			{
				this.sgt_adl_omvang_lengteField = value;
			}
		}
		public string sgt_adres_school
		{
			get
			{
				return this.sgt_adres_schoolField;
			}
			set
			{
				this.sgt_adres_schoolField = value;
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
		public string sgt_contactpersoon
		{
			get
			{
				return this.sgt_contactpersoonField;
			}
			set
			{
				this.sgt_contactpersoonField = value;
			}
		}
		public CrmDateTime sgt_datum_accoord
		{
			get
			{
				return this.sgt_datum_accoordField;
			}
			set
			{
				this.sgt_datum_accoordField = value;
			}
		}
		public CrmDateTime sgt_datum_keuring
		{
			get
			{
				return this.sgt_datum_keuringField;
			}
			set
			{
				this.sgt_datum_keuringField = value;
			}
		}
		public Lookup sgt_districtid
		{
			get
			{
				return this.sgt_districtidField;
			}
			set
			{
				this.sgt_districtidField = value;
			}
		}
		public string sgt_email
		{
			get
			{
				return this.sgt_emailField;
			}
			set
			{
				this.sgt_emailField = value;
			}
		}
		public string sgt_extra_info
		{
			get
			{
				return this.sgt_extra_infoField;
			}
			set
			{
				this.sgt_extra_infoField = value;
			}
		}
		public CrmDateTime sgt_geboortedatum
		{
			get
			{
				return this.sgt_geboortedatumField;
			}
			set
			{
				this.sgt_geboortedatumField = value;
			}
		}
		public Picklist sgt_geslacht
		{
			get
			{
				return this.sgt_geslachtField;
			}
			set
			{
				this.sgt_geslachtField = value;
			}
		}
		public CrmDateTime sgt_heeft_les_sinds
		{
			get
			{
				return this.sgt_heeft_les_sindsField;
			}
			set
			{
				this.sgt_heeft_les_sindsField = value;
			}
		}
		public string sgt_ipin_number
		{
			get
			{
				return this.sgt_ipin_numberField;
			}
			set
			{
				this.sgt_ipin_numberField = value;
			}
		}
		public Picklist sgt_keuze
		{
			get
			{
				return this.sgt_keuzeField;
			}
			set
			{
				this.sgt_keuzeField = value;
			}
		}
		public string sgt_klas_groep
		{
			get
			{
				return this.sgt_klas_groepField;
			}
			set
			{
				this.sgt_klas_groepField = value;
			}
		}
		public Picklist sgt_klasse
		{
			get
			{
				return this.sgt_klasseField;
			}
			set
			{
				this.sgt_klasseField = value;
			}
		}
		public string sgt_kledingsponsor
		{
			get
			{
				return this.sgt_kledingsponsorField;
			}
			set
			{
				this.sgt_kledingsponsorField = value;
			}
		}
		public string sgt_maat_kostuum
		{
			get
			{
				return this.sgt_maat_kostuumField;
			}
			set
			{
				this.sgt_maat_kostuumField = value;
			}
		}
		public Picklist sgt_maat_loopschoen
		{
			get
			{
				return this.sgt_maat_loopschoenField;
			}
			set
			{
				this.sgt_maat_loopschoenField = value;
			}
		}
		public string sgt_maat_rok_short
		{
			get
			{
				return this.sgt_maat_rok_shortField;
			}
			set
			{
				this.sgt_maat_rok_shortField = value;
			}
		}
		public Picklist sgt_maat_tennisschoen
		{
			get
			{
				return this.sgt_maat_tennisschoenField;
			}
			set
			{
				this.sgt_maat_tennisschoenField = value;
			}
		}
		public string sgt_maat_trainingspak
		{
			get
			{
				return this.sgt_maat_trainingspakField;
			}
			set
			{
				this.sgt_maat_trainingspakField = value;
			}
		}
		public string sgt_maat_trui_polo
		{
			get
			{
				return this.sgt_maat_trui_poloField;
			}
			set
			{
				this.sgt_maat_trui_poloField = value;
			}
		}
		public string sgt_meest_recente_competitie_deelname
		{
			get
			{
				return this.sgt_meest_recente_competitie_deelnameField;
			}
			set
			{
				this.sgt_meest_recente_competitie_deelnameField = value;
			}
		}
		public string sgt_naam_automatische_incasso
		{
			get
			{
				return this.sgt_naam_automatische_incassoField;
			}
			set
			{
				this.sgt_naam_automatische_incassoField = value;
			}
		}
		public string sgt_naam_school
		{
			get
			{
				return this.sgt_naam_schoolField;
			}
			set
			{
				this.sgt_naam_schoolField = value;
			}
		}
		public Picklist sgt_onderwijstype
		{
			get
			{
				return this.sgt_onderwijstypeField;
			}
			set
			{
				this.sgt_onderwijstypeField = value;
			}
		}
		public string sgt_opmerking_keuring
		{
			get
			{
				return this.sgt_opmerking_keuringField;
			}
			set
			{
				this.sgt_opmerking_keuringField = value;
			}
		}
		public string sgt_opmerking_ouders
		{
			get
			{
				return this.sgt_opmerking_oudersField;
			}
			set
			{
				this.sgt_opmerking_oudersField = value;
			}
		}
		public Lookup sgt_persoonid
		{
			get
			{
				return this.sgt_persoonidField;
			}
			set
			{
				this.sgt_persoonidField = value;
			}
		}
		public Lookup sgt_predicaat_id
		{
			get
			{
				return this.sgt_predicaat_idField;
			}
			set
			{
				this.sgt_predicaat_idField = value;
			}
		}
		public Lookup sgt_predicaatid
		{
			get
			{
				return this.sgt_predicaatidField;
			}
			set
			{
				this.sgt_predicaatidField = value;
			}
		}
		public string sgt_rekening_automatische_incasso
		{
			get
			{
				return this.sgt_rekening_automatische_incassoField;
			}
			set
			{
				this.sgt_rekening_automatische_incassoField = value;
			}
		}
		public string sgt_roepnaam
		{
			get
			{
				return this.sgt_roepnaamField;
			}
			set
			{
				this.sgt_roepnaamField = value;
			}
		}
		public Picklist sgt_seizoen
		{
			get
			{
				return this.sgt_seizoenField;
			}
			set
			{
				this.sgt_seizoenField = value;
			}
		}
		public Picklist sgt_soort_onderwijs
		{
			get
			{
				return this.sgt_soort_onderwijsField;
			}
			set
			{
				this.sgt_soort_onderwijsField = value;
			}
		}
		public CrmBoolean sgt_speelhand
		{
			get
			{
				return this.sgt_speelhandField;
			}
			set
			{
				this.sgt_speelhandField = value;
			}
		}
		public CrmBoolean sgt_sponsorpatch_op_shirt
		{
			get
			{
				return this.sgt_sponsorpatch_op_shirtField;
			}
			set
			{
				this.sgt_sponsorpatch_op_shirtField = value;
			}
		}
		public CrmBoolean sgt_srs_accu
		{
			get
			{
				return this.sgt_srs_accuField;
			}
			set
			{
				this.sgt_srs_accuField = value;
			}
		}
		public CrmDecimal sgt_srs_gewicht
		{
			get
			{
				return this.sgt_srs_gewichtField;
			}
			set
			{
				this.sgt_srs_gewichtField = value;
			}
		}
		public CrmBoolean sgt_srs_handmatig_bewogen
		{
			get
			{
				return this.sgt_srs_handmatig_bewogenField;
			}
			set
			{
				this.sgt_srs_handmatig_bewogenField = value;
			}
		}
		public CrmBoolean sgt_srs_inklapbaar
		{
			get
			{
				return this.sgt_srs_inklapbaarField;
			}
			set
			{
				this.sgt_srs_inklapbaarField = value;
			}
		}
		public CrmDecimal sgt_srs_omvang_breedte
		{
			get
			{
				return this.sgt_srs_omvang_breedteField;
			}
			set
			{
				this.sgt_srs_omvang_breedteField = value;
			}
		}
		public CrmDecimal sgt_srs_omvang_hoogte
		{
			get
			{
				return this.sgt_srs_omvang_hoogteField;
			}
			set
			{
				this.sgt_srs_omvang_hoogteField = value;
			}
		}
		public CrmDecimal sgt_srs_omvang_lengte
		{
			get
			{
				return this.sgt_srs_omvang_lengteField;
			}
			set
			{
				this.sgt_srs_omvang_lengteField = value;
			}
		}
		public Picklist sgt_status_contract
		{
			get
			{
				return this.sgt_status_contractField;
			}
			set
			{
				this.sgt_status_contractField = value;
			}
		}
		public Picklist sgt_status_speler
		{
			get
			{
				return this.sgt_status_spelerField;
			}
			set
			{
				this.sgt_status_spelerField = value;
			}
		}
		public string sgt_telefoon
		{
			get
			{
				return this.sgt_telefoonField;
			}
			set
			{
				this.sgt_telefoonField = value;
			}
		}
		public CrmBoolean sgt_termijnbetaling
		{
			get
			{
				return this.sgt_termijnbetalingField;
			}
			set
			{
				this.sgt_termijnbetalingField = value;
			}
		}
		[XmlElement("sgt_top_geselecteerd_tennisser")]
		public string sgt_top_geselecteerd_tennisser1
		{
			get
			{
				return this.sgt_top_geselecteerd_tennisser1Field;
			}
			set
			{
				this.sgt_top_geselecteerd_tennisser1Field = value;
			}
		}
		public Key sgt_top_geselecteerd_tennisserid
		{
			get
			{
				return this.sgt_top_geselecteerd_tennisseridField;
			}
			set
			{
				this.sgt_top_geselecteerd_tennisseridField = value;
			}
		}
		public string sgt_tussenvoegsel
		{
			get
			{
				return this.sgt_tussenvoegselField;
			}
			set
			{
				this.sgt_tussenvoegselField = value;
			}
		}
		public Lookup sgt_type_tennisserid
		{
			get
			{
				return this.sgt_type_tennisseridField;
			}
			set
			{
				this.sgt_type_tennisseridField = value;
			}
		}
		public string sgt_woonplaats_automatische_incasso
		{
			get
			{
				return this.sgt_woonplaats_automatische_incassoField;
			}
			set
			{
				this.sgt_woonplaats_automatische_incassoField = value;
			}
		}
		public Sgt_top_geselecteerd_tennisserStateInfo statecode
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
