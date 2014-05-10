using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
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
		public CrmNumber sgt_aantal_partij_resultaten_dubbel
		{
			get
			{
				return this.sgt_aantal_partij_resultaten_dubbelField;
			}
			set
			{
				this.sgt_aantal_partij_resultaten_dubbelField = value;
			}
		}
		public CrmNumber sgt_aantal_partij_resultaten_dubbel_dss
		{
			get
			{
				return this.sgt_aantal_partij_resultaten_dubbel_dssField;
			}
			set
			{
				this.sgt_aantal_partij_resultaten_dubbel_dssField = value;
			}
		}
		public CrmNumber sgt_aantal_partij_resultaten_enkel_dss
		{
			get
			{
				return this.sgt_aantal_partij_resultaten_enkel_dssField;
			}
			set
			{
				this.sgt_aantal_partij_resultaten_enkel_dssField = value;
			}
		}
		public CrmNumber sgt_aantal_partij_resultatenenkel
		{
			get
			{
				return this.sgt_aantal_partij_resultatenenkelField;
			}
			set
			{
				this.sgt_aantal_partij_resultatenenkelField = value;
			}
		}
		public CrmBoolean sgt_alleen_in_te_schrijven
		{
			get
			{
				return this.sgt_alleen_in_te_schrijvenField;
			}
			set
			{
				this.sgt_alleen_in_te_schrijvenField = value;
			}
		}
		public CrmDecimal sgt_basisgetal_dubbel
		{
			get
			{
				return this.sgt_basisgetal_dubbelField;
			}
			set
			{
				this.sgt_basisgetal_dubbelField = value;
			}
		}
		public CrmDecimal sgt_basisgetal_enkel
		{
			get
			{
				return this.sgt_basisgetal_enkelField;
			}
			set
			{
				this.sgt_basisgetal_enkelField = value;
			}
		}
		public Lookup sgt_bonusranglijst_tm_14id
		{
			get
			{
				return this.sgt_bonusranglijst_tm_14idField;
			}
			set
			{
				this.sgt_bonusranglijst_tm_14idField = value;
			}
		}
		public Lookup sgt_bonusranglijst_tm_16id
		{
			get
			{
				return this.sgt_bonusranglijst_tm_16idField;
			}
			set
			{
				this.sgt_bonusranglijst_tm_16idField = value;
			}
		}
		public CrmBoolean sgt_buitenland_dubbel_pr_dss
		{
			get
			{
				return this.sgt_buitenland_dubbel_pr_dssField;
			}
			set
			{
				this.sgt_buitenland_dubbel_pr_dssField = value;
			}
		}
		public CrmBoolean sgt_buitenland_dubbel_pr_er
		{
			get
			{
				return this.sgt_buitenland_dubbel_pr_erField;
			}
			set
			{
				this.sgt_buitenland_dubbel_pr_erField = value;
			}
		}
		public CrmBoolean sgt_buitenland_enkel_pr_dss
		{
			get
			{
				return this.sgt_buitenland_enkel_pr_dssField;
			}
			set
			{
				this.sgt_buitenland_enkel_pr_dssField = value;
			}
		}
		public CrmBoolean sgt_buitenland_enkel_pr_er
		{
			get
			{
				return this.sgt_buitenland_enkel_pr_erField;
			}
			set
			{
				this.sgt_buitenland_enkel_pr_erField = value;
			}
		}
		public CrmDateTime sgt_datum_aangepast
		{
			get
			{
				return this.sgt_datum_aangepastField;
			}
			set
			{
				this.sgt_datum_aangepastField = value;
			}
		}
		public CrmDateTime sgt_datum_dss
		{
			get
			{
				return this.sgt_datum_dssField;
			}
			set
			{
				this.sgt_datum_dssField = value;
			}
		}
		public CrmDateTime sgt_datum_overleden
		{
			get
			{
				return this.sgt_datum_overledenField;
			}
			set
			{
				this.sgt_datum_overledenField = value;
			}
		}
		public Lookup sgt_default_toernooisoortid
		{
			get
			{
				return this.sgt_default_toernooisoortidField;
			}
			set
			{
				this.sgt_default_toernooisoortidField = value;
			}
		}
		public Picklist sgt_default_type_inschrijving
		{
			get
			{
				return this.sgt_default_type_inschrijvingField;
			}
			set
			{
				this.sgt_default_type_inschrijvingField = value;
			}
		}
		public CrmDecimal sgt_dss_basigetal_dubbel_handmatig
		{
			get
			{
				return this.sgt_dss_basigetal_dubbel_handmatigField;
			}
			set
			{
				this.sgt_dss_basigetal_dubbel_handmatigField = value;
			}
		}
		public CrmDecimal sgt_dss_basigetal_enkel_handmatig
		{
			get
			{
				return this.sgt_dss_basigetal_enkel_handmatigField;
			}
			set
			{
				this.sgt_dss_basigetal_enkel_handmatigField = value;
			}
		}
		public CrmDecimal sgt_dss_bg_d_hnd
		{
			get
			{
				return this.sgt_dss_bg_d_hndField;
			}
			set
			{
				this.sgt_dss_bg_d_hndField = value;
			}
		}
		public CrmDecimal sgt_dss_bg_e_hnd
		{
			get
			{
				return this.sgt_dss_bg_e_hndField;
			}
			set
			{
				this.sgt_dss_bg_e_hndField = value;
			}
		}
		public string sgt_dss_bondsnummer
		{
			get
			{
				return this.sgt_dss_bondsnummerField;
			}
			set
			{
				this.sgt_dss_bondsnummerField = value;
			}
		}
		public CrmNumber sgt_dss_d_hnd
		{
			get
			{
				return this.sgt_dss_d_hndField;
			}
			set
			{
				this.sgt_dss_d_hndField = value;
			}
		}
		public CrmNumber sgt_dss_dubbel_bepaald
		{
			get
			{
				return this.sgt_dss_dubbel_bepaaldField;
			}
			set
			{
				this.sgt_dss_dubbel_bepaaldField = value;
			}
		}
		public CrmNumber sgt_dss_dubbel_handmatig
		{
			get
			{
				return this.sgt_dss_dubbel_handmatigField;
			}
			set
			{
				this.sgt_dss_dubbel_handmatigField = value;
			}
		}
		public CrmNumber sgt_dss_e_hnd
		{
			get
			{
				return this.sgt_dss_e_hndField;
			}
			set
			{
				this.sgt_dss_e_hndField = value;
			}
		}
		public CrmNumber sgt_dss_enkel_bepaald
		{
			get
			{
				return this.sgt_dss_enkel_bepaaldField;
			}
			set
			{
				this.sgt_dss_enkel_bepaaldField = value;
			}
		}
		public CrmNumber sgt_dss_enkel_handmatig
		{
			get
			{
				return this.sgt_dss_enkel_handmatigField;
			}
			set
			{
				this.sgt_dss_enkel_handmatigField = value;
			}
		}
		public Key sgt_dss_spelersprofielid
		{
			get
			{
				return this.sgt_dss_spelersprofielidField;
			}
			set
			{
				this.sgt_dss_spelersprofielidField = value;
			}
		}
		public CrmBoolean sgt_dubbel_degradatie_9
		{
			get
			{
				return this.sgt_dubbel_degradatie_9Field;
			}
			set
			{
				this.sgt_dubbel_degradatie_9Field = value;
			}
		}
		public CrmBoolean sgt_dubbel_pr_dss
		{
			get
			{
				return this.sgt_dubbel_pr_dssField;
			}
			set
			{
				this.sgt_dubbel_pr_dssField = value;
			}
		}
		public CrmBoolean sgt_dubbel_pr_er
		{
			get
			{
				return this.sgt_dubbel_pr_erField;
			}
			set
			{
				this.sgt_dubbel_pr_erField = value;
			}
		}
		public CrmDecimal sgt_eindejaarsrating_dubbel
		{
			get
			{
				return this.sgt_eindejaarsrating_dubbelField;
			}
			set
			{
				this.sgt_eindejaarsrating_dubbelField = value;
			}
		}
		public CrmDecimal sgt_eindejaarsrating_enkel
		{
			get
			{
				return this.sgt_eindejaarsrating_enkelField;
			}
			set
			{
				this.sgt_eindejaarsrating_enkelField = value;
			}
		}
		public CrmBoolean sgt_enkel_degradatie_9
		{
			get
			{
				return this.sgt_enkel_degradatie_9Field;
			}
			set
			{
				this.sgt_enkel_degradatie_9Field = value;
			}
		}
		public CrmBoolean sgt_enkel_pr_dss
		{
			get
			{
				return this.sgt_enkel_pr_dssField;
			}
			set
			{
				this.sgt_enkel_pr_dssField = value;
			}
		}
		public CrmBoolean sgt_enkel_pr_er
		{
			get
			{
				return this.sgt_enkel_pr_erField;
			}
			set
			{
				this.sgt_enkel_pr_erField = value;
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
		public CrmBoolean sgt_geen_pr_betere_dss
		{
			get
			{
				return this.sgt_geen_pr_betere_dssField;
			}
			set
			{
				this.sgt_geen_pr_betere_dssField = value;
			}
		}
		public CrmBoolean sgt_geen_pr_betere_dss_dubbel
		{
			get
			{
				return this.sgt_geen_pr_betere_dss_dubbelField;
			}
			set
			{
				this.sgt_geen_pr_betere_dss_dubbelField = value;
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
		public CrmBoolean sgt_minder_valide_speler
		{
			get
			{
				return this.sgt_minder_valide_spelerField;
			}
			set
			{
				this.sgt_minder_valide_spelerField = value;
			}
		}
		public Lookup sgt_naamid
		{
			get
			{
				return this.sgt_naamidField;
			}
			set
			{
				this.sgt_naamidField = value;
			}
		}
		public CrmNumber sgt_partijreslutaten_dubbel_laatste
		{
			get
			{
				return this.sgt_partijreslutaten_dubbel_laatsteField;
			}
			set
			{
				this.sgt_partijreslutaten_dubbel_laatsteField = value;
			}
		}
		public CrmNumber sgt_partijresultaten_enkel_laatste
		{
			get
			{
				return this.sgt_partijresultaten_enkel_laatsteField;
			}
			set
			{
				this.sgt_partijresultaten_enkel_laatsteField = value;
			}
		}
		public CrmDecimal sgt_rating_dubbel
		{
			get
			{
				return this.sgt_rating_dubbelField;
			}
			set
			{
				this.sgt_rating_dubbelField = value;
			}
		}
		public CrmDecimal sgt_rating_enkel
		{
			get
			{
				return this.sgt_rating_enkelField;
			}
			set
			{
				this.sgt_rating_enkelField = value;
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
		public CrmNumber sgt_speelsterkte_dubbel_oud
		{
			get
			{
				return this.sgt_speelsterkte_dubbel_oudField;
			}
			set
			{
				this.sgt_speelsterkte_dubbel_oudField = value;
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
		public CrmNumber sgt_speelsterkte_enkel_oud
		{
			get
			{
				return this.sgt_speelsterkte_enkel_oudField;
			}
			set
			{
				this.sgt_speelsterkte_enkel_oudField = value;
			}
		}
		public Lookup sgt_speelsterktebepaling_id
		{
			get
			{
				return this.sgt_speelsterktebepaling_idField;
			}
			set
			{
				this.sgt_speelsterktebepaling_idField = value;
			}
		}
		public CrmBoolean sgt_sterke_buitenlander
		{
			get
			{
				return this.sgt_sterke_buitenlanderField;
			}
			set
			{
				this.sgt_sterke_buitenlanderField = value;
			}
		}
		public Lookup sgt_tennisnationaliteitid
		{
			get
			{
				return this.sgt_tennisnationaliteitidField;
			}
			set
			{
				this.sgt_tennisnationaliteitidField = value;
			}
		}
		public Sgt_dss_spelersprofielStateInfo statecode
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
