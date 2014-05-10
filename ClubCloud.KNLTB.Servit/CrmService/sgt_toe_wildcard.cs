using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_toe_wildcard : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private CrmBoolean sgt_aangevraagd_via_mijnknltbField;
		private string sgt_bondsnummerField;
		private string sgt_button_spelersprofielField;
		private string sgt_emailField;
		private string sgt_email_trainerField;
		private CrmDateTime sgt_geboortedatumField;
		private Picklist sgt_geslachtField;
		private string sgt_mobielField;
		private string sgt_mobiel_trainerField;
		private Lookup sgt_privetraineridField;
		private CrmDecimal sgt_rating_dubbelField;
		private CrmDecimal sgt_rating_enkelField;
		private string sgt_reden_aanvraagField;
		private string sgt_reden_afwijzingField;
		private CrmNumber sgt_speelsterkte_dubbelField;
		private CrmNumber sgt_speelsterkte_enkelField;
		private Lookup sgt_speleridField;
		private Picklist sgt_status_aanvraagField;
		private string sgt_toe_wildcard1Field;
		private Key sgt_toe_wildcardidField;
		private Lookup sgt_toernooiafhandelingidField;
		private Lookup sgt_toernooionderdeelidField;
		private Lookup sgt_toernooisoortidField;
		private Picklist sgt_wildcard_voorField;
		private Sgt_toe_wildcardStateInfo statecodeField;
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
		public CrmBoolean sgt_aangevraagd_via_mijnknltb
		{
			get
			{
				return this.sgt_aangevraagd_via_mijnknltbField;
			}
			set
			{
				this.sgt_aangevraagd_via_mijnknltbField = value;
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
		public string sgt_button_spelersprofiel
		{
			get
			{
				return this.sgt_button_spelersprofielField;
			}
			set
			{
				this.sgt_button_spelersprofielField = value;
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
		public string sgt_email_trainer
		{
			get
			{
				return this.sgt_email_trainerField;
			}
			set
			{
				this.sgt_email_trainerField = value;
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
		public string sgt_mobiel_trainer
		{
			get
			{
				return this.sgt_mobiel_trainerField;
			}
			set
			{
				this.sgt_mobiel_trainerField = value;
			}
		}
		public Lookup sgt_privetrainerid
		{
			get
			{
				return this.sgt_privetraineridField;
			}
			set
			{
				this.sgt_privetraineridField = value;
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
		public string sgt_reden_aanvraag
		{
			get
			{
				return this.sgt_reden_aanvraagField;
			}
			set
			{
				this.sgt_reden_aanvraagField = value;
			}
		}
		public string sgt_reden_afwijzing
		{
			get
			{
				return this.sgt_reden_afwijzingField;
			}
			set
			{
				this.sgt_reden_afwijzingField = value;
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
		public Lookup sgt_spelerid
		{
			get
			{
				return this.sgt_speleridField;
			}
			set
			{
				this.sgt_speleridField = value;
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
		[XmlElement("sgt_toe_wildcard")]
		public string sgt_toe_wildcard1
		{
			get
			{
				return this.sgt_toe_wildcard1Field;
			}
			set
			{
				this.sgt_toe_wildcard1Field = value;
			}
		}
		public Key sgt_toe_wildcardid
		{
			get
			{
				return this.sgt_toe_wildcardidField;
			}
			set
			{
				this.sgt_toe_wildcardidField = value;
			}
		}
		public Lookup sgt_toernooiafhandelingid
		{
			get
			{
				return this.sgt_toernooiafhandelingidField;
			}
			set
			{
				this.sgt_toernooiafhandelingidField = value;
			}
		}
		public Lookup sgt_toernooionderdeelid
		{
			get
			{
				return this.sgt_toernooionderdeelidField;
			}
			set
			{
				this.sgt_toernooionderdeelidField = value;
			}
		}
		public Lookup sgt_toernooisoortid
		{
			get
			{
				return this.sgt_toernooisoortidField;
			}
			set
			{
				this.sgt_toernooisoortidField = value;
			}
		}
		public Picklist sgt_wildcard_voor
		{
			get
			{
				return this.sgt_wildcard_voorField;
			}
			set
			{
				this.sgt_wildcard_voorField = value;
			}
		}
		public Sgt_toe_wildcardStateInfo statecode
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
