using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
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
		public string sgt_achternaam1
		{
			get
			{
				return this.sgt_achternaam1Field;
			}
			set
			{
				this.sgt_achternaam1Field = value;
			}
		}
		public string sgt_achternaam2
		{
			get
			{
				return this.sgt_achternaam2Field;
			}
			set
			{
				this.sgt_achternaam2Field = value;
			}
		}
		public string sgt_bondsnummer1
		{
			get
			{
				return this.sgt_bondsnummer1Field;
			}
			set
			{
				this.sgt_bondsnummer1Field = value;
			}
		}
		public string sgt_bondsnummer2
		{
			get
			{
				return this.sgt_bondsnummer2Field;
			}
			set
			{
				this.sgt_bondsnummer2Field = value;
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
		public CrmNumber sgt_eindstand_tot_en_met
		{
			get
			{
				return this.sgt_eindstand_tot_en_metField;
			}
			set
			{
				this.sgt_eindstand_tot_en_metField = value;
			}
		}
		public CrmNumber sgt_eindstand_vanaf
		{
			get
			{
				return this.sgt_eindstand_vanafField;
			}
			set
			{
				this.sgt_eindstand_vanafField = value;
			}
		}
		public CrmNumber sgt_geplaatst
		{
			get
			{
				return this.sgt_geplaatstField;
			}
			set
			{
				this.sgt_geplaatstField = value;
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
		public string sgt_kwalificatiecode
		{
			get
			{
				return this.sgt_kwalificatiecodeField;
			}
			set
			{
				this.sgt_kwalificatiecodeField = value;
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
		public Lookup sgt_pb_toernooionderdeelverwijzing_id
		{
			get
			{
				return this.sgt_pb_toernooionderdeelverwijzing_idField;
			}
			set
			{
				this.sgt_pb_toernooionderdeelverwijzing_idField = value;
			}
		}
		public Lookup sgt_pb_toernooiverwijzing_id
		{
			get
			{
				return this.sgt_pb_toernooiverwijzing_idField;
			}
			set
			{
				this.sgt_pb_toernooiverwijzing_idField = value;
			}
		}
		public string sgt_team_geplaatst
		{
			get
			{
				return this.sgt_team_geplaatstField;
			}
			set
			{
				this.sgt_team_geplaatstField = value;
			}
		}
		public string sgt_team_id
		{
			get
			{
				return this.sgt_team_idField;
			}
			set
			{
				this.sgt_team_idField = value;
			}
		}
		public Key sgt_toe_pb_mutatie_toernooiuitslag_teamid
		{
			get
			{
				return this.sgt_toe_pb_mutatie_toernooiuitslag_teamidField;
			}
			set
			{
				this.sgt_toe_pb_mutatie_toernooiuitslag_teamidField = value;
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
		public string sgt_tussenvoegsel1
		{
			get
			{
				return this.sgt_tussenvoegsel1Field;
			}
			set
			{
				this.sgt_tussenvoegsel1Field = value;
			}
		}
		public string sgt_tussenvoegsel2
		{
			get
			{
				return this.sgt_tussenvoegsel2Field;
			}
			set
			{
				this.sgt_tussenvoegsel2Field = value;
			}
		}
		public string sgt_voornaam1
		{
			get
			{
				return this.sgt_voornaam1Field;
			}
			set
			{
				this.sgt_voornaam1Field = value;
			}
		}
		public string sgt_voornaam2
		{
			get
			{
				return this.sgt_voornaam2Field;
			}
			set
			{
				this.sgt_voornaam2Field = value;
			}
		}
		public Sgt_toe_pb_mutatie_toernooiuitslag_teamStateInfo statecode
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
