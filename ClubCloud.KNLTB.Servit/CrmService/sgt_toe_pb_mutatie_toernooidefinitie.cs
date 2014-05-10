using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
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
		public string sgt_aanhef_tav
		{
			get
			{
				return this.sgt_aanhef_tavField;
			}
			set
			{
				this.sgt_aanhef_tavField = value;
			}
		}
		public string sgt_accountnumber
		{
			get
			{
				return this.sgt_accountnumberField;
			}
			set
			{
				this.sgt_accountnumberField = value;
			}
		}
		public CrmDateTime sgt_begindatum
		{
			get
			{
				return this.sgt_begindatumField;
			}
			set
			{
				this.sgt_begindatumField = value;
			}
		}
		public string sgt_bestandsnaam
		{
			get
			{
				return this.sgt_bestandsnaamField;
			}
			set
			{
				this.sgt_bestandsnaamField = value;
			}
		}
		public string sgt_bg_emailadres
		{
			get
			{
				return this.sgt_bg_emailadresField;
			}
			set
			{
				this.sgt_bg_emailadresField = value;
			}
		}
		public string sgt_bg_mobiele_telefoon
		{
			get
			{
				return this.sgt_bg_mobiele_telefoonField;
			}
			set
			{
				this.sgt_bg_mobiele_telefoonField = value;
			}
		}
		public string sgt_bg_telefoon_overdag
		{
			get
			{
				return this.sgt_bg_telefoon_overdagField;
			}
			set
			{
				this.sgt_bg_telefoon_overdagField = value;
			}
		}
		public string sgt_bg_telefoon_savonds
		{
			get
			{
				return this.sgt_bg_telefoon_savondsField;
			}
			set
			{
				this.sgt_bg_telefoon_savondsField = value;
			}
		}
		public Lookup sgt_bondsgedelegeerde_id
		{
			get
			{
				return this.sgt_bondsgedelegeerde_idField;
			}
			set
			{
				this.sgt_bondsgedelegeerde_idField = value;
			}
		}
		public Lookup sgt_dag_toernooinaam_id
		{
			get
			{
				return this.sgt_dag_toernooinaam_idField;
			}
			set
			{
				this.sgt_dag_toernooinaam_idField = value;
			}
		}
		public CrmDateTime sgt_datum_mutatie_verwerkt
		{
			get
			{
				return this.sgt_datum_mutatie_verwerktField;
			}
			set
			{
				this.sgt_datum_mutatie_verwerktField = value;
			}
		}
		public string sgt_dtd_versie
		{
			get
			{
				return this.sgt_dtd_versieField;
			}
			set
			{
				this.sgt_dtd_versieField = value;
			}
		}
		public CrmDateTime sgt_einddatum
		{
			get
			{
				return this.sgt_einddatumField;
			}
			set
			{
				this.sgt_einddatumField = value;
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
		public Lookup sgt_hoofdscheidsrechter_id
		{
			get
			{
				return this.sgt_hoofdscheidsrechter_idField;
			}
			set
			{
				this.sgt_hoofdscheidsrechter_idField = value;
			}
		}
		public string sgt_hs_emailadres
		{
			get
			{
				return this.sgt_hs_emailadresField;
			}
			set
			{
				this.sgt_hs_emailadresField = value;
			}
		}
		public string sgt_hs_mobiele_telefoon
		{
			get
			{
				return this.sgt_hs_mobiele_telefoonField;
			}
			set
			{
				this.sgt_hs_mobiele_telefoonField = value;
			}
		}
		public string sgt_hs_telefoon_overdag
		{
			get
			{
				return this.sgt_hs_telefoon_overdagField;
			}
			set
			{
				this.sgt_hs_telefoon_overdagField = value;
			}
		}
		public string sgt_hs_telefoon_savonds
		{
			get
			{
				return this.sgt_hs_telefoon_savondsField;
			}
			set
			{
				this.sgt_hs_telefoon_savondsField = value;
			}
		}
		public string sgt_huisnummer
		{
			get
			{
				return this.sgt_huisnummerField;
			}
			set
			{
				this.sgt_huisnummerField = value;
			}
		}
		public Picklist sgt_import_export
		{
			get
			{
				return this.sgt_import_exportField;
			}
			set
			{
				this.sgt_import_exportField = value;
			}
		}
		public Lookup sgt_pb_itf_log_toernooien_id
		{
			get
			{
				return this.sgt_pb_itf_log_toernooien_idField;
			}
			set
			{
				this.sgt_pb_itf_log_toernooien_idField = value;
			}
		}
		public string sgt_plaatsnaam
		{
			get
			{
				return this.sgt_plaatsnaamField;
			}
			set
			{
				this.sgt_plaatsnaamField = value;
			}
		}
		public string sgt_postcode
		{
			get
			{
				return this.sgt_postcodeField;
			}
			set
			{
				this.sgt_postcodeField = value;
			}
		}
		public string sgt_status
		{
			get
			{
				return this.sgt_statusField;
			}
			set
			{
				this.sgt_statusField = value;
			}
		}
		public string sgt_straat
		{
			get
			{
				return this.sgt_straatField;
			}
			set
			{
				this.sgt_straatField = value;
			}
		}
		public string sgt_telefoonnummer
		{
			get
			{
				return this.sgt_telefoonnummerField;
			}
			set
			{
				this.sgt_telefoonnummerField = value;
			}
		}
		public Key sgt_toe_pb_mutatie_toernooidefinitieid
		{
			get
			{
				return this.sgt_toe_pb_mutatie_toernooidefinitieidField;
			}
			set
			{
				this.sgt_toe_pb_mutatie_toernooidefinitieidField = value;
			}
		}
		public string sgt_toe_volgnummer
		{
			get
			{
				return this.sgt_toe_volgnummerField;
			}
			set
			{
				this.sgt_toe_volgnummerField = value;
			}
		}
		public Lookup sgt_toernooi_aanvraag_verwerking_id
		{
			get
			{
				return this.sgt_toernooi_aanvraag_verwerking_idField;
			}
			set
			{
				this.sgt_toernooi_aanvraag_verwerking_idField = value;
			}
		}
		public Lookup sgt_toernooinaam_id
		{
			get
			{
				return this.sgt_toernooinaam_idField;
			}
			set
			{
				this.sgt_toernooinaam_idField = value;
			}
		}
		public string sgt_toernooinummer
		{
			get
			{
				return this.sgt_toernooinummerField;
			}
			set
			{
				this.sgt_toernooinummerField = value;
			}
		}
		public Lookup sgt_toernooiorganisatie_id
		{
			get
			{
				return this.sgt_toernooiorganisatie_idField;
			}
			set
			{
				this.sgt_toernooiorganisatie_idField = value;
			}
		}
		public string sgt_toevoeging
		{
			get
			{
				return this.sgt_toevoegingField;
			}
			set
			{
				this.sgt_toevoegingField = value;
			}
		}
		public string sgt_website
		{
			get
			{
				return this.sgt_websiteField;
			}
			set
			{
				this.sgt_websiteField = value;
			}
		}
		public Lookup sgt_wedstrijdleider_id
		{
			get
			{
				return this.sgt_wedstrijdleider_idField;
			}
			set
			{
				this.sgt_wedstrijdleider_idField = value;
			}
		}
		public string sgt_wl_emailadres
		{
			get
			{
				return this.sgt_wl_emailadresField;
			}
			set
			{
				this.sgt_wl_emailadresField = value;
			}
		}
		public string sgt_wl_mobiele_telefoon
		{
			get
			{
				return this.sgt_wl_mobiele_telefoonField;
			}
			set
			{
				this.sgt_wl_mobiele_telefoonField = value;
			}
		}
		public string sgt_wl_telefoon_overdag
		{
			get
			{
				return this.sgt_wl_telefoon_overdagField;
			}
			set
			{
				this.sgt_wl_telefoon_overdagField = value;
			}
		}
		public string sgt_wl_telefoon_savonds
		{
			get
			{
				return this.sgt_wl_telefoon_savondsField;
			}
			set
			{
				this.sgt_wl_telefoon_savondsField = value;
			}
		}
		public Sgt_toe_pb_mutatie_toernooidefinitieStateInfo statecode
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
