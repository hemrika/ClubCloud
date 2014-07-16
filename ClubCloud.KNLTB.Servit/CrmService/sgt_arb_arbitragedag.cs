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
	public class sgt_arb_arbitragedag : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private Key sgt_arb_arbitragedagidField;

		private string sgt_arb_nameField;

		private CrmNumber sgt_begeleiderField;

		private CrmNumber sgt_bronze_badge_stoelscheidsrechterField;

		private Picklist sgt_district_nationaalField;

		private CrmNumber sgt_hoofdscheidsrechterField;

		private CrmNumber sgt_kandidaat_nationaal_1_2Field;

		private CrmNumber sgt_lijnrechterField;

		private Lookup sgt_rapporthsidField;

		private CrmNumber sgt_stoelscheidsrechterField;

		private CrmNumber sgt_toezichthouderField;

		private CrmNumber sgt_totaalField;

		private CrmNumber sgt_white_badge_hoofdscheidsrechterField;

		private CrmNumber sgt_white_badge_stoelscheidsrechterField;

		private Sgt_arb_arbitragedagStateInfo statecodeField;

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
		public Key sgt_arb_arbitragedagid
		{
			get
			{
				return this.sgt_arb_arbitragedagidField;
			}
			set
			{
				this.sgt_arb_arbitragedagidField = value;
				base.RaisePropertyChanged("sgt_arb_arbitragedagid");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public string sgt_arb_name
		{
			get
			{
				return this.sgt_arb_nameField;
			}
			set
			{
				this.sgt_arb_nameField = value;
				base.RaisePropertyChanged("sgt_arb_name");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public CrmNumber sgt_begeleider
		{
			get
			{
				return this.sgt_begeleiderField;
			}
			set
			{
				this.sgt_begeleiderField = value;
				base.RaisePropertyChanged("sgt_begeleider");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public CrmNumber sgt_bronze_badge_stoelscheidsrechter
		{
			get
			{
				return this.sgt_bronze_badge_stoelscheidsrechterField;
			}
			set
			{
				this.sgt_bronze_badge_stoelscheidsrechterField = value;
				base.RaisePropertyChanged("sgt_bronze_badge_stoelscheidsrechter");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public Picklist sgt_district_nationaal
		{
			get
			{
				return this.sgt_district_nationaalField;
			}
			set
			{
				this.sgt_district_nationaalField = value;
				base.RaisePropertyChanged("sgt_district_nationaal");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public CrmNumber sgt_hoofdscheidsrechter
		{
			get
			{
				return this.sgt_hoofdscheidsrechterField;
			}
			set
			{
				this.sgt_hoofdscheidsrechterField = value;
				base.RaisePropertyChanged("sgt_hoofdscheidsrechter");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public CrmNumber sgt_kandidaat_nationaal_1_2
		{
			get
			{
				return this.sgt_kandidaat_nationaal_1_2Field;
			}
			set
			{
				this.sgt_kandidaat_nationaal_1_2Field = value;
				base.RaisePropertyChanged("sgt_kandidaat_nationaal_1_2");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public CrmNumber sgt_lijnrechter
		{
			get
			{
				return this.sgt_lijnrechterField;
			}
			set
			{
				this.sgt_lijnrechterField = value;
				base.RaisePropertyChanged("sgt_lijnrechter");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public Lookup sgt_rapporthsid
		{
			get
			{
				return this.sgt_rapporthsidField;
			}
			set
			{
				this.sgt_rapporthsidField = value;
				base.RaisePropertyChanged("sgt_rapporthsid");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public CrmNumber sgt_stoelscheidsrechter
		{
			get
			{
				return this.sgt_stoelscheidsrechterField;
			}
			set
			{
				this.sgt_stoelscheidsrechterField = value;
				base.RaisePropertyChanged("sgt_stoelscheidsrechter");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public CrmNumber sgt_toezichthouder
		{
			get
			{
				return this.sgt_toezichthouderField;
			}
			set
			{
				this.sgt_toezichthouderField = value;
				base.RaisePropertyChanged("sgt_toezichthouder");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
		public CrmNumber sgt_totaal
		{
			get
			{
				return this.sgt_totaalField;
			}
			set
			{
				this.sgt_totaalField = value;
				base.RaisePropertyChanged("sgt_totaal");
			}
		}

		[XmlElement] //[XmlElement(Order=20)]
		public CrmNumber sgt_white_badge_hoofdscheidsrechter
		{
			get
			{
				return this.sgt_white_badge_hoofdscheidsrechterField;
			}
			set
			{
				this.sgt_white_badge_hoofdscheidsrechterField = value;
				base.RaisePropertyChanged("sgt_white_badge_hoofdscheidsrechter");
			}
		}

		[XmlElement] //[XmlElement(Order=21)]
		public CrmNumber sgt_white_badge_stoelscheidsrechter
		{
			get
			{
				return this.sgt_white_badge_stoelscheidsrechterField;
			}
			set
			{
				this.sgt_white_badge_stoelscheidsrechterField = value;
				base.RaisePropertyChanged("sgt_white_badge_stoelscheidsrechter");
			}
		}

		[XmlElement] //[XmlElement(Order=22)]
		public Sgt_arb_arbitragedagStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=23)]
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

		[XmlElement] //[XmlElement(Order=24)]
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

		[XmlElement] //[XmlElement(Order=25)]
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

		public sgt_arb_arbitragedag()
		{
		}
	}
}