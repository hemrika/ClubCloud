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
		public CrmDecimal sgt_acceleratie_jeugd_extra_jongens
		{
			get
			{
				return this.sgt_acceleratie_jeugd_extra_jongensField;
			}
			set
			{
				this.sgt_acceleratie_jeugd_extra_jongensField = value;
			}
		}
		public CrmDecimal sgt_acceleratie_jeugd_extra_meisjes
		{
			get
			{
				return this.sgt_acceleratie_jeugd_extra_meisjesField;
			}
			set
			{
				this.sgt_acceleratie_jeugd_extra_meisjesField = value;
			}
		}
		public CrmDecimal sgt_acceleratie_jeugd_jongens
		{
			get
			{
				return this.sgt_acceleratie_jeugd_jongensField;
			}
			set
			{
				this.sgt_acceleratie_jeugd_jongensField = value;
			}
		}
		public CrmDecimal sgt_acceleratie_jeugd_meisjes
		{
			get
			{
				return this.sgt_acceleratie_jeugd_meisjesField;
			}
			set
			{
				this.sgt_acceleratie_jeugd_meisjesField = value;
			}
		}
		public CrmNumber sgt_basisresultaten
		{
			get
			{
				return this.sgt_basisresultatenField;
			}
			set
			{
				this.sgt_basisresultatenField = value;
			}
		}
		public CrmDecimal sgt_dempingwaarde_1
		{
			get
			{
				return this.sgt_dempingwaarde_1Field;
			}
			set
			{
				this.sgt_dempingwaarde_1Field = value;
			}
		}
		public CrmDecimal sgt_dempingwaarde_2
		{
			get
			{
				return this.sgt_dempingwaarde_2Field;
			}
			set
			{
				this.sgt_dempingwaarde_2Field = value;
			}
		}
		public CrmDecimal sgt_dempingwaarde_3
		{
			get
			{
				return this.sgt_dempingwaarde_3Field;
			}
			set
			{
				this.sgt_dempingwaarde_3Field = value;
			}
		}
		public string sgt_dss_code
		{
			get
			{
				return this.sgt_dss_codeField;
			}
			set
			{
				this.sgt_dss_codeField = value;
			}
		}
		public Key sgt_dss_variabelen_dssid
		{
			get
			{
				return this.sgt_dss_variabelen_dssidField;
			}
			set
			{
				this.sgt_dss_variabelen_dssidField = value;
			}
		}
		public CrmDecimal sgt_inactiviteitswaarde_dubbel
		{
			get
			{
				return this.sgt_inactiviteitswaarde_dubbelField;
			}
			set
			{
				this.sgt_inactiviteitswaarde_dubbelField = value;
			}
		}
		public CrmDecimal sgt_inactiviteitswaarde_enkel
		{
			get
			{
				return this.sgt_inactiviteitswaarde_enkelField;
			}
			set
			{
				this.sgt_inactiviteitswaarde_enkelField = value;
			}
		}
		public CrmNumber sgt_leeftijd_tot_en_met_1
		{
			get
			{
				return this.sgt_leeftijd_tot_en_met_1Field;
			}
			set
			{
				this.sgt_leeftijd_tot_en_met_1Field = value;
			}
		}
		public CrmNumber sgt_leeftijd_tot_en_met_2
		{
			get
			{
				return this.sgt_leeftijd_tot_en_met_2Field;
			}
			set
			{
				this.sgt_leeftijd_tot_en_met_2Field = value;
			}
		}
		public CrmNumber sgt_leeftijd_tot_en_met_3
		{
			get
			{
				return this.sgt_leeftijd_tot_en_met_3Field;
			}
			set
			{
				this.sgt_leeftijd_tot_en_met_3Field = value;
			}
		}
		public CrmNumber sgt_leeftijd_tot_en_met_extra_jongens
		{
			get
			{
				return this.sgt_leeftijd_tot_en_met_extra_jongensField;
			}
			set
			{
				this.sgt_leeftijd_tot_en_met_extra_jongensField = value;
			}
		}
		public CrmNumber sgt_leeftijd_tot_en_met_extra_meisjes
		{
			get
			{
				return this.sgt_leeftijd_tot_en_met_extra_meisjesField;
			}
			set
			{
				this.sgt_leeftijd_tot_en_met_extra_meisjesField = value;
			}
		}
		public CrmNumber sgt_leeftijd_tot_en_met_jongens
		{
			get
			{
				return this.sgt_leeftijd_tot_en_met_jongensField;
			}
			set
			{
				this.sgt_leeftijd_tot_en_met_jongensField = value;
			}
		}
		public CrmNumber sgt_leeftijd_tot_en_met_meisjes
		{
			get
			{
				return this.sgt_leeftijd_tot_en_met_meisjesField;
			}
			set
			{
				this.sgt_leeftijd_tot_en_met_meisjesField = value;
			}
		}
		public CrmNumber sgt_leeftijd_vanaf_1
		{
			get
			{
				return this.sgt_leeftijd_vanaf_1Field;
			}
			set
			{
				this.sgt_leeftijd_vanaf_1Field = value;
			}
		}
		public CrmNumber sgt_leeftijd_vanaf_2
		{
			get
			{
				return this.sgt_leeftijd_vanaf_2Field;
			}
			set
			{
				this.sgt_leeftijd_vanaf_2Field = value;
			}
		}
		public CrmNumber sgt_leeftijd_vanaf_3
		{
			get
			{
				return this.sgt_leeftijd_vanaf_3Field;
			}
			set
			{
				this.sgt_leeftijd_vanaf_3Field = value;
			}
		}
		public CrmNumber sgt_leeftijd_vanaf_extra_jongens
		{
			get
			{
				return this.sgt_leeftijd_vanaf_extra_jongensField;
			}
			set
			{
				this.sgt_leeftijd_vanaf_extra_jongensField = value;
			}
		}
		public CrmNumber sgt_leeftijd_vanaf_extra_meisjes
		{
			get
			{
				return this.sgt_leeftijd_vanaf_extra_meisjesField;
			}
			set
			{
				this.sgt_leeftijd_vanaf_extra_meisjesField = value;
			}
		}
		public CrmNumber sgt_leeftijd_vanaf_jongens
		{
			get
			{
				return this.sgt_leeftijd_vanaf_jongensField;
			}
			set
			{
				this.sgt_leeftijd_vanaf_jongensField = value;
			}
		}
		public CrmNumber sgt_leeftijd_vanaf_meisjes
		{
			get
			{
				return this.sgt_leeftijd_vanaf_meisjesField;
			}
			set
			{
				this.sgt_leeftijd_vanaf_meisjesField = value;
			}
		}
		public CrmNumber sgt_leeftijd_vanaf_minimale_rating
		{
			get
			{
				return this.sgt_leeftijd_vanaf_minimale_ratingField;
			}
			set
			{
				this.sgt_leeftijd_vanaf_minimale_ratingField = value;
			}
		}
		public CrmDecimal sgt_maximale_rating
		{
			get
			{
				return this.sgt_maximale_ratingField;
			}
			set
			{
				this.sgt_maximale_ratingField = value;
			}
		}
		public CrmDecimal sgt_maximale_rating_na_2e_jaar
		{
			get
			{
				return this.sgt_maximale_rating_na_2e_jaarField;
			}
			set
			{
				this.sgt_maximale_rating_na_2e_jaarField = value;
			}
		}
		public CrmNumber sgt_min_resultaten_overgang_3_naar_2
		{
			get
			{
				return this.sgt_min_resultaten_overgang_3_naar_2Field;
			}
			set
			{
				this.sgt_min_resultaten_overgang_3_naar_2Field = value;
			}
		}
		public CrmNumber sgt_min_resultaten_overgang_naar_1
		{
			get
			{
				return this.sgt_min_resultaten_overgang_naar_1Field;
			}
			set
			{
				this.sgt_min_resultaten_overgang_naar_1Field = value;
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
		public CrmNumber sgt_partijen_voor_acceleratie_jongens
		{
			get
			{
				return this.sgt_partijen_voor_acceleratie_jongensField;
			}
			set
			{
				this.sgt_partijen_voor_acceleratie_jongensField = value;
			}
		}
		public CrmNumber sgt_partijen_voor_acceleratie_meisjes
		{
			get
			{
				return this.sgt_partijen_voor_acceleratie_meisjesField;
			}
			set
			{
				this.sgt_partijen_voor_acceleratie_meisjesField = value;
			}
		}
		public CrmNumber sgt_partijen_voor_demping_1
		{
			get
			{
				return this.sgt_partijen_voor_demping_1Field;
			}
			set
			{
				this.sgt_partijen_voor_demping_1Field = value;
			}
		}
		public CrmNumber sgt_partijen_voor_demping_2
		{
			get
			{
				return this.sgt_partijen_voor_demping_2Field;
			}
			set
			{
				this.sgt_partijen_voor_demping_2Field = value;
			}
		}
		public CrmNumber sgt_partijen_voor_demping_3
		{
			get
			{
				return this.sgt_partijen_voor_demping_3Field;
			}
			set
			{
				this.sgt_partijen_voor_demping_3Field = value;
			}
		}
		public Lookup sgt_ranglijst_ddid
		{
			get
			{
				return this.sgt_ranglijst_ddidField;
			}
			set
			{
				this.sgt_ranglijst_ddidField = value;
			}
		}
		public Lookup sgt_ranglijst_deid
		{
			get
			{
				return this.sgt_ranglijst_deidField;
			}
			set
			{
				this.sgt_ranglijst_deidField = value;
			}
		}
		public Lookup sgt_ranglijst_hdid
		{
			get
			{
				return this.sgt_ranglijst_hdidField;
			}
			set
			{
				this.sgt_ranglijst_hdidField = value;
			}
		}
		public Lookup sgt_ranglijst_heid
		{
			get
			{
				return this.sgt_ranglijst_heidField;
			}
			set
			{
				this.sgt_ranglijst_heidField = value;
			}
		}
		public Lookup sgt_ranglijst_mindervaliden_id
		{
			get
			{
				return this.sgt_ranglijst_mindervaliden_idField;
			}
			set
			{
				this.sgt_ranglijst_mindervaliden_idField = value;
			}
		}
		public CrmNumber sgt_speelsterkte_1_dames
		{
			get
			{
				return this.sgt_speelsterkte_1_damesField;
			}
			set
			{
				this.sgt_speelsterkte_1_damesField = value;
			}
		}
		public CrmNumber sgt_speelsterkte_1_dames_dubbel
		{
			get
			{
				return this.sgt_speelsterkte_1_dames_dubbelField;
			}
			set
			{
				this.sgt_speelsterkte_1_dames_dubbelField = value;
			}
		}
		public CrmNumber sgt_speelsterkte_1_heren
		{
			get
			{
				return this.sgt_speelsterkte_1_herenField;
			}
			set
			{
				this.sgt_speelsterkte_1_herenField = value;
			}
		}
		public CrmNumber sgt_speelsterkte_1_heren_dubbel
		{
			get
			{
				return this.sgt_speelsterkte_1_heren_dubbelField;
			}
			set
			{
				this.sgt_speelsterkte_1_heren_dubbelField = value;
			}
		}
		public CrmNumber sgt_speelsterkte_2_dames
		{
			get
			{
				return this.sgt_speelsterkte_2_damesField;
			}
			set
			{
				this.sgt_speelsterkte_2_damesField = value;
			}
		}
		public CrmNumber sgt_speelsterkte_2_dames_dubbel
		{
			get
			{
				return this.sgt_speelsterkte_2_dames_dubbelField;
			}
			set
			{
				this.sgt_speelsterkte_2_dames_dubbelField = value;
			}
		}
		public CrmNumber sgt_speelsterkte_2_heren
		{
			get
			{
				return this.sgt_speelsterkte_2_herenField;
			}
			set
			{
				this.sgt_speelsterkte_2_herenField = value;
			}
		}
		public CrmNumber sgt_speelsterkte_2_heren_dubbel
		{
			get
			{
				return this.sgt_speelsterkte_2_heren_dubbelField;
			}
			set
			{
				this.sgt_speelsterkte_2_heren_dubbelField = value;
			}
		}
		public CrmNumber sgt_sterkte_1_rating_dames
		{
			get
			{
				return this.sgt_sterkte_1_rating_damesField;
			}
			set
			{
				this.sgt_sterkte_1_rating_damesField = value;
			}
		}
		public CrmNumber sgt_sterkte_1_rating_dames_dubbel
		{
			get
			{
				return this.sgt_sterkte_1_rating_dames_dubbelField;
			}
			set
			{
				this.sgt_sterkte_1_rating_dames_dubbelField = value;
			}
		}
		public CrmNumber sgt_sterkte_1_rating_heren
		{
			get
			{
				return this.sgt_sterkte_1_rating_herenField;
			}
			set
			{
				this.sgt_sterkte_1_rating_herenField = value;
			}
		}
		public CrmNumber sgt_sterkte_1_rating_heren_dubbel
		{
			get
			{
				return this.sgt_sterkte_1_rating_heren_dubbelField;
			}
			set
			{
				this.sgt_sterkte_1_rating_heren_dubbelField = value;
			}
		}
		public CrmNumber sgt_sterkte_2_rating_dames
		{
			get
			{
				return this.sgt_sterkte_2_rating_damesField;
			}
			set
			{
				this.sgt_sterkte_2_rating_damesField = value;
			}
		}
		public CrmNumber sgt_sterkte_2_rating_dames_dubbel
		{
			get
			{
				return this.sgt_sterkte_2_rating_dames_dubbelField;
			}
			set
			{
				this.sgt_sterkte_2_rating_dames_dubbelField = value;
			}
		}
		public CrmNumber sgt_sterkte_2_rating_heren
		{
			get
			{
				return this.sgt_sterkte_2_rating_herenField;
			}
			set
			{
				this.sgt_sterkte_2_rating_herenField = value;
			}
		}
		public CrmNumber sgt_sterkte_2_rating_heren_dubbel
		{
			get
			{
				return this.sgt_sterkte_2_rating_heren_dubbelField;
			}
			set
			{
				this.sgt_sterkte_2_rating_heren_dubbelField = value;
			}
		}
		public Sgt_dss_variabelen_dssStateInfo statecode
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
