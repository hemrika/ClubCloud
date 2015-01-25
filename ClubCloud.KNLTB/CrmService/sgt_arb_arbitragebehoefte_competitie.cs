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
	public class sgt_arb_arbitragebehoefte_competitie : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private CrmNumber sgt_aantal_bgField;

		private CrmNumber sgt_aantal_hoofdscheidsrechterField;

		private CrmNumber sgt_aantal_lrField;

		private CrmNumber sgt_aantal_srField;

		private CrmNumber sgt_aantal_tzField;

		private string sgt_arb_arbitragebehoefte_competitie1Field;

		private Key sgt_arb_arbitragebehoefte_competitieidField;

		private Lookup sgt_competitieidField;

		private Picklist sgt_functie_statusField;

		private Lookup sgt_klassegroepidField;

		private Lookup sgt_piramideidField;

		private CrmDateTime sgt_speeldag_datumField;

		private CrmBoolean sgt_speeldag_inhaaldagField;

		private CrmNumber sgt_verwacht_begeleiderField;

		private CrmNumber sgt_verwacht_hoofdscheidsrechterField;

		private CrmNumber sgt_verwacht_lijnrechterField;

		private CrmNumber sgt_verwacht_stoelscheidsrechterField;

		private CrmNumber sgt_verwacht_toezichthouderField;

		private Sgt_arb_arbitragebehoefte_competitieStateInfo statecodeField;

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
		public CrmNumber sgt_aantal_bg
		{
			get
			{
				return this.sgt_aantal_bgField;
			}
			set
			{
				this.sgt_aantal_bgField = value;
				base.RaisePropertyChanged("sgt_aantal_bg");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public CrmNumber sgt_aantal_hoofdscheidsrechter
		{
			get
			{
				return this.sgt_aantal_hoofdscheidsrechterField;
			}
			set
			{
				this.sgt_aantal_hoofdscheidsrechterField = value;
				base.RaisePropertyChanged("sgt_aantal_hoofdscheidsrechter");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public CrmNumber sgt_aantal_lr
		{
			get
			{
				return this.sgt_aantal_lrField;
			}
			set
			{
				this.sgt_aantal_lrField = value;
				base.RaisePropertyChanged("sgt_aantal_lr");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public CrmNumber sgt_aantal_sr
		{
			get
			{
				return this.sgt_aantal_srField;
			}
			set
			{
				this.sgt_aantal_srField = value;
				base.RaisePropertyChanged("sgt_aantal_sr");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public CrmNumber sgt_aantal_tz
		{
			get
			{
				return this.sgt_aantal_tzField;
			}
			set
			{
				this.sgt_aantal_tzField = value;
				base.RaisePropertyChanged("sgt_aantal_tz");
			}
		}

		[XmlElement("sgt_arb_arbitragebehoefte_competitie")] //, Order=13)]
		public string sgt_arb_arbitragebehoefte_competitie1
		{
			get
			{
				return this.sgt_arb_arbitragebehoefte_competitie1Field;
			}
			set
			{
				this.sgt_arb_arbitragebehoefte_competitie1Field = value;
				base.RaisePropertyChanged("sgt_arb_arbitragebehoefte_competitie1");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public Key sgt_arb_arbitragebehoefte_competitieid
		{
			get
			{
				return this.sgt_arb_arbitragebehoefte_competitieidField;
			}
			set
			{
				this.sgt_arb_arbitragebehoefte_competitieidField = value;
				base.RaisePropertyChanged("sgt_arb_arbitragebehoefte_competitieid");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
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

		[XmlElement] //[XmlElement(Order=16)]
		public Picklist sgt_functie_status
		{
			get
			{
				return this.sgt_functie_statusField;
			}
			set
			{
				this.sgt_functie_statusField = value;
				base.RaisePropertyChanged("sgt_functie_status");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
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

		[XmlElement] //[XmlElement(Order=18)]
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
		public CrmBoolean sgt_speeldag_inhaaldag
		{
			get
			{
				return this.sgt_speeldag_inhaaldagField;
			}
			set
			{
				this.sgt_speeldag_inhaaldagField = value;
				base.RaisePropertyChanged("sgt_speeldag_inhaaldag");
			}
		}

		[XmlElement] //[XmlElement(Order=21)]
		public CrmNumber sgt_verwacht_begeleider
		{
			get
			{
				return this.sgt_verwacht_begeleiderField;
			}
			set
			{
				this.sgt_verwacht_begeleiderField = value;
				base.RaisePropertyChanged("sgt_verwacht_begeleider");
			}
		}

		[XmlElement] //[XmlElement(Order=22)]
		public CrmNumber sgt_verwacht_hoofdscheidsrechter
		{
			get
			{
				return this.sgt_verwacht_hoofdscheidsrechterField;
			}
			set
			{
				this.sgt_verwacht_hoofdscheidsrechterField = value;
				base.RaisePropertyChanged("sgt_verwacht_hoofdscheidsrechter");
			}
		}

		[XmlElement] //[XmlElement(Order=23)]
		public CrmNumber sgt_verwacht_lijnrechter
		{
			get
			{
				return this.sgt_verwacht_lijnrechterField;
			}
			set
			{
				this.sgt_verwacht_lijnrechterField = value;
				base.RaisePropertyChanged("sgt_verwacht_lijnrechter");
			}
		}

		[XmlElement] //[XmlElement(Order=24)]
		public CrmNumber sgt_verwacht_stoelscheidsrechter
		{
			get
			{
				return this.sgt_verwacht_stoelscheidsrechterField;
			}
			set
			{
				this.sgt_verwacht_stoelscheidsrechterField = value;
				base.RaisePropertyChanged("sgt_verwacht_stoelscheidsrechter");
			}
		}

		[XmlElement] //[XmlElement(Order=25)]
		public CrmNumber sgt_verwacht_toezichthouder
		{
			get
			{
				return this.sgt_verwacht_toezichthouderField;
			}
			set
			{
				this.sgt_verwacht_toezichthouderField = value;
				base.RaisePropertyChanged("sgt_verwacht_toezichthouder");
			}
		}

		[XmlElement] //[XmlElement(Order=26)]
		public Sgt_arb_arbitragebehoefte_competitieStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=27)]
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

		[XmlElement] //[XmlElement(Order=28)]
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

		[XmlElement] //[XmlElement(Order=29)]
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

		public sgt_arb_arbitragebehoefte_competitie()
		{
		}
	}
}