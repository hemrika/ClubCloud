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
	public class sgt_toe_toernooischema_speler : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private Lookup sgt_basisschema_gespeeld_idField;

		private string sgt_omschrijvingField;

		private CrmNumber sgt_positie_gespeeldField;

		private string sgt_poule_gespeeldField;

		private Lookup sgt_poule_gespeeld_idField;

		private string sgt_poule_te_spelenField;

		private Lookup sgt_poule_te_spelen_idField;

		private Lookup sgt_ronde_poule_gespeeld_idField;

		private Lookup sgt_ronde_poule_te_spelen_idField;

		private string sgt_schemaspeler_te_spelenField;

		private Key sgt_toe_toernooischema_speleridField;

		private Lookup sgt_toernooischema_idField;

		private Picklist sgt_volgnummerField;

		private Sgt_toe_toernooischema_spelerStateInfo statecodeField;

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
		public Lookup sgt_basisschema_gespeeld_id
		{
			get
			{
				return this.sgt_basisschema_gespeeld_idField;
			}
			set
			{
				this.sgt_basisschema_gespeeld_idField = value;
				base.RaisePropertyChanged("sgt_basisschema_gespeeld_id");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public string sgt_omschrijving
		{
			get
			{
				return this.sgt_omschrijvingField;
			}
			set
			{
				this.sgt_omschrijvingField = value;
				base.RaisePropertyChanged("sgt_omschrijving");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public CrmNumber sgt_positie_gespeeld
		{
			get
			{
				return this.sgt_positie_gespeeldField;
			}
			set
			{
				this.sgt_positie_gespeeldField = value;
				base.RaisePropertyChanged("sgt_positie_gespeeld");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public string sgt_poule_gespeeld
		{
			get
			{
				return this.sgt_poule_gespeeldField;
			}
			set
			{
				this.sgt_poule_gespeeldField = value;
				base.RaisePropertyChanged("sgt_poule_gespeeld");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public Lookup sgt_poule_gespeeld_id
		{
			get
			{
				return this.sgt_poule_gespeeld_idField;
			}
			set
			{
				this.sgt_poule_gespeeld_idField = value;
				base.RaisePropertyChanged("sgt_poule_gespeeld_id");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public string sgt_poule_te_spelen
		{
			get
			{
				return this.sgt_poule_te_spelenField;
			}
			set
			{
				this.sgt_poule_te_spelenField = value;
				base.RaisePropertyChanged("sgt_poule_te_spelen");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public Lookup sgt_poule_te_spelen_id
		{
			get
			{
				return this.sgt_poule_te_spelen_idField;
			}
			set
			{
				this.sgt_poule_te_spelen_idField = value;
				base.RaisePropertyChanged("sgt_poule_te_spelen_id");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public Lookup sgt_ronde_poule_gespeeld_id
		{
			get
			{
				return this.sgt_ronde_poule_gespeeld_idField;
			}
			set
			{
				this.sgt_ronde_poule_gespeeld_idField = value;
				base.RaisePropertyChanged("sgt_ronde_poule_gespeeld_id");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public Lookup sgt_ronde_poule_te_spelen_id
		{
			get
			{
				return this.sgt_ronde_poule_te_spelen_idField;
			}
			set
			{
				this.sgt_ronde_poule_te_spelen_idField = value;
				base.RaisePropertyChanged("sgt_ronde_poule_te_spelen_id");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public string sgt_schemaspeler_te_spelen
		{
			get
			{
				return this.sgt_schemaspeler_te_spelenField;
			}
			set
			{
				this.sgt_schemaspeler_te_spelenField = value;
				base.RaisePropertyChanged("sgt_schemaspeler_te_spelen");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public Key sgt_toe_toernooischema_spelerid
		{
			get
			{
				return this.sgt_toe_toernooischema_speleridField;
			}
			set
			{
				this.sgt_toe_toernooischema_speleridField = value;
				base.RaisePropertyChanged("sgt_toe_toernooischema_spelerid");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
		public Lookup sgt_toernooischema_id
		{
			get
			{
				return this.sgt_toernooischema_idField;
			}
			set
			{
				this.sgt_toernooischema_idField = value;
				base.RaisePropertyChanged("sgt_toernooischema_id");
			}
		}

		[XmlElement] //[XmlElement(Order=20)]
		public Picklist sgt_volgnummer
		{
			get
			{
				return this.sgt_volgnummerField;
			}
			set
			{
				this.sgt_volgnummerField = value;
				base.RaisePropertyChanged("sgt_volgnummer");
			}
		}

		[XmlElement] //[XmlElement(Order=21)]
		public Sgt_toe_toernooischema_spelerStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=22)]
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

		[XmlElement] //[XmlElement(Order=23)]
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

		[XmlElement] //[XmlElement(Order=24)]
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

		public sgt_toe_toernooischema_speler()
		{
		}
	}
}