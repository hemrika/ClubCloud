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
	public class sgt_toe_pb_mutatie_toernooiuitslag_ps : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private CrmDateTime sgt_datum_mutatie_verwerktField;

		private Picklist sgt_import_exportField;

		private Lookup sgt_pb_itf_log_toernooien_idField;

		private Lookup sgt_pb_to_verwijzing_poule_idField;

		private Lookup sgt_pb_toernooionderdeelverwijzing_idField;

		private Lookup sgt_pb_toernooiverwijzing_idField;

		private CrmNumber sgt_positieField;

		private Lookup sgt_sgt_pb_to_verwijzing_ronde_idField;

		private string sgt_team_idField;

		private Lookup sgt_team_identificatieField;

		private Key sgt_toe_pb_mutatie_toernooiuitslag_psidField;

		private string sgt_toe_volgnummerField;

		private Sgt_toe_pb_mutatie_toernooiuitslag_psStateInfo statecodeField;

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

		[XmlElement] //[XmlElement(Order=9)]
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

		[XmlElement] //[XmlElement(Order=10)]
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

		[XmlElement] //[XmlElement(Order=11)]
		public Lookup sgt_pb_to_verwijzing_poule_id
		{
			get
			{
				return this.sgt_pb_to_verwijzing_poule_idField;
			}
			set
			{
				this.sgt_pb_to_verwijzing_poule_idField = value;
				base.RaisePropertyChanged("sgt_pb_to_verwijzing_poule_id");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
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

		[XmlElement] //[XmlElement(Order=13)]
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

		[XmlElement] //[XmlElement(Order=14)]
		public CrmNumber sgt_positie
		{
			get
			{
				return this.sgt_positieField;
			}
			set
			{
				this.sgt_positieField = value;
				base.RaisePropertyChanged("sgt_positie");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public Lookup sgt_sgt_pb_to_verwijzing_ronde_id
		{
			get
			{
				return this.sgt_sgt_pb_to_verwijzing_ronde_idField;
			}
			set
			{
				this.sgt_sgt_pb_to_verwijzing_ronde_idField = value;
				base.RaisePropertyChanged("sgt_sgt_pb_to_verwijzing_ronde_id");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
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

		[XmlElement] //[XmlElement(Order=17)]
		public Lookup sgt_team_identificatie
		{
			get
			{
				return this.sgt_team_identificatieField;
			}
			set
			{
				this.sgt_team_identificatieField = value;
				base.RaisePropertyChanged("sgt_team_identificatie");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public Key sgt_toe_pb_mutatie_toernooiuitslag_psid
		{
			get
			{
				return this.sgt_toe_pb_mutatie_toernooiuitslag_psidField;
			}
			set
			{
				this.sgt_toe_pb_mutatie_toernooiuitslag_psidField = value;
				base.RaisePropertyChanged("sgt_toe_pb_mutatie_toernooiuitslag_psid");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
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

		[XmlElement] //[XmlElement(Order=20)]
		public Sgt_toe_pb_mutatie_toernooiuitslag_psStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=21)]
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

		[XmlElement] //[XmlElement(Order=22)]
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

		[XmlElement] //[XmlElement(Order=23)]
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

		public sgt_toe_pb_mutatie_toernooiuitslag_ps()
		{
		}
	}
}