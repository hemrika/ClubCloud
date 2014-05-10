using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_alg_pb_mutatie_functionarissen : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private Lookup sgt_2e_nationaliteitidField;
		private string sgt_achternaamField;
		private CrmBoolean sgt_adres_geheimField;
		private Key sgt_alg_pb_mutatie_functionarissenidField;
		private Lookup sgt_bestuursorgaanidField;
		private string sgt_bestuursorgaanid_naamField;
		private string sgt_bondsnummerField;
		private CrmDateTime sgt_datum_mutatie_verwerktField;
		private CrmDateTime sgt_datum_overledenField;
		private Lookup sgt_districtidField;
		private string sgt_districtid_naamField;
		private CrmBoolean sgt_do_not_bulk_emailField;
		private CrmBoolean sgt_do_not_emailField;
		private CrmBoolean sgt_do_not_faxField;
		private CrmBoolean sgt_do_not_phoneField;
		private CrmBoolean sgt_do_not_postal_mailField;
		private string sgt_emailadresField;
		private string sgt_emailadres2Field;
		private string sgt_emailadres3Field;
		private string sgt_faxField;
		private Lookup sgt_functieidField;
		private string sgt_functieid_naamField;
		private Lookup sgt_functionarisidField;
		private CrmDateTime sgt_geboortedatumField;
		private string sgt_gemeente_paField;
		private string sgt_gemeente_waField;
		private Picklist sgt_geslachtField;
		private string sgt_huisnummer_paField;
		private string sgt_huisnummer_waField;
		private Picklist sgt_import_exportField;
		private Lookup sgt_landcode_postadresidField;
		private Lookup sgt_landcode_woonadresidField;
		private CrmBoolean sgt_meerlingField;
		private string sgt_mobielField;
		private Lookup sgt_nationaliteitidField;
		private CrmBoolean sgt_ongeldige_licentie_tennisleraarField;
		private Lookup sgt_pb_interface_logboek_export_xmlidField;
		private Lookup sgt_pb_interface_logboek_import_xmlidField;
		private Lookup sgt_pb_interface_logboekidField;
		private Lookup sgt_persoonidField;
		private string sgt_plaats_paField;
		private string sgt_plaats_waField;
		private string sgt_postcode_paField;
		private string sgt_postcode_waField;
		private string sgt_roepnaamField;
		private string sgt_straat_paField;
		private string sgt_straat_waField;
		private string sgt_telefoon_avondField;
		private CrmBoolean sgt_telefoon_geheimField;
		private string sgt_telefoon_overdagField;
		private CrmDateTime sgt_termijn_begintField;
		private CrmDateTime sgt_termijn_loopt_afField;
		private string sgt_toevoeging_paField;
		private string sgt_toevoeging_waField;
		private string sgt_tussenvoegselsField;
		private Picklist sgt_type_mutatieField;
		private Lookup sgt_verenigingidField;
		private string sgt_verenigingsnummerField;
		private string sgt_volgnummerField;
		private string sgt_volledige_naamField;
		private Picklist sgt_voorkeur_contactwijzeField;
		private string sgt_voorlettersField;
		private string sgt_voornamenField;
		private Sgt_alg_pb_mutatie_functionarissenStateInfo statecodeField;
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
		public Lookup sgt_2e_nationaliteitid
		{
			get
			{
				return this.sgt_2e_nationaliteitidField;
			}
			set
			{
				this.sgt_2e_nationaliteitidField = value;
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
		public CrmBoolean sgt_adres_geheim
		{
			get
			{
				return this.sgt_adres_geheimField;
			}
			set
			{
				this.sgt_adres_geheimField = value;
			}
		}
		public Key sgt_alg_pb_mutatie_functionarissenid
		{
			get
			{
				return this.sgt_alg_pb_mutatie_functionarissenidField;
			}
			set
			{
				this.sgt_alg_pb_mutatie_functionarissenidField = value;
			}
		}
		public Lookup sgt_bestuursorgaanid
		{
			get
			{
				return this.sgt_bestuursorgaanidField;
			}
			set
			{
				this.sgt_bestuursorgaanidField = value;
			}
		}
		public string sgt_bestuursorgaanid_naam
		{
			get
			{
				return this.sgt_bestuursorgaanid_naamField;
			}
			set
			{
				this.sgt_bestuursorgaanid_naamField = value;
			}
		}
		public string sgt_bondsnummer
		{
			get
			{
				return this.sgt_bondsnummerField;
			}
			set
			{
				this.sgt_bondsnummerField = value;
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
		public string sgt_districtid_naam
		{
			get
			{
				return this.sgt_districtid_naamField;
			}
			set
			{
				this.sgt_districtid_naamField = value;
			}
		}
		public CrmBoolean sgt_do_not_bulk_email
		{
			get
			{
				return this.sgt_do_not_bulk_emailField;
			}
			set
			{
				this.sgt_do_not_bulk_emailField = value;
			}
		}
		public CrmBoolean sgt_do_not_email
		{
			get
			{
				return this.sgt_do_not_emailField;
			}
			set
			{
				this.sgt_do_not_emailField = value;
			}
		}
		public CrmBoolean sgt_do_not_fax
		{
			get
			{
				return this.sgt_do_not_faxField;
			}
			set
			{
				this.sgt_do_not_faxField = value;
			}
		}
		public CrmBoolean sgt_do_not_phone
		{
			get
			{
				return this.sgt_do_not_phoneField;
			}
			set
			{
				this.sgt_do_not_phoneField = value;
			}
		}
		public CrmBoolean sgt_do_not_postal_mail
		{
			get
			{
				return this.sgt_do_not_postal_mailField;
			}
			set
			{
				this.sgt_do_not_postal_mailField = value;
			}
		}
		public string sgt_emailadres
		{
			get
			{
				return this.sgt_emailadresField;
			}
			set
			{
				this.sgt_emailadresField = value;
			}
		}
		public string sgt_emailadres2
		{
			get
			{
				return this.sgt_emailadres2Field;
			}
			set
			{
				this.sgt_emailadres2Field = value;
			}
		}
		public string sgt_emailadres3
		{
			get
			{
				return this.sgt_emailadres3Field;
			}
			set
			{
				this.sgt_emailadres3Field = value;
			}
		}
		public string sgt_fax
		{
			get
			{
				return this.sgt_faxField;
			}
			set
			{
				this.sgt_faxField = value;
			}
		}
		public Lookup sgt_functieid
		{
			get
			{
				return this.sgt_functieidField;
			}
			set
			{
				this.sgt_functieidField = value;
			}
		}
		public string sgt_functieid_naam
		{
			get
			{
				return this.sgt_functieid_naamField;
			}
			set
			{
				this.sgt_functieid_naamField = value;
			}
		}
		public Lookup sgt_functionarisid
		{
			get
			{
				return this.sgt_functionarisidField;
			}
			set
			{
				this.sgt_functionarisidField = value;
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
		public string sgt_gemeente_pa
		{
			get
			{
				return this.sgt_gemeente_paField;
			}
			set
			{
				this.sgt_gemeente_paField = value;
			}
		}
		public string sgt_gemeente_wa
		{
			get
			{
				return this.sgt_gemeente_waField;
			}
			set
			{
				this.sgt_gemeente_waField = value;
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
		public string sgt_huisnummer_pa
		{
			get
			{
				return this.sgt_huisnummer_paField;
			}
			set
			{
				this.sgt_huisnummer_paField = value;
			}
		}
		public string sgt_huisnummer_wa
		{
			get
			{
				return this.sgt_huisnummer_waField;
			}
			set
			{
				this.sgt_huisnummer_waField = value;
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
		public Lookup sgt_landcode_postadresid
		{
			get
			{
				return this.sgt_landcode_postadresidField;
			}
			set
			{
				this.sgt_landcode_postadresidField = value;
			}
		}
		public Lookup sgt_landcode_woonadresid
		{
			get
			{
				return this.sgt_landcode_woonadresidField;
			}
			set
			{
				this.sgt_landcode_woonadresidField = value;
			}
		}
		public CrmBoolean sgt_meerling
		{
			get
			{
				return this.sgt_meerlingField;
			}
			set
			{
				this.sgt_meerlingField = value;
			}
		}
		public string sgt_mobiel
		{
			get
			{
				return this.sgt_mobielField;
			}
			set
			{
				this.sgt_mobielField = value;
			}
		}
		public Lookup sgt_nationaliteitid
		{
			get
			{
				return this.sgt_nationaliteitidField;
			}
			set
			{
				this.sgt_nationaliteitidField = value;
			}
		}
		public CrmBoolean sgt_ongeldige_licentie_tennisleraar
		{
			get
			{
				return this.sgt_ongeldige_licentie_tennisleraarField;
			}
			set
			{
				this.sgt_ongeldige_licentie_tennisleraarField = value;
			}
		}
		public Lookup sgt_pb_interface_logboek_export_xmlid
		{
			get
			{
				return this.sgt_pb_interface_logboek_export_xmlidField;
			}
			set
			{
				this.sgt_pb_interface_logboek_export_xmlidField = value;
			}
		}
		public Lookup sgt_pb_interface_logboek_import_xmlid
		{
			get
			{
				return this.sgt_pb_interface_logboek_import_xmlidField;
			}
			set
			{
				this.sgt_pb_interface_logboek_import_xmlidField = value;
			}
		}
		public Lookup sgt_pb_interface_logboekid
		{
			get
			{
				return this.sgt_pb_interface_logboekidField;
			}
			set
			{
				this.sgt_pb_interface_logboekidField = value;
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
		public string sgt_plaats_pa
		{
			get
			{
				return this.sgt_plaats_paField;
			}
			set
			{
				this.sgt_plaats_paField = value;
			}
		}
		public string sgt_plaats_wa
		{
			get
			{
				return this.sgt_plaats_waField;
			}
			set
			{
				this.sgt_plaats_waField = value;
			}
		}
		public string sgt_postcode_pa
		{
			get
			{
				return this.sgt_postcode_paField;
			}
			set
			{
				this.sgt_postcode_paField = value;
			}
		}
		public string sgt_postcode_wa
		{
			get
			{
				return this.sgt_postcode_waField;
			}
			set
			{
				this.sgt_postcode_waField = value;
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
		public string sgt_straat_pa
		{
			get
			{
				return this.sgt_straat_paField;
			}
			set
			{
				this.sgt_straat_paField = value;
			}
		}
		public string sgt_straat_wa
		{
			get
			{
				return this.sgt_straat_waField;
			}
			set
			{
				this.sgt_straat_waField = value;
			}
		}
		public string sgt_telefoon_avond
		{
			get
			{
				return this.sgt_telefoon_avondField;
			}
			set
			{
				this.sgt_telefoon_avondField = value;
			}
		}
		public CrmBoolean sgt_telefoon_geheim
		{
			get
			{
				return this.sgt_telefoon_geheimField;
			}
			set
			{
				this.sgt_telefoon_geheimField = value;
			}
		}
		public string sgt_telefoon_overdag
		{
			get
			{
				return this.sgt_telefoon_overdagField;
			}
			set
			{
				this.sgt_telefoon_overdagField = value;
			}
		}
		public CrmDateTime sgt_termijn_begint
		{
			get
			{
				return this.sgt_termijn_begintField;
			}
			set
			{
				this.sgt_termijn_begintField = value;
			}
		}
		public CrmDateTime sgt_termijn_loopt_af
		{
			get
			{
				return this.sgt_termijn_loopt_afField;
			}
			set
			{
				this.sgt_termijn_loopt_afField = value;
			}
		}
		public string sgt_toevoeging_pa
		{
			get
			{
				return this.sgt_toevoeging_paField;
			}
			set
			{
				this.sgt_toevoeging_paField = value;
			}
		}
		public string sgt_toevoeging_wa
		{
			get
			{
				return this.sgt_toevoeging_waField;
			}
			set
			{
				this.sgt_toevoeging_waField = value;
			}
		}
		public string sgt_tussenvoegsels
		{
			get
			{
				return this.sgt_tussenvoegselsField;
			}
			set
			{
				this.sgt_tussenvoegselsField = value;
			}
		}
		public Picklist sgt_type_mutatie
		{
			get
			{
				return this.sgt_type_mutatieField;
			}
			set
			{
				this.sgt_type_mutatieField = value;
			}
		}
		public Lookup sgt_verenigingid
		{
			get
			{
				return this.sgt_verenigingidField;
			}
			set
			{
				this.sgt_verenigingidField = value;
			}
		}
		public string sgt_verenigingsnummer
		{
			get
			{
				return this.sgt_verenigingsnummerField;
			}
			set
			{
				this.sgt_verenigingsnummerField = value;
			}
		}
		public string sgt_volgnummer
		{
			get
			{
				return this.sgt_volgnummerField;
			}
			set
			{
				this.sgt_volgnummerField = value;
			}
		}
		public string sgt_volledige_naam
		{
			get
			{
				return this.sgt_volledige_naamField;
			}
			set
			{
				this.sgt_volledige_naamField = value;
			}
		}
		public Picklist sgt_voorkeur_contactwijze
		{
			get
			{
				return this.sgt_voorkeur_contactwijzeField;
			}
			set
			{
				this.sgt_voorkeur_contactwijzeField = value;
			}
		}
		public string sgt_voorletters
		{
			get
			{
				return this.sgt_voorlettersField;
			}
			set
			{
				this.sgt_voorlettersField = value;
			}
		}
		public string sgt_voornamen
		{
			get
			{
				return this.sgt_voornamenField;
			}
			set
			{
				this.sgt_voornamenField = value;
			}
		}
		public Sgt_alg_pb_mutatie_functionarissenStateInfo statecode
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
