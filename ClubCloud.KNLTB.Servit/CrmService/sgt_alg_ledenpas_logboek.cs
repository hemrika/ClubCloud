using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[GeneratedCode("System.Xml", "4.0.30319.33440")]
	[Serializable]
	[XmlType(Namespace="http://schemas.microsoft.com/crm/2007/WebServices")]
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

		[XmlElement] //[XmlElement(Order=0)]
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

		[XmlElement] //[XmlElement(Order=1)]
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

		[XmlElement] //[XmlElement(Order=2)]
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

		[XmlElement] //[XmlElement(Order=3)]
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

		[XmlElement] //[XmlElement(Order=4)]
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

		[XmlElement] //[XmlElement(Order=5)]
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

		[XmlElement] //[XmlElement(Order=6)]
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

		[XmlElement] //[XmlElement(Order=7)]
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

		[XmlElement] //[XmlElement(Order=8)]
		public Key sgt_alg_ledenpas_logboekid
		{
			get
			{
				return this.sgt_alg_ledenpas_logboekidField;
			}
			set
			{
				this.sgt_alg_ledenpas_logboekidField = value;
				base.RaisePropertyChanged("sgt_alg_ledenpas_logboekid");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public string sgt_alg_lognummer
		{
			get
			{
				return this.sgt_alg_lognummerField;
			}
			set
			{
				this.sgt_alg_lognummerField = value;
				base.RaisePropertyChanged("sgt_alg_lognummer");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public Lookup sgt_bericht_passen_naar_id
		{
			get
			{
				return this.sgt_bericht_passen_naar_idField;
			}
			set
			{
				this.sgt_bericht_passen_naar_idField = value;
				base.RaisePropertyChanged("sgt_bericht_passen_naar_id");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public CrmDateTime sgt_datum_export
		{
			get
			{
				return this.sgt_datum_exportField;
			}
			set
			{
				this.sgt_datum_exportField = value;
				base.RaisePropertyChanged("sgt_datum_export");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public CrmDateTime sgt_datum_lidmaatschap_vanaf
		{
			get
			{
				return this.sgt_datum_lidmaatschap_vanafField;
			}
			set
			{
				this.sgt_datum_lidmaatschap_vanafField = value;
				base.RaisePropertyChanged("sgt_datum_lidmaatschap_vanaf");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public CrmDateTime sgt_datum_tm
		{
			get
			{
				return this.sgt_datum_tmField;
			}
			set
			{
				this.sgt_datum_tmField = value;
				base.RaisePropertyChanged("sgt_datum_tm");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public Lookup sgt_district_id
		{
			get
			{
				return this.sgt_district_idField;
			}
			set
			{
				this.sgt_district_idField = value;
				base.RaisePropertyChanged("sgt_district_id");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public CrmBoolean sgt_export_aanmaken
		{
			get
			{
				return this.sgt_export_aanmakenField;
			}
			set
			{
				this.sgt_export_aanmakenField = value;
				base.RaisePropertyChanged("sgt_export_aanmaken");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public CrmNumber sgt_export_aantal_leden_fout
		{
			get
			{
				return this.sgt_export_aantal_leden_foutField;
			}
			set
			{
				this.sgt_export_aantal_leden_foutField = value;
				base.RaisePropertyChanged("sgt_export_aantal_leden_fout");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public CrmNumber sgt_export_aantal_leden_goed
		{
			get
			{
				return this.sgt_export_aantal_leden_goedField;
			}
			set
			{
				this.sgt_export_aantal_leden_goedField = value;
				base.RaisePropertyChanged("sgt_export_aantal_leden_goed");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public CrmNumber sgt_export_aantal_verenigingen_fout
		{
			get
			{
				return this.sgt_export_aantal_verenigingen_foutField;
			}
			set
			{
				this.sgt_export_aantal_verenigingen_foutField = value;
				base.RaisePropertyChanged("sgt_export_aantal_verenigingen_fout");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
		public CrmNumber sgt_export_aantal_verenigingen_goed
		{
			get
			{
				return this.sgt_export_aantal_verenigingen_goedField;
			}
			set
			{
				this.sgt_export_aantal_verenigingen_goedField = value;
				base.RaisePropertyChanged("sgt_export_aantal_verenigingen_goed");
			}
		}

		[XmlElement] //[XmlElement(Order=20)]
		public string sgt_extra_info_exporteren
		{
			get
			{
				return this.sgt_extra_info_exporterenField;
			}
			set
			{
				this.sgt_extra_info_exporterenField = value;
				base.RaisePropertyChanged("sgt_extra_info_exporteren");
			}
		}

		[XmlElement] //[XmlElement(Order=21)]
		public string sgt_extra_info_kopieeractie
		{
			get
			{
				return this.sgt_extra_info_kopieeractieField;
			}
			set
			{
				this.sgt_extra_info_kopieeractieField = value;
				base.RaisePropertyChanged("sgt_extra_info_kopieeractie");
			}
		}

		[XmlElement] //[XmlElement(Order=22)]
		public string sgt_jaartal_op_pas
		{
			get
			{
				return this.sgt_jaartal_op_pasField;
			}
			set
			{
				this.sgt_jaartal_op_pasField = value;
				base.RaisePropertyChanged("sgt_jaartal_op_pas");
			}
		}

		[XmlElement] //[XmlElement(Order=23)]
		public Picklist sgt_kopieeractie
		{
			get
			{
				return this.sgt_kopieeractieField;
			}
			set
			{
				this.sgt_kopieeractieField = value;
				base.RaisePropertyChanged("sgt_kopieeractie");
			}
		}

		[XmlElement] //[XmlElement(Order=24)]
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

		[XmlElement] //[XmlElement(Order=25)]
		public Picklist sgt_opdracht_type
		{
			get
			{
				return this.sgt_opdracht_typeField;
			}
			set
			{
				this.sgt_opdracht_typeField = value;
				base.RaisePropertyChanged("sgt_opdracht_type");
			}
		}

		[XmlElement] //[XmlElement(Order=26)]
		public CrmBoolean sgt_opnieuw
		{
			get
			{
				return this.sgt_opnieuwField;
			}
			set
			{
				this.sgt_opnieuwField = value;
				base.RaisePropertyChanged("sgt_opnieuw");
			}
		}

		[XmlElement] //[XmlElement(Order=27)]
		public CrmBoolean sgt_pas_rechtstreeks
		{
			get
			{
				return this.sgt_pas_rechtstreeksField;
			}
			set
			{
				this.sgt_pas_rechtstreeksField = value;
				base.RaisePropertyChanged("sgt_pas_rechtstreeks");
			}
		}

		[XmlElement] //[XmlElement(Order=28)]
		public Lookup sgt_pastype_id
		{
			get
			{
				return this.sgt_pastype_idField;
			}
			set
			{
				this.sgt_pastype_idField = value;
				base.RaisePropertyChanged("sgt_pastype_id");
			}
		}

		[XmlElement] //[XmlElement(Order=29)]
		public Lookup sgt_regio_id
		{
			get
			{
				return this.sgt_regio_idField;
			}
			set
			{
				this.sgt_regio_idField = value;
				base.RaisePropertyChanged("sgt_regio_id");
			}
		}

		[XmlElement] //[XmlElement(Order=30)]
		public Picklist sgt_soort_export
		{
			get
			{
				return this.sgt_soort_exportField;
			}
			set
			{
				this.sgt_soort_exportField = value;
				base.RaisePropertyChanged("sgt_soort_export");
			}
		}

		[XmlElement] //[XmlElement(Order=31)]
		public Lookup sgt_soort_lidmaatschap_id
		{
			get
			{
				return this.sgt_soort_lidmaatschap_idField;
			}
			set
			{
				this.sgt_soort_lidmaatschap_idField = value;
				base.RaisePropertyChanged("sgt_soort_lidmaatschap_id");
			}
		}

		[XmlElement] //[XmlElement(Order=32)]
		public Picklist sgt_status_exporteren
		{
			get
			{
				return this.sgt_status_exporterenField;
			}
			set
			{
				this.sgt_status_exporterenField = value;
				base.RaisePropertyChanged("sgt_status_exporteren");
			}
		}

		[XmlElement] //[XmlElement(Order=33)]
		public Picklist sgt_status_kopieren
		{
			get
			{
				return this.sgt_status_kopierenField;
			}
			set
			{
				this.sgt_status_kopierenField = value;
				base.RaisePropertyChanged("sgt_status_kopieren");
			}
		}

		[XmlElement] //[XmlElement(Order=34)]
		public Picklist sgt_vereniging_of_leden
		{
			get
			{
				return this.sgt_vereniging_of_ledenField;
			}
			set
			{
				this.sgt_vereniging_of_ledenField = value;
				base.RaisePropertyChanged("sgt_vereniging_of_leden");
			}
		}

		[XmlElement] //[XmlElement(Order=35)]
		public Sgt_alg_ledenpas_logboekStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=36)]
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

		[XmlElement] //[XmlElement(Order=37)]
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

		[XmlElement] //[XmlElement(Order=38)]
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

		public sgt_alg_ledenpas_logboek()
		{
		}
	}
}