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
	public class sgt_toe_pb_mutatie_toernooidefinitie : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private string sgt_aanhef_tavField;

		private string sgt_accountnumberField;

		private CrmDateTime sgt_begindatumField;

		private string sgt_bestandsnaamField;

		private string sgt_bg_emailadresField;

		private string sgt_bg_mobiele_telefoonField;

		private string sgt_bg_telefoon_overdagField;

		private string sgt_bg_telefoon_savondsField;

		private Lookup sgt_bondsgedelegeerde_idField;

		private Lookup sgt_dag_toernooinaam_idField;

		private CrmDateTime sgt_datum_mutatie_verwerktField;

		private string sgt_dtd_versieField;

		private CrmDateTime sgt_einddatumField;

		private string sgt_emailField;

		private Lookup sgt_hoofdscheidsrechter_idField;

		private string sgt_hs_emailadresField;

		private string sgt_hs_mobiele_telefoonField;

		private string sgt_hs_telefoon_overdagField;

		private string sgt_hs_telefoon_savondsField;

		private string sgt_huisnummerField;

		private Picklist sgt_import_exportField;

		private Lookup sgt_pb_itf_log_toernooien_idField;

		private string sgt_plaatsnaamField;

		private string sgt_postcodeField;

		private string sgt_statusField;

		private string sgt_straatField;

		private string sgt_telefoonnummerField;

		private Key sgt_toe_pb_mutatie_toernooidefinitieidField;

		private string sgt_toe_volgnummerField;

		private Lookup sgt_toernooi_aanvraag_verwerking_idField;

		private Lookup sgt_toernooinaam_idField;

		private string sgt_toernooinummerField;

		private Lookup sgt_toernooiorganisatie_idField;

		private string sgt_toevoegingField;

		private string sgt_websiteField;

		private Lookup sgt_wedstrijdleider_idField;

		private string sgt_wl_emailadresField;

		private string sgt_wl_mobiele_telefoonField;

		private string sgt_wl_telefoon_overdagField;

		private string sgt_wl_telefoon_savondsField;

		private Sgt_toe_pb_mutatie_toernooidefinitieStateInfo statecodeField;

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
		public string sgt_aanhef_tav
		{
			get
			{
				return this.sgt_aanhef_tavField;
			}
			set
			{
				this.sgt_aanhef_tavField = value;
				base.RaisePropertyChanged("sgt_aanhef_tav");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public string sgt_accountnumber
		{
			get
			{
				return this.sgt_accountnumberField;
			}
			set
			{
				this.sgt_accountnumberField = value;
				base.RaisePropertyChanged("sgt_accountnumber");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public CrmDateTime sgt_begindatum
		{
			get
			{
				return this.sgt_begindatumField;
			}
			set
			{
				this.sgt_begindatumField = value;
				base.RaisePropertyChanged("sgt_begindatum");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public string sgt_bestandsnaam
		{
			get
			{
				return this.sgt_bestandsnaamField;
			}
			set
			{
				this.sgt_bestandsnaamField = value;
				base.RaisePropertyChanged("sgt_bestandsnaam");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public string sgt_bg_emailadres
		{
			get
			{
				return this.sgt_bg_emailadresField;
			}
			set
			{
				this.sgt_bg_emailadresField = value;
				base.RaisePropertyChanged("sgt_bg_emailadres");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public string sgt_bg_mobiele_telefoon
		{
			get
			{
				return this.sgt_bg_mobiele_telefoonField;
			}
			set
			{
				this.sgt_bg_mobiele_telefoonField = value;
				base.RaisePropertyChanged("sgt_bg_mobiele_telefoon");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public string sgt_bg_telefoon_overdag
		{
			get
			{
				return this.sgt_bg_telefoon_overdagField;
			}
			set
			{
				this.sgt_bg_telefoon_overdagField = value;
				base.RaisePropertyChanged("sgt_bg_telefoon_overdag");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public string sgt_bg_telefoon_savonds
		{
			get
			{
				return this.sgt_bg_telefoon_savondsField;
			}
			set
			{
				this.sgt_bg_telefoon_savondsField = value;
				base.RaisePropertyChanged("sgt_bg_telefoon_savonds");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public Lookup sgt_bondsgedelegeerde_id
		{
			get
			{
				return this.sgt_bondsgedelegeerde_idField;
			}
			set
			{
				this.sgt_bondsgedelegeerde_idField = value;
				base.RaisePropertyChanged("sgt_bondsgedelegeerde_id");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public Lookup sgt_dag_toernooinaam_id
		{
			get
			{
				return this.sgt_dag_toernooinaam_idField;
			}
			set
			{
				this.sgt_dag_toernooinaam_idField = value;
				base.RaisePropertyChanged("sgt_dag_toernooinaam_id");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public CrmDateTime sgt_datum_mutatie_verwerkt
		{
			get
			{
				return this.sgt_datum_mutatie_verwerktField;
			}
			set
			{
				this.sgt_datum_mutatie_verwerktField = value;
				base.RaisePropertyChanged("sgt_datum_mutatie_verwerkt");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
		public string sgt_dtd_versie
		{
			get
			{
				return this.sgt_dtd_versieField;
			}
			set
			{
				this.sgt_dtd_versieField = value;
				base.RaisePropertyChanged("sgt_dtd_versie");
			}
		}

		[XmlElement] //[XmlElement(Order=20)]
		public CrmDateTime sgt_einddatum
		{
			get
			{
				return this.sgt_einddatumField;
			}
			set
			{
				this.sgt_einddatumField = value;
				base.RaisePropertyChanged("sgt_einddatum");
			}
		}

		[XmlElement] //[XmlElement(Order=21)]
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

		[XmlElement] //[XmlElement(Order=22)]
		public Lookup sgt_hoofdscheidsrechter_id
		{
			get
			{
				return this.sgt_hoofdscheidsrechter_idField;
			}
			set
			{
				this.sgt_hoofdscheidsrechter_idField = value;
				base.RaisePropertyChanged("sgt_hoofdscheidsrechter_id");
			}
		}

		[XmlElement] //[XmlElement(Order=23)]
		public string sgt_hs_emailadres
		{
			get
			{
				return this.sgt_hs_emailadresField;
			}
			set
			{
				this.sgt_hs_emailadresField = value;
				base.RaisePropertyChanged("sgt_hs_emailadres");
			}
		}

		[XmlElement] //[XmlElement(Order=24)]
		public string sgt_hs_mobiele_telefoon
		{
			get
			{
				return this.sgt_hs_mobiele_telefoonField;
			}
			set
			{
				this.sgt_hs_mobiele_telefoonField = value;
				base.RaisePropertyChanged("sgt_hs_mobiele_telefoon");
			}
		}

		[XmlElement] //[XmlElement(Order=25)]
		public string sgt_hs_telefoon_overdag
		{
			get
			{
				return this.sgt_hs_telefoon_overdagField;
			}
			set
			{
				this.sgt_hs_telefoon_overdagField = value;
				base.RaisePropertyChanged("sgt_hs_telefoon_overdag");
			}
		}

		[XmlElement] //[XmlElement(Order=26)]
		public string sgt_hs_telefoon_savonds
		{
			get
			{
				return this.sgt_hs_telefoon_savondsField;
			}
			set
			{
				this.sgt_hs_telefoon_savondsField = value;
				base.RaisePropertyChanged("sgt_hs_telefoon_savonds");
			}
		}

		[XmlElement] //[XmlElement(Order=27)]
		public string sgt_huisnummer
		{
			get
			{
				return this.sgt_huisnummerField;
			}
			set
			{
				this.sgt_huisnummerField = value;
				base.RaisePropertyChanged("sgt_huisnummer");
			}
		}

		[XmlElement] //[XmlElement(Order=28)]
		public Picklist sgt_import_export
		{
			get
			{
				return this.sgt_import_exportField;
			}
			set
			{
				this.sgt_import_exportField = value;
				base.RaisePropertyChanged("sgt_import_export");
			}
		}

		[XmlElement] //[XmlElement(Order=29)]
		public Lookup sgt_pb_itf_log_toernooien_id
		{
			get
			{
				return this.sgt_pb_itf_log_toernooien_idField;
			}
			set
			{
				this.sgt_pb_itf_log_toernooien_idField = value;
				base.RaisePropertyChanged("sgt_pb_itf_log_toernooien_id");
			}
		}

		[XmlElement] //[XmlElement(Order=30)]
		public string sgt_plaatsnaam
		{
			get
			{
				return this.sgt_plaatsnaamField;
			}
			set
			{
				this.sgt_plaatsnaamField = value;
				base.RaisePropertyChanged("sgt_plaatsnaam");
			}
		}

		[XmlElement] //[XmlElement(Order=31)]
		public string sgt_postcode
		{
			get
			{
				return this.sgt_postcodeField;
			}
			set
			{
				this.sgt_postcodeField = value;
				base.RaisePropertyChanged("sgt_postcode");
			}
		}

		[XmlElement] //[XmlElement(Order=32)]
		public string sgt_status
		{
			get
			{
				return this.sgt_statusField;
			}
			set
			{
				this.sgt_statusField = value;
				base.RaisePropertyChanged("sgt_status");
			}
		}

		[XmlElement] //[XmlElement(Order=33)]
		public string sgt_straat
		{
			get
			{
				return this.sgt_straatField;
			}
			set
			{
				this.sgt_straatField = value;
				base.RaisePropertyChanged("sgt_straat");
			}
		}

		[XmlElement] //[XmlElement(Order=34)]
		public string sgt_telefoonnummer
		{
			get
			{
				return this.sgt_telefoonnummerField;
			}
			set
			{
				this.sgt_telefoonnummerField = value;
				base.RaisePropertyChanged("sgt_telefoonnummer");
			}
		}

		[XmlElement] //[XmlElement(Order=35)]
		public Key sgt_toe_pb_mutatie_toernooidefinitieid
		{
			get
			{
				return this.sgt_toe_pb_mutatie_toernooidefinitieidField;
			}
			set
			{
				this.sgt_toe_pb_mutatie_toernooidefinitieidField = value;
				base.RaisePropertyChanged("sgt_toe_pb_mutatie_toernooidefinitieid");
			}
		}

		[XmlElement] //[XmlElement(Order=36)]
		public string sgt_toe_volgnummer
		{
			get
			{
				return this.sgt_toe_volgnummerField;
			}
			set
			{
				this.sgt_toe_volgnummerField = value;
				base.RaisePropertyChanged("sgt_toe_volgnummer");
			}
		}

		[XmlElement] //[XmlElement(Order=37)]
		public Lookup sgt_toernooi_aanvraag_verwerking_id
		{
			get
			{
				return this.sgt_toernooi_aanvraag_verwerking_idField;
			}
			set
			{
				this.sgt_toernooi_aanvraag_verwerking_idField = value;
				base.RaisePropertyChanged("sgt_toernooi_aanvraag_verwerking_id");
			}
		}

		[XmlElement] //[XmlElement(Order=38)]
		public Lookup sgt_toernooinaam_id
		{
			get
			{
				return this.sgt_toernooinaam_idField;
			}
			set
			{
				this.sgt_toernooinaam_idField = value;
				base.RaisePropertyChanged("sgt_toernooinaam_id");
			}
		}

		[XmlElement] //[XmlElement(Order=39)]
		public string sgt_toernooinummer
		{
			get
			{
				return this.sgt_toernooinummerField;
			}
			set
			{
				this.sgt_toernooinummerField = value;
				base.RaisePropertyChanged("sgt_toernooinummer");
			}
		}

		[XmlElement] //[XmlElement(Order=40)]
		public Lookup sgt_toernooiorganisatie_id
		{
			get
			{
				return this.sgt_toernooiorganisatie_idField;
			}
			set
			{
				this.sgt_toernooiorganisatie_idField = value;
				base.RaisePropertyChanged("sgt_toernooiorganisatie_id");
			}
		}

		[XmlElement] //[XmlElement(Order=41)]
		public string sgt_toevoeging
		{
			get
			{
				return this.sgt_toevoegingField;
			}
			set
			{
				this.sgt_toevoegingField = value;
				base.RaisePropertyChanged("sgt_toevoeging");
			}
		}

		[XmlElement] //[XmlElement(Order=42)]
		public string sgt_website
		{
			get
			{
				return this.sgt_websiteField;
			}
			set
			{
				this.sgt_websiteField = value;
				base.RaisePropertyChanged("sgt_website");
			}
		}

		[XmlElement] //[XmlElement(Order=43)]
		public Lookup sgt_wedstrijdleider_id
		{
			get
			{
				return this.sgt_wedstrijdleider_idField;
			}
			set
			{
				this.sgt_wedstrijdleider_idField = value;
				base.RaisePropertyChanged("sgt_wedstrijdleider_id");
			}
		}

		[XmlElement] //[XmlElement(Order=44)]
		public string sgt_wl_emailadres
		{
			get
			{
				return this.sgt_wl_emailadresField;
			}
			set
			{
				this.sgt_wl_emailadresField = value;
				base.RaisePropertyChanged("sgt_wl_emailadres");
			}
		}

		[XmlElement] //[XmlElement(Order=45)]
		public string sgt_wl_mobiele_telefoon
		{
			get
			{
				return this.sgt_wl_mobiele_telefoonField;
			}
			set
			{
				this.sgt_wl_mobiele_telefoonField = value;
				base.RaisePropertyChanged("sgt_wl_mobiele_telefoon");
			}
		}

		[XmlElement] //[XmlElement(Order=46)]
		public string sgt_wl_telefoon_overdag
		{
			get
			{
				return this.sgt_wl_telefoon_overdagField;
			}
			set
			{
				this.sgt_wl_telefoon_overdagField = value;
				base.RaisePropertyChanged("sgt_wl_telefoon_overdag");
			}
		}

		[XmlElement] //[XmlElement(Order=47)]
		public string sgt_wl_telefoon_savonds
		{
			get
			{
				return this.sgt_wl_telefoon_savondsField;
			}
			set
			{
				this.sgt_wl_telefoon_savondsField = value;
				base.RaisePropertyChanged("sgt_wl_telefoon_savonds");
			}
		}

		[XmlElement] //[XmlElement(Order=48)]
		public Sgt_toe_pb_mutatie_toernooidefinitieStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=49)]
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

		[XmlElement] //[XmlElement(Order=50)]
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

		[XmlElement] //[XmlElement(Order=51)]
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

		public sgt_toe_pb_mutatie_toernooidefinitie()
		{
		}
	}
}