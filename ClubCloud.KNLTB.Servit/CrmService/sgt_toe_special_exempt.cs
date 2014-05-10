using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_toe_special_exempt : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private Lookup sgt_aangevraagd_door_idField;
		private string sgt_bondsnummerField;
		private Picklist sgt_exempt_voorField;
		private Lookup sgt_functieidField;
		private CrmDateTime sgt_geboortedatumField;
		private Picklist sgt_geslachtField;
		private CrmDecimal sgt_rating_dubbelField;
		private CrmDecimal sgt_rating_enkelField;
		private string sgt_reden_aanvraagField;
		private string sgt_reden_afwijzingField;
		private CrmNumber sgt_speelsterkte_dubbelField;
		private CrmNumber sgt_speelsterkte_enkelField;
		private Lookup sgt_speleridField;
		private Picklist sgt_statusField;
		private string sgt_toe_special_exempt1Field;
		private Key sgt_toe_special_exemptidField;
		private Lookup sgt_toernooinaam_knltb_idField;
		private Lookup sgt_toernooionderdeelidField;
		private Sgt_toe_special_exemptStateInfo statecodeField;
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
		public Lookup sgt_aangevraagd_door_id
		{
			get
			{
				return this.sgt_aangevraagd_door_idField;
			}
			set
			{
				this.sgt_aangevraagd_door_idField = value;
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
		public Picklist sgt_exempt_voor
		{
			get
			{
				return this.sgt_exempt_voorField;
			}
			set
			{
				this.sgt_exempt_voorField = value;
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
		public Picklist sgt_status
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
		[XmlElement("sgt_toe_special_exempt")]
		public string sgt_toe_special_exempt1
		{
			get
			{
				return this.sgt_toe_special_exempt1Field;
			}
			set
			{
				this.sgt_toe_special_exempt1Field = value;
			}
		}
		public Key sgt_toe_special_exemptid
		{
			get
			{
				return this.sgt_toe_special_exemptidField;
			}
			set
			{
				this.sgt_toe_special_exemptidField = value;
			}
		}
		public Lookup sgt_toernooinaam_knltb_id
		{
			get
			{
				return this.sgt_toernooinaam_knltb_idField;
			}
			set
			{
				this.sgt_toernooinaam_knltb_idField = value;
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
		public Sgt_toe_special_exemptStateInfo statecode
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
