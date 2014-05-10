using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_toe_pb_mutatie_toernooiuitslag : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private string sgt_bg_achternaamField;
		private string sgt_bg_emailadresField;
		private string sgt_bg_telefoonField;
		private string sgt_bg_tussenvoegselField;
		private string sgt_bg_voornaamField;
		private CrmDateTime sgt_datum_mutatie_verwerktField;
		private string sgt_dtd_versieField;
		private CrmBoolean sgt_herstart_mogelijkField;
		private Picklist sgt_import_exportField;
		private CrmBoolean sgt_opnieuw_verwerkenField;
		private Lookup sgt_pb_itf_log_toernooien_idField;
		private Key sgt_toe_pb_mutatie_toernooiuitslagidField;
		private string sgt_toe_volgnummerField;
		private string sgt_toernooinaamField;
		private string sgt_toernooinummerField;
		private string sgt_toernooiplanner_naamField;
		private string sgt_toernooiplanner_versieField;
		private string sgt_verenigingsnaamField;
		private string sgt_verenigingsnummerField;
		private string sgt_verenigingsplaatsField;
		private string sgt_wl_achternaamField;
		private string sgt_wl_emailadresField;
		private string sgt_wl_telefoonField;
		private string sgt_wl_tussenvoegselField;
		private string sgt_wl_voornaamField;
		private Sgt_toe_pb_mutatie_toernooiuitslagStateInfo statecodeField;
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
		public string sgt_bg_achternaam
		{
			get
			{
				return this.sgt_bg_achternaamField;
			}
			set
			{
				this.sgt_bg_achternaamField = value;
			}
		}
		public string sgt_bg_emailadres
		{
			get
			{
				return this.sgt_bg_emailadresField;
			}
			set
			{
				this.sgt_bg_emailadresField = value;
			}
		}
		public string sgt_bg_telefoon
		{
			get
			{
				return this.sgt_bg_telefoonField;
			}
			set
			{
				this.sgt_bg_telefoonField = value;
			}
		}
		public string sgt_bg_tussenvoegsel
		{
			get
			{
				return this.sgt_bg_tussenvoegselField;
			}
			set
			{
				this.sgt_bg_tussenvoegselField = value;
			}
		}
		public string sgt_bg_voornaam
		{
			get
			{
				return this.sgt_bg_voornaamField;
			}
			set
			{
				this.sgt_bg_voornaamField = value;
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
		public string sgt_dtd_versie
		{
			get
			{
				return this.sgt_dtd_versieField;
			}
			set
			{
				this.sgt_dtd_versieField = value;
			}
		}
		public CrmBoolean sgt_herstart_mogelijk
		{
			get
			{
				return this.sgt_herstart_mogelijkField;
			}
			set
			{
				this.sgt_herstart_mogelijkField = value;
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
		public CrmBoolean sgt_opnieuw_verwerken
		{
			get
			{
				return this.sgt_opnieuw_verwerkenField;
			}
			set
			{
				this.sgt_opnieuw_verwerkenField = value;
			}
		}
		public Lookup sgt_pb_itf_log_toernooien_id
		{
			get
			{
				return this.sgt_pb_itf_log_toernooien_idField;
			}
			set
			{
				this.sgt_pb_itf_log_toernooien_idField = value;
			}
		}
		public Key sgt_toe_pb_mutatie_toernooiuitslagid
		{
			get
			{
				return this.sgt_toe_pb_mutatie_toernooiuitslagidField;
			}
			set
			{
				this.sgt_toe_pb_mutatie_toernooiuitslagidField = value;
			}
		}
		public string sgt_toe_volgnummer
		{
			get
			{
				return this.sgt_toe_volgnummerField;
			}
			set
			{
				this.sgt_toe_volgnummerField = value;
			}
		}
		public string sgt_toernooinaam
		{
			get
			{
				return this.sgt_toernooinaamField;
			}
			set
			{
				this.sgt_toernooinaamField = value;
			}
		}
		public string sgt_toernooinummer
		{
			get
			{
				return this.sgt_toernooinummerField;
			}
			set
			{
				this.sgt_toernooinummerField = value;
			}
		}
		public string sgt_toernooiplanner_naam
		{
			get
			{
				return this.sgt_toernooiplanner_naamField;
			}
			set
			{
				this.sgt_toernooiplanner_naamField = value;
			}
		}
		public string sgt_toernooiplanner_versie
		{
			get
			{
				return this.sgt_toernooiplanner_versieField;
			}
			set
			{
				this.sgt_toernooiplanner_versieField = value;
			}
		}
		public string sgt_verenigingsnaam
		{
			get
			{
				return this.sgt_verenigingsnaamField;
			}
			set
			{
				this.sgt_verenigingsnaamField = value;
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
		public string sgt_verenigingsplaats
		{
			get
			{
				return this.sgt_verenigingsplaatsField;
			}
			set
			{
				this.sgt_verenigingsplaatsField = value;
			}
		}
		public string sgt_wl_achternaam
		{
			get
			{
				return this.sgt_wl_achternaamField;
			}
			set
			{
				this.sgt_wl_achternaamField = value;
			}
		}
		public string sgt_wl_emailadres
		{
			get
			{
				return this.sgt_wl_emailadresField;
			}
			set
			{
				this.sgt_wl_emailadresField = value;
			}
		}
		public string sgt_wl_telefoon
		{
			get
			{
				return this.sgt_wl_telefoonField;
			}
			set
			{
				this.sgt_wl_telefoonField = value;
			}
		}
		public string sgt_wl_tussenvoegsel
		{
			get
			{
				return this.sgt_wl_tussenvoegselField;
			}
			set
			{
				this.sgt_wl_tussenvoegselField = value;
			}
		}
		public string sgt_wl_voornaam
		{
			get
			{
				return this.sgt_wl_voornaamField;
			}
			set
			{
				this.sgt_wl_voornaamField = value;
			}
		}
		public Sgt_toe_pb_mutatie_toernooiuitslagStateInfo statecode
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
