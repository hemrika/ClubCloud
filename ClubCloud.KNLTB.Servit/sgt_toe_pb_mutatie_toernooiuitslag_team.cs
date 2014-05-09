using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_toe_pb_mutatie_toernooiuitslag_team : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private string sgt_achternaam1Field;
		private string sgt_achternaam2Field;
		private string sgt_bondsnummer1Field;
		private string sgt_bondsnummer2Field;
		private CrmDateTime sgt_datum_mutatie_verwerktField;
		private CrmNumber sgt_eindstand_tot_en_metField;
		private CrmNumber sgt_eindstand_vanafField;
		private CrmNumber sgt_geplaatstField;
		private Picklist sgt_import_exportField;
		private string sgt_kwalificatiecodeField;
		private Lookup sgt_pb_itf_log_toernooien_idField;
		private Lookup sgt_pb_toernooionderdeelverwijzing_idField;
		private Lookup sgt_pb_toernooiverwijzing_idField;
		private string sgt_team_geplaatstField;
		private string sgt_team_idField;
		private Key sgt_toe_pb_mutatie_toernooiuitslag_teamidField;
		private string sgt_toe_volgnummerField;
		private string sgt_tussenvoegsel1Field;
		private string sgt_tussenvoegsel2Field;
		private string sgt_voornaam1Field;
		private string sgt_voornaam2Field;
		private Sgt_toe_pb_mutatie_toernooiuitslag_teamStateInfo statecodeField;
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
		public string sgt_achternaam1
		{
			get
			{
				return this.sgt_achternaam1Field;
			}
			set
			{
				this.sgt_achternaam1Field = value;
				base.RaisePropertyChanged("sgt_achternaam1");
			}
		}
		[XmlElement(Order = 9)]
		public string sgt_achternaam2
		{
			get
			{
				return this.sgt_achternaam2Field;
			}
			set
			{
				this.sgt_achternaam2Field = value;
				base.RaisePropertyChanged("sgt_achternaam2");
			}
		}
		[XmlElement(Order = 10)]
		public string sgt_bondsnummer1
		{
			get
			{
				return this.sgt_bondsnummer1Field;
			}
			set
			{
				this.sgt_bondsnummer1Field = value;
				base.RaisePropertyChanged("sgt_bondsnummer1");
			}
		}
		[XmlElement(Order = 11)]
		public string sgt_bondsnummer2
		{
			get
			{
				return this.sgt_bondsnummer2Field;
			}
			set
			{
				this.sgt_bondsnummer2Field = value;
				base.RaisePropertyChanged("sgt_bondsnummer2");
			}
		}
		[XmlElement(Order = 12)]
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
		[XmlElement(Order = 13)]
		public CrmNumber sgt_eindstand_tot_en_met
		{
			get
			{
				return this.sgt_eindstand_tot_en_metField;
			}
			set
			{
				this.sgt_eindstand_tot_en_metField = value;
				base.RaisePropertyChanged("sgt_eindstand_tot_en_met");
			}
		}
		[XmlElement(Order = 14)]
		public CrmNumber sgt_eindstand_vanaf
		{
			get
			{
				return this.sgt_eindstand_vanafField;
			}
			set
			{
				this.sgt_eindstand_vanafField = value;
				base.RaisePropertyChanged("sgt_eindstand_vanaf");
			}
		}
		[XmlElement(Order = 15)]
		public CrmNumber sgt_geplaatst
		{
			get
			{
				return this.sgt_geplaatstField;
			}
			set
			{
				this.sgt_geplaatstField = value;
				base.RaisePropertyChanged("sgt_geplaatst");
			}
		}
		[XmlElement(Order = 16)]
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
		[XmlElement(Order = 17)]
		public string sgt_kwalificatiecode
		{
			get
			{
				return this.sgt_kwalificatiecodeField;
			}
			set
			{
				this.sgt_kwalificatiecodeField = value;
				base.RaisePropertyChanged("sgt_kwalificatiecode");
			}
		}
		[XmlElement(Order = 18)]
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
		[XmlElement(Order = 19)]
		public Lookup sgt_pb_toernooionderdeelverwijzing_id
		{
			get
			{
				return this.sgt_pb_toernooionderdeelverwijzing_idField;
			}
			set
			{
				this.sgt_pb_toernooionderdeelverwijzing_idField = value;
				base.RaisePropertyChanged("sgt_pb_toernooionderdeelverwijzing_id");
			}
		}
		[XmlElement(Order = 20)]
		public Lookup sgt_pb_toernooiverwijzing_id
		{
			get
			{
				return this.sgt_pb_toernooiverwijzing_idField;
			}
			set
			{
				this.sgt_pb_toernooiverwijzing_idField = value;
				base.RaisePropertyChanged("sgt_pb_toernooiverwijzing_id");
			}
		}
		[XmlElement(Order = 21)]
		public string sgt_team_geplaatst
		{
			get
			{
				return this.sgt_team_geplaatstField;
			}
			set
			{
				this.sgt_team_geplaatstField = value;
				base.RaisePropertyChanged("sgt_team_geplaatst");
			}
		}
		[XmlElement(Order = 22)]
		public string sgt_team_id
		{
			get
			{
				return this.sgt_team_idField;
			}
			set
			{
				this.sgt_team_idField = value;
				base.RaisePropertyChanged("sgt_team_id");
			}
		}
		[XmlElement(Order = 23)]
		public Key sgt_toe_pb_mutatie_toernooiuitslag_teamid
		{
			get
			{
				return this.sgt_toe_pb_mutatie_toernooiuitslag_teamidField;
			}
			set
			{
				this.sgt_toe_pb_mutatie_toernooiuitslag_teamidField = value;
				base.RaisePropertyChanged("sgt_toe_pb_mutatie_toernooiuitslag_teamid");
			}
		}
		[XmlElement(Order = 24)]
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
		[XmlElement(Order = 25)]
		public string sgt_tussenvoegsel1
		{
			get
			{
				return this.sgt_tussenvoegsel1Field;
			}
			set
			{
				this.sgt_tussenvoegsel1Field = value;
				base.RaisePropertyChanged("sgt_tussenvoegsel1");
			}
		}
		[XmlElement(Order = 26)]
		public string sgt_tussenvoegsel2
		{
			get
			{
				return this.sgt_tussenvoegsel2Field;
			}
			set
			{
				this.sgt_tussenvoegsel2Field = value;
				base.RaisePropertyChanged("sgt_tussenvoegsel2");
			}
		}
		[XmlElement(Order = 27)]
		public string sgt_voornaam1
		{
			get
			{
				return this.sgt_voornaam1Field;
			}
			set
			{
				this.sgt_voornaam1Field = value;
				base.RaisePropertyChanged("sgt_voornaam1");
			}
		}
		[XmlElement(Order = 28)]
		public string sgt_voornaam2
		{
			get
			{
				return this.sgt_voornaam2Field;
			}
			set
			{
				this.sgt_voornaam2Field = value;
				base.RaisePropertyChanged("sgt_voornaam2");
			}
		}
		[XmlElement(Order = 29)]
		public Sgt_toe_pb_mutatie_toernooiuitslag_teamStateInfo statecode
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
		[XmlElement(Order = 30)]
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
		[XmlElement(Order = 31)]
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
		[XmlElement(Order = 32)]
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
