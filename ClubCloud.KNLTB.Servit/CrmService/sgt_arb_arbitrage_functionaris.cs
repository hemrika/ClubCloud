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
		public Key sgt_arb_arbitrage_functionarisid
		{
			get
			{
				return this.sgt_arb_arbitrage_functionarisidField;
			}
			set
			{
				this.sgt_arb_arbitrage_functionarisidField = value;
				base.RaisePropertyChanged("sgt_arb_arbitrage_functionarisid");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public Picklist sgt_arb_jeans_breedte
		{
			get
			{
				return this.sgt_arb_jeans_breedteField;
			}
			set
			{
				this.sgt_arb_jeans_breedteField = value;
				base.RaisePropertyChanged("sgt_arb_jeans_breedte");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public Picklist sgt_arb_jeans_lengte
		{
			get
			{
				return this.sgt_arb_jeans_lengteField;
			}
			set
			{
				this.sgt_arb_jeans_lengteField = value;
				base.RaisePropertyChanged("sgt_arb_jeans_lengte");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public Picklist sgt_arb_maat_schoenen
		{
			get
			{
				return this.sgt_arb_maat_schoenenField;
			}
			set
			{
				this.sgt_arb_maat_schoenenField = value;
				base.RaisePropertyChanged("sgt_arb_maat_schoenen");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public string sgt_arb_naam
		{
			get
			{
				return this.sgt_arb_naamField;
			}
			set
			{
				this.sgt_arb_naamField = value;
				base.RaisePropertyChanged("sgt_arb_naam");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public Picklist sgt_arb_pantalon
		{
			get
			{
				return this.sgt_arb_pantalonField;
			}
			set
			{
				this.sgt_arb_pantalonField = value;
				base.RaisePropertyChanged("sgt_arb_pantalon");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public Picklist sgt_arb_polo
		{
			get
			{
				return this.sgt_arb_poloField;
			}
			set
			{
				this.sgt_arb_poloField = value;
				base.RaisePropertyChanged("sgt_arb_polo");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public Picklist sgt_arb_trainingspak
		{
			get
			{
				return this.sgt_arb_trainingspakField;
			}
			set
			{
				this.sgt_arb_trainingspakField = value;
				base.RaisePropertyChanged("sgt_arb_trainingspak");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public Picklist sgt_arb_trui
		{
			get
			{
				return this.sgt_arb_truiField;
			}
			set
			{
				this.sgt_arb_truiField = value;
				base.RaisePropertyChanged("sgt_arb_trui");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public Lookup sgt_persoonid
		{
			get
			{
				return this.sgt_persoonidField;
			}
			set
			{
				this.sgt_persoonidField = value;
				base.RaisePropertyChanged("sgt_persoonid");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public CrmBoolean sgt_voorkeurhoofdscheidsrechter_voor_toernooi
		{
			get
			{
				return this.sgt_voorkeurhoofdscheidsrechter_voor_toernooiField;
			}
			set
			{
				this.sgt_voorkeurhoofdscheidsrechter_voor_toernooiField = value;
				base.RaisePropertyChanged("sgt_voorkeurhoofdscheidsrechter_voor_toernooi");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
		public Sgt_arb_arbitrage_functionarisStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=20)]
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

		[XmlElement] //[XmlElement(Order=21)]
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

		[XmlElement] //[XmlElement(Order=22)]
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

		public sgt_arb_arbitrage_functionaris()
		{
		}
	}
}