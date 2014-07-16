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
	public class sgt_arb_behoefte_per_competitiewedstrijd : BusinessEntity
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

		private string sgt_arb_behoefte_per_competitiewedstrijd1Field;

		private Key sgt_arb_behoefte_per_competitiewedstrijdidField;

		private Lookup sgt_arbitragebehoeftecompetitieperwidField;

		private Lookup sgt_arbitragefunctieisField;

		private Lookup sgt_baansoortidField;

		private Lookup sgt_ploeg_thuisidField;

		private Lookup sgt_ploeg_uitidField;

		private CrmNumber sgt_regelementair_aantalField;

		private Picklist sgt_statusField;

		private Lookup sgt_verenigingthuisidField;

		private Lookup sgt_vereniginguitidField;

		private Lookup sgt_wedstrijdidField;

		private Sgt_arb_behoefte_per_competitiewedstrijdStateInfo statecodeField;

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
		public CrmNumber sgt_aantal
		{
			get
			{
				return this.sgt_aantalField;
			}
			set
			{
				this.sgt_aantalField = value;
				base.RaisePropertyChanged("sgt_aantal");
			}
		}

		[XmlElement("sgt_arb_behoefte_per_competitiewedstrijd")] //, Order=9)]
		public string sgt_arb_behoefte_per_competitiewedstrijd1
		{
			get
			{
				return this.sgt_arb_behoefte_per_competitiewedstrijd1Field;
			}
			set
			{
				this.sgt_arb_behoefte_per_competitiewedstrijd1Field = value;
				base.RaisePropertyChanged("sgt_arb_behoefte_per_competitiewedstrijd1");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public Key sgt_arb_behoefte_per_competitiewedstrijdid
		{
			get
			{
				return this.sgt_arb_behoefte_per_competitiewedstrijdidField;
			}
			set
			{
				this.sgt_arb_behoefte_per_competitiewedstrijdidField = value;
				base.RaisePropertyChanged("sgt_arb_behoefte_per_competitiewedstrijdid");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public Lookup sgt_arbitragebehoeftecompetitieperwid
		{
			get
			{
				return this.sgt_arbitragebehoeftecompetitieperwidField;
			}
			set
			{
				this.sgt_arbitragebehoeftecompetitieperwidField = value;
				base.RaisePropertyChanged("sgt_arbitragebehoeftecompetitieperwid");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public Lookup sgt_arbitragefunctieis
		{
			get
			{
				return this.sgt_arbitragefunctieisField;
			}
			set
			{
				this.sgt_arbitragefunctieisField = value;
				base.RaisePropertyChanged("sgt_arbitragefunctieis");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public Lookup sgt_baansoortid
		{
			get
			{
				return this.sgt_baansoortidField;
			}
			set
			{
				this.sgt_baansoortidField = value;
				base.RaisePropertyChanged("sgt_baansoortid");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public Lookup sgt_ploeg_thuisid
		{
			get
			{
				return this.sgt_ploeg_thuisidField;
			}
			set
			{
				this.sgt_ploeg_thuisidField = value;
				base.RaisePropertyChanged("sgt_ploeg_thuisid");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public Lookup sgt_ploeg_uitid
		{
			get
			{
				return this.sgt_ploeg_uitidField;
			}
			set
			{
				this.sgt_ploeg_uitidField = value;
				base.RaisePropertyChanged("sgt_ploeg_uitid");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public CrmNumber sgt_regelementair_aantal
		{
			get
			{
				return this.sgt_regelementair_aantalField;
			}
			set
			{
				this.sgt_regelementair_aantalField = value;
				base.RaisePropertyChanged("sgt_regelementair_aantal");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public Picklist sgt_status
		{
			get
			{
				return this.sgt_statusField;
			}
			set
			{
				this.sgt_statusField = value;
				base.RaisePropertyChanged("sgt_status");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
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

		[XmlElement] //[XmlElement(Order=19)]
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

		[XmlElement] //[XmlElement(Order=20)]
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

		[XmlElement] //[XmlElement(Order=21)]
		public Sgt_arb_behoefte_per_competitiewedstrijdStateInfo statecode
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

		public sgt_arb_behoefte_per_competitiewedstrijd()
		{
		}
	}
}