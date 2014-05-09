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
		[XmlElement(Order = 3)]
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
		[XmlElement(Order = 4)]
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
		[XmlElement(Order = 5)]
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
		[XmlElement(Order = 6)]
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
		[XmlElement(Order = 7)]
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
		[XmlElement(Order = 8)]
		public string sgt_2e_sport
		{
			get
			{
				return this.sgt_2e_sportField;
			}
			set
			{
				this.sgt_2e_sportField = value;
				base.RaisePropertyChanged("sgt_2e_sport");
			}
		}
		[XmlElement(Order = 9)]
		public CrmBoolean sgt_aanhef_ouders_verzorgers_van
		{
			get
			{
				return this.sgt_aanhef_ouders_verzorgers_vanField;
			}
			set
			{
				this.sgt_aanhef_ouders_verzorgers_vanField = value;
				base.RaisePropertyChanged("sgt_aanhef_ouders_verzorgers_van");
			}
		}
		[XmlElement(Order = 10)]
		public CrmBoolean sgt_aanpassen
		{
			get
			{
				return this.sgt_aanpassenField;
			}
			set
			{
				this.sgt_aanpassenField = value;
				base.RaisePropertyChanged("sgt_aanpassen");
			}
		}
		[XmlElement(Order = 11)]
		public string sgt_achternaam
		{
			get
			{
				return this.sgt_achternaamField;
			}
			set
			{
				this.sgt_achternaamField = value;
				base.RaisePropertyChanged("sgt_achternaam");
			}
		}
		[XmlElement(Order = 12)]
		public CrmBoolean sgt_adl_accu
		{
			get
			{
				return this.sgt_adl_accuField;
			}
			set
			{
				this.sgt_adl_accuField = value;
				base.RaisePropertyChanged("sgt_adl_accu");
			}
		}
		[XmlElement(Order = 13)]
		public CrmDecimal sgt_adl_gewicht
		{
			get
			{
				return this.sgt_adl_gewichtField;
			}
			set
			{
				this.sgt_adl_gewichtField = value;
				base.RaisePropertyChanged("sgt_adl_gewicht");
			}
		}
		[XmlElement(Order = 14)]
		public CrmBoolean sgt_adl_handmatig_bewogen
		{
			get
			{
				return this.sgt_adl_handmatig_bewogenField;
			}
			set
			{
				this.sgt_adl_handmatig_bewogenField = value;
				base.RaisePropertyChanged("sgt_adl_handmatig_bewogen");
			}
		}
		[XmlElement(Order = 15)]
		public CrmBoolean sgt_adl_inklapbaar
		{
			get
			{
				return this.sgt_adl_inklapbaarField;
			}
			set
			{
				this.sgt_adl_inklapbaarField = value;
				base.RaisePropertyChanged("sgt_adl_inklapbaar");
			}
		}
		[XmlElement(Order = 16)]
		public CrmDecimal sgt_adl_omvang_breedte
		{
			get
			{
				return this.sgt_adl_omvang_breedteField;
			}
			set
			{
				this.sgt_adl_omvang_breedteField = value;
				base.RaisePropertyChanged("sgt_adl_omvang_breedte");
			}
		}
		[XmlElement(Order = 17)]
		public CrmDecimal sgt_adl_omvang_hoogte
		{
			get
			{
				return this.sgt_adl_omvang_hoogteField;
			}
			set
			{
				this.sgt_adl_omvang_hoogteField = value;
				base.RaisePropertyChanged("sgt_adl_omvang_hoogte");
			}
		}
		[XmlElement(Order = 18)]
		public CrmDecimal sgt_adl_omvang_lengte
		{
			get
			{
				return this.sgt_adl_omvang_lengteField;
			}
			set
			{
				this.sgt_adl_omvang_lengteField = value;
				base.RaisePropertyChanged("sgt_adl_omvang_lengte");
			}
		}
		[XmlElement(Order = 19)]
		public string sgt_adres_school
		{
			get
			{
				return this.sgt_adres_schoolField;
			}
			set
			{
				this.sgt_adres_schoolField = value;
				base.RaisePropertyChanged("sgt_adres_school");
			}
		}
		[XmlElement(Order = 20)]
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
		[XmlElement(Order = 21)]
		public string sgt_contactpersoon
		{
			get
			{
				return this.sgt_contactpersoonField;
			}
			set
			{
				this.sgt_contactpersoonField = value;
				base.RaisePropertyChanged("sgt_contactpersoon");
			}
		}
		[XmlElement(Order = 22)]
		public CrmDateTime sgt_datum_accoord
		{
			get
			{
				return this.sgt_datum_accoordField;
			}
			set
			{
				this.sgt_datum_accoordField = value;
				base.RaisePropertyChanged("sgt_datum_accoord");
			}
		}
		[XmlElement(Order = 23)]
		public CrmDateTime sgt_datum_keuring
		{
			get
			{
				return this.sgt_datum_keuringField;
			}
			set
			{
				this.sgt_datum_keuringField = value;
				base.RaisePropertyChanged("sgt_datum_keuring");
			}
		}
		[XmlElement(Order = 24)]
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
		[XmlElement(Order = 25)]
		public string sgt_email
		{
			get
			{
				return this.sgt_emailField;
			}
			set
			{
				this.sgt_emailField = value;
				base.RaisePropertyChanged("sgt_email");
			}
		}
		[XmlElement(Order = 26)]
		public string sgt_extra_info
		{
			get
			{
				return this.sgt_extra_infoField;
			}
			set
			{
				this.sgt_extra_infoField = value;
				base.RaisePropertyChanged("sgt_extra_info");
			}
		}
		[XmlElement(Order = 27)]
		public CrmDateTime sgt_geboortedatum
		{
			get
			{
				return this.sgt_geboortedatumField;
			}
			set
			{
				this.sgt_geboortedatumField = value;
				base.RaisePropertyChanged("sgt_geboortedatum");
			}
		}
		[XmlElement(Order = 28)]
		public Picklist sgt_geslacht
		{
			get
			{
				return this.sgt_geslachtField;
			}
			set
			{
				this.sgt_geslachtField = value;
				base.RaisePropertyChanged("sgt_geslacht");
			}
		}
		[XmlElement(Order = 29)]
		public CrmDateTime sgt_heeft_les_sinds
		{
			get
			{
				return this.sgt_heeft_les_sindsField;
			}
			set
			{
				this.sgt_heeft_les_sindsField = value;
				base.RaisePropertyChanged("sgt_heeft_les_sinds");
			}
		}
		[XmlElement(Order = 30)]
		public string sgt_ipin_number
		{
			get
			{
				return this.sgt_ipin_numberField;
			}
			set
			{
				this.sgt_ipin_numberField = value;
				base.RaisePropertyChanged("sgt_ipin_number");
			}
		}
		[XmlElement(Order = 31)]
		public Picklist sgt_keuze
		{
			get
			{
				return this.sgt_keuzeField;
			}
			set
			{
				this.sgt_keuzeField = value;
				base.RaisePropertyChanged("sgt_keuze");
			}
		}
		[XmlElement(Order = 32)]
		public string sgt_klas_groep
		{
			get
			{
				return this.sgt_klas_groepField;
			}
			set
			{
				this.sgt_klas_groepField = value;
				base.RaisePropertyChanged("sgt_klas_groep");
			}
		}
		[XmlElement(Order = 33)]
		public Picklist sgt_klasse
		{
			get
			{
				return this.sgt_klasseField;
			}
			set
			{
				this.sgt_klasseField = value;
				base.RaisePropertyChanged("sgt_klasse");
			}
		}
		[XmlElement(Order = 34)]
		public string sgt_kledingsponsor
		{
			get
			{
				return this.sgt_kledingsponsorField;
			}
			set
			{
				this.sgt_kledingsponsorField = value;
				base.RaisePropertyChanged("sgt_kledingsponsor");
			}
		}
		[XmlElement(Order = 35)]
		public string sgt_maat_kostuum
		{
			get
			{
				return this.sgt_maat_kostuumField;
			}
			set
			{
				this.sgt_maat_kostuumField = value;
				base.RaisePropertyChanged("sgt_maat_kostuum");
			}
		}
		[XmlElement(Order = 36)]
		public Picklist sgt_maat_loopschoen
		{
			get
			{
				return this.sgt_maat_loopschoenField;
			}
			set
			{
				this.sgt_maat_loopschoenField = value;
				base.RaisePropertyChanged("sgt_maat_loopschoen");
			}
		}
		[XmlElement(Order = 37)]
		public string sgt_maat_rok_short
		{
			get
			{
				return this.sgt_maat_rok_shortField;
			}
			set
			{
				this.sgt_maat_rok_shortField = value;
				base.RaisePropertyChanged("sgt_maat_rok_short");
			}
		}
		[XmlElement(Order = 38)]
		public Picklist sgt_maat_tennisschoen
		{
			get
			{
				return this.sgt_maat_tennisschoenField;
			}
			set
			{
				this.sgt_maat_tennisschoenField = value;
				base.RaisePropertyChanged("sgt_maat_tennisschoen");
			}
		}
		[XmlElement(Order = 39)]
		public string sgt_maat_trainingspak
		{
			get
			{
				return this.sgt_maat_trainingspakField;
			}
			set
			{
				this.sgt_maat_trainingspakField = value;
				base.RaisePropertyChanged("sgt_maat_trainingspak");
			}
		}
		[XmlElement(Order = 40)]
		public string sgt_maat_trui_polo
		{
			get
			{
				return this.sgt_maat_trui_poloField;
			}
			set
			{
				this.sgt_maat_trui_poloField = value;
				base.RaisePropertyChanged("sgt_maat_trui_polo");
			}
		}
		[XmlElement(Order = 41)]
		public string sgt_meest_recente_competitie_deelname
		{
			get
			{
				return this.sgt_meest_recente_competitie_deelnameField;
			}
			set
			{
				this.sgt_meest_recente_competitie_deelnameField = value;
				base.RaisePropertyChanged("sgt_meest_recente_competitie_deelname");
			}
		}
		[XmlElement(Order = 42)]
		public string sgt_naam_automatische_incasso
		{
			get
			{
				return this.sgt_naam_automatische_incassoField;
			}
			set
			{
				this.sgt_naam_automatische_incassoField = value;
				base.RaisePropertyChanged("sgt_naam_automatische_incasso");
			}
		}
		[XmlElement(Order = 43)]
		public string sgt_naam_school
		{
			get
			{
				return this.sgt_naam_schoolField;
			}
			set
			{
				this.sgt_naam_schoolField = value;
				base.RaisePropertyChanged("sgt_naam_school");
			}
		}
		[XmlElement(Order = 44)]
		public Picklist sgt_onderwijstype
		{
			get
			{
				return this.sgt_onderwijstypeField;
			}
			set
			{
				this.sgt_onderwijstypeField = value;
				base.RaisePropertyChanged("sgt_onderwijstype");
			}
		}
		[XmlElement(Order = 45)]
		public string sgt_opmerking_keuring
		{
			get
			{
				return this.sgt_opmerking_keuringField;
			}
			set
			{
				this.sgt_opmerking_keuringField = value;
				base.RaisePropertyChanged("sgt_opmerking_keuring");
			}
		}
		[XmlElement(Order = 46)]
		public string sgt_opmerking_ouders
		{
			get
			{
				return this.sgt_opmerking_oudersField;
			}
			set
			{
				this.sgt_opmerking_oudersField = value;
				base.RaisePropertyChanged("sgt_opmerking_ouders");
			}
		}
		[XmlElement(Order = 47)]
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
		[XmlElement(Order = 48)]
		public Lookup sgt_predicaat_id
		{
			get
			{
				return this.sgt_predicaat_idField;
			}
			set
			{
				this.sgt_predicaat_idField = value;
				base.RaisePropertyChanged("sgt_predicaat_id");
			}
		}
		[XmlElement(Order = 49)]
		public Lookup sgt_predicaatid
		{
			get
			{
				return this.sgt_predicaatidField;
			}
			set
			{
				this.sgt_predicaatidField = value;
				base.RaisePropertyChanged("sgt_predicaatid");
			}
		}
		[XmlElement(Order = 50)]
		public string sgt_rekening_automatische_incasso
		{
			get
			{
				return this.sgt_rekening_automatische_incassoField;
			}
			set
			{
				this.sgt_rekening_automatische_incassoField = value;
				base.RaisePropertyChanged("sgt_rekening_automatische_incasso");
			}
		}
		[XmlElement(Order = 51)]
		public string sgt_roepnaam
		{
			get
			{
				return this.sgt_roepnaamField;
			}
			set
			{
				this.sgt_roepnaamField = value;
				base.RaisePropertyChanged("sgt_roepnaam");
			}
		}
		[XmlElement(Order = 52)]
		public Picklist sgt_seizoen
		{
			get
			{
				return this.sgt_seizoenField;
			}
			set
			{
				this.sgt_seizoenField = value;
				base.RaisePropertyChanged("sgt_seizoen");
			}
		}
		[XmlElement(Order = 53)]
		public Picklist sgt_soort_onderwijs
		{
			get
			{
				return this.sgt_soort_onderwijsField;
			}
			set
			{
				this.sgt_soort_onderwijsField = value;
				base.RaisePropertyChanged("sgt_soort_onderwijs");
			}
		}
		[XmlElement(Order = 54)]
		public CrmBoolean sgt_speelhand
		{
			get
			{
				return this.sgt_speelhandField;
			}
			set
			{
				this.sgt_speelhandField = value;
				base.RaisePropertyChanged("sgt_speelhand");
			}
		}
		[XmlElement(Order = 55)]
		public CrmBoolean sgt_sponsorpatch_op_shirt
		{
			get
			{
				return this.sgt_sponsorpatch_op_shirtField;
			}
			set
			{
				this.sgt_sponsorpatch_op_shirtField = value;
				base.RaisePropertyChanged("sgt_sponsorpatch_op_shirt");
			}
		}
		[XmlElement(Order = 56)]
		public CrmBoolean sgt_srs_accu
		{
			get
			{
				return this.sgt_srs_accuField;
			}
			set
			{
				this.sgt_srs_accuField = value;
				base.RaisePropertyChanged("sgt_srs_accu");
			}
		}
		[XmlElement(Order = 57)]
		public CrmDecimal sgt_srs_gewicht
		{
			get
			{
				return this.sgt_srs_gewichtField;
			}
			set
			{
				this.sgt_srs_gewichtField = value;
				base.RaisePropertyChanged("sgt_srs_gewicht");
			}
		}
		[XmlElement(Order = 58)]
		public CrmBoolean sgt_srs_handmatig_bewogen
		{
			get
			{
				return this.sgt_srs_handmatig_bewogenField;
			}
			set
			{
				this.sgt_srs_handmatig_bewogenField = value;
				base.RaisePropertyChanged("sgt_srs_handmatig_bewogen");
			}
		}
		[XmlElement(Order = 59)]
		public CrmBoolean sgt_srs_inklapbaar
		{
			get
			{
				return this.sgt_srs_inklapbaarField;
			}
			set
			{
				this.sgt_srs_inklapbaarField = value;
				base.RaisePropertyChanged("sgt_srs_inklapbaar");
			}
		}
		[XmlElement(Order = 60)]
		public CrmDecimal sgt_srs_omvang_breedte
		{
			get
			{
				return this.sgt_srs_omvang_breedteField;
			}
			set
			{
				this.sgt_srs_omvang_breedteField = value;
				base.RaisePropertyChanged("sgt_srs_omvang_breedte");
			}
		}
		[XmlElement(Order = 61)]
		public CrmDecimal sgt_srs_omvang_hoogte
		{
			get
			{
				return this.sgt_srs_omvang_hoogteField;
			}
			set
			{
				this.sgt_srs_omvang_hoogteField = value;
				base.RaisePropertyChanged("sgt_srs_omvang_hoogte");
			}
		}
		[XmlElement(Order = 62)]
		public CrmDecimal sgt_srs_omvang_lengte
		{
			get
			{
				return this.sgt_srs_omvang_lengteField;
			}
			set
			{
				this.sgt_srs_omvang_lengteField = value;
				base.RaisePropertyChanged("sgt_srs_omvang_lengte");
			}
		}
		[XmlElement(Order = 63)]
		public Picklist sgt_status_contract
		{
			get
			{
				return this.sgt_status_contractField;
			}
			set
			{
				this.sgt_status_contractField = value;
				base.RaisePropertyChanged("sgt_status_contract");
			}
		}
		[XmlElement(Order = 64)]
		public Picklist sgt_status_speler
		{
			get
			{
				return this.sgt_status_spelerField;
			}
			set
			{
				this.sgt_status_spelerField = value;
				base.RaisePropertyChanged("sgt_status_speler");
			}
		}
		[XmlElement(Order = 65)]
		public string sgt_telefoon
		{
			get
			{
				return this.sgt_telefoonField;
			}
			set
			{
				this.sgt_telefoonField = value;
				base.RaisePropertyChanged("sgt_telefoon");
			}
		}
		[XmlElement(Order = 66)]
		public CrmBoolean sgt_termijnbetaling
		{
			get
			{
				return this.sgt_termijnbetalingField;
			}
			set
			{
				this.sgt_termijnbetalingField = value;
				base.RaisePropertyChanged("sgt_termijnbetaling");
			}
		}
		[XmlElement("sgt_top_geselecteerd_tennisser", Order = 67)]
		public string sgt_top_geselecteerd_tennisser1
		{
			get
			{
				return this.sgt_top_geselecteerd_tennisser1Field;
			}
			set
			{
				this.sgt_top_geselecteerd_tennisser1Field = value;
				base.RaisePropertyChanged("sgt_top_geselecteerd_tennisser1");
			}
		}
		[XmlElement(Order = 68)]
		public Key sgt_top_geselecteerd_tennisserid
		{
			get
			{
				return this.sgt_top_geselecteerd_tennisseridField;
			}
			set
			{
				this.sgt_top_geselecteerd_tennisseridField = value;
				base.RaisePropertyChanged("sgt_top_geselecteerd_tennisserid");
			}
		}
		[XmlElement(Order = 69)]
		public string sgt_tussenvoegsel
		{
			get
			{
				return this.sgt_tussenvoegselField;
			}
			set
			{
				this.sgt_tussenvoegselField = value;
				base.RaisePropertyChanged("sgt_tussenvoegsel");
			}
		}
		[XmlElement(Order = 70)]
		public Lookup sgt_type_tennisserid
		{
			get
			{
				return this.sgt_type_tennisseridField;
			}
			set
			{
				this.sgt_type_tennisseridField = value;
				base.RaisePropertyChanged("sgt_type_tennisserid");
			}
		}
		[XmlElement(Order = 71)]
		public string sgt_woonplaats_automatische_incasso
		{
			get
			{
				return this.sgt_woonplaats_automatische_incassoField;
			}
			set
			{
				this.sgt_woonplaats_automatische_incassoField = value;
				base.RaisePropertyChanged("sgt_woonplaats_automatische_incasso");
			}
		}
		[XmlElement(Order = 72)]
		public Sgt_top_geselecteerd_tennisserStateInfo statecode
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
		[XmlElement(Order = 73)]
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
		[XmlElement(Order = 74)]
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
		[XmlElement(Order = 75)]
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
