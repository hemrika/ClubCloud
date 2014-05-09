using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
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
		public Lookup sgt_aangevraagd_door_id
		{
			get
			{
				return this.sgt_aangevraagd_door_idField;
			}
			set
			{
				this.sgt_aangevraagd_door_idField = value;
				base.RaisePropertyChanged("sgt_aangevraagd_door_id");
			}
		}
		[XmlElement(Order = 9)]
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
		[XmlElement(Order = 10)]
		public Picklist sgt_exempt_voor
		{
			get
			{
				return this.sgt_exempt_voorField;
			}
			set
			{
				this.sgt_exempt_voorField = value;
				base.RaisePropertyChanged("sgt_exempt_voor");
			}
		}
		[XmlElement(Order = 11)]
		public Lookup sgt_functieid
		{
			get
			{
				return this.sgt_functieidField;
			}
			set
			{
				this.sgt_functieidField = value;
				base.RaisePropertyChanged("sgt_functieid");
			}
		}
		[XmlElement(Order = 12)]
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
		[XmlElement(Order = 13)]
		public Picklist sgt_geslacht
		{
			get
			{
				return this.sgt_geslachtField;
			}
			set
			{
				this.sgt_geslachtField = value;
				base.RaisePropertyChanged("sgt_geslacht");
			}
		}
		[XmlElement(Order = 14)]
		public CrmDecimal sgt_rating_dubbel
		{
			get
			{
				return this.sgt_rating_dubbelField;
			}
			set
			{
				this.sgt_rating_dubbelField = value;
				base.RaisePropertyChanged("sgt_rating_dubbel");
			}
		}
		[XmlElement(Order = 15)]
		public CrmDecimal sgt_rating_enkel
		{
			get
			{
				return this.sgt_rating_enkelField;
			}
			set
			{
				this.sgt_rating_enkelField = value;
				base.RaisePropertyChanged("sgt_rating_enkel");
			}
		}
		[XmlElement(Order = 16)]
		public string sgt_reden_aanvraag
		{
			get
			{
				return this.sgt_reden_aanvraagField;
			}
			set
			{
				this.sgt_reden_aanvraagField = value;
				base.RaisePropertyChanged("sgt_reden_aanvraag");
			}
		}
		[XmlElement(Order = 17)]
		public string sgt_reden_afwijzing
		{
			get
			{
				return this.sgt_reden_afwijzingField;
			}
			set
			{
				this.sgt_reden_afwijzingField = value;
				base.RaisePropertyChanged("sgt_reden_afwijzing");
			}
		}
		[XmlElement(Order = 18)]
		public CrmNumber sgt_speelsterkte_dubbel
		{
			get
			{
				return this.sgt_speelsterkte_dubbelField;
			}
			set
			{
				this.sgt_speelsterkte_dubbelField = value;
				base.RaisePropertyChanged("sgt_speelsterkte_dubbel");
			}
		}
		[XmlElement(Order = 19)]
		public CrmNumber sgt_speelsterkte_enkel
		{
			get
			{
				return this.sgt_speelsterkte_enkelField;
			}
			set
			{
				this.sgt_speelsterkte_enkelField = value;
				base.RaisePropertyChanged("sgt_speelsterkte_enkel");
			}
		}
		[XmlElement(Order = 20)]
		public Lookup sgt_spelerid
		{
			get
			{
				return this.sgt_speleridField;
			}
			set
			{
				this.sgt_speleridField = value;
				base.RaisePropertyChanged("sgt_spelerid");
			}
		}
		[XmlElement(Order = 21)]
		public Picklist sgt_status
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
		[XmlElement("sgt_toe_special_exempt", Order = 22)]
		public string sgt_toe_special_exempt1
		{
			get
			{
				return this.sgt_toe_special_exempt1Field;
			}
			set
			{
				this.sgt_toe_special_exempt1Field = value;
				base.RaisePropertyChanged("sgt_toe_special_exempt1");
			}
		}
		[XmlElement(Order = 23)]
		public Key sgt_toe_special_exemptid
		{
			get
			{
				return this.sgt_toe_special_exemptidField;
			}
			set
			{
				this.sgt_toe_special_exemptidField = value;
				base.RaisePropertyChanged("sgt_toe_special_exemptid");
			}
		}
		[XmlElement(Order = 24)]
		public Lookup sgt_toernooinaam_knltb_id
		{
			get
			{
				return this.sgt_toernooinaam_knltb_idField;
			}
			set
			{
				this.sgt_toernooinaam_knltb_idField = value;
				base.RaisePropertyChanged("sgt_toernooinaam_knltb_id");
			}
		}
		[XmlElement(Order = 25)]
		public Lookup sgt_toernooionderdeelid
		{
			get
			{
				return this.sgt_toernooionderdeelidField;
			}
			set
			{
				this.sgt_toernooionderdeelidField = value;
				base.RaisePropertyChanged("sgt_toernooionderdeelid");
			}
		}
		[XmlElement(Order = 26)]
		public Sgt_toe_special_exemptStateInfo statecode
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
		[XmlElement(Order = 27)]
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
		[XmlElement(Order = 28)]
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
		[XmlElement(Order = 29)]
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
