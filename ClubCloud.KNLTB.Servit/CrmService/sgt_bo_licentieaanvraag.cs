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
		public string sgt_aanvullende_informatie
		{
			get
			{
				return this.sgt_aanvullende_informatieField;
			}
			set
			{
				this.sgt_aanvullende_informatieField = value;
			}
		}
		public CrmBoolean sgt_betaald
		{
			get
			{
				return this.sgt_betaaldField;
			}
			set
			{
				this.sgt_betaaldField = value;
			}
		}
		public string sgt_bo_licentie_aanvraag
		{
			get
			{
				return this.sgt_bo_licentie_aanvraagField;
			}
			set
			{
				this.sgt_bo_licentie_aanvraagField = value;
			}
		}
		public Key sgt_bo_licentieaanvraagid
		{
			get
			{
				return this.sgt_bo_licentieaanvraagidField;
			}
			set
			{
				this.sgt_bo_licentieaanvraagidField = value;
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
		public CrmDateTime sgt_datum_betaling
		{
			get
			{
				return this.sgt_datum_betalingField;
			}
			set
			{
				this.sgt_datum_betalingField = value;
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
		public string sgt_huisnummer_toevoeging
		{
			get
			{
				return this.sgt_huisnummer_toevoegingField;
			}
			set
			{
				this.sgt_huisnummer_toevoegingField = value;
			}
		}
		public Lookup sgt_landid
		{
			get
			{
				return this.sgt_landidField;
			}
			set
			{
				this.sgt_landidField = value;
			}
		}
		public Lookup sgt_licentieaanvraagid
		{
			get
			{
				return this.sgt_licentieaanvraagidField;
			}
			set
			{
				this.sgt_licentieaanvraagidField = value;
			}
		}
		public Lookup sgt_licentieid
		{
			get
			{
				return this.sgt_licentieidField;
			}
			set
			{
				this.sgt_licentieidField = value;
			}
		}
		public string sgt_opmerking_betaling
		{
			get
			{
				return this.sgt_opmerking_betalingField;
			}
			set
			{
				this.sgt_opmerking_betalingField = value;
			}
		}
		public CrmBoolean sgt_persoonsgegevens_aangepast
		{
			get
			{
				return this.sgt_persoonsgegevens_aangepastField;
			}
			set
			{
				this.sgt_persoonsgegevens_aangepastField = value;
			}
		}
		public string sgt_plaats
		{
			get
			{
				return this.sgt_plaatsField;
			}
			set
			{
				this.sgt_plaatsField = value;
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
		public Picklist sgt_status_aanvraag
		{
			get
			{
				return this.sgt_status_aanvraagField;
			}
			set
			{
				this.sgt_status_aanvraagField = value;
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
		public string sgt_telefoon_mobiel
		{
			get
			{
				return this.sgt_telefoon_mobielField;
			}
			set
			{
				this.sgt_telefoon_mobielField = value;
			}
		}
		public string sgt_telefoon_thuis
		{
			get
			{
				return this.sgt_telefoon_thuisField;
			}
			set
			{
				this.sgt_telefoon_thuisField = value;
			}
		}
		public string sgt_telefoon_werk
		{
			get
			{
				return this.sgt_telefoon_werkField;
			}
			set
			{
				this.sgt_telefoon_werkField = value;
			}
		}
		public Lookup sgt_tennisleraarid
		{
			get
			{
				return this.sgt_tennisleraaridField;
			}
			set
			{
				this.sgt_tennisleraaridField = value;
			}
		}
		public CrmBoolean sgt_vnt_lid
		{
			get
			{
				return this.sgt_vnt_lidField;
			}
			set
			{
				this.sgt_vnt_lidField = value;
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
		public Sgt_bo_licentieaanvraagStateInfo statecode
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
