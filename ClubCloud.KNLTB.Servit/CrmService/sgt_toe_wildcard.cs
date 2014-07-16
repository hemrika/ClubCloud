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
		public CrmBoolean sgt_aangevraagd_via_mijnknltb
		{
			get
			{
				return this.sgt_aangevraagd_via_mijnknltbField;
			}
			set
			{
				this.sgt_aangevraagd_via_mijnknltbField = value;
				base.RaisePropertyChanged("sgt_aangevraagd_via_mijnknltb");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
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

		[XmlElement] //[XmlElement(Order=10)]
		public string sgt_button_spelersprofiel
		{
			get
			{
				return this.sgt_button_spelersprofielField;
			}
			set
			{
				this.sgt_button_spelersprofielField = value;
				base.RaisePropertyChanged("sgt_button_spelersprofiel");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
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

		[XmlElement] //[XmlElement(Order=12)]
		public string sgt_email_trainer
		{
			get
			{
				return this.sgt_email_trainerField;
			}
			set
			{
				this.sgt_email_trainerField = value;
				base.RaisePropertyChanged("sgt_email_trainer");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
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

		[XmlElement] //[XmlElement(Order=14)]
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

		[XmlElement] //[XmlElement(Order=15)]
		public string sgt_mobiel
		{
			get
			{
				return this.sgt_mobielField;
			}
			set
			{
				this.sgt_mobielField = value;
				base.RaisePropertyChanged("sgt_mobiel");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public string sgt_mobiel_trainer
		{
			get
			{
				return this.sgt_mobiel_trainerField;
			}
			set
			{
				this.sgt_mobiel_trainerField = value;
				base.RaisePropertyChanged("sgt_mobiel_trainer");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public Lookup sgt_privetrainerid
		{
			get
			{
				return this.sgt_privetraineridField;
			}
			set
			{
				this.sgt_privetraineridField = value;
				base.RaisePropertyChanged("sgt_privetrainerid");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
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

		[XmlElement] //[XmlElement(Order=19)]
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

		[XmlElement] //[XmlElement(Order=20)]
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

		[XmlElement] //[XmlElement(Order=21)]
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

		[XmlElement] //[XmlElement(Order=22)]
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

		[XmlElement] //[XmlElement(Order=23)]
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

		[XmlElement] //[XmlElement(Order=24)]
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

		[XmlElement] //[XmlElement(Order=25)]
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

		[XmlElement("sgt_toe_wildcard")] //, Order=26)]
		public string sgt_toe_wildcard1
		{
			get
			{
				return this.sgt_toe_wildcard1Field;
			}
			set
			{
				this.sgt_toe_wildcard1Field = value;
				base.RaisePropertyChanged("sgt_toe_wildcard1");
			}
		}

		[XmlElement] //[XmlElement(Order=27)]
		public Key sgt_toe_wildcardid
		{
			get
			{
				return this.sgt_toe_wildcardidField;
			}
			set
			{
				this.sgt_toe_wildcardidField = value;
				base.RaisePropertyChanged("sgt_toe_wildcardid");
			}
		}

		[XmlElement] //[XmlElement(Order=28)]
		public Lookup sgt_toernooiafhandelingid
		{
			get
			{
				return this.sgt_toernooiafhandelingidField;
			}
			set
			{
				this.sgt_toernooiafhandelingidField = value;
				base.RaisePropertyChanged("sgt_toernooiafhandelingid");
			}
		}

		[XmlElement] //[XmlElement(Order=29)]
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

		[XmlElement] //[XmlElement(Order=30)]
		public Lookup sgt_toernooisoortid
		{
			get
			{
				return this.sgt_toernooisoortidField;
			}
			set
			{
				this.sgt_toernooisoortidField = value;
				base.RaisePropertyChanged("sgt_toernooisoortid");
			}
		}

		[XmlElement] //[XmlElement(Order=31)]
		public Picklist sgt_wildcard_voor
		{
			get
			{
				return this.sgt_wildcard_voorField;
			}
			set
			{
				this.sgt_wildcard_voorField = value;
				base.RaisePropertyChanged("sgt_wildcard_voor");
			}
		}

		[XmlElement] //[XmlElement(Order=32)]
		public Sgt_toe_wildcardStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=33)]
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

		[XmlElement] //[XmlElement(Order=34)]
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

		[XmlElement] //[XmlElement(Order=35)]
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

		public sgt_toe_wildcard()
		{
		}
	}
}