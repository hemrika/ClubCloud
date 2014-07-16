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
	public class sgt_arb_arbitrage_inzet_competitie : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private Lookup sgt_afdelingidField;

		private string sgt_arb_arbitrage_inzet_competitie1Field;

		private Key sgt_arb_arbitrage_inzet_competitieidField;

		private Lookup sgt_arbitragefunctionarisidField;

		private Lookup sgt_competitieidField;

		private Lookup sgt_functieidField;

		private Picklist sgt_inzet_statusField;

		private Lookup sgt_klassegroepidField;

		private Lookup sgt_piramideidField;

		private Lookup sgt_ploegthuisidField;

		private Lookup sgt_ploeguitidField;

		private CrmDateTime sgt_speeldag_datumField;

		private Lookup sgt_verenigingthuisidField;

		private Lookup sgt_vereniginguitidField;

		private Lookup sgt_wedstrijdidField;

		private Sgt_arb_arbitrage_inzet_competitieStateInfo statecodeField;

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
		public Lookup sgt_afdelingid
		{
			get
			{
				return this.sgt_afdelingidField;
			}
			set
			{
				this.sgt_afdelingidField = value;
				base.RaisePropertyChanged("sgt_afdelingid");
			}
		}

		[XmlElement("sgt_arb_arbitrage_inzet_competitie")] //, Order=9)]
		public string sgt_arb_arbitrage_inzet_competitie1
		{
			get
			{
				return this.sgt_arb_arbitrage_inzet_competitie1Field;
			}
			set
			{
				this.sgt_arb_arbitrage_inzet_competitie1Field = value;
				base.RaisePropertyChanged("sgt_arb_arbitrage_inzet_competitie1");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public Key sgt_arb_arbitrage_inzet_competitieid
		{
			get
			{
				return this.sgt_arb_arbitrage_inzet_competitieidField;
			}
			set
			{
				this.sgt_arb_arbitrage_inzet_competitieidField = value;
				base.RaisePropertyChanged("sgt_arb_arbitrage_inzet_competitieid");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public Lookup sgt_arbitragefunctionarisid
		{
			get
			{
				return this.sgt_arbitragefunctionarisidField;
			}
			set
			{
				this.sgt_arbitragefunctionarisidField = value;
				base.RaisePropertyChanged("sgt_arbitragefunctionarisid");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public Lookup sgt_competitieid
		{
			get
			{
				return this.sgt_competitieidField;
			}
			set
			{
				this.sgt_competitieidField = value;
				base.RaisePropertyChanged("sgt_competitieid");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public Lookup sgt_functieid
		{
			get
			{
				return this.sgt_functieidField;
			}
			set
			{
				this.sgt_functieidField = value;
				base.RaisePropertyChanged("sgt_functieid");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public Picklist sgt_inzet_status
		{
			get
			{
				return this.sgt_inzet_statusField;
			}
			set
			{
				this.sgt_inzet_statusField = value;
				base.RaisePropertyChanged("sgt_inzet_status");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public Lookup sgt_klassegroepid
		{
			get
			{
				return this.sgt_klassegroepidField;
			}
			set
			{
				this.sgt_klassegroepidField = value;
				base.RaisePropertyChanged("sgt_klassegroepid");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public Lookup sgt_piramideid
		{
			get
			{
				return this.sgt_piramideidField;
			}
			set
			{
				this.sgt_piramideidField = value;
				base.RaisePropertyChanged("sgt_piramideid");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public Lookup sgt_ploegthuisid
		{
			get
			{
				return this.sgt_ploegthuisidField;
			}
			set
			{
				this.sgt_ploegthuisidField = value;
				base.RaisePropertyChanged("sgt_ploegthuisid");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public Lookup sgt_ploeguitid
		{
			get
			{
				return this.sgt_ploeguitidField;
			}
			set
			{
				this.sgt_ploeguitidField = value;
				base.RaisePropertyChanged("sgt_ploeguitid");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
		public CrmDateTime sgt_speeldag_datum
		{
			get
			{
				return this.sgt_speeldag_datumField;
			}
			set
			{
				this.sgt_speeldag_datumField = value;
				base.RaisePropertyChanged("sgt_speeldag_datum");
			}
		}

		[XmlElement] //[XmlElement(Order=20)]
		public Lookup sgt_verenigingthuisid
		{
			get
			{
				return this.sgt_verenigingthuisidField;
			}
			set
			{
				this.sgt_verenigingthuisidField = value;
				base.RaisePropertyChanged("sgt_verenigingthuisid");
			}
		}

		[XmlElement] //[XmlElement(Order=21)]
		public Lookup sgt_vereniginguitid
		{
			get
			{
				return this.sgt_vereniginguitidField;
			}
			set
			{
				this.sgt_vereniginguitidField = value;
				base.RaisePropertyChanged("sgt_vereniginguitid");
			}
		}

		[XmlElement] //[XmlElement(Order=22)]
		public Lookup sgt_wedstrijdid
		{
			get
			{
				return this.sgt_wedstrijdidField;
			}
			set
			{
				this.sgt_wedstrijdidField = value;
				base.RaisePropertyChanged("sgt_wedstrijdid");
			}
		}

		[XmlElement] //[XmlElement(Order=23)]
		public Sgt_arb_arbitrage_inzet_competitieStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=24)]
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

		[XmlElement] //[XmlElement(Order=25)]
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

		[XmlElement] //[XmlElement(Order=26)]
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

		public sgt_arb_arbitrage_inzet_competitie()
		{
		}
	}
}