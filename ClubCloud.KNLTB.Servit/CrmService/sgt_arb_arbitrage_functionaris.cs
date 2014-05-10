using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_arb_arbitrage_functionaris : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private Key sgt_arb_arbitrage_functionarisidField;
		private Picklist sgt_arb_jeans_breedteField;
		private Picklist sgt_arb_jeans_lengteField;
		private Picklist sgt_arb_maat_schoenenField;
		private string sgt_arb_naamField;
		private Picklist sgt_arb_pantalonField;
		private Picklist sgt_arb_poloField;
		private Picklist sgt_arb_trainingspakField;
		private Picklist sgt_arb_truiField;
		private Lookup sgt_persoonidField;
		private CrmBoolean sgt_voorkeurhoofdscheidsrechter_voor_toernooiField;
		private Sgt_arb_arbitrage_functionarisStateInfo statecodeField;
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
		public Key sgt_arb_arbitrage_functionarisid
		{
			get
			{
				return this.sgt_arb_arbitrage_functionarisidField;
			}
			set
			{
				this.sgt_arb_arbitrage_functionarisidField = value;
			}
		}
		public Picklist sgt_arb_jeans_breedte
		{
			get
			{
				return this.sgt_arb_jeans_breedteField;
			}
			set
			{
				this.sgt_arb_jeans_breedteField = value;
			}
		}
		public Picklist sgt_arb_jeans_lengte
		{
			get
			{
				return this.sgt_arb_jeans_lengteField;
			}
			set
			{
				this.sgt_arb_jeans_lengteField = value;
			}
		}
		public Picklist sgt_arb_maat_schoenen
		{
			get
			{
				return this.sgt_arb_maat_schoenenField;
			}
			set
			{
				this.sgt_arb_maat_schoenenField = value;
			}
		}
		public string sgt_arb_naam
		{
			get
			{
				return this.sgt_arb_naamField;
			}
			set
			{
				this.sgt_arb_naamField = value;
			}
		}
		public Picklist sgt_arb_pantalon
		{
			get
			{
				return this.sgt_arb_pantalonField;
			}
			set
			{
				this.sgt_arb_pantalonField = value;
			}
		}
		public Picklist sgt_arb_polo
		{
			get
			{
				return this.sgt_arb_poloField;
			}
			set
			{
				this.sgt_arb_poloField = value;
			}
		}
		public Picklist sgt_arb_trainingspak
		{
			get
			{
				return this.sgt_arb_trainingspakField;
			}
			set
			{
				this.sgt_arb_trainingspakField = value;
			}
		}
		public Picklist sgt_arb_trui
		{
			get
			{
				return this.sgt_arb_truiField;
			}
			set
			{
				this.sgt_arb_truiField = value;
			}
		}
		public Lookup sgt_persoonid
		{
			get
			{
				return this.sgt_persoonidField;
			}
			set
			{
				this.sgt_persoonidField = value;
			}
		}
		public CrmBoolean sgt_voorkeurhoofdscheidsrechter_voor_toernooi
		{
			get
			{
				return this.sgt_voorkeurhoofdscheidsrechter_voor_toernooiField;
			}
			set
			{
				this.sgt_voorkeurhoofdscheidsrechter_voor_toernooiField = value;
			}
		}
		public Sgt_arb_arbitrage_functionarisStateInfo statecode
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
