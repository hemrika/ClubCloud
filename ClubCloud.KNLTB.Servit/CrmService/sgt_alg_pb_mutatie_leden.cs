using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_alg_pb_mutatie_leden : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private Lookup sgt_2e_nationaliteit_idField;
		private string sgt_achternaamField;
		private CrmBoolean sgt_adres_geheimField;
		private Key sgt_alg_pb_mutatie_ledenidField;
		private string sgt_bondsnummerField;
		private Picklist sgt_burgerlijke_staatField;
		private CrmDateTime sgt_datum_mutatie_verwerktField;
		private CrmDateTime sgt_datum_opgezegdField;
		private CrmDateTime sgt_datum_overledenField;
		private string sgt_debiteurnummerField;
		private CrmBoolean sgt_do_not_bulk_emailField;
		private CrmBoolean sgt_do_not_bulk_postal_mailField;
		private CrmBoolean sgt_do_not_emailField;
		private CrmBoolean sgt_do_not_faxField;
		private CrmBoolean sgt_do_not_phoneField;
		private CrmBoolean sgt_do_not_postal_mailField;
		private string sgt_emailadresField;
		private string sgt_emailadres2Field;
		private string sgt_emailadres3Field;
		private string sgt_faxField;
		private string sgt_fotoField;
		private string sgt_fotonummerField;
		private CrmDateTime sgt_geboortedatumField;
		private string sgt_geboorteplaatsField;
		private string sgt_gemeente_paField;
		private string sgt_gemeente_waField;
		private Picklist sgt_geslachtField;
		private string sgt_huisnummer_paField;
		private string sgt_huisnummer_waField;
		private string sgt_iban_codeField;
		private Picklist sgt_import_exportField;
		private Picklist sgt_junior_seniorField;
		private Lookup sgt_landcode_postadres_idField;
		private Lookup sgt_landcode_woonadres_idField;
		private Lookup sgt_lid_bij_1e_vereniging_idField;
		private Lookup sgt_lid_idField;
		private CrmDateTime sgt_lidmaatschap_beindigdField;
		private CrmDateTime sgt_lidmaatschap_vanafField;
		private string sgt_lidnummer_bij_verenigingField;
		private CrmBoolean sgt_meerlingField;
		private string sgt_meldingField;
		private string sgt_mobielField;
		private Lookup sgt_nationaliteit_idField;
		private Lookup sgt_pb_interface_idField;
		private Lookup sgt_pb_interface_logboek_export_xmlidField;
		private Lookup sgt_pb_interface_logboek_idField;
		private Lookup sgt_pb_interface_logboek_importxmlidField;
		private Lookup sgt_pb_interface_logboek_leden_expidField;
		private Lookup sgt_pb_interface_logboek_leden_impidField;
		private string sgt_plaats_paField;
		private string sgt_plaats_waField;
		private string sgt_postcode_paField;
		private string sgt_postcode_waField;
		private CrmDecimal sgt_rating_dubbelField;
		private CrmDecimal sgt_rating_enkelField;
		private string sgt_rekeningnummerField;
		private string sgt_roepnaamField;
		private Lookup sgt_soort_lidmaatschapidField;
		private CrmNumber sgt_speelsterkte_dubbelField;
		private CrmNumber sgt_speelsterkte_enkelField;
		private string sgt_straat_paField;
		private string sgt_straat_waField;
		private string sgt_telefoon_avondField;
		private CrmBoolean sgt_telefoon_geheimField;
		private string sgt_telefoon_overdagField;
		private Lookup sgt_tennisnationaliteit_idField;
		private string sgt_toevoeging_paField;
		private string sgt_toevoeging_waField;
		private string sgt_tussenvoegselsField;
		private Picklist sgt_type_mutatieField;
		private Lookup sgt_valutacode_idField;
		private Lookup sgt_vereniging_idField;
		private string sgt_volgnummerField;
		private string sgt_volgnummer_per_verenigingField;
		private string sgt_volledige_naamField;
		private Picklist sgt_voorkeur_contactwijzeField;
		private string sgt_voorlettersField;
		private string sgt_voornamenField;
		private Sgt_alg_pb_mutatie_ledenStateInfo statecodeField;
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
		public Lookup sgt_2e_nationaliteit_id
		{
			get
			{
				return this.sgt_2e_nationaliteit_idField;
			}
			set
			{
				this.sgt_2e_nationaliteit_idField = value;
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
		public Key sgt_alg_pb_mutatie_ledenid
		{
			get
			{
				return this.sgt_alg_pb_mutatie_ledenidField;
			}
			set
			{
				this.sgt_alg_pb_mutatie_ledenidField = value;
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
		public Picklist sgt_burgerlijke_staat
		{
			get
			{
				return this.sgt_burgerlijke_staatField;
			}
			set
			{
				this.sgt_burgerlijke_staatField = value;
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
		public CrmDateTime sgt_datum_opgezegd
		{
			get
			{
				return this.sgt_datum_opgezegdField;
			}
			set
			{
				this.sgt_datum_opgezegdField = value;
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
		public string sgt_debiteurnummer
		{
			get
			{
				return this.sgt_debiteurnummerField;
			}
			set
			{
				this.sgt_debiteurnummerField = value;
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
		public CrmBoolean sgt_do_not_bulk_postal_mail
		{
			get
			{
				return this.sgt_do_not_bulk_postal_mailField;
			}
			set
			{
				this.sgt_do_not_bulk_postal_mailField = value;
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
		public string sgt_foto
		{
			get
			{
				return this.sgt_fotoField;
			}
			set
			{
				this.sgt_fotoField = value;
			}
		}
		public string sgt_fotonummer
		{
			get
			{
				return this.sgt_fotonummerField;
			}
			set
			{
				this.sgt_fotonummerField = value;
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
		public string sgt_geboorteplaats
		{
			get
			{
				return this.sgt_geboorteplaatsField;
			}
			set
			{
				this.sgt_geboorteplaatsField = value;
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
		public string sgt_iban_code
		{
			get
			{
				return this.sgt_iban_codeField;
			}
			set
			{
				this.sgt_iban_codeField = value;
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
		public Picklist sgt_junior_senior
		{
			get
			{
				return this.sgt_junior_seniorField;
			}
			set
			{
				this.sgt_junior_seniorField = value;
			}
		}
		public Lookup sgt_landcode_postadres_id
		{
			get
			{
				return this.sgt_landcode_postadres_idField;
			}
			set
			{
				this.sgt_landcode_postadres_idField = value;
			}
		}
		public Lookup sgt_landcode_woonadres_id
		{
			get
			{
				return this.sgt_landcode_woonadres_idField;
			}
			set
			{
				this.sgt_landcode_woonadres_idField = value;
			}
		}
		public Lookup sgt_lid_bij_1e_vereniging_id
		{
			get
			{
				return this.sgt_lid_bij_1e_vereniging_idField;
			}
			set
			{
				this.sgt_lid_bij_1e_vereniging_idField = value;
			}
		}
		public Lookup sgt_lid_id
		{
			get
			{
				return this.sgt_lid_idField;
			}
			set
			{
				this.sgt_lid_idField = value;
			}
		}
		public CrmDateTime sgt_lidmaatschap_beindigd
		{
			get
			{
				return this.sgt_lidmaatschap_beindigdField;
			}
			set
			{
				this.sgt_lidmaatschap_beindigdField = value;
			}
		}
		public CrmDateTime sgt_lidmaatschap_vanaf
		{
			get
			{
				return this.sgt_lidmaatschap_vanafField;
			}
			set
			{
				this.sgt_lidmaatschap_vanafField = value;
			}
		}
		public string sgt_lidnummer_bij_vereniging
		{
			get
			{
				return this.sgt_lidnummer_bij_verenigingField;
			}
			set
			{
				this.sgt_lidnummer_bij_verenigingField = value;
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
		public string sgt_melding
		{
			get
			{
				return this.sgt_meldingField;
			}
			set
			{
				this.sgt_meldingField = value;
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
		public Lookup sgt_nationaliteit_id
		{
			get
			{
				return this.sgt_nationaliteit_idField;
			}
			set
			{
				this.sgt_nationaliteit_idField = value;
			}
		}
		public Lookup sgt_pb_interface_id
		{
			get
			{
				return this.sgt_pb_interface_idField;
			}
			set
			{
				this.sgt_pb_interface_idField = value;
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
		public Lookup sgt_pb_interface_logboek_id
		{
			get
			{
				return this.sgt_pb_interface_logboek_idField;
			}
			set
			{
				this.sgt_pb_interface_logboek_idField = value;
			}
		}
		public Lookup sgt_pb_interface_logboek_importxmlid
		{
			get
			{
				return this.sgt_pb_interface_logboek_importxmlidField;
			}
			set
			{
				this.sgt_pb_interface_logboek_importxmlidField = value;
			}
		}
		public Lookup sgt_pb_interface_logboek_leden_expid
		{
			get
			{
				return this.sgt_pb_interface_logboek_leden_expidField;
			}
			set
			{
				this.sgt_pb_interface_logboek_leden_expidField = value;
			}
		}
		public Lookup sgt_pb_interface_logboek_leden_impid
		{
			get
			{
				return this.sgt_pb_interface_logboek_leden_impidField;
			}
			set
			{
				this.sgt_pb_interface_logboek_leden_impidField = value;
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
		public string sgt_rekeningnummer
		{
			get
			{
				return this.sgt_rekeningnummerField;
			}
			set
			{
				this.sgt_rekeningnummerField = value;
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
		public Lookup sgt_soort_lidmaatschapid
		{
			get
			{
				return this.sgt_soort_lidmaatschapidField;
			}
			set
			{
				this.sgt_soort_lidmaatschapidField = value;
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
		public Lookup sgt_tennisnationaliteit_id
		{
			get
			{
				return this.sgt_tennisnationaliteit_idField;
			}
			set
			{
				this.sgt_tennisnationaliteit_idField = value;
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
		public Lookup sgt_valutacode_id
		{
			get
			{
				return this.sgt_valutacode_idField;
			}
			set
			{
				this.sgt_valutacode_idField = value;
			}
		}
		public Lookup sgt_vereniging_id
		{
			get
			{
				return this.sgt_vereniging_idField;
			}
			set
			{
				this.sgt_vereniging_idField = value;
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
		public string sgt_volgnummer_per_vereniging
		{
			get
			{
				return this.sgt_volgnummer_per_verenigingField;
			}
			set
			{
				this.sgt_volgnummer_per_verenigingField = value;
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
		public Sgt_alg_pb_mutatie_ledenStateInfo statecode
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
