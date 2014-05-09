using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_toe_pb_mutatie_toernooiuitslag_partij : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private Picklist sgt_bijzonderheidField;
		private CrmDateTime sgt_datum_mutatie_verwerktField;
		private Picklist sgt_import_exportField;
		private Lookup sgt_pb_itf_log_toernooien_idField;
		private Lookup sgt_pb_to_verwijzing_poule_idField;
		private Lookup sgt_pb_to_verwijzing_ronde_idField;
		private Lookup sgt_pb_toernooionderdeelverwijzing_idField;
		private Lookup sgt_pb_toernooiverwijzing_idField;
		private Picklist sgt_spelsoortField;
		private string sgt_team_thuisField;
		private Lookup sgt_team_thuis_idField;
		private string sgt_team_uitField;
		private Lookup sgt_team_uit_idField;
		private Key sgt_toe_pb_mutatie_toernooiuitslag_partijidField;
		private string sgt_toe_volgnummerField;
		private Picklist sgt_uitslagField;
		private Sgt_toe_pb_mutatie_toernooiuitslag_partijStateInfo statecodeField;
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
		public Picklist sgt_bijzonderheid
		{
			get
			{
				return this.sgt_bijzonderheidField;
			}
			set
			{
				this.sgt_bijzonderheidField = value;
				base.RaisePropertyChanged("sgt_bijzonderheid");
			}
		}
		[XmlElement(Order = 9)]
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
		[XmlElement(Order = 10)]
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
		[XmlElement(Order = 11)]
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
		[XmlElement(Order = 12)]
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
		[XmlElement(Order = 13)]
		public Lookup sgt_pb_to_verwijzing_ronde_id
		{
			get
			{
				return this.sgt_pb_to_verwijzing_ronde_idField;
			}
			set
			{
				this.sgt_pb_to_verwijzing_ronde_idField = value;
				base.RaisePropertyChanged("sgt_pb_to_verwijzing_ronde_id");
			}
		}
		[XmlElement(Order = 14)]
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
		[XmlElement(Order = 15)]
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
		[XmlElement(Order = 16)]
		public Picklist sgt_spelsoort
		{
			get
			{
				return this.sgt_spelsoortField;
			}
			set
			{
				this.sgt_spelsoortField = value;
				base.RaisePropertyChanged("sgt_spelsoort");
			}
		}
		[XmlElement(Order = 17)]
		public string sgt_team_thuis
		{
			get
			{
				return this.sgt_team_thuisField;
			}
			set
			{
				this.sgt_team_thuisField = value;
				base.RaisePropertyChanged("sgt_team_thuis");
			}
		}
		[XmlElement(Order = 18)]
		public Lookup sgt_team_thuis_id
		{
			get
			{
				return this.sgt_team_thuis_idField;
			}
			set
			{
				this.sgt_team_thuis_idField = value;
				base.RaisePropertyChanged("sgt_team_thuis_id");
			}
		}
		[XmlElement(Order = 19)]
		public string sgt_team_uit
		{
			get
			{
				return this.sgt_team_uitField;
			}
			set
			{
				this.sgt_team_uitField = value;
				base.RaisePropertyChanged("sgt_team_uit");
			}
		}
		[XmlElement(Order = 20)]
		public Lookup sgt_team_uit_id
		{
			get
			{
				return this.sgt_team_uit_idField;
			}
			set
			{
				this.sgt_team_uit_idField = value;
				base.RaisePropertyChanged("sgt_team_uit_id");
			}
		}
		[XmlElement(Order = 21)]
		public Key sgt_toe_pb_mutatie_toernooiuitslag_partijid
		{
			get
			{
				return this.sgt_toe_pb_mutatie_toernooiuitslag_partijidField;
			}
			set
			{
				this.sgt_toe_pb_mutatie_toernooiuitslag_partijidField = value;
				base.RaisePropertyChanged("sgt_toe_pb_mutatie_toernooiuitslag_partijid");
			}
		}
		[XmlElement(Order = 22)]
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
		[XmlElement(Order = 23)]
		public Picklist sgt_uitslag
		{
			get
			{
				return this.sgt_uitslagField;
			}
			set
			{
				this.sgt_uitslagField = value;
				base.RaisePropertyChanged("sgt_uitslag");
			}
		}
		[XmlElement(Order = 24)]
		public Sgt_toe_pb_mutatie_toernooiuitslag_partijStateInfo statecode
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
		[XmlElement(Order = 25)]
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
		[XmlElement(Order = 26)]
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
		[XmlElement(Order = 27)]
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
