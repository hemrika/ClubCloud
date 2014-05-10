using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_arb_arbitragebehoefte_toernooi_per_dag : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private CrmNumber sgt_aantalField;
		private string sgt_arb_arbitragebehoefte_toernooi_per_daField;
		private Key sgt_arb_arbitragebehoefte_toernooi_per_dagidField;
		private Lookup sgt_arbitragebehoefteidField;
		private Picklist sgt_arbitragedagField;
		private Picklist sgt_behoefte_statusField;
		private CrmDateTime sgt_datumField;
		private Lookup sgt_functieidField;
		private CrmNumber sgt_reglementair_aantalField;
		private Lookup sgt_toernooi_aanvraag_verwerking_idField;
		private Lookup sgt_toernooiidField;
		private CrmNumber sgt_toernooiweekField;
		private Sgt_arb_arbitragebehoefte_toernooi_per_dagStateInfo statecodeField;
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
		public CrmNumber sgt_aantal
		{
			get
			{
				return this.sgt_aantalField;
			}
			set
			{
				this.sgt_aantalField = value;
			}
		}
		public string sgt_arb_arbitragebehoefte_toernooi_per_da
		{
			get
			{
				return this.sgt_arb_arbitragebehoefte_toernooi_per_daField;
			}
			set
			{
				this.sgt_arb_arbitragebehoefte_toernooi_per_daField = value;
			}
		}
		public Key sgt_arb_arbitragebehoefte_toernooi_per_dagid
		{
			get
			{
				return this.sgt_arb_arbitragebehoefte_toernooi_per_dagidField;
			}
			set
			{
				this.sgt_arb_arbitragebehoefte_toernooi_per_dagidField = value;
			}
		}
		public Lookup sgt_arbitragebehoefteid
		{
			get
			{
				return this.sgt_arbitragebehoefteidField;
			}
			set
			{
				this.sgt_arbitragebehoefteidField = value;
			}
		}
		public Picklist sgt_arbitragedag
		{
			get
			{
				return this.sgt_arbitragedagField;
			}
			set
			{
				this.sgt_arbitragedagField = value;
			}
		}
		public Picklist sgt_behoefte_status
		{
			get
			{
				return this.sgt_behoefte_statusField;
			}
			set
			{
				this.sgt_behoefte_statusField = value;
			}
		}
		public CrmDateTime sgt_datum
		{
			get
			{
				return this.sgt_datumField;
			}
			set
			{
				this.sgt_datumField = value;
			}
		}
		public Lookup sgt_functieid
		{
			get
			{
				return this.sgt_functieidField;
			}
			set
			{
				this.sgt_functieidField = value;
			}
		}
		public CrmNumber sgt_reglementair_aantal
		{
			get
			{
				return this.sgt_reglementair_aantalField;
			}
			set
			{
				this.sgt_reglementair_aantalField = value;
			}
		}
		public Lookup sgt_toernooi_aanvraag_verwerking_id
		{
			get
			{
				return this.sgt_toernooi_aanvraag_verwerking_idField;
			}
			set
			{
				this.sgt_toernooi_aanvraag_verwerking_idField = value;
			}
		}
		public Lookup sgt_toernooiid
		{
			get
			{
				return this.sgt_toernooiidField;
			}
			set
			{
				this.sgt_toernooiidField = value;
			}
		}
		public CrmNumber sgt_toernooiweek
		{
			get
			{
				return this.sgt_toernooiweekField;
			}
			set
			{
				this.sgt_toernooiweekField = value;
			}
		}
		public Sgt_arb_arbitragebehoefte_toernooi_per_dagStateInfo statecode
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
