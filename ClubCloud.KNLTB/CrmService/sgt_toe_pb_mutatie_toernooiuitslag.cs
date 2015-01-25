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
		public string sgt_bg_achternaam
		{
			get
			{
				return this.sgt_bg_achternaamField;
			}
			set
			{
				this.sgt_bg_achternaamField = value;
				base.RaisePropertyChanged("sgt_bg_achternaam");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public string sgt_bg_emailadres
		{
			get
			{
				return this.sgt_bg_emailadresField;
			}
			set
			{
				this.sgt_bg_emailadresField = value;
				base.RaisePropertyChanged("sgt_bg_emailadres");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public string sgt_bg_telefoon
		{
			get
			{
				return this.sgt_bg_telefoonField;
			}
			set
			{
				this.sgt_bg_telefoonField = value;
				base.RaisePropertyChanged("sgt_bg_telefoon");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public string sgt_bg_tussenvoegsel
		{
			get
			{
				return this.sgt_bg_tussenvoegselField;
			}
			set
			{
				this.sgt_bg_tussenvoegselField = value;
				base.RaisePropertyChanged("sgt_bg_tussenvoegsel");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public string sgt_bg_voornaam
		{
			get
			{
				return this.sgt_bg_voornaamField;
			}
			set
			{
				this.sgt_bg_voornaamField = value;
				base.RaisePropertyChanged("sgt_bg_voornaam");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
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

		[XmlElement] //[XmlElement(Order=14)]
		public string sgt_dtd_versie
		{
			get
			{
				return this.sgt_dtd_versieField;
			}
			set
			{
				this.sgt_dtd_versieField = value;
				base.RaisePropertyChanged("sgt_dtd_versie");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public CrmBoolean sgt_herstart_mogelijk
		{
			get
			{
				return this.sgt_herstart_mogelijkField;
			}
			set
			{
				this.sgt_herstart_mogelijkField = value;
				base.RaisePropertyChanged("sgt_herstart_mogelijk");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
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

		[XmlElement] //[XmlElement(Order=17)]
		public CrmBoolean sgt_opnieuw_verwerken
		{
			get
			{
				return this.sgt_opnieuw_verwerkenField;
			}
			set
			{
				this.sgt_opnieuw_verwerkenField = value;
				base.RaisePropertyChanged("sgt_opnieuw_verwerken");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public Lookup sgt_pb_itf_log_toernooien_id
		{
			get
			{
				return this.sgt_pb_itf_log_toernooien_idField;
			}
			set
			{
				this.sgt_pb_itf_log_toernooien_idField = value;
				base.RaisePropertyChanged("sgt_pb_itf_log_toernooien_id");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
		public Key sgt_toe_pb_mutatie_toernooiuitslagid
		{
			get
			{
				return this.sgt_toe_pb_mutatie_toernooiuitslagidField;
			}
			set
			{
				this.sgt_toe_pb_mutatie_toernooiuitslagidField = value;
				base.RaisePropertyChanged("sgt_toe_pb_mutatie_toernooiuitslagid");
			}
		}

		[XmlElement] //[XmlElement(Order=20)]
		public string sgt_toe_volgnummer
		{
			get
			{
				return this.sgt_toe_volgnummerField;
			}
			set
			{
				this.sgt_toe_volgnummerField = value;
				base.RaisePropertyChanged("sgt_toe_volgnummer");
			}
		}

		[XmlElement] //[XmlElement(Order=21)]
		public string sgt_toernooinaam
		{
			get
			{
				return this.sgt_toernooinaamField;
			}
			set
			{
				this.sgt_toernooinaamField = value;
				base.RaisePropertyChanged("sgt_toernooinaam");
			}
		}

		[XmlElement] //[XmlElement(Order=22)]
		public string sgt_toernooinummer
		{
			get
			{
				return this.sgt_toernooinummerField;
			}
			set
			{
				this.sgt_toernooinummerField = value;
				base.RaisePropertyChanged("sgt_toernooinummer");
			}
		}

		[XmlElement] //[XmlElement(Order=23)]
		public string sgt_toernooiplanner_naam
		{
			get
			{
				return this.sgt_toernooiplanner_naamField;
			}
			set
			{
				this.sgt_toernooiplanner_naamField = value;
				base.RaisePropertyChanged("sgt_toernooiplanner_naam");
			}
		}

		[XmlElement] //[XmlElement(Order=24)]
		public string sgt_toernooiplanner_versie
		{
			get
			{
				return this.sgt_toernooiplanner_versieField;
			}
			set
			{
				this.sgt_toernooiplanner_versieField = value;
				base.RaisePropertyChanged("sgt_toernooiplanner_versie");
			}
		}

		[XmlElement] //[XmlElement(Order=25)]
		public string sgt_verenigingsnaam
		{
			get
			{
				return this.sgt_verenigingsnaamField;
			}
			set
			{
				this.sgt_verenigingsnaamField = value;
				base.RaisePropertyChanged("sgt_verenigingsnaam");
			}
		}

		[XmlElement] //[XmlElement(Order=26)]
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

		[XmlElement] //[XmlElement(Order=27)]
		public string sgt_verenigingsplaats
		{
			get
			{
				return this.sgt_verenigingsplaatsField;
			}
			set
			{
				this.sgt_verenigingsplaatsField = value;
				base.RaisePropertyChanged("sgt_verenigingsplaats");
			}
		}

		[XmlElement] //[XmlElement(Order=28)]
		public string sgt_wl_achternaam
		{
			get
			{
				return this.sgt_wl_achternaamField;
			}
			set
			{
				this.sgt_wl_achternaamField = value;
				base.RaisePropertyChanged("sgt_wl_achternaam");
			}
		}

		[XmlElement] //[XmlElement(Order=29)]
		public string sgt_wl_emailadres
		{
			get
			{
				return this.sgt_wl_emailadresField;
			}
			set
			{
				this.sgt_wl_emailadresField = value;
				base.RaisePropertyChanged("sgt_wl_emailadres");
			}
		}

		[XmlElement] //[XmlElement(Order=30)]
		public string sgt_wl_telefoon
		{
			get
			{
				return this.sgt_wl_telefoonField;
			}
			set
			{
				this.sgt_wl_telefoonField = value;
				base.RaisePropertyChanged("sgt_wl_telefoon");
			}
		}

		[XmlElement] //[XmlElement(Order=31)]
		public string sgt_wl_tussenvoegsel
		{
			get
			{
				return this.sgt_wl_tussenvoegselField;
			}
			set
			{
				this.sgt_wl_tussenvoegselField = value;
				base.RaisePropertyChanged("sgt_wl_tussenvoegsel");
			}
		}

		[XmlElement] //[XmlElement(Order=32)]
		public string sgt_wl_voornaam
		{
			get
			{
				return this.sgt_wl_voornaamField;
			}
			set
			{
				this.sgt_wl_voornaamField = value;
				base.RaisePropertyChanged("sgt_wl_voornaam");
			}
		}

		[XmlElement] //[XmlElement(Order=33)]
		public Sgt_toe_pb_mutatie_toernooiuitslagStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=34)]
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

		[XmlElement] //[XmlElement(Order=35)]
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

		[XmlElement] //[XmlElement(Order=36)]
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

		public sgt_toe_pb_mutatie_toernooiuitslag()
		{
		}
	}
}