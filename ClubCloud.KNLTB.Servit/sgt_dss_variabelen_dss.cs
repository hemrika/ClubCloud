using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_dss_variabelen_dss : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private CrmDecimal sgt_acceleratie_jeugd_extra_jongensField;
		private CrmDecimal sgt_acceleratie_jeugd_extra_meisjesField;
		private CrmDecimal sgt_acceleratie_jeugd_jongensField;
		private CrmDecimal sgt_acceleratie_jeugd_meisjesField;
		private CrmNumber sgt_basisresultatenField;
		private CrmDecimal sgt_dempingwaarde_1Field;
		private CrmDecimal sgt_dempingwaarde_2Field;
		private CrmDecimal sgt_dempingwaarde_3Field;
		private string sgt_dss_codeField;
		private Key sgt_dss_variabelen_dssidField;
		private CrmDecimal sgt_inactiviteitswaarde_dubbelField;
		private CrmDecimal sgt_inactiviteitswaarde_enkelField;
		private CrmNumber sgt_leeftijd_tot_en_met_1Field;
		private CrmNumber sgt_leeftijd_tot_en_met_2Field;
		private CrmNumber sgt_leeftijd_tot_en_met_3Field;
		private CrmNumber sgt_leeftijd_tot_en_met_extra_jongensField;
		private CrmNumber sgt_leeftijd_tot_en_met_extra_meisjesField;
		private CrmNumber sgt_leeftijd_tot_en_met_jongensField;
		private CrmNumber sgt_leeftijd_tot_en_met_meisjesField;
		private CrmNumber sgt_leeftijd_vanaf_1Field;
		private CrmNumber sgt_leeftijd_vanaf_2Field;
		private CrmNumber sgt_leeftijd_vanaf_3Field;
		private CrmNumber sgt_leeftijd_vanaf_extra_jongensField;
		private CrmNumber sgt_leeftijd_vanaf_extra_meisjesField;
		private CrmNumber sgt_leeftijd_vanaf_jongensField;
		private CrmNumber sgt_leeftijd_vanaf_meisjesField;
		private CrmNumber sgt_leeftijd_vanaf_minimale_ratingField;
		private CrmDecimal sgt_maximale_ratingField;
		private CrmDecimal sgt_maximale_rating_na_2e_jaarField;
		private CrmNumber sgt_min_resultaten_overgang_3_naar_2Field;
		private CrmNumber sgt_min_resultaten_overgang_naar_1Field;
		private string sgt_omschrijvingField;
		private CrmNumber sgt_partijen_voor_acceleratie_jongensField;
		private CrmNumber sgt_partijen_voor_acceleratie_meisjesField;
		private CrmNumber sgt_partijen_voor_demping_1Field;
		private CrmNumber sgt_partijen_voor_demping_2Field;
		private CrmNumber sgt_partijen_voor_demping_3Field;
		private Lookup sgt_ranglijst_ddidField;
		private Lookup sgt_ranglijst_deidField;
		private Lookup sgt_ranglijst_hdidField;
		private Lookup sgt_ranglijst_heidField;
		private Lookup sgt_ranglijst_mindervaliden_idField;
		private CrmNumber sgt_speelsterkte_1_damesField;
		private CrmNumber sgt_speelsterkte_1_dames_dubbelField;
		private CrmNumber sgt_speelsterkte_1_herenField;
		private CrmNumber sgt_speelsterkte_1_heren_dubbelField;
		private CrmNumber sgt_speelsterkte_2_damesField;
		private CrmNumber sgt_speelsterkte_2_dames_dubbelField;
		private CrmNumber sgt_speelsterkte_2_herenField;
		private CrmNumber sgt_speelsterkte_2_heren_dubbelField;
		private CrmNumber sgt_sterkte_1_rating_damesField;
		private CrmNumber sgt_sterkte_1_rating_dames_dubbelField;
		private CrmNumber sgt_sterkte_1_rating_herenField;
		private CrmNumber sgt_sterkte_1_rating_heren_dubbelField;
		private CrmNumber sgt_sterkte_2_rating_damesField;
		private CrmNumber sgt_sterkte_2_rating_dames_dubbelField;
		private CrmNumber sgt_sterkte_2_rating_herenField;
		private CrmNumber sgt_sterkte_2_rating_heren_dubbelField;
		private Sgt_dss_variabelen_dssStateInfo statecodeField;
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
		public CrmDecimal sgt_acceleratie_jeugd_extra_jongens
		{
			get
			{
				return this.sgt_acceleratie_jeugd_extra_jongensField;
			}
			set
			{
				this.sgt_acceleratie_jeugd_extra_jongensField = value;
				base.RaisePropertyChanged("sgt_acceleratie_jeugd_extra_jongens");
			}
		}
		[XmlElement(Order = 9)]
		public CrmDecimal sgt_acceleratie_jeugd_extra_meisjes
		{
			get
			{
				return this.sgt_acceleratie_jeugd_extra_meisjesField;
			}
			set
			{
				this.sgt_acceleratie_jeugd_extra_meisjesField = value;
				base.RaisePropertyChanged("sgt_acceleratie_jeugd_extra_meisjes");
			}
		}
		[XmlElement(Order = 10)]
		public CrmDecimal sgt_acceleratie_jeugd_jongens
		{
			get
			{
				return this.sgt_acceleratie_jeugd_jongensField;
			}
			set
			{
				this.sgt_acceleratie_jeugd_jongensField = value;
				base.RaisePropertyChanged("sgt_acceleratie_jeugd_jongens");
			}
		}
		[XmlElement(Order = 11)]
		public CrmDecimal sgt_acceleratie_jeugd_meisjes
		{
			get
			{
				return this.sgt_acceleratie_jeugd_meisjesField;
			}
			set
			{
				this.sgt_acceleratie_jeugd_meisjesField = value;
				base.RaisePropertyChanged("sgt_acceleratie_jeugd_meisjes");
			}
		}
		[XmlElement(Order = 12)]
		public CrmNumber sgt_basisresultaten
		{
			get
			{
				return this.sgt_basisresultatenField;
			}
			set
			{
				this.sgt_basisresultatenField = value;
				base.RaisePropertyChanged("sgt_basisresultaten");
			}
		}
		[XmlElement(Order = 13)]
		public CrmDecimal sgt_dempingwaarde_1
		{
			get
			{
				return this.sgt_dempingwaarde_1Field;
			}
			set
			{
				this.sgt_dempingwaarde_1Field = value;
				base.RaisePropertyChanged("sgt_dempingwaarde_1");
			}
		}
		[XmlElement(Order = 14)]
		public CrmDecimal sgt_dempingwaarde_2
		{
			get
			{
				return this.sgt_dempingwaarde_2Field;
			}
			set
			{
				this.sgt_dempingwaarde_2Field = value;
				base.RaisePropertyChanged("sgt_dempingwaarde_2");
			}
		}
		[XmlElement(Order = 15)]
		public CrmDecimal sgt_dempingwaarde_3
		{
			get
			{
				return this.sgt_dempingwaarde_3Field;
			}
			set
			{
				this.sgt_dempingwaarde_3Field = value;
				base.RaisePropertyChanged("sgt_dempingwaarde_3");
			}
		}
		[XmlElement(Order = 16)]
		public string sgt_dss_code
		{
			get
			{
				return this.sgt_dss_codeField;
			}
			set
			{
				this.sgt_dss_codeField = value;
				base.RaisePropertyChanged("sgt_dss_code");
			}
		}
		[XmlElement(Order = 17)]
		public Key sgt_dss_variabelen_dssid
		{
			get
			{
				return this.sgt_dss_variabelen_dssidField;
			}
			set
			{
				this.sgt_dss_variabelen_dssidField = value;
				base.RaisePropertyChanged("sgt_dss_variabelen_dssid");
			}
		}
		[XmlElement(Order = 18)]
		public CrmDecimal sgt_inactiviteitswaarde_dubbel
		{
			get
			{
				return this.sgt_inactiviteitswaarde_dubbelField;
			}
			set
			{
				this.sgt_inactiviteitswaarde_dubbelField = value;
				base.RaisePropertyChanged("sgt_inactiviteitswaarde_dubbel");
			}
		}
		[XmlElement(Order = 19)]
		public CrmDecimal sgt_inactiviteitswaarde_enkel
		{
			get
			{
				return this.sgt_inactiviteitswaarde_enkelField;
			}
			set
			{
				this.sgt_inactiviteitswaarde_enkelField = value;
				base.RaisePropertyChanged("sgt_inactiviteitswaarde_enkel");
			}
		}
		[XmlElement(Order = 20)]
		public CrmNumber sgt_leeftijd_tot_en_met_1
		{
			get
			{
				return this.sgt_leeftijd_tot_en_met_1Field;
			}
			set
			{
				this.sgt_leeftijd_tot_en_met_1Field = value;
				base.RaisePropertyChanged("sgt_leeftijd_tot_en_met_1");
			}
		}
		[XmlElement(Order = 21)]
		public CrmNumber sgt_leeftijd_tot_en_met_2
		{
			get
			{
				return this.sgt_leeftijd_tot_en_met_2Field;
			}
			set
			{
				this.sgt_leeftijd_tot_en_met_2Field = value;
				base.RaisePropertyChanged("sgt_leeftijd_tot_en_met_2");
			}
		}
		[XmlElement(Order = 22)]
		public CrmNumber sgt_leeftijd_tot_en_met_3
		{
			get
			{
				return this.sgt_leeftijd_tot_en_met_3Field;
			}
			set
			{
				this.sgt_leeftijd_tot_en_met_3Field = value;
				base.RaisePropertyChanged("sgt_leeftijd_tot_en_met_3");
			}
		}
		[XmlElement(Order = 23)]
		public CrmNumber sgt_leeftijd_tot_en_met_extra_jongens
		{
			get
			{
				return this.sgt_leeftijd_tot_en_met_extra_jongensField;
			}
			set
			{
				this.sgt_leeftijd_tot_en_met_extra_jongensField = value;
				base.RaisePropertyChanged("sgt_leeftijd_tot_en_met_extra_jongens");
			}
		}
		[XmlElement(Order = 24)]
		public CrmNumber sgt_leeftijd_tot_en_met_extra_meisjes
		{
			get
			{
				return this.sgt_leeftijd_tot_en_met_extra_meisjesField;
			}
			set
			{
				this.sgt_leeftijd_tot_en_met_extra_meisjesField = value;
				base.RaisePropertyChanged("sgt_leeftijd_tot_en_met_extra_meisjes");
			}
		}
		[XmlElement(Order = 25)]
		public CrmNumber sgt_leeftijd_tot_en_met_jongens
		{
			get
			{
				return this.sgt_leeftijd_tot_en_met_jongensField;
			}
			set
			{
				this.sgt_leeftijd_tot_en_met_jongensField = value;
				base.RaisePropertyChanged("sgt_leeftijd_tot_en_met_jongens");
			}
		}
		[XmlElement(Order = 26)]
		public CrmNumber sgt_leeftijd_tot_en_met_meisjes
		{
			get
			{
				return this.sgt_leeftijd_tot_en_met_meisjesField;
			}
			set
			{
				this.sgt_leeftijd_tot_en_met_meisjesField = value;
				base.RaisePropertyChanged("sgt_leeftijd_tot_en_met_meisjes");
			}
		}
		[XmlElement(Order = 27)]
		public CrmNumber sgt_leeftijd_vanaf_1
		{
			get
			{
				return this.sgt_leeftijd_vanaf_1Field;
			}
			set
			{
				this.sgt_leeftijd_vanaf_1Field = value;
				base.RaisePropertyChanged("sgt_leeftijd_vanaf_1");
			}
		}
		[XmlElement(Order = 28)]
		public CrmNumber sgt_leeftijd_vanaf_2
		{
			get
			{
				return this.sgt_leeftijd_vanaf_2Field;
			}
			set
			{
				this.sgt_leeftijd_vanaf_2Field = value;
				base.RaisePropertyChanged("sgt_leeftijd_vanaf_2");
			}
		}
		[XmlElement(Order = 29)]
		public CrmNumber sgt_leeftijd_vanaf_3
		{
			get
			{
				return this.sgt_leeftijd_vanaf_3Field;
			}
			set
			{
				this.sgt_leeftijd_vanaf_3Field = value;
				base.RaisePropertyChanged("sgt_leeftijd_vanaf_3");
			}
		}
		[XmlElement(Order = 30)]
		public CrmNumber sgt_leeftijd_vanaf_extra_jongens
		{
			get
			{
				return this.sgt_leeftijd_vanaf_extra_jongensField;
			}
			set
			{
				this.sgt_leeftijd_vanaf_extra_jongensField = value;
				base.RaisePropertyChanged("sgt_leeftijd_vanaf_extra_jongens");
			}
		}
		[XmlElement(Order = 31)]
		public CrmNumber sgt_leeftijd_vanaf_extra_meisjes
		{
			get
			{
				return this.sgt_leeftijd_vanaf_extra_meisjesField;
			}
			set
			{
				this.sgt_leeftijd_vanaf_extra_meisjesField = value;
				base.RaisePropertyChanged("sgt_leeftijd_vanaf_extra_meisjes");
			}
		}
		[XmlElement(Order = 32)]
		public CrmNumber sgt_leeftijd_vanaf_jongens
		{
			get
			{
				return this.sgt_leeftijd_vanaf_jongensField;
			}
			set
			{
				this.sgt_leeftijd_vanaf_jongensField = value;
				base.RaisePropertyChanged("sgt_leeftijd_vanaf_jongens");
			}
		}
		[XmlElement(Order = 33)]
		public CrmNumber sgt_leeftijd_vanaf_meisjes
		{
			get
			{
				return this.sgt_leeftijd_vanaf_meisjesField;
			}
			set
			{
				this.sgt_leeftijd_vanaf_meisjesField = value;
				base.RaisePropertyChanged("sgt_leeftijd_vanaf_meisjes");
			}
		}
		[XmlElement(Order = 34)]
		public CrmNumber sgt_leeftijd_vanaf_minimale_rating
		{
			get
			{
				return this.sgt_leeftijd_vanaf_minimale_ratingField;
			}
			set
			{
				this.sgt_leeftijd_vanaf_minimale_ratingField = value;
				base.RaisePropertyChanged("sgt_leeftijd_vanaf_minimale_rating");
			}
		}
		[XmlElement(Order = 35)]
		public CrmDecimal sgt_maximale_rating
		{
			get
			{
				return this.sgt_maximale_ratingField;
			}
			set
			{
				this.sgt_maximale_ratingField = value;
				base.RaisePropertyChanged("sgt_maximale_rating");
			}
		}
		[XmlElement(Order = 36)]
		public CrmDecimal sgt_maximale_rating_na_2e_jaar
		{
			get
			{
				return this.sgt_maximale_rating_na_2e_jaarField;
			}
			set
			{
				this.sgt_maximale_rating_na_2e_jaarField = value;
				base.RaisePropertyChanged("sgt_maximale_rating_na_2e_jaar");
			}
		}
		[XmlElement(Order = 37)]
		public CrmNumber sgt_min_resultaten_overgang_3_naar_2
		{
			get
			{
				return this.sgt_min_resultaten_overgang_3_naar_2Field;
			}
			set
			{
				this.sgt_min_resultaten_overgang_3_naar_2Field = value;
				base.RaisePropertyChanged("sgt_min_resultaten_overgang_3_naar_2");
			}
		}
		[XmlElement(Order = 38)]
		public CrmNumber sgt_min_resultaten_overgang_naar_1
		{
			get
			{
				return this.sgt_min_resultaten_overgang_naar_1Field;
			}
			set
			{
				this.sgt_min_resultaten_overgang_naar_1Field = value;
				base.RaisePropertyChanged("sgt_min_resultaten_overgang_naar_1");
			}
		}
		[XmlElement(Order = 39)]
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
		[XmlElement(Order = 40)]
		public CrmNumber sgt_partijen_voor_acceleratie_jongens
		{
			get
			{
				return this.sgt_partijen_voor_acceleratie_jongensField;
			}
			set
			{
				this.sgt_partijen_voor_acceleratie_jongensField = value;
				base.RaisePropertyChanged("sgt_partijen_voor_acceleratie_jongens");
			}
		}
		[XmlElement(Order = 41)]
		public CrmNumber sgt_partijen_voor_acceleratie_meisjes
		{
			get
			{
				return this.sgt_partijen_voor_acceleratie_meisjesField;
			}
			set
			{
				this.sgt_partijen_voor_acceleratie_meisjesField = value;
				base.RaisePropertyChanged("sgt_partijen_voor_acceleratie_meisjes");
			}
		}
		[XmlElement(Order = 42)]
		public CrmNumber sgt_partijen_voor_demping_1
		{
			get
			{
				return this.sgt_partijen_voor_demping_1Field;
			}
			set
			{
				this.sgt_partijen_voor_demping_1Field = value;
				base.RaisePropertyChanged("sgt_partijen_voor_demping_1");
			}
		}
		[XmlElement(Order = 43)]
		public CrmNumber sgt_partijen_voor_demping_2
		{
			get
			{
				return this.sgt_partijen_voor_demping_2Field;
			}
			set
			{
				this.sgt_partijen_voor_demping_2Field = value;
				base.RaisePropertyChanged("sgt_partijen_voor_demping_2");
			}
		}
		[XmlElement(Order = 44)]
		public CrmNumber sgt_partijen_voor_demping_3
		{
			get
			{
				return this.sgt_partijen_voor_demping_3Field;
			}
			set
			{
				this.sgt_partijen_voor_demping_3Field = value;
				base.RaisePropertyChanged("sgt_partijen_voor_demping_3");
			}
		}
		[XmlElement(Order = 45)]
		public Lookup sgt_ranglijst_ddid
		{
			get
			{
				return this.sgt_ranglijst_ddidField;
			}
			set
			{
				this.sgt_ranglijst_ddidField = value;
				base.RaisePropertyChanged("sgt_ranglijst_ddid");
			}
		}
		[XmlElement(Order = 46)]
		public Lookup sgt_ranglijst_deid
		{
			get
			{
				return this.sgt_ranglijst_deidField;
			}
			set
			{
				this.sgt_ranglijst_deidField = value;
				base.RaisePropertyChanged("sgt_ranglijst_deid");
			}
		}
		[XmlElement(Order = 47)]
		public Lookup sgt_ranglijst_hdid
		{
			get
			{
				return this.sgt_ranglijst_hdidField;
			}
			set
			{
				this.sgt_ranglijst_hdidField = value;
				base.RaisePropertyChanged("sgt_ranglijst_hdid");
			}
		}
		[XmlElement(Order = 48)]
		public Lookup sgt_ranglijst_heid
		{
			get
			{
				return this.sgt_ranglijst_heidField;
			}
			set
			{
				this.sgt_ranglijst_heidField = value;
				base.RaisePropertyChanged("sgt_ranglijst_heid");
			}
		}
		[XmlElement(Order = 49)]
		public Lookup sgt_ranglijst_mindervaliden_id
		{
			get
			{
				return this.sgt_ranglijst_mindervaliden_idField;
			}
			set
			{
				this.sgt_ranglijst_mindervaliden_idField = value;
				base.RaisePropertyChanged("sgt_ranglijst_mindervaliden_id");
			}
		}
		[XmlElement(Order = 50)]
		public CrmNumber sgt_speelsterkte_1_dames
		{
			get
			{
				return this.sgt_speelsterkte_1_damesField;
			}
			set
			{
				this.sgt_speelsterkte_1_damesField = value;
				base.RaisePropertyChanged("sgt_speelsterkte_1_dames");
			}
		}
		[XmlElement(Order = 51)]
		public CrmNumber sgt_speelsterkte_1_dames_dubbel
		{
			get
			{
				return this.sgt_speelsterkte_1_dames_dubbelField;
			}
			set
			{
				this.sgt_speelsterkte_1_dames_dubbelField = value;
				base.RaisePropertyChanged("sgt_speelsterkte_1_dames_dubbel");
			}
		}
		[XmlElement(Order = 52)]
		public CrmNumber sgt_speelsterkte_1_heren
		{
			get
			{
				return this.sgt_speelsterkte_1_herenField;
			}
			set
			{
				this.sgt_speelsterkte_1_herenField = value;
				base.RaisePropertyChanged("sgt_speelsterkte_1_heren");
			}
		}
		[XmlElement(Order = 53)]
		public CrmNumber sgt_speelsterkte_1_heren_dubbel
		{
			get
			{
				return this.sgt_speelsterkte_1_heren_dubbelField;
			}
			set
			{
				this.sgt_speelsterkte_1_heren_dubbelField = value;
				base.RaisePropertyChanged("sgt_speelsterkte_1_heren_dubbel");
			}
		}
		[XmlElement(Order = 54)]
		public CrmNumber sgt_speelsterkte_2_dames
		{
			get
			{
				return this.sgt_speelsterkte_2_damesField;
			}
			set
			{
				this.sgt_speelsterkte_2_damesField = value;
				base.RaisePropertyChanged("sgt_speelsterkte_2_dames");
			}
		}
		[XmlElement(Order = 55)]
		public CrmNumber sgt_speelsterkte_2_dames_dubbel
		{
			get
			{
				return this.sgt_speelsterkte_2_dames_dubbelField;
			}
			set
			{
				this.sgt_speelsterkte_2_dames_dubbelField = value;
				base.RaisePropertyChanged("sgt_speelsterkte_2_dames_dubbel");
			}
		}
		[XmlElement(Order = 56)]
		public CrmNumber sgt_speelsterkte_2_heren
		{
			get
			{
				return this.sgt_speelsterkte_2_herenField;
			}
			set
			{
				this.sgt_speelsterkte_2_herenField = value;
				base.RaisePropertyChanged("sgt_speelsterkte_2_heren");
			}
		}
		[XmlElement(Order = 57)]
		public CrmNumber sgt_speelsterkte_2_heren_dubbel
		{
			get
			{
				return this.sgt_speelsterkte_2_heren_dubbelField;
			}
			set
			{
				this.sgt_speelsterkte_2_heren_dubbelField = value;
				base.RaisePropertyChanged("sgt_speelsterkte_2_heren_dubbel");
			}
		}
		[XmlElement(Order = 58)]
		public CrmNumber sgt_sterkte_1_rating_dames
		{
			get
			{
				return this.sgt_sterkte_1_rating_damesField;
			}
			set
			{
				this.sgt_sterkte_1_rating_damesField = value;
				base.RaisePropertyChanged("sgt_sterkte_1_rating_dames");
			}
		}
		[XmlElement(Order = 59)]
		public CrmNumber sgt_sterkte_1_rating_dames_dubbel
		{
			get
			{
				return this.sgt_sterkte_1_rating_dames_dubbelField;
			}
			set
			{
				this.sgt_sterkte_1_rating_dames_dubbelField = value;
				base.RaisePropertyChanged("sgt_sterkte_1_rating_dames_dubbel");
			}
		}
		[XmlElement(Order = 60)]
		public CrmNumber sgt_sterkte_1_rating_heren
		{
			get
			{
				return this.sgt_sterkte_1_rating_herenField;
			}
			set
			{
				this.sgt_sterkte_1_rating_herenField = value;
				base.RaisePropertyChanged("sgt_sterkte_1_rating_heren");
			}
		}
		[XmlElement(Order = 61)]
		public CrmNumber sgt_sterkte_1_rating_heren_dubbel
		{
			get
			{
				return this.sgt_sterkte_1_rating_heren_dubbelField;
			}
			set
			{
				this.sgt_sterkte_1_rating_heren_dubbelField = value;
				base.RaisePropertyChanged("sgt_sterkte_1_rating_heren_dubbel");
			}
		}
		[XmlElement(Order = 62)]
		public CrmNumber sgt_sterkte_2_rating_dames
		{
			get
			{
				return this.sgt_sterkte_2_rating_damesField;
			}
			set
			{
				this.sgt_sterkte_2_rating_damesField = value;
				base.RaisePropertyChanged("sgt_sterkte_2_rating_dames");
			}
		}
		[XmlElement(Order = 63)]
		public CrmNumber sgt_sterkte_2_rating_dames_dubbel
		{
			get
			{
				return this.sgt_sterkte_2_rating_dames_dubbelField;
			}
			set
			{
				this.sgt_sterkte_2_rating_dames_dubbelField = value;
				base.RaisePropertyChanged("sgt_sterkte_2_rating_dames_dubbel");
			}
		}
		[XmlElement(Order = 64)]
		public CrmNumber sgt_sterkte_2_rating_heren
		{
			get
			{
				return this.sgt_sterkte_2_rating_herenField;
			}
			set
			{
				this.sgt_sterkte_2_rating_herenField = value;
				base.RaisePropertyChanged("sgt_sterkte_2_rating_heren");
			}
		}
		[XmlElement(Order = 65)]
		public CrmNumber sgt_sterkte_2_rating_heren_dubbel
		{
			get
			{
				return this.sgt_sterkte_2_rating_heren_dubbelField;
			}
			set
			{
				this.sgt_sterkte_2_rating_heren_dubbelField = value;
				base.RaisePropertyChanged("sgt_sterkte_2_rating_heren_dubbel");
			}
		}
		[XmlElement(Order = 66)]
		public Sgt_dss_variabelen_dssStateInfo statecode
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
		[XmlElement(Order = 67)]
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
		[XmlElement(Order = 68)]
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
		[XmlElement(Order = 69)]
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
