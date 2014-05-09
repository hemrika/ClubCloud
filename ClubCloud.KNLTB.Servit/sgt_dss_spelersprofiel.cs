using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_dss_spelersprofiel : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private CrmNumber sgt_aantal_partij_resultaten_dubbelField;
		private CrmNumber sgt_aantal_partij_resultaten_dubbel_dssField;
		private CrmNumber sgt_aantal_partij_resultaten_enkel_dssField;
		private CrmNumber sgt_aantal_partij_resultatenenkelField;
		private CrmBoolean sgt_alleen_in_te_schrijvenField;
		private CrmDecimal sgt_basisgetal_dubbelField;
		private CrmDecimal sgt_basisgetal_enkelField;
		private Lookup sgt_bonusranglijst_tm_14idField;
		private Lookup sgt_bonusranglijst_tm_16idField;
		private CrmBoolean sgt_buitenland_dubbel_pr_dssField;
		private CrmBoolean sgt_buitenland_dubbel_pr_erField;
		private CrmBoolean sgt_buitenland_enkel_pr_dssField;
		private CrmBoolean sgt_buitenland_enkel_pr_erField;
		private CrmDateTime sgt_datum_aangepastField;
		private CrmDateTime sgt_datum_dssField;
		private CrmDateTime sgt_datum_overledenField;
		private Lookup sgt_default_toernooisoortidField;
		private Picklist sgt_default_type_inschrijvingField;
		private CrmDecimal sgt_dss_basigetal_dubbel_handmatigField;
		private CrmDecimal sgt_dss_basigetal_enkel_handmatigField;
		private CrmDecimal sgt_dss_bg_d_hndField;
		private CrmDecimal sgt_dss_bg_e_hndField;
		private string sgt_dss_bondsnummerField;
		private CrmNumber sgt_dss_d_hndField;
		private CrmNumber sgt_dss_dubbel_bepaaldField;
		private CrmNumber sgt_dss_dubbel_handmatigField;
		private CrmNumber sgt_dss_e_hndField;
		private CrmNumber sgt_dss_enkel_bepaaldField;
		private CrmNumber sgt_dss_enkel_handmatigField;
		private Key sgt_dss_spelersprofielidField;
		private CrmBoolean sgt_dubbel_degradatie_9Field;
		private CrmBoolean sgt_dubbel_pr_dssField;
		private CrmBoolean sgt_dubbel_pr_erField;
		private CrmDecimal sgt_eindejaarsrating_dubbelField;
		private CrmDecimal sgt_eindejaarsrating_enkelField;
		private CrmBoolean sgt_enkel_degradatie_9Field;
		private CrmBoolean sgt_enkel_pr_dssField;
		private CrmBoolean sgt_enkel_pr_erField;
		private CrmDateTime sgt_geboortedatumField;
		private CrmBoolean sgt_geen_pr_betere_dssField;
		private CrmBoolean sgt_geen_pr_betere_dss_dubbelField;
		private Picklist sgt_geslachtField;
		private CrmBoolean sgt_minder_valide_spelerField;
		private Lookup sgt_naamidField;
		private CrmNumber sgt_partijreslutaten_dubbel_laatsteField;
		private CrmNumber sgt_partijresultaten_enkel_laatsteField;
		private CrmDecimal sgt_rating_dubbelField;
		private CrmDecimal sgt_rating_enkelField;
		private CrmNumber sgt_speelsterkte_dubbelField;
		private CrmNumber sgt_speelsterkte_dubbel_oudField;
		private CrmNumber sgt_speelsterkte_enkelField;
		private CrmNumber sgt_speelsterkte_enkel_oudField;
		private Lookup sgt_speelsterktebepaling_idField;
		private CrmBoolean sgt_sterke_buitenlanderField;
		private Lookup sgt_tennisnationaliteitidField;
		private Sgt_dss_spelersprofielStateInfo statecodeField;
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
		public CrmNumber sgt_aantal_partij_resultaten_dubbel
		{
			get
			{
				return this.sgt_aantal_partij_resultaten_dubbelField;
			}
			set
			{
				this.sgt_aantal_partij_resultaten_dubbelField = value;
				base.RaisePropertyChanged("sgt_aantal_partij_resultaten_dubbel");
			}
		}
		[XmlElement(Order = 9)]
		public CrmNumber sgt_aantal_partij_resultaten_dubbel_dss
		{
			get
			{
				return this.sgt_aantal_partij_resultaten_dubbel_dssField;
			}
			set
			{
				this.sgt_aantal_partij_resultaten_dubbel_dssField = value;
				base.RaisePropertyChanged("sgt_aantal_partij_resultaten_dubbel_dss");
			}
		}
		[XmlElement(Order = 10)]
		public CrmNumber sgt_aantal_partij_resultaten_enkel_dss
		{
			get
			{
				return this.sgt_aantal_partij_resultaten_enkel_dssField;
			}
			set
			{
				this.sgt_aantal_partij_resultaten_enkel_dssField = value;
				base.RaisePropertyChanged("sgt_aantal_partij_resultaten_enkel_dss");
			}
		}
		[XmlElement(Order = 11)]
		public CrmNumber sgt_aantal_partij_resultatenenkel
		{
			get
			{
				return this.sgt_aantal_partij_resultatenenkelField;
			}
			set
			{
				this.sgt_aantal_partij_resultatenenkelField = value;
				base.RaisePropertyChanged("sgt_aantal_partij_resultatenenkel");
			}
		}
		[XmlElement(Order = 12)]
		public CrmBoolean sgt_alleen_in_te_schrijven
		{
			get
			{
				return this.sgt_alleen_in_te_schrijvenField;
			}
			set
			{
				this.sgt_alleen_in_te_schrijvenField = value;
				base.RaisePropertyChanged("sgt_alleen_in_te_schrijven");
			}
		}
		[XmlElement(Order = 13)]
		public CrmDecimal sgt_basisgetal_dubbel
		{
			get
			{
				return this.sgt_basisgetal_dubbelField;
			}
			set
			{
				this.sgt_basisgetal_dubbelField = value;
				base.RaisePropertyChanged("sgt_basisgetal_dubbel");
			}
		}
		[XmlElement(Order = 14)]
		public CrmDecimal sgt_basisgetal_enkel
		{
			get
			{
				return this.sgt_basisgetal_enkelField;
			}
			set
			{
				this.sgt_basisgetal_enkelField = value;
				base.RaisePropertyChanged("sgt_basisgetal_enkel");
			}
		}
		[XmlElement(Order = 15)]
		public Lookup sgt_bonusranglijst_tm_14id
		{
			get
			{
				return this.sgt_bonusranglijst_tm_14idField;
			}
			set
			{
				this.sgt_bonusranglijst_tm_14idField = value;
				base.RaisePropertyChanged("sgt_bonusranglijst_tm_14id");
			}
		}
		[XmlElement(Order = 16)]
		public Lookup sgt_bonusranglijst_tm_16id
		{
			get
			{
				return this.sgt_bonusranglijst_tm_16idField;
			}
			set
			{
				this.sgt_bonusranglijst_tm_16idField = value;
				base.RaisePropertyChanged("sgt_bonusranglijst_tm_16id");
			}
		}
		[XmlElement(Order = 17)]
		public CrmBoolean sgt_buitenland_dubbel_pr_dss
		{
			get
			{
				return this.sgt_buitenland_dubbel_pr_dssField;
			}
			set
			{
				this.sgt_buitenland_dubbel_pr_dssField = value;
				base.RaisePropertyChanged("sgt_buitenland_dubbel_pr_dss");
			}
		}
		[XmlElement(Order = 18)]
		public CrmBoolean sgt_buitenland_dubbel_pr_er
		{
			get
			{
				return this.sgt_buitenland_dubbel_pr_erField;
			}
			set
			{
				this.sgt_buitenland_dubbel_pr_erField = value;
				base.RaisePropertyChanged("sgt_buitenland_dubbel_pr_er");
			}
		}
		[XmlElement(Order = 19)]
		public CrmBoolean sgt_buitenland_enkel_pr_dss
		{
			get
			{
				return this.sgt_buitenland_enkel_pr_dssField;
			}
			set
			{
				this.sgt_buitenland_enkel_pr_dssField = value;
				base.RaisePropertyChanged("sgt_buitenland_enkel_pr_dss");
			}
		}
		[XmlElement(Order = 20)]
		public CrmBoolean sgt_buitenland_enkel_pr_er
		{
			get
			{
				return this.sgt_buitenland_enkel_pr_erField;
			}
			set
			{
				this.sgt_buitenland_enkel_pr_erField = value;
				base.RaisePropertyChanged("sgt_buitenland_enkel_pr_er");
			}
		}
		[XmlElement(Order = 21)]
		public CrmDateTime sgt_datum_aangepast
		{
			get
			{
				return this.sgt_datum_aangepastField;
			}
			set
			{
				this.sgt_datum_aangepastField = value;
				base.RaisePropertyChanged("sgt_datum_aangepast");
			}
		}
		[XmlElement(Order = 22)]
		public CrmDateTime sgt_datum_dss
		{
			get
			{
				return this.sgt_datum_dssField;
			}
			set
			{
				this.sgt_datum_dssField = value;
				base.RaisePropertyChanged("sgt_datum_dss");
			}
		}
		[XmlElement(Order = 23)]
		public CrmDateTime sgt_datum_overleden
		{
			get
			{
				return this.sgt_datum_overledenField;
			}
			set
			{
				this.sgt_datum_overledenField = value;
				base.RaisePropertyChanged("sgt_datum_overleden");
			}
		}
		[XmlElement(Order = 24)]
		public Lookup sgt_default_toernooisoortid
		{
			get
			{
				return this.sgt_default_toernooisoortidField;
			}
			set
			{
				this.sgt_default_toernooisoortidField = value;
				base.RaisePropertyChanged("sgt_default_toernooisoortid");
			}
		}
		[XmlElement(Order = 25)]
		public Picklist sgt_default_type_inschrijving
		{
			get
			{
				return this.sgt_default_type_inschrijvingField;
			}
			set
			{
				this.sgt_default_type_inschrijvingField = value;
				base.RaisePropertyChanged("sgt_default_type_inschrijving");
			}
		}
		[XmlElement(Order = 26)]
		public CrmDecimal sgt_dss_basigetal_dubbel_handmatig
		{
			get
			{
				return this.sgt_dss_basigetal_dubbel_handmatigField;
			}
			set
			{
				this.sgt_dss_basigetal_dubbel_handmatigField = value;
				base.RaisePropertyChanged("sgt_dss_basigetal_dubbel_handmatig");
			}
		}
		[XmlElement(Order = 27)]
		public CrmDecimal sgt_dss_basigetal_enkel_handmatig
		{
			get
			{
				return this.sgt_dss_basigetal_enkel_handmatigField;
			}
			set
			{
				this.sgt_dss_basigetal_enkel_handmatigField = value;
				base.RaisePropertyChanged("sgt_dss_basigetal_enkel_handmatig");
			}
		}
		[XmlElement(Order = 28)]
		public CrmDecimal sgt_dss_bg_d_hnd
		{
			get
			{
				return this.sgt_dss_bg_d_hndField;
			}
			set
			{
				this.sgt_dss_bg_d_hndField = value;
				base.RaisePropertyChanged("sgt_dss_bg_d_hnd");
			}
		}
		[XmlElement(Order = 29)]
		public CrmDecimal sgt_dss_bg_e_hnd
		{
			get
			{
				return this.sgt_dss_bg_e_hndField;
			}
			set
			{
				this.sgt_dss_bg_e_hndField = value;
				base.RaisePropertyChanged("sgt_dss_bg_e_hnd");
			}
		}
		[XmlElement(Order = 30)]
		public string sgt_dss_bondsnummer
		{
			get
			{
				return this.sgt_dss_bondsnummerField;
			}
			set
			{
				this.sgt_dss_bondsnummerField = value;
				base.RaisePropertyChanged("sgt_dss_bondsnummer");
			}
		}
		[XmlElement(Order = 31)]
		public CrmNumber sgt_dss_d_hnd
		{
			get
			{
				return this.sgt_dss_d_hndField;
			}
			set
			{
				this.sgt_dss_d_hndField = value;
				base.RaisePropertyChanged("sgt_dss_d_hnd");
			}
		}
		[XmlElement(Order = 32)]
		public CrmNumber sgt_dss_dubbel_bepaald
		{
			get
			{
				return this.sgt_dss_dubbel_bepaaldField;
			}
			set
			{
				this.sgt_dss_dubbel_bepaaldField = value;
				base.RaisePropertyChanged("sgt_dss_dubbel_bepaald");
			}
		}
		[XmlElement(Order = 33)]
		public CrmNumber sgt_dss_dubbel_handmatig
		{
			get
			{
				return this.sgt_dss_dubbel_handmatigField;
			}
			set
			{
				this.sgt_dss_dubbel_handmatigField = value;
				base.RaisePropertyChanged("sgt_dss_dubbel_handmatig");
			}
		}
		[XmlElement(Order = 34)]
		public CrmNumber sgt_dss_e_hnd
		{
			get
			{
				return this.sgt_dss_e_hndField;
			}
			set
			{
				this.sgt_dss_e_hndField = value;
				base.RaisePropertyChanged("sgt_dss_e_hnd");
			}
		}
		[XmlElement(Order = 35)]
		public CrmNumber sgt_dss_enkel_bepaald
		{
			get
			{
				return this.sgt_dss_enkel_bepaaldField;
			}
			set
			{
				this.sgt_dss_enkel_bepaaldField = value;
				base.RaisePropertyChanged("sgt_dss_enkel_bepaald");
			}
		}
		[XmlElement(Order = 36)]
		public CrmNumber sgt_dss_enkel_handmatig
		{
			get
			{
				return this.sgt_dss_enkel_handmatigField;
			}
			set
			{
				this.sgt_dss_enkel_handmatigField = value;
				base.RaisePropertyChanged("sgt_dss_enkel_handmatig");
			}
		}
		[XmlElement(Order = 37)]
		public Key sgt_dss_spelersprofielid
		{
			get
			{
				return this.sgt_dss_spelersprofielidField;
			}
			set
			{
				this.sgt_dss_spelersprofielidField = value;
				base.RaisePropertyChanged("sgt_dss_spelersprofielid");
			}
		}
		[XmlElement(Order = 38)]
		public CrmBoolean sgt_dubbel_degradatie_9
		{
			get
			{
				return this.sgt_dubbel_degradatie_9Field;
			}
			set
			{
				this.sgt_dubbel_degradatie_9Field = value;
				base.RaisePropertyChanged("sgt_dubbel_degradatie_9");
			}
		}
		[XmlElement(Order = 39)]
		public CrmBoolean sgt_dubbel_pr_dss
		{
			get
			{
				return this.sgt_dubbel_pr_dssField;
			}
			set
			{
				this.sgt_dubbel_pr_dssField = value;
				base.RaisePropertyChanged("sgt_dubbel_pr_dss");
			}
		}
		[XmlElement(Order = 40)]
		public CrmBoolean sgt_dubbel_pr_er
		{
			get
			{
				return this.sgt_dubbel_pr_erField;
			}
			set
			{
				this.sgt_dubbel_pr_erField = value;
				base.RaisePropertyChanged("sgt_dubbel_pr_er");
			}
		}
		[XmlElement(Order = 41)]
		public CrmDecimal sgt_eindejaarsrating_dubbel
		{
			get
			{
				return this.sgt_eindejaarsrating_dubbelField;
			}
			set
			{
				this.sgt_eindejaarsrating_dubbelField = value;
				base.RaisePropertyChanged("sgt_eindejaarsrating_dubbel");
			}
		}
		[XmlElement(Order = 42)]
		public CrmDecimal sgt_eindejaarsrating_enkel
		{
			get
			{
				return this.sgt_eindejaarsrating_enkelField;
			}
			set
			{
				this.sgt_eindejaarsrating_enkelField = value;
				base.RaisePropertyChanged("sgt_eindejaarsrating_enkel");
			}
		}
		[XmlElement(Order = 43)]
		public CrmBoolean sgt_enkel_degradatie_9
		{
			get
			{
				return this.sgt_enkel_degradatie_9Field;
			}
			set
			{
				this.sgt_enkel_degradatie_9Field = value;
				base.RaisePropertyChanged("sgt_enkel_degradatie_9");
			}
		}
		[XmlElement(Order = 44)]
		public CrmBoolean sgt_enkel_pr_dss
		{
			get
			{
				return this.sgt_enkel_pr_dssField;
			}
			set
			{
				this.sgt_enkel_pr_dssField = value;
				base.RaisePropertyChanged("sgt_enkel_pr_dss");
			}
		}
		[XmlElement(Order = 45)]
		public CrmBoolean sgt_enkel_pr_er
		{
			get
			{
				return this.sgt_enkel_pr_erField;
			}
			set
			{
				this.sgt_enkel_pr_erField = value;
				base.RaisePropertyChanged("sgt_enkel_pr_er");
			}
		}
		[XmlElement(Order = 46)]
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
		[XmlElement(Order = 47)]
		public CrmBoolean sgt_geen_pr_betere_dss
		{
			get
			{
				return this.sgt_geen_pr_betere_dssField;
			}
			set
			{
				this.sgt_geen_pr_betere_dssField = value;
				base.RaisePropertyChanged("sgt_geen_pr_betere_dss");
			}
		}
		[XmlElement(Order = 48)]
		public CrmBoolean sgt_geen_pr_betere_dss_dubbel
		{
			get
			{
				return this.sgt_geen_pr_betere_dss_dubbelField;
			}
			set
			{
				this.sgt_geen_pr_betere_dss_dubbelField = value;
				base.RaisePropertyChanged("sgt_geen_pr_betere_dss_dubbel");
			}
		}
		[XmlElement(Order = 49)]
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
		[XmlElement(Order = 50)]
		public CrmBoolean sgt_minder_valide_speler
		{
			get
			{
				return this.sgt_minder_valide_spelerField;
			}
			set
			{
				this.sgt_minder_valide_spelerField = value;
				base.RaisePropertyChanged("sgt_minder_valide_speler");
			}
		}
		[XmlElement(Order = 51)]
		public Lookup sgt_naamid
		{
			get
			{
				return this.sgt_naamidField;
			}
			set
			{
				this.sgt_naamidField = value;
				base.RaisePropertyChanged("sgt_naamid");
			}
		}
		[XmlElement(Order = 52)]
		public CrmNumber sgt_partijreslutaten_dubbel_laatste
		{
			get
			{
				return this.sgt_partijreslutaten_dubbel_laatsteField;
			}
			set
			{
				this.sgt_partijreslutaten_dubbel_laatsteField = value;
				base.RaisePropertyChanged("sgt_partijreslutaten_dubbel_laatste");
			}
		}
		[XmlElement(Order = 53)]
		public CrmNumber sgt_partijresultaten_enkel_laatste
		{
			get
			{
				return this.sgt_partijresultaten_enkel_laatsteField;
			}
			set
			{
				this.sgt_partijresultaten_enkel_laatsteField = value;
				base.RaisePropertyChanged("sgt_partijresultaten_enkel_laatste");
			}
		}
		[XmlElement(Order = 54)]
		public CrmDecimal sgt_rating_dubbel
		{
			get
			{
				return this.sgt_rating_dubbelField;
			}
			set
			{
				this.sgt_rating_dubbelField = value;
				base.RaisePropertyChanged("sgt_rating_dubbel");
			}
		}
		[XmlElement(Order = 55)]
		public CrmDecimal sgt_rating_enkel
		{
			get
			{
				return this.sgt_rating_enkelField;
			}
			set
			{
				this.sgt_rating_enkelField = value;
				base.RaisePropertyChanged("sgt_rating_enkel");
			}
		}
		[XmlElement(Order = 56)]
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
		[XmlElement(Order = 57)]
		public CrmNumber sgt_speelsterkte_dubbel_oud
		{
			get
			{
				return this.sgt_speelsterkte_dubbel_oudField;
			}
			set
			{
				this.sgt_speelsterkte_dubbel_oudField = value;
				base.RaisePropertyChanged("sgt_speelsterkte_dubbel_oud");
			}
		}
		[XmlElement(Order = 58)]
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
		[XmlElement(Order = 59)]
		public CrmNumber sgt_speelsterkte_enkel_oud
		{
			get
			{
				return this.sgt_speelsterkte_enkel_oudField;
			}
			set
			{
				this.sgt_speelsterkte_enkel_oudField = value;
				base.RaisePropertyChanged("sgt_speelsterkte_enkel_oud");
			}
		}
		[XmlElement(Order = 60)]
		public Lookup sgt_speelsterktebepaling_id
		{
			get
			{
				return this.sgt_speelsterktebepaling_idField;
			}
			set
			{
				this.sgt_speelsterktebepaling_idField = value;
				base.RaisePropertyChanged("sgt_speelsterktebepaling_id");
			}
		}
		[XmlElement(Order = 61)]
		public CrmBoolean sgt_sterke_buitenlander
		{
			get
			{
				return this.sgt_sterke_buitenlanderField;
			}
			set
			{
				this.sgt_sterke_buitenlanderField = value;
				base.RaisePropertyChanged("sgt_sterke_buitenlander");
			}
		}
		[XmlElement(Order = 62)]
		public Lookup sgt_tennisnationaliteitid
		{
			get
			{
				return this.sgt_tennisnationaliteitidField;
			}
			set
			{
				this.sgt_tennisnationaliteitidField = value;
				base.RaisePropertyChanged("sgt_tennisnationaliteitid");
			}
		}
		[XmlElement(Order = 63)]
		public Sgt_dss_spelersprofielStateInfo statecode
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
		[XmlElement(Order = 64)]
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
		[XmlElement(Order = 65)]
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
		[XmlElement(Order = 66)]
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
