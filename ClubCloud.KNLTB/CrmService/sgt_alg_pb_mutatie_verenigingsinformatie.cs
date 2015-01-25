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
		public Key sgt_alg_pb_mutatie_verenigingsinformatieid
		{
			get
			{
				return this.sgt_alg_pb_mutatie_verenigingsinformatieidField;
			}
			set
			{
				this.sgt_alg_pb_mutatie_verenigingsinformatieidField = value;
				base.RaisePropertyChanged("sgt_alg_pb_mutatie_verenigingsinformatieid");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public string sgt_alg_volgnummer
		{
			get
			{
				return this.sgt_alg_volgnummerField;
			}
			set
			{
				this.sgt_alg_volgnummerField = value;
				base.RaisePropertyChanged("sgt_alg_volgnummer");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public string sgt_ba_huisnummer
		{
			get
			{
				return this.sgt_ba_huisnummerField;
			}
			set
			{
				this.sgt_ba_huisnummerField = value;
				base.RaisePropertyChanged("sgt_ba_huisnummer");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public Lookup sgt_ba_landcodeid
		{
			get
			{
				return this.sgt_ba_landcodeidField;
			}
			set
			{
				this.sgt_ba_landcodeidField = value;
				base.RaisePropertyChanged("sgt_ba_landcodeid");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public string sgt_ba_plaats
		{
			get
			{
				return this.sgt_ba_plaatsField;
			}
			set
			{
				this.sgt_ba_plaatsField = value;
				base.RaisePropertyChanged("sgt_ba_plaats");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public string sgt_ba_postcode
		{
			get
			{
				return this.sgt_ba_postcodeField;
			}
			set
			{
				this.sgt_ba_postcodeField = value;
				base.RaisePropertyChanged("sgt_ba_postcode");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public string sgt_ba_straat
		{
			get
			{
				return this.sgt_ba_straatField;
			}
			set
			{
				this.sgt_ba_straatField = value;
				base.RaisePropertyChanged("sgt_ba_straat");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public string sgt_ba_toevoeging
		{
			get
			{
				return this.sgt_ba_toevoegingField;
			}
			set
			{
				this.sgt_ba_toevoegingField = value;
				base.RaisePropertyChanged("sgt_ba_toevoeging");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public CrmDateTime sgt_datum_afmelding
		{
			get
			{
				return this.sgt_datum_afmeldingField;
			}
			set
			{
				this.sgt_datum_afmeldingField = value;
				base.RaisePropertyChanged("sgt_datum_afmelding");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public CrmDateTime sgt_datum_erkenning
		{
			get
			{
				return this.sgt_datum_erkenningField;
			}
			set
			{
				this.sgt_datum_erkenningField = value;
				base.RaisePropertyChanged("sgt_datum_erkenning");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public CrmDateTime sgt_datum_fusie
		{
			get
			{
				return this.sgt_datum_fusieField;
			}
			set
			{
				this.sgt_datum_fusieField = value;
				base.RaisePropertyChanged("sgt_datum_fusie");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
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

		[XmlElement] //[XmlElement(Order=20)]
		public CrmDateTime sgt_datum_oprichting
		{
			get
			{
				return this.sgt_datum_oprichtingField;
			}
			set
			{
				this.sgt_datum_oprichtingField = value;
				base.RaisePropertyChanged("sgt_datum_oprichting");
			}
		}

		[XmlElement] //[XmlElement(Order=21)]
		public Lookup sgt_districtid
		{
			get
			{
				return this.sgt_districtidField;
			}
			set
			{
				this.sgt_districtidField = value;
				base.RaisePropertyChanged("sgt_districtid");
			}
		}

		[XmlElement] //[XmlElement(Order=22)]
		public string sgt_email_op_website
		{
			get
			{
				return this.sgt_email_op_websiteField;
			}
			set
			{
				this.sgt_email_op_websiteField = value;
				base.RaisePropertyChanged("sgt_email_op_website");
			}
		}

		[XmlElement] //[XmlElement(Order=23)]
		public string sgt_email_voor_knltb
		{
			get
			{
				return this.sgt_email_voor_knltbField;
			}
			set
			{
				this.sgt_email_voor_knltbField = value;
				base.RaisePropertyChanged("sgt_email_voor_knltb");
			}
		}

		[XmlElement] //[XmlElement(Order=24)]
		public string sgt_fax
		{
			get
			{
				return this.sgt_faxField;
			}
			set
			{
				this.sgt_faxField = value;
				base.RaisePropertyChanged("sgt_fax");
			}
		}

		[XmlElement] //[XmlElement(Order=25)]
		public Lookup sgt_hoofdaccommodatieid
		{
			get
			{
				return this.sgt_hoofdaccommodatieidField;
			}
			set
			{
				this.sgt_hoofdaccommodatieidField = value;
				base.RaisePropertyChanged("sgt_hoofdaccommodatieid");
			}
		}

		[XmlElement] //[XmlElement(Order=26)]
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

		[XmlElement] //[XmlElement(Order=27)]
		public Picklist sgt_naam_op_pas
		{
			get
			{
				return this.sgt_naam_op_pasField;
			}
			set
			{
				this.sgt_naam_op_pasField = value;
				base.RaisePropertyChanged("sgt_naam_op_pas");
			}
		}

		[XmlElement] //[XmlElement(Order=28)]
		public Lookup sgt_organisatienaamid
		{
			get
			{
				return this.sgt_organisatienaamidField;
			}
			set
			{
				this.sgt_organisatienaamidField = value;
				base.RaisePropertyChanged("sgt_organisatienaamid");
			}
		}

		[XmlElement] //[XmlElement(Order=29)]
		public string sgt_pa_huisnummer
		{
			get
			{
				return this.sgt_pa_huisnummerField;
			}
			set
			{
				this.sgt_pa_huisnummerField = value;
				base.RaisePropertyChanged("sgt_pa_huisnummer");
			}
		}

		[XmlElement] //[XmlElement(Order=30)]
		public Lookup sgt_pa_landcodeid
		{
			get
			{
				return this.sgt_pa_landcodeidField;
			}
			set
			{
				this.sgt_pa_landcodeidField = value;
				base.RaisePropertyChanged("sgt_pa_landcodeid");
			}
		}

		[XmlElement] //[XmlElement(Order=31)]
		public string sgt_pa_plaats
		{
			get
			{
				return this.sgt_pa_plaatsField;
			}
			set
			{
				this.sgt_pa_plaatsField = value;
				base.RaisePropertyChanged("sgt_pa_plaats");
			}
		}

		[XmlElement] //[XmlElement(Order=32)]
		public string sgt_pa_straat
		{
			get
			{
				return this.sgt_pa_straatField;
			}
			set
			{
				this.sgt_pa_straatField = value;
				base.RaisePropertyChanged("sgt_pa_straat");
			}
		}

		[XmlElement] //[XmlElement(Order=33)]
		public string sgt_pa_toevoeging
		{
			get
			{
				return this.sgt_pa_toevoegingField;
			}
			set
			{
				this.sgt_pa_toevoegingField = value;
				base.RaisePropertyChanged("sgt_pa_toevoeging");
			}
		}

		[XmlElement] //[XmlElement(Order=34)]
		public string sgt_pasnaam
		{
			get
			{
				return this.sgt_pasnaamField;
			}
			set
			{
				this.sgt_pasnaamField = value;
				base.RaisePropertyChanged("sgt_pasnaam");
			}
		}

		[XmlElement] //[XmlElement(Order=35)]
		public Lookup sgt_pb_interface_logboek_export_xmlid
		{
			get
			{
				return this.sgt_pb_interface_logboek_export_xmlidField;
			}
			set
			{
				this.sgt_pb_interface_logboek_export_xmlidField = value;
				base.RaisePropertyChanged("sgt_pb_interface_logboek_export_xmlid");
			}
		}

		[XmlElement] //[XmlElement(Order=36)]
		public Lookup sgt_pb_interface_logboek_import_xmlid
		{
			get
			{
				return this.sgt_pb_interface_logboek_import_xmlidField;
			}
			set
			{
				this.sgt_pb_interface_logboek_import_xmlidField = value;
				base.RaisePropertyChanged("sgt_pb_interface_logboek_import_xmlid");
			}
		}

		[XmlElement] //[XmlElement(Order=37)]
		public Lookup sgt_pb_interface_logboekid
		{
			get
			{
				return this.sgt_pb_interface_logboekidField;
			}
			set
			{
				this.sgt_pb_interface_logboekidField = value;
				base.RaisePropertyChanged("sgt_pb_interface_logboekid");
			}
		}

		[XmlElement] //[XmlElement(Order=38)]
		public string sgt_postcode_pa
		{
			get
			{
				return this.sgt_postcode_paField;
			}
			set
			{
				this.sgt_postcode_paField = value;
				base.RaisePropertyChanged("sgt_postcode_pa");
			}
		}

		[XmlElement] //[XmlElement(Order=39)]
		public string sgt_telefoon_overdag
		{
			get
			{
				return this.sgt_telefoon_overdagField;
			}
			set
			{
				this.sgt_telefoon_overdagField = value;
				base.RaisePropertyChanged("sgt_telefoon_overdag");
			}
		}

		[XmlElement] //[XmlElement(Order=40)]
		public string sgt_telefoon_s_avonds
		{
			get
			{
				return this.sgt_telefoon_s_avondsField;
			}
			set
			{
				this.sgt_telefoon_s_avondsField = value;
				base.RaisePropertyChanged("sgt_telefoon_s_avonds");
			}
		}

		[XmlElement] //[XmlElement(Order=41)]
		public string sgt_verenigingsnummer
		{
			get
			{
				return this.sgt_verenigingsnummerField;
			}
			set
			{
				this.sgt_verenigingsnummerField = value;
				base.RaisePropertyChanged("sgt_verenigingsnummer");
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
		public Sgt_alg_pb_mutatie_verenigingsinformatieStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=44)]
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

		[XmlElement] //[XmlElement(Order=45)]
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

		[XmlElement] //[XmlElement(Order=46)]
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

		public sgt_alg_pb_mutatie_verenigingsinformatie()
		{
		}
	}
}