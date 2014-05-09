using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_bo_licentieaanvraag : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private string sgt_aanvullende_informatieField;
		private CrmBoolean sgt_betaaldField;
		private string sgt_bo_licentie_aanvraagField;
		private Key sgt_bo_licentieaanvraagidField;
		private string sgt_bondsnummerField;
		private CrmDateTime sgt_datum_betalingField;
		private string sgt_emailField;
		private CrmDateTime sgt_geboortedatumField;
		private string sgt_geboorteplaatsField;
		private string sgt_huisnummerField;
		private string sgt_huisnummer_toevoegingField;
		private Lookup sgt_landidField;
		private Lookup sgt_licentieaanvraagidField;
		private Lookup sgt_licentieidField;
		private string sgt_opmerking_betalingField;
		private CrmBoolean sgt_persoonsgegevens_aangepastField;
		private string sgt_plaatsField;
		private string sgt_postcodeField;
		private string sgt_roepnaamField;
		private Picklist sgt_status_aanvraagField;
		private string sgt_straatField;
		private string sgt_telefoon_mobielField;
		private string sgt_telefoon_thuisField;
		private string sgt_telefoon_werkField;
		private Lookup sgt_tennisleraaridField;
		private CrmBoolean sgt_vnt_lidField;
		private string sgt_voorlettersField;
		private string sgt_voornamenField;
		private Sgt_bo_licentieaanvraagStateInfo statecodeField;
		private Status statuscodeField;
		private CrmNumber timezoneruleversionnumberField;
		private CrmNumber utcconversiontimezonecodeField;
		[XmlElement(Order = 0)]
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
		[XmlElement(Order = 1)]
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
		[XmlElement(Order = 2)]
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
		[XmlElement(Order = 3)]
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
		[XmlElement(Order = 4)]
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
		[XmlElement(Order = 5)]
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
		[XmlElement(Order = 6)]
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
		[XmlElement(Order = 7)]
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
		[XmlElement(Order = 8)]
		public string sgt_aanvullende_informatie
		{
			get
			{
				return this.sgt_aanvullende_informatieField;
			}
			set
			{
				this.sgt_aanvullende_informatieField = value;
				base.RaisePropertyChanged("sgt_aanvullende_informatie");
			}
		}
		[XmlElement(Order = 9)]
		public CrmBoolean sgt_betaald
		{
			get
			{
				return this.sgt_betaaldField;
			}
			set
			{
				this.sgt_betaaldField = value;
				base.RaisePropertyChanged("sgt_betaald");
			}
		}
		[XmlElement(Order = 10)]
		public string sgt_bo_licentie_aanvraag
		{
			get
			{
				return this.sgt_bo_licentie_aanvraagField;
			}
			set
			{
				this.sgt_bo_licentie_aanvraagField = value;
				base.RaisePropertyChanged("sgt_bo_licentie_aanvraag");
			}
		}
		[XmlElement(Order = 11)]
		public Key sgt_bo_licentieaanvraagid
		{
			get
			{
				return this.sgt_bo_licentieaanvraagidField;
			}
			set
			{
				this.sgt_bo_licentieaanvraagidField = value;
				base.RaisePropertyChanged("sgt_bo_licentieaanvraagid");
			}
		}
		[XmlElement(Order = 12)]
		public string sgt_bondsnummer
		{
			get
			{
				return this.sgt_bondsnummerField;
			}
			set
			{
				this.sgt_bondsnummerField = value;
				base.RaisePropertyChanged("sgt_bondsnummer");
			}
		}
		[XmlElement(Order = 13)]
		public CrmDateTime sgt_datum_betaling
		{
			get
			{
				return this.sgt_datum_betalingField;
			}
			set
			{
				this.sgt_datum_betalingField = value;
				base.RaisePropertyChanged("sgt_datum_betaling");
			}
		}
		[XmlElement(Order = 14)]
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
		[XmlElement(Order = 15)]
		public CrmDateTime sgt_geboortedatum
		{
			get
			{
				return this.sgt_geboortedatumField;
			}
			set
			{
				this.sgt_geboortedatumField = value;
				base.RaisePropertyChanged("sgt_geboortedatum");
			}
		}
		[XmlElement(Order = 16)]
		public string sgt_geboorteplaats
		{
			get
			{
				return this.sgt_geboorteplaatsField;
			}
			set
			{
				this.sgt_geboorteplaatsField = value;
				base.RaisePropertyChanged("sgt_geboorteplaats");
			}
		}
		[XmlElement(Order = 17)]
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
		[XmlElement(Order = 18)]
		public string sgt_huisnummer_toevoeging
		{
			get
			{
				return this.sgt_huisnummer_toevoegingField;
			}
			set
			{
				this.sgt_huisnummer_toevoegingField = value;
				base.RaisePropertyChanged("sgt_huisnummer_toevoeging");
			}
		}
		[XmlElement(Order = 19)]
		public Lookup sgt_landid
		{
			get
			{
				return this.sgt_landidField;
			}
			set
			{
				this.sgt_landidField = value;
				base.RaisePropertyChanged("sgt_landid");
			}
		}
		[XmlElement(Order = 20)]
		public Lookup sgt_licentieaanvraagid
		{
			get
			{
				return this.sgt_licentieaanvraagidField;
			}
			set
			{
				this.sgt_licentieaanvraagidField = value;
				base.RaisePropertyChanged("sgt_licentieaanvraagid");
			}
		}
		[XmlElement(Order = 21)]
		public Lookup sgt_licentieid
		{
			get
			{
				return this.sgt_licentieidField;
			}
			set
			{
				this.sgt_licentieidField = value;
				base.RaisePropertyChanged("sgt_licentieid");
			}
		}
		[XmlElement(Order = 22)]
		public string sgt_opmerking_betaling
		{
			get
			{
				return this.sgt_opmerking_betalingField;
			}
			set
			{
				this.sgt_opmerking_betalingField = value;
				base.RaisePropertyChanged("sgt_opmerking_betaling");
			}
		}
		[XmlElement(Order = 23)]
		public CrmBoolean sgt_persoonsgegevens_aangepast
		{
			get
			{
				return this.sgt_persoonsgegevens_aangepastField;
			}
			set
			{
				this.sgt_persoonsgegevens_aangepastField = value;
				base.RaisePropertyChanged("sgt_persoonsgegevens_aangepast");
			}
		}
		[XmlElement(Order = 24)]
		public string sgt_plaats
		{
			get
			{
				return this.sgt_plaatsField;
			}
			set
			{
				this.sgt_plaatsField = value;
				base.RaisePropertyChanged("sgt_plaats");
			}
		}
		[XmlElement(Order = 25)]
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
		[XmlElement(Order = 26)]
		public string sgt_roepnaam
		{
			get
			{
				return this.sgt_roepnaamField;
			}
			set
			{
				this.sgt_roepnaamField = value;
				base.RaisePropertyChanged("sgt_roepnaam");
			}
		}
		[XmlElement(Order = 27)]
		public Picklist sgt_status_aanvraag
		{
			get
			{
				return this.sgt_status_aanvraagField;
			}
			set
			{
				this.sgt_status_aanvraagField = value;
				base.RaisePropertyChanged("sgt_status_aanvraag");
			}
		}
		[XmlElement(Order = 28)]
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
		[XmlElement(Order = 29)]
		public string sgt_telefoon_mobiel
		{
			get
			{
				return this.sgt_telefoon_mobielField;
			}
			set
			{
				this.sgt_telefoon_mobielField = value;
				base.RaisePropertyChanged("sgt_telefoon_mobiel");
			}
		}
		[XmlElement(Order = 30)]
		public string sgt_telefoon_thuis
		{
			get
			{
				return this.sgt_telefoon_thuisField;
			}
			set
			{
				this.sgt_telefoon_thuisField = value;
				base.RaisePropertyChanged("sgt_telefoon_thuis");
			}
		}
		[XmlElement(Order = 31)]
		public string sgt_telefoon_werk
		{
			get
			{
				return this.sgt_telefoon_werkField;
			}
			set
			{
				this.sgt_telefoon_werkField = value;
				base.RaisePropertyChanged("sgt_telefoon_werk");
			}
		}
		[XmlElement(Order = 32)]
		public Lookup sgt_tennisleraarid
		{
			get
			{
				return this.sgt_tennisleraaridField;
			}
			set
			{
				this.sgt_tennisleraaridField = value;
				base.RaisePropertyChanged("sgt_tennisleraarid");
			}
		}
		[XmlElement(Order = 33)]
		public CrmBoolean sgt_vnt_lid
		{
			get
			{
				return this.sgt_vnt_lidField;
			}
			set
			{
				this.sgt_vnt_lidField = value;
				base.RaisePropertyChanged("sgt_vnt_lid");
			}
		}
		[XmlElement(Order = 34)]
		public string sgt_voorletters
		{
			get
			{
				return this.sgt_voorlettersField;
			}
			set
			{
				this.sgt_voorlettersField = value;
				base.RaisePropertyChanged("sgt_voorletters");
			}
		}
		[XmlElement(Order = 35)]
		public string sgt_voornamen
		{
			get
			{
				return this.sgt_voornamenField;
			}
			set
			{
				this.sgt_voornamenField = value;
				base.RaisePropertyChanged("sgt_voornamen");
			}
		}
		[XmlElement(Order = 36)]
		public Sgt_bo_licentieaanvraagStateInfo statecode
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
		[XmlElement(Order = 37)]
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
		[XmlElement(Order = 38)]
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
		[XmlElement(Order = 39)]
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
	}
}
