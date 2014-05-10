using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_alg_pb_mutatie_verenigingsinformatie : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private Key sgt_alg_pb_mutatie_verenigingsinformatieidField;
		private string sgt_alg_volgnummerField;
		private string sgt_ba_huisnummerField;
		private Lookup sgt_ba_landcodeidField;
		private string sgt_ba_plaatsField;
		private string sgt_ba_postcodeField;
		private string sgt_ba_straatField;
		private string sgt_ba_toevoegingField;
		private CrmDateTime sgt_datum_afmeldingField;
		private CrmDateTime sgt_datum_erkenningField;
		private CrmDateTime sgt_datum_fusieField;
		private CrmDateTime sgt_datum_mutatie_verwerktField;
		private CrmDateTime sgt_datum_oprichtingField;
		private Lookup sgt_districtidField;
		private string sgt_email_op_websiteField;
		private string sgt_email_voor_knltbField;
		private string sgt_faxField;
		private Lookup sgt_hoofdaccommodatieidField;
		private Picklist sgt_import_exportField;
		private Picklist sgt_naam_op_pasField;
		private Lookup sgt_organisatienaamidField;
		private string sgt_pa_huisnummerField;
		private Lookup sgt_pa_landcodeidField;
		private string sgt_pa_plaatsField;
		private string sgt_pa_straatField;
		private string sgt_pa_toevoegingField;
		private string sgt_pasnaamField;
		private Lookup sgt_pb_interface_logboek_export_xmlidField;
		private Lookup sgt_pb_interface_logboek_import_xmlidField;
		private Lookup sgt_pb_interface_logboekidField;
		private string sgt_postcode_paField;
		private string sgt_telefoon_overdagField;
		private string sgt_telefoon_s_avondsField;
		private string sgt_verenigingsnummerField;
		private string sgt_websiteField;
		private Sgt_alg_pb_mutatie_verenigingsinformatieStateInfo statecodeField;
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
		public Key sgt_alg_pb_mutatie_verenigingsinformatieid
		{
			get
			{
				return this.sgt_alg_pb_mutatie_verenigingsinformatieidField;
			}
			set
			{
				this.sgt_alg_pb_mutatie_verenigingsinformatieidField = value;
			}
		}
		public string sgt_alg_volgnummer
		{
			get
			{
				return this.sgt_alg_volgnummerField;
			}
			set
			{
				this.sgt_alg_volgnummerField = value;
			}
		}
		public string sgt_ba_huisnummer
		{
			get
			{
				return this.sgt_ba_huisnummerField;
			}
			set
			{
				this.sgt_ba_huisnummerField = value;
			}
		}
		public Lookup sgt_ba_landcodeid
		{
			get
			{
				return this.sgt_ba_landcodeidField;
			}
			set
			{
				this.sgt_ba_landcodeidField = value;
			}
		}
		public string sgt_ba_plaats
		{
			get
			{
				return this.sgt_ba_plaatsField;
			}
			set
			{
				this.sgt_ba_plaatsField = value;
			}
		}
		public string sgt_ba_postcode
		{
			get
			{
				return this.sgt_ba_postcodeField;
			}
			set
			{
				this.sgt_ba_postcodeField = value;
			}
		}
		public string sgt_ba_straat
		{
			get
			{
				return this.sgt_ba_straatField;
			}
			set
			{
				this.sgt_ba_straatField = value;
			}
		}
		public string sgt_ba_toevoeging
		{
			get
			{
				return this.sgt_ba_toevoegingField;
			}
			set
			{
				this.sgt_ba_toevoegingField = value;
			}
		}
		public CrmDateTime sgt_datum_afmelding
		{
			get
			{
				return this.sgt_datum_afmeldingField;
			}
			set
			{
				this.sgt_datum_afmeldingField = value;
			}
		}
		public CrmDateTime sgt_datum_erkenning
		{
			get
			{
				return this.sgt_datum_erkenningField;
			}
			set
			{
				this.sgt_datum_erkenningField = value;
			}
		}
		public CrmDateTime sgt_datum_fusie
		{
			get
			{
				return this.sgt_datum_fusieField;
			}
			set
			{
				this.sgt_datum_fusieField = value;
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
		public CrmDateTime sgt_datum_oprichting
		{
			get
			{
				return this.sgt_datum_oprichtingField;
			}
			set
			{
				this.sgt_datum_oprichtingField = value;
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
		public string sgt_email_op_website
		{
			get
			{
				return this.sgt_email_op_websiteField;
			}
			set
			{
				this.sgt_email_op_websiteField = value;
			}
		}
		public string sgt_email_voor_knltb
		{
			get
			{
				return this.sgt_email_voor_knltbField;
			}
			set
			{
				this.sgt_email_voor_knltbField = value;
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
		public Lookup sgt_hoofdaccommodatieid
		{
			get
			{
				return this.sgt_hoofdaccommodatieidField;
			}
			set
			{
				this.sgt_hoofdaccommodatieidField = value;
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
		public Picklist sgt_naam_op_pas
		{
			get
			{
				return this.sgt_naam_op_pasField;
			}
			set
			{
				this.sgt_naam_op_pasField = value;
			}
		}
		public Lookup sgt_organisatienaamid
		{
			get
			{
				return this.sgt_organisatienaamidField;
			}
			set
			{
				this.sgt_organisatienaamidField = value;
			}
		}
		public string sgt_pa_huisnummer
		{
			get
			{
				return this.sgt_pa_huisnummerField;
			}
			set
			{
				this.sgt_pa_huisnummerField = value;
			}
		}
		public Lookup sgt_pa_landcodeid
		{
			get
			{
				return this.sgt_pa_landcodeidField;
			}
			set
			{
				this.sgt_pa_landcodeidField = value;
			}
		}
		public string sgt_pa_plaats
		{
			get
			{
				return this.sgt_pa_plaatsField;
			}
			set
			{
				this.sgt_pa_plaatsField = value;
			}
		}
		public string sgt_pa_straat
		{
			get
			{
				return this.sgt_pa_straatField;
			}
			set
			{
				this.sgt_pa_straatField = value;
			}
		}
		public string sgt_pa_toevoeging
		{
			get
			{
				return this.sgt_pa_toevoegingField;
			}
			set
			{
				this.sgt_pa_toevoegingField = value;
			}
		}
		public string sgt_pasnaam
		{
			get
			{
				return this.sgt_pasnaamField;
			}
			set
			{
				this.sgt_pasnaamField = value;
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
		public string sgt_telefoon_s_avonds
		{
			get
			{
				return this.sgt_telefoon_s_avondsField;
			}
			set
			{
				this.sgt_telefoon_s_avondsField = value;
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
		public Sgt_alg_pb_mutatie_verenigingsinformatieStateInfo statecode
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
