using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
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
		public Lookup sgt_basisschema_gespeeld_id
		{
			get
			{
				return this.sgt_basisschema_gespeeld_idField;
			}
			set
			{
				this.sgt_basisschema_gespeeld_idField = value;
			}
		}
		public string sgt_omschrijving
		{
			get
			{
				return this.sgt_omschrijvingField;
			}
			set
			{
				this.sgt_omschrijvingField = value;
			}
		}
		public CrmNumber sgt_positie_gespeeld
		{
			get
			{
				return this.sgt_positie_gespeeldField;
			}
			set
			{
				this.sgt_positie_gespeeldField = value;
			}
		}
		public string sgt_poule_gespeeld
		{
			get
			{
				return this.sgt_poule_gespeeldField;
			}
			set
			{
				this.sgt_poule_gespeeldField = value;
			}
		}
		public Lookup sgt_poule_gespeeld_id
		{
			get
			{
				return this.sgt_poule_gespeeld_idField;
			}
			set
			{
				this.sgt_poule_gespeeld_idField = value;
			}
		}
		public string sgt_poule_te_spelen
		{
			get
			{
				return this.sgt_poule_te_spelenField;
			}
			set
			{
				this.sgt_poule_te_spelenField = value;
			}
		}
		public Lookup sgt_poule_te_spelen_id
		{
			get
			{
				return this.sgt_poule_te_spelen_idField;
			}
			set
			{
				this.sgt_poule_te_spelen_idField = value;
			}
		}
		public Lookup sgt_ronde_poule_gespeeld_id
		{
			get
			{
				return this.sgt_ronde_poule_gespeeld_idField;
			}
			set
			{
				this.sgt_ronde_poule_gespeeld_idField = value;
			}
		}
		public Lookup sgt_ronde_poule_te_spelen_id
		{
			get
			{
				return this.sgt_ronde_poule_te_spelen_idField;
			}
			set
			{
				this.sgt_ronde_poule_te_spelen_idField = value;
			}
		}
		public string sgt_schemaspeler_te_spelen
		{
			get
			{
				return this.sgt_schemaspeler_te_spelenField;
			}
			set
			{
				this.sgt_schemaspeler_te_spelenField = value;
			}
		}
		public Key sgt_toe_toernooischema_spelerid
		{
			get
			{
				return this.sgt_toe_toernooischema_speleridField;
			}
			set
			{
				this.sgt_toe_toernooischema_speleridField = value;
			}
		}
		public Lookup sgt_toernooischema_id
		{
			get
			{
				return this.sgt_toernooischema_idField;
			}
			set
			{
				this.sgt_toernooischema_idField = value;
			}
		}
		public Picklist sgt_volgnummer
		{
			get
			{
				return this.sgt_volgnummerField;
			}
			set
			{
				this.sgt_volgnummerField = value;
			}
		}
		public Sgt_toe_toernooischema_spelerStateInfo statecode
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
