using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_arbitrage_inzet_per_dag : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private Lookup sgt_arbiteridField;
		private string sgt_arbitrage_inzet_per_dag1Field;
		private Key sgt_arbitrage_inzet_per_dagidField;
		private Lookup sgt_arbitrage_inzet_toernooiField;
		private CrmDateTime sgt_datumField;
		private Lookup sgt_functieidField;
		private Picklist sgt_inzet_dagField;
		private CrmBoolean sgt_kandidaatField;
		private Picklist sgt_statusField;
		private Lookup sgt_toernooi_aanvraag_verwerking_idField;
		private Lookup sgt_toernooiidField;
		private Sgt_arbitrage_inzet_per_dagStateInfo statecodeField;
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
		public Lookup sgt_arbiterid
		{
			get
			{
				return this.sgt_arbiteridField;
			}
			set
			{
				this.sgt_arbiteridField = value;
			}
		}
		[XmlElement("sgt_arbitrage_inzet_per_dag")]
		public string sgt_arbitrage_inzet_per_dag1
		{
			get
			{
				return this.sgt_arbitrage_inzet_per_dag1Field;
			}
			set
			{
				this.sgt_arbitrage_inzet_per_dag1Field = value;
			}
		}
		public Key sgt_arbitrage_inzet_per_dagid
		{
			get
			{
				return this.sgt_arbitrage_inzet_per_dagidField;
			}
			set
			{
				this.sgt_arbitrage_inzet_per_dagidField = value;
			}
		}
		public Lookup sgt_arbitrage_inzet_toernooi
		{
			get
			{
				return this.sgt_arbitrage_inzet_toernooiField;
			}
			set
			{
				this.sgt_arbitrage_inzet_toernooiField = value;
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
		public Picklist sgt_inzet_dag
		{
			get
			{
				return this.sgt_inzet_dagField;
			}
			set
			{
				this.sgt_inzet_dagField = value;
			}
		}
		public CrmBoolean sgt_kandidaat
		{
			get
			{
				return this.sgt_kandidaatField;
			}
			set
			{
				this.sgt_kandidaatField = value;
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
		public Sgt_arbitrage_inzet_per_dagStateInfo statecode
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
