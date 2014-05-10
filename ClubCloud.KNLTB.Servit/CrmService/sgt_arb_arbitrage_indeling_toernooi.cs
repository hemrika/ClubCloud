using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_arb_arbitrage_indeling_toernooi : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private string sgt_arb_arbitrage_indeling_toernooi1Field;
		private Key sgt_arb_arbitrage_indeling_toernooiidField;
		private CrmBoolean sgt_automatisch_indelenField;
		private CrmDateTime sgt_datum_herstartField;
		private CrmDateTime sgt_datum_indelenField;
		private CrmBoolean sgt_herstartenField;
		private string sgt_reden_statusField;
		private Picklist sgt_statusField;
		private Lookup sgt_toernooikalenderidField;
		private Sgt_arb_arbitrage_indeling_toernooiStateInfo statecodeField;
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
		[XmlElement("sgt_arb_arbitrage_indeling_toernooi")]
		public string sgt_arb_arbitrage_indeling_toernooi1
		{
			get
			{
				return this.sgt_arb_arbitrage_indeling_toernooi1Field;
			}
			set
			{
				this.sgt_arb_arbitrage_indeling_toernooi1Field = value;
			}
		}
		public Key sgt_arb_arbitrage_indeling_toernooiid
		{
			get
			{
				return this.sgt_arb_arbitrage_indeling_toernooiidField;
			}
			set
			{
				this.sgt_arb_arbitrage_indeling_toernooiidField = value;
			}
		}
		public CrmBoolean sgt_automatisch_indelen
		{
			get
			{
				return this.sgt_automatisch_indelenField;
			}
			set
			{
				this.sgt_automatisch_indelenField = value;
			}
		}
		public CrmDateTime sgt_datum_herstart
		{
			get
			{
				return this.sgt_datum_herstartField;
			}
			set
			{
				this.sgt_datum_herstartField = value;
			}
		}
		public CrmDateTime sgt_datum_indelen
		{
			get
			{
				return this.sgt_datum_indelenField;
			}
			set
			{
				this.sgt_datum_indelenField = value;
			}
		}
		public CrmBoolean sgt_herstarten
		{
			get
			{
				return this.sgt_herstartenField;
			}
			set
			{
				this.sgt_herstartenField = value;
			}
		}
		public string sgt_reden_status
		{
			get
			{
				return this.sgt_reden_statusField;
			}
			set
			{
				this.sgt_reden_statusField = value;
			}
		}
		public Picklist sgt_status
		{
			get
			{
				return this.sgt_statusField;
			}
			set
			{
				this.sgt_statusField = value;
			}
		}
		public Lookup sgt_toernooikalenderid
		{
			get
			{
				return this.sgt_toernooikalenderidField;
			}
			set
			{
				this.sgt_toernooikalenderidField = value;
			}
		}
		public Sgt_arb_arbitrage_indeling_toernooiStateInfo statecode
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
