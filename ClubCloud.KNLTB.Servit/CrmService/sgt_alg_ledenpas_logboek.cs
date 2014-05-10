using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_alg_ledenpas_logboek : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private Key sgt_alg_ledenpas_logboekidField;
		private string sgt_alg_lognummerField;
		private Lookup sgt_bericht_passen_naar_idField;
		private CrmDateTime sgt_datum_exportField;
		private CrmDateTime sgt_datum_lidmaatschap_vanafField;
		private CrmDateTime sgt_datum_tmField;
		private Lookup sgt_district_idField;
		private CrmBoolean sgt_export_aanmakenField;
		private CrmNumber sgt_export_aantal_leden_foutField;
		private CrmNumber sgt_export_aantal_leden_goedField;
		private CrmNumber sgt_export_aantal_verenigingen_foutField;
		private CrmNumber sgt_export_aantal_verenigingen_goedField;
		private string sgt_extra_info_exporterenField;
		private string sgt_extra_info_kopieeractieField;
		private string sgt_jaartal_op_pasField;
		private Picklist sgt_kopieeractieField;
		private string sgt_omschrijvingField;
		private Picklist sgt_opdracht_typeField;
		private CrmBoolean sgt_opnieuwField;
		private CrmBoolean sgt_pas_rechtstreeksField;
		private Lookup sgt_pastype_idField;
		private Lookup sgt_regio_idField;
		private Picklist sgt_soort_exportField;
		private Lookup sgt_soort_lidmaatschap_idField;
		private Picklist sgt_status_exporterenField;
		private Picklist sgt_status_kopierenField;
		private Picklist sgt_vereniging_of_ledenField;
		private Sgt_alg_ledenpas_logboekStateInfo statecodeField;
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
		public Key sgt_alg_ledenpas_logboekid
		{
			get
			{
				return this.sgt_alg_ledenpas_logboekidField;
			}
			set
			{
				this.sgt_alg_ledenpas_logboekidField = value;
			}
		}
		public string sgt_alg_lognummer
		{
			get
			{
				return this.sgt_alg_lognummerField;
			}
			set
			{
				this.sgt_alg_lognummerField = value;
			}
		}
		public Lookup sgt_bericht_passen_naar_id
		{
			get
			{
				return this.sgt_bericht_passen_naar_idField;
			}
			set
			{
				this.sgt_bericht_passen_naar_idField = value;
			}
		}
		public CrmDateTime sgt_datum_export
		{
			get
			{
				return this.sgt_datum_exportField;
			}
			set
			{
				this.sgt_datum_exportField = value;
			}
		}
		public CrmDateTime sgt_datum_lidmaatschap_vanaf
		{
			get
			{
				return this.sgt_datum_lidmaatschap_vanafField;
			}
			set
			{
				this.sgt_datum_lidmaatschap_vanafField = value;
			}
		}
		public CrmDateTime sgt_datum_tm
		{
			get
			{
				return this.sgt_datum_tmField;
			}
			set
			{
				this.sgt_datum_tmField = value;
			}
		}
		public Lookup sgt_district_id
		{
			get
			{
				return this.sgt_district_idField;
			}
			set
			{
				this.sgt_district_idField = value;
			}
		}
		public CrmBoolean sgt_export_aanmaken
		{
			get
			{
				return this.sgt_export_aanmakenField;
			}
			set
			{
				this.sgt_export_aanmakenField = value;
			}
		}
		public CrmNumber sgt_export_aantal_leden_fout
		{
			get
			{
				return this.sgt_export_aantal_leden_foutField;
			}
			set
			{
				this.sgt_export_aantal_leden_foutField = value;
			}
		}
		public CrmNumber sgt_export_aantal_leden_goed
		{
			get
			{
				return this.sgt_export_aantal_leden_goedField;
			}
			set
			{
				this.sgt_export_aantal_leden_goedField = value;
			}
		}
		public CrmNumber sgt_export_aantal_verenigingen_fout
		{
			get
			{
				return this.sgt_export_aantal_verenigingen_foutField;
			}
			set
			{
				this.sgt_export_aantal_verenigingen_foutField = value;
			}
		}
		public CrmNumber sgt_export_aantal_verenigingen_goed
		{
			get
			{
				return this.sgt_export_aantal_verenigingen_goedField;
			}
			set
			{
				this.sgt_export_aantal_verenigingen_goedField = value;
			}
		}
		public string sgt_extra_info_exporteren
		{
			get
			{
				return this.sgt_extra_info_exporterenField;
			}
			set
			{
				this.sgt_extra_info_exporterenField = value;
			}
		}
		public string sgt_extra_info_kopieeractie
		{
			get
			{
				return this.sgt_extra_info_kopieeractieField;
			}
			set
			{
				this.sgt_extra_info_kopieeractieField = value;
			}
		}
		public string sgt_jaartal_op_pas
		{
			get
			{
				return this.sgt_jaartal_op_pasField;
			}
			set
			{
				this.sgt_jaartal_op_pasField = value;
			}
		}
		public Picklist sgt_kopieeractie
		{
			get
			{
				return this.sgt_kopieeractieField;
			}
			set
			{
				this.sgt_kopieeractieField = value;
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
		public Picklist sgt_opdracht_type
		{
			get
			{
				return this.sgt_opdracht_typeField;
			}
			set
			{
				this.sgt_opdracht_typeField = value;
			}
		}
		public CrmBoolean sgt_opnieuw
		{
			get
			{
				return this.sgt_opnieuwField;
			}
			set
			{
				this.sgt_opnieuwField = value;
			}
		}
		public CrmBoolean sgt_pas_rechtstreeks
		{
			get
			{
				return this.sgt_pas_rechtstreeksField;
			}
			set
			{
				this.sgt_pas_rechtstreeksField = value;
			}
		}
		public Lookup sgt_pastype_id
		{
			get
			{
				return this.sgt_pastype_idField;
			}
			set
			{
				this.sgt_pastype_idField = value;
			}
		}
		public Lookup sgt_regio_id
		{
			get
			{
				return this.sgt_regio_idField;
			}
			set
			{
				this.sgt_regio_idField = value;
			}
		}
		public Picklist sgt_soort_export
		{
			get
			{
				return this.sgt_soort_exportField;
			}
			set
			{
				this.sgt_soort_exportField = value;
			}
		}
		public Lookup sgt_soort_lidmaatschap_id
		{
			get
			{
				return this.sgt_soort_lidmaatschap_idField;
			}
			set
			{
				this.sgt_soort_lidmaatschap_idField = value;
			}
		}
		public Picklist sgt_status_exporteren
		{
			get
			{
				return this.sgt_status_exporterenField;
			}
			set
			{
				this.sgt_status_exporterenField = value;
			}
		}
		public Picklist sgt_status_kopieren
		{
			get
			{
				return this.sgt_status_kopierenField;
			}
			set
			{
				this.sgt_status_kopierenField = value;
			}
		}
		public Picklist sgt_vereniging_of_leden
		{
			get
			{
				return this.sgt_vereniging_of_ledenField;
			}
			set
			{
				this.sgt_vereniging_of_ledenField = value;
			}
		}
		public Sgt_alg_ledenpas_logboekStateInfo statecode
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
