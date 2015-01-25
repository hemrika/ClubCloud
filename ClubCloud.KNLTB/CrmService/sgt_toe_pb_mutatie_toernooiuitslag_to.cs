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
	public class sgt_toe_pb_mutatie_toernooiuitslag_to : BusinessEntity
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

		private CrmDateTime sgt_datum_opnieuw_verwerktField;

		private Picklist sgt_geslachtField;

		private CrmBoolean sgt_herstart_mogelijkField;

		private Picklist sgt_import_exportField;

		private CrmNumber sgt_leeftijd_tot_en_metField;

		private CrmNumber sgt_leeftijd_vanafField;

		private string sgt_onderdeel_idField;

		private string sgt_onderdeel_naamField;

		private CrmBoolean sgt_opnieuw_verwerkenField;

		private Lookup sgt_pb_itf_log_toernooien_idField;

		private Lookup sgt_pb_uitslag_toernooiverwijzing_idField;

		private Picklist sgt_speelsterkteField;

		private Picklist sgt_spelsoortField;

		private Key sgt_toe_pb_mutatie_toernooiuitslag_toidField;

		private string sgt_toe_volgnummerField;

		private CrmBoolean sgt_verwerkenField;

		private Sgt_toe_pb_mutatie_toernooiuitslag_toStateInfo statecodeField;

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
		public CrmDateTime sgt_datum_opnieuw_verwerkt
		{
			get
			{
				return this.sgt_datum_opnieuw_verwerktField;
			}
			set
			{
				this.sgt_datum_opnieuw_verwerktField = value;
				base.RaisePropertyChanged("sgt_datum_opnieuw_verwerkt");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
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

		[XmlElement] //[XmlElement(Order=11)]
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

		[XmlElement] //[XmlElement(Order=12)]
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

		[XmlElement] //[XmlElement(Order=13)]
		public CrmNumber sgt_leeftijd_tot_en_met
		{
			get
			{
				return this.sgt_leeftijd_tot_en_metField;
			}
			set
			{
				this.sgt_leeftijd_tot_en_metField = value;
				base.RaisePropertyChanged("sgt_leeftijd_tot_en_met");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public CrmNumber sgt_leeftijd_vanaf
		{
			get
			{
				return this.sgt_leeftijd_vanafField;
			}
			set
			{
				this.sgt_leeftijd_vanafField = value;
				base.RaisePropertyChanged("sgt_leeftijd_vanaf");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public string sgt_onderdeel_id
		{
			get
			{
				return this.sgt_onderdeel_idField;
			}
			set
			{
				this.sgt_onderdeel_idField = value;
				base.RaisePropertyChanged("sgt_onderdeel_id");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public string sgt_onderdeel_naam
		{
			get
			{
				return this.sgt_onderdeel_naamField;
			}
			set
			{
				this.sgt_onderdeel_naamField = value;
				base.RaisePropertyChanged("sgt_onderdeel_naam");
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
		public Lookup sgt_pb_uitslag_toernooiverwijzing_id
		{
			get
			{
				return this.sgt_pb_uitslag_toernooiverwijzing_idField;
			}
			set
			{
				this.sgt_pb_uitslag_toernooiverwijzing_idField = value;
				base.RaisePropertyChanged("sgt_pb_uitslag_toernooiverwijzing_id");
			}
		}

		[XmlElement] //[XmlElement(Order=20)]
		public Picklist sgt_speelsterkte
		{
			get
			{
				return this.sgt_speelsterkteField;
			}
			set
			{
				this.sgt_speelsterkteField = value;
				base.RaisePropertyChanged("sgt_speelsterkte");
			}
		}

		[XmlElement] //[XmlElement(Order=21)]
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

		[XmlElement] //[XmlElement(Order=22)]
		public Key sgt_toe_pb_mutatie_toernooiuitslag_toid
		{
			get
			{
				return this.sgt_toe_pb_mutatie_toernooiuitslag_toidField;
			}
			set
			{
				this.sgt_toe_pb_mutatie_toernooiuitslag_toidField = value;
				base.RaisePropertyChanged("sgt_toe_pb_mutatie_toernooiuitslag_toid");
			}
		}

		[XmlElement] //[XmlElement(Order=23)]
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

		[XmlElement] //[XmlElement(Order=24)]
		public CrmBoolean sgt_verwerken
		{
			get
			{
				return this.sgt_verwerkenField;
			}
			set
			{
				this.sgt_verwerkenField = value;
				base.RaisePropertyChanged("sgt_verwerken");
			}
		}

		[XmlElement] //[XmlElement(Order=25)]
		public Sgt_toe_pb_mutatie_toernooiuitslag_toStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=26)]
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

		[XmlElement] //[XmlElement(Order=27)]
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

		[XmlElement] //[XmlElement(Order=28)]
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

		public sgt_toe_pb_mutatie_toernooiuitslag_to()
		{
		}
	}
}