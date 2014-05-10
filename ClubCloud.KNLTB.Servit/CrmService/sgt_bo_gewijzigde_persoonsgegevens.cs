using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
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
		public Key sgt_bo_gewijzigde_persoonsgegevensid
		{
			get
			{
				return this.sgt_bo_gewijzigde_persoonsgegevensidField;
			}
			set
			{
				this.sgt_bo_gewijzigde_persoonsgegevensidField = value;
			}
		}
		public string sgt_email_nieuw
		{
			get
			{
				return this.sgt_email_nieuwField;
			}
			set
			{
				this.sgt_email_nieuwField = value;
			}
		}
		public string sgt_email_oud
		{
			get
			{
				return this.sgt_email_oudField;
			}
			set
			{
				this.sgt_email_oudField = value;
			}
		}
		public string sgt_geboorteplaats_nieuw
		{
			get
			{
				return this.sgt_geboorteplaats_nieuwField;
			}
			set
			{
				this.sgt_geboorteplaats_nieuwField = value;
			}
		}
		public string sgt_geboorteplaats_oud
		{
			get
			{
				return this.sgt_geboorteplaats_oudField;
			}
			set
			{
				this.sgt_geboorteplaats_oudField = value;
			}
		}
		public string sgt_gemeente_nieuw
		{
			get
			{
				return this.sgt_gemeente_nieuwField;
			}
			set
			{
				this.sgt_gemeente_nieuwField = value;
			}
		}
		public string sgt_gemeente_oud
		{
			get
			{
				return this.sgt_gemeente_oudField;
			}
			set
			{
				this.sgt_gemeente_oudField = value;
			}
		}
		public string sgt_huisnummer_nieuw
		{
			get
			{
				return this.sgt_huisnummer_nieuwField;
			}
			set
			{
				this.sgt_huisnummer_nieuwField = value;
			}
		}
		public string sgt_huisnummer_oud
		{
			get
			{
				return this.sgt_huisnummer_oudField;
			}
			set
			{
				this.sgt_huisnummer_oudField = value;
			}
		}
		public Lookup sgt_inschrijfformulier_testdagid
		{
			get
			{
				return this.sgt_inschrijfformulier_testdagidField;
			}
			set
			{
				this.sgt_inschrijfformulier_testdagidField = value;
			}
		}
		public string sgt_mobiel_telefoonnummer_nieuw
		{
			get
			{
				return this.sgt_mobiel_telefoonnummer_nieuwField;
			}
			set
			{
				this.sgt_mobiel_telefoonnummer_nieuwField = value;
			}
		}
		public string sgt_mobiel_telefoonnummer_oud
		{
			get
			{
				return this.sgt_mobiel_telefoonnummer_oudField;
			}
			set
			{
				this.sgt_mobiel_telefoonnummer_oudField = value;
			}
		}
		public string sgt_name
		{
			get
			{
				return this.sgt_nameField;
			}
			set
			{
				this.sgt_nameField = value;
			}
		}
		public string sgt_plaats_nieuw
		{
			get
			{
				return this.sgt_plaats_nieuwField;
			}
			set
			{
				this.sgt_plaats_nieuwField = value;
			}
		}
		public string sgt_plaats_oud
		{
			get
			{
				return this.sgt_plaats_oudField;
			}
			set
			{
				this.sgt_plaats_oudField = value;
			}
		}
		public string sgt_postcode_nieuw
		{
			get
			{
				return this.sgt_postcode_nieuwField;
			}
			set
			{
				this.sgt_postcode_nieuwField = value;
			}
		}
		public string sgt_postcode_oud
		{
			get
			{
				return this.sgt_postcode_oudField;
			}
			set
			{
				this.sgt_postcode_oudField = value;
			}
		}
		public string sgt_roepnaam_nieuw
		{
			get
			{
				return this.sgt_roepnaam_nieuwField;
			}
			set
			{
				this.sgt_roepnaam_nieuwField = value;
			}
		}
		public string sgt_roepnaam_oud
		{
			get
			{
				return this.sgt_roepnaam_oudField;
			}
			set
			{
				this.sgt_roepnaam_oudField = value;
			}
		}
		public string sgt_straat_nieuw
		{
			get
			{
				return this.sgt_straat_nieuwField;
			}
			set
			{
				this.sgt_straat_nieuwField = value;
			}
		}
		public string sgt_straat_oud
		{
			get
			{
				return this.sgt_straat_oudField;
			}
			set
			{
				this.sgt_straat_oudField = value;
			}
		}
		public string sgt_telefoonoverdag_nieuw
		{
			get
			{
				return this.sgt_telefoonoverdag_nieuwField;
			}
			set
			{
				this.sgt_telefoonoverdag_nieuwField = value;
			}
		}
		public string sgt_telefoonoverdag_oud
		{
			get
			{
				return this.sgt_telefoonoverdag_oudField;
			}
			set
			{
				this.sgt_telefoonoverdag_oudField = value;
			}
		}
		public string sgt_telefoonsavonds_nieuw
		{
			get
			{
				return this.sgt_telefoonsavonds_nieuwField;
			}
			set
			{
				this.sgt_telefoonsavonds_nieuwField = value;
			}
		}
		public string sgt_telefoonsavonds_oud
		{
			get
			{
				return this.sgt_telefoonsavonds_oudField;
			}
			set
			{
				this.sgt_telefoonsavonds_oudField = value;
			}
		}
		public string sgt_toevoeging_nieuw
		{
			get
			{
				return this.sgt_toevoeging_nieuwField;
			}
			set
			{
				this.sgt_toevoeging_nieuwField = value;
			}
		}
		public string sgt_toevoeging_oud
		{
			get
			{
				return this.sgt_toevoeging_oudField;
			}
			set
			{
				this.sgt_toevoeging_oudField = value;
			}
		}
		public string sgt_voornamen_nieuw
		{
			get
			{
				return this.sgt_voornamen_nieuwField;
			}
			set
			{
				this.sgt_voornamen_nieuwField = value;
			}
		}
		public string sgt_voornamen_oud
		{
			get
			{
				return this.sgt_voornamen_oudField;
			}
			set
			{
				this.sgt_voornamen_oudField = value;
			}
		}
		public Sgt_bo_gewijzigde_persoonsgegevensStateInfo statecode
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
