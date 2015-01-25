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
	public class sgt_bo_gewijzigde_persoonsgegevens : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private Key sgt_bo_gewijzigde_persoonsgegevensidField;

		private string sgt_email_nieuwField;

		private string sgt_email_oudField;

		private string sgt_geboorteplaats_nieuwField;

		private string sgt_geboorteplaats_oudField;

		private string sgt_gemeente_nieuwField;

		private string sgt_gemeente_oudField;

		private string sgt_huisnummer_nieuwField;

		private string sgt_huisnummer_oudField;

		private Lookup sgt_inschrijfformulier_testdagidField;

		private string sgt_mobiel_telefoonnummer_nieuwField;

		private string sgt_mobiel_telefoonnummer_oudField;

		private string sgt_nameField;

		private string sgt_plaats_nieuwField;

		private string sgt_plaats_oudField;

		private string sgt_postcode_nieuwField;

		private string sgt_postcode_oudField;

		private string sgt_roepnaam_nieuwField;

		private string sgt_roepnaam_oudField;

		private string sgt_straat_nieuwField;

		private string sgt_straat_oudField;

		private string sgt_telefoonoverdag_nieuwField;

		private string sgt_telefoonoverdag_oudField;

		private string sgt_telefoonsavonds_nieuwField;

		private string sgt_telefoonsavonds_oudField;

		private string sgt_toevoeging_nieuwField;

		private string sgt_toevoeging_oudField;

		private string sgt_voornamen_nieuwField;

		private string sgt_voornamen_oudField;

		private Sgt_bo_gewijzigde_persoonsgegevensStateInfo statecodeField;

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
		public Key sgt_bo_gewijzigde_persoonsgegevensid
		{
			get
			{
				return this.sgt_bo_gewijzigde_persoonsgegevensidField;
			}
			set
			{
				this.sgt_bo_gewijzigde_persoonsgegevensidField = value;
				base.RaisePropertyChanged("sgt_bo_gewijzigde_persoonsgegevensid");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public string sgt_email_nieuw
		{
			get
			{
				return this.sgt_email_nieuwField;
			}
			set
			{
				this.sgt_email_nieuwField = value;
				base.RaisePropertyChanged("sgt_email_nieuw");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public string sgt_email_oud
		{
			get
			{
				return this.sgt_email_oudField;
			}
			set
			{
				this.sgt_email_oudField = value;
				base.RaisePropertyChanged("sgt_email_oud");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public string sgt_geboorteplaats_nieuw
		{
			get
			{
				return this.sgt_geboorteplaats_nieuwField;
			}
			set
			{
				this.sgt_geboorteplaats_nieuwField = value;
				base.RaisePropertyChanged("sgt_geboorteplaats_nieuw");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public string sgt_geboorteplaats_oud
		{
			get
			{
				return this.sgt_geboorteplaats_oudField;
			}
			set
			{
				this.sgt_geboorteplaats_oudField = value;
				base.RaisePropertyChanged("sgt_geboorteplaats_oud");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public string sgt_gemeente_nieuw
		{
			get
			{
				return this.sgt_gemeente_nieuwField;
			}
			set
			{
				this.sgt_gemeente_nieuwField = value;
				base.RaisePropertyChanged("sgt_gemeente_nieuw");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public string sgt_gemeente_oud
		{
			get
			{
				return this.sgt_gemeente_oudField;
			}
			set
			{
				this.sgt_gemeente_oudField = value;
				base.RaisePropertyChanged("sgt_gemeente_oud");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public string sgt_huisnummer_nieuw
		{
			get
			{
				return this.sgt_huisnummer_nieuwField;
			}
			set
			{
				this.sgt_huisnummer_nieuwField = value;
				base.RaisePropertyChanged("sgt_huisnummer_nieuw");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public string sgt_huisnummer_oud
		{
			get
			{
				return this.sgt_huisnummer_oudField;
			}
			set
			{
				this.sgt_huisnummer_oudField = value;
				base.RaisePropertyChanged("sgt_huisnummer_oud");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public Lookup sgt_inschrijfformulier_testdagid
		{
			get
			{
				return this.sgt_inschrijfformulier_testdagidField;
			}
			set
			{
				this.sgt_inschrijfformulier_testdagidField = value;
				base.RaisePropertyChanged("sgt_inschrijfformulier_testdagid");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public string sgt_mobiel_telefoonnummer_nieuw
		{
			get
			{
				return this.sgt_mobiel_telefoonnummer_nieuwField;
			}
			set
			{
				this.sgt_mobiel_telefoonnummer_nieuwField = value;
				base.RaisePropertyChanged("sgt_mobiel_telefoonnummer_nieuw");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
		public string sgt_mobiel_telefoonnummer_oud
		{
			get
			{
				return this.sgt_mobiel_telefoonnummer_oudField;
			}
			set
			{
				this.sgt_mobiel_telefoonnummer_oudField = value;
				base.RaisePropertyChanged("sgt_mobiel_telefoonnummer_oud");
			}
		}

		[XmlElement] //[XmlElement(Order=20)]
		public string sgt_name
		{
			get
			{
				return this.sgt_nameField;
			}
			set
			{
				this.sgt_nameField = value;
				base.RaisePropertyChanged("sgt_name");
			}
		}

		[XmlElement] //[XmlElement(Order=21)]
		public string sgt_plaats_nieuw
		{
			get
			{
				return this.sgt_plaats_nieuwField;
			}
			set
			{
				this.sgt_plaats_nieuwField = value;
				base.RaisePropertyChanged("sgt_plaats_nieuw");
			}
		}

		[XmlElement] //[XmlElement(Order=22)]
		public string sgt_plaats_oud
		{
			get
			{
				return this.sgt_plaats_oudField;
			}
			set
			{
				this.sgt_plaats_oudField = value;
				base.RaisePropertyChanged("sgt_plaats_oud");
			}
		}

		[XmlElement] //[XmlElement(Order=23)]
		public string sgt_postcode_nieuw
		{
			get
			{
				return this.sgt_postcode_nieuwField;
			}
			set
			{
				this.sgt_postcode_nieuwField = value;
				base.RaisePropertyChanged("sgt_postcode_nieuw");
			}
		}

		[XmlElement] //[XmlElement(Order=24)]
		public string sgt_postcode_oud
		{
			get
			{
				return this.sgt_postcode_oudField;
			}
			set
			{
				this.sgt_postcode_oudField = value;
				base.RaisePropertyChanged("sgt_postcode_oud");
			}
		}

		[XmlElement] //[XmlElement(Order=25)]
		public string sgt_roepnaam_nieuw
		{
			get
			{
				return this.sgt_roepnaam_nieuwField;
			}
			set
			{
				this.sgt_roepnaam_nieuwField = value;
				base.RaisePropertyChanged("sgt_roepnaam_nieuw");
			}
		}

		[XmlElement] //[XmlElement(Order=26)]
		public string sgt_roepnaam_oud
		{
			get
			{
				return this.sgt_roepnaam_oudField;
			}
			set
			{
				this.sgt_roepnaam_oudField = value;
				base.RaisePropertyChanged("sgt_roepnaam_oud");
			}
		}

		[XmlElement] //[XmlElement(Order=27)]
		public string sgt_straat_nieuw
		{
			get
			{
				return this.sgt_straat_nieuwField;
			}
			set
			{
				this.sgt_straat_nieuwField = value;
				base.RaisePropertyChanged("sgt_straat_nieuw");
			}
		}

		[XmlElement] //[XmlElement(Order=28)]
		public string sgt_straat_oud
		{
			get
			{
				return this.sgt_straat_oudField;
			}
			set
			{
				this.sgt_straat_oudField = value;
				base.RaisePropertyChanged("sgt_straat_oud");
			}
		}

		[XmlElement] //[XmlElement(Order=29)]
		public string sgt_telefoonoverdag_nieuw
		{
			get
			{
				return this.sgt_telefoonoverdag_nieuwField;
			}
			set
			{
				this.sgt_telefoonoverdag_nieuwField = value;
				base.RaisePropertyChanged("sgt_telefoonoverdag_nieuw");
			}
		}

		[XmlElement] //[XmlElement(Order=30)]
		public string sgt_telefoonoverdag_oud
		{
			get
			{
				return this.sgt_telefoonoverdag_oudField;
			}
			set
			{
				this.sgt_telefoonoverdag_oudField = value;
				base.RaisePropertyChanged("sgt_telefoonoverdag_oud");
			}
		}

		[XmlElement] //[XmlElement(Order=31)]
		public string sgt_telefoonsavonds_nieuw
		{
			get
			{
				return this.sgt_telefoonsavonds_nieuwField;
			}
			set
			{
				this.sgt_telefoonsavonds_nieuwField = value;
				base.RaisePropertyChanged("sgt_telefoonsavonds_nieuw");
			}
		}

		[XmlElement] //[XmlElement(Order=32)]
		public string sgt_telefoonsavonds_oud
		{
			get
			{
				return this.sgt_telefoonsavonds_oudField;
			}
			set
			{
				this.sgt_telefoonsavonds_oudField = value;
				base.RaisePropertyChanged("sgt_telefoonsavonds_oud");
			}
		}

		[XmlElement] //[XmlElement(Order=33)]
		public string sgt_toevoeging_nieuw
		{
			get
			{
				return this.sgt_toevoeging_nieuwField;
			}
			set
			{
				this.sgt_toevoeging_nieuwField = value;
				base.RaisePropertyChanged("sgt_toevoeging_nieuw");
			}
		}

		[XmlElement] //[XmlElement(Order=34)]
		public string sgt_toevoeging_oud
		{
			get
			{
				return this.sgt_toevoeging_oudField;
			}
			set
			{
				this.sgt_toevoeging_oudField = value;
				base.RaisePropertyChanged("sgt_toevoeging_oud");
			}
		}

		[XmlElement] //[XmlElement(Order=35)]
		public string sgt_voornamen_nieuw
		{
			get
			{
				return this.sgt_voornamen_nieuwField;
			}
			set
			{
				this.sgt_voornamen_nieuwField = value;
				base.RaisePropertyChanged("sgt_voornamen_nieuw");
			}
		}

		[XmlElement] //[XmlElement(Order=36)]
		public string sgt_voornamen_oud
		{
			get
			{
				return this.sgt_voornamen_oudField;
			}
			set
			{
				this.sgt_voornamen_oudField = value;
				base.RaisePropertyChanged("sgt_voornamen_oud");
			}
		}

		[XmlElement] //[XmlElement(Order=37)]
		public Sgt_bo_gewijzigde_persoonsgegevensStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=38)]
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

		[XmlElement] //[XmlElement(Order=39)]
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

		[XmlElement] //[XmlElement(Order=40)]
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

		public sgt_bo_gewijzigde_persoonsgegevens()
		{
		}
	}
}