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
	public class sgt_com_reeks_speeldatums : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private CrmDateTime sgt_10e_inhaaldatumField;

		private string sgt_10e_inhaaldatum_dagaanduidingField;

		private CrmDateTime sgt_10e_speeldatumField;

		private string sgt_10e_speeldatum_dagaanduidingField;

		private CrmDateTime sgt_11e_speeldatumField;

		private string sgt_11e_speeldatum_dagaanduidingField;

		private CrmDateTime sgt_12e_speeldatumField;

		private string sgt_12e_speeldatum_dagaanduidingField;

		private CrmDateTime sgt_13e_speeldatumField;

		private string sgt_13e_speeldatum_dagaanduidingField;

		private CrmDateTime sgt_14e_speeldatumField;

		private string sgt_14e_speeldatum_dagaanduidingField;

		private CrmDateTime sgt_15e_speeldatumField;

		private string sgt_15e_speeldatum_dagaanduidingField;

		private CrmDateTime sgt_16e_speeldatumField;

		private string sgt_16e_speeldatum_dagaanduidingField;

		private CrmDateTime sgt_17e_speeldatumField;

		private string sgt_17e_speeldatum_dagaanduidingField;

		private CrmDateTime sgt_18e_speeldatumField;

		private string sgt_18e_speeldatum_dagaanduidingField;

		private CrmDateTime sgt_19e_speeldatumField;

		private string sgt_19e_speeldatum_dagaanduidingField;

		private CrmDateTime sgt_1e_inhaaldatumField;

		private string sgt_1e_inhaaldatum_dagaanduidingField;

		private CrmDateTime sgt_1e_speeldatumField;

		private string sgt_1e_speeldatum_dagaanduidingField;

		private CrmDateTime sgt_20e_speeldatumField;

		private string sgt_20e_speeldatum_dagaanduidingField;

		private CrmDateTime sgt_2e_inhaaldatumField;

		private string sgt_2e_inhaaldatum_dagaanduidingField;

		private CrmDateTime sgt_2e_speeldatumField;

		private string sgt_2e_speeldatum_dagaanduidingField;

		private CrmDateTime sgt_3e_inhaaldatumField;

		private string sgt_3e_inhaaldatum_dagaanduidingField;

		private CrmDateTime sgt_3e_speeldatumField;

		private string sgt_3e_speeldatum_dagaanduidingField;

		private CrmDateTime sgt_4e_inhaaldatumField;

		private string sgt_4e_inhaaldatum_dagaanduidingField;

		private CrmDateTime sgt_4e_speeldatumField;

		private string sgt_4e_speeldatum_dagaanduidingField;

		private CrmDateTime sgt_5e_inhaaldatumField;

		private string sgt_5e_inhaaldatum_dagaanduidingField;

		private CrmDateTime sgt_5e_speeldatumField;

		private string sgt_5e_speeldatum_dagaanduidingField;

		private CrmDateTime sgt_6e_inhaaldatumField;

		private string sgt_6e_inhaaldatum_dagaanduidingField;

		private CrmDateTime sgt_6e_speeldatumField;

		private string sgt_6e_speeldatum_dagaanduidingField;

		private CrmDateTime sgt_7e_inhaaldatumField;

		private string sgt_7e_inhaaldatum_dagaanduidingField;

		private CrmDateTime sgt_7e_speeldatumField;

		private string sgt_7e_speeldatum_dagaanduidingField;

		private CrmDateTime sgt_8e_inhaaldatumField;

		private string sgt_8e_inhaaldatum_dagaanduidingField;

		private CrmDateTime sgt_8e_speeldatumField;

		private string sgt_8e_speeldatum_dagaanduidingField;

		private CrmDateTime sgt_9e_inhaaldatumField;

		private string sgt_9e_inhaaldatum_dagaanduidingField;

		private CrmDateTime sgt_9e_speeldatumField;

		private string sgt_9e_speeldatum_dagaanduidingField;

		private string sgt_com_reeks_speeldatums1Field;

		private Key sgt_com_reeks_speeldatumsidField;

		private Lookup sgt_competitieidField;

		private Sgt_com_reeks_speeldatumsStateInfo statecodeField;

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
		public CrmDateTime sgt_10e_inhaaldatum
		{
			get
			{
				return this.sgt_10e_inhaaldatumField;
			}
			set
			{
				this.sgt_10e_inhaaldatumField = value;
				base.RaisePropertyChanged("sgt_10e_inhaaldatum");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public string sgt_10e_inhaaldatum_dagaanduiding
		{
			get
			{
				return this.sgt_10e_inhaaldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_10e_inhaaldatum_dagaanduidingField = value;
				base.RaisePropertyChanged("sgt_10e_inhaaldatum_dagaanduiding");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public CrmDateTime sgt_10e_speeldatum
		{
			get
			{
				return this.sgt_10e_speeldatumField;
			}
			set
			{
				this.sgt_10e_speeldatumField = value;
				base.RaisePropertyChanged("sgt_10e_speeldatum");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public string sgt_10e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_10e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_10e_speeldatum_dagaanduidingField = value;
				base.RaisePropertyChanged("sgt_10e_speeldatum_dagaanduiding");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public CrmDateTime sgt_11e_speeldatum
		{
			get
			{
				return this.sgt_11e_speeldatumField;
			}
			set
			{
				this.sgt_11e_speeldatumField = value;
				base.RaisePropertyChanged("sgt_11e_speeldatum");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public string sgt_11e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_11e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_11e_speeldatum_dagaanduidingField = value;
				base.RaisePropertyChanged("sgt_11e_speeldatum_dagaanduiding");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public CrmDateTime sgt_12e_speeldatum
		{
			get
			{
				return this.sgt_12e_speeldatumField;
			}
			set
			{
				this.sgt_12e_speeldatumField = value;
				base.RaisePropertyChanged("sgt_12e_speeldatum");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public string sgt_12e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_12e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_12e_speeldatum_dagaanduidingField = value;
				base.RaisePropertyChanged("sgt_12e_speeldatum_dagaanduiding");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public CrmDateTime sgt_13e_speeldatum
		{
			get
			{
				return this.sgt_13e_speeldatumField;
			}
			set
			{
				this.sgt_13e_speeldatumField = value;
				base.RaisePropertyChanged("sgt_13e_speeldatum");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public string sgt_13e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_13e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_13e_speeldatum_dagaanduidingField = value;
				base.RaisePropertyChanged("sgt_13e_speeldatum_dagaanduiding");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public CrmDateTime sgt_14e_speeldatum
		{
			get
			{
				return this.sgt_14e_speeldatumField;
			}
			set
			{
				this.sgt_14e_speeldatumField = value;
				base.RaisePropertyChanged("sgt_14e_speeldatum");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
		public string sgt_14e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_14e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_14e_speeldatum_dagaanduidingField = value;
				base.RaisePropertyChanged("sgt_14e_speeldatum_dagaanduiding");
			}
		}

		[XmlElement] //[XmlElement(Order=20)]
		public CrmDateTime sgt_15e_speeldatum
		{
			get
			{
				return this.sgt_15e_speeldatumField;
			}
			set
			{
				this.sgt_15e_speeldatumField = value;
				base.RaisePropertyChanged("sgt_15e_speeldatum");
			}
		}

		[XmlElement] //[XmlElement(Order=21)]
		public string sgt_15e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_15e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_15e_speeldatum_dagaanduidingField = value;
				base.RaisePropertyChanged("sgt_15e_speeldatum_dagaanduiding");
			}
		}

		[XmlElement] //[XmlElement(Order=22)]
		public CrmDateTime sgt_16e_speeldatum
		{
			get
			{
				return this.sgt_16e_speeldatumField;
			}
			set
			{
				this.sgt_16e_speeldatumField = value;
				base.RaisePropertyChanged("sgt_16e_speeldatum");
			}
		}

		[XmlElement] //[XmlElement(Order=23)]
		public string sgt_16e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_16e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_16e_speeldatum_dagaanduidingField = value;
				base.RaisePropertyChanged("sgt_16e_speeldatum_dagaanduiding");
			}
		}

		[XmlElement] //[XmlElement(Order=24)]
		public CrmDateTime sgt_17e_speeldatum
		{
			get
			{
				return this.sgt_17e_speeldatumField;
			}
			set
			{
				this.sgt_17e_speeldatumField = value;
				base.RaisePropertyChanged("sgt_17e_speeldatum");
			}
		}

		[XmlElement] //[XmlElement(Order=25)]
		public string sgt_17e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_17e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_17e_speeldatum_dagaanduidingField = value;
				base.RaisePropertyChanged("sgt_17e_speeldatum_dagaanduiding");
			}
		}

		[XmlElement] //[XmlElement(Order=26)]
		public CrmDateTime sgt_18e_speeldatum
		{
			get
			{
				return this.sgt_18e_speeldatumField;
			}
			set
			{
				this.sgt_18e_speeldatumField = value;
				base.RaisePropertyChanged("sgt_18e_speeldatum");
			}
		}

		[XmlElement] //[XmlElement(Order=27)]
		public string sgt_18e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_18e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_18e_speeldatum_dagaanduidingField = value;
				base.RaisePropertyChanged("sgt_18e_speeldatum_dagaanduiding");
			}
		}

		[XmlElement] //[XmlElement(Order=28)]
		public CrmDateTime sgt_19e_speeldatum
		{
			get
			{
				return this.sgt_19e_speeldatumField;
			}
			set
			{
				this.sgt_19e_speeldatumField = value;
				base.RaisePropertyChanged("sgt_19e_speeldatum");
			}
		}

		[XmlElement] //[XmlElement(Order=29)]
		public string sgt_19e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_19e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_19e_speeldatum_dagaanduidingField = value;
				base.RaisePropertyChanged("sgt_19e_speeldatum_dagaanduiding");
			}
		}

		[XmlElement] //[XmlElement(Order=30)]
		public CrmDateTime sgt_1e_inhaaldatum
		{
			get
			{
				return this.sgt_1e_inhaaldatumField;
			}
			set
			{
				this.sgt_1e_inhaaldatumField = value;
				base.RaisePropertyChanged("sgt_1e_inhaaldatum");
			}
		}

		[XmlElement] //[XmlElement(Order=31)]
		public string sgt_1e_inhaaldatum_dagaanduiding
		{
			get
			{
				return this.sgt_1e_inhaaldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_1e_inhaaldatum_dagaanduidingField = value;
				base.RaisePropertyChanged("sgt_1e_inhaaldatum_dagaanduiding");
			}
		}

		[XmlElement] //[XmlElement(Order=32)]
		public CrmDateTime sgt_1e_speeldatum
		{
			get
			{
				return this.sgt_1e_speeldatumField;
			}
			set
			{
				this.sgt_1e_speeldatumField = value;
				base.RaisePropertyChanged("sgt_1e_speeldatum");
			}
		}

		[XmlElement] //[XmlElement(Order=33)]
		public string sgt_1e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_1e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_1e_speeldatum_dagaanduidingField = value;
				base.RaisePropertyChanged("sgt_1e_speeldatum_dagaanduiding");
			}
		}

		[XmlElement] //[XmlElement(Order=34)]
		public CrmDateTime sgt_20e_speeldatum
		{
			get
			{
				return this.sgt_20e_speeldatumField;
			}
			set
			{
				this.sgt_20e_speeldatumField = value;
				base.RaisePropertyChanged("sgt_20e_speeldatum");
			}
		}

		[XmlElement] //[XmlElement(Order=35)]
		public string sgt_20e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_20e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_20e_speeldatum_dagaanduidingField = value;
				base.RaisePropertyChanged("sgt_20e_speeldatum_dagaanduiding");
			}
		}

		[XmlElement] //[XmlElement(Order=36)]
		public CrmDateTime sgt_2e_inhaaldatum
		{
			get
			{
				return this.sgt_2e_inhaaldatumField;
			}
			set
			{
				this.sgt_2e_inhaaldatumField = value;
				base.RaisePropertyChanged("sgt_2e_inhaaldatum");
			}
		}

		[XmlElement] //[XmlElement(Order=37)]
		public string sgt_2e_inhaaldatum_dagaanduiding
		{
			get
			{
				return this.sgt_2e_inhaaldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_2e_inhaaldatum_dagaanduidingField = value;
				base.RaisePropertyChanged("sgt_2e_inhaaldatum_dagaanduiding");
			}
		}

		[XmlElement] //[XmlElement(Order=38)]
		public CrmDateTime sgt_2e_speeldatum
		{
			get
			{
				return this.sgt_2e_speeldatumField;
			}
			set
			{
				this.sgt_2e_speeldatumField = value;
				base.RaisePropertyChanged("sgt_2e_speeldatum");
			}
		}

		[XmlElement] //[XmlElement(Order=39)]
		public string sgt_2e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_2e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_2e_speeldatum_dagaanduidingField = value;
				base.RaisePropertyChanged("sgt_2e_speeldatum_dagaanduiding");
			}
		}

		[XmlElement] //[XmlElement(Order=40)]
		public CrmDateTime sgt_3e_inhaaldatum
		{
			get
			{
				return this.sgt_3e_inhaaldatumField;
			}
			set
			{
				this.sgt_3e_inhaaldatumField = value;
				base.RaisePropertyChanged("sgt_3e_inhaaldatum");
			}
		}

		[XmlElement] //[XmlElement(Order=41)]
		public string sgt_3e_inhaaldatum_dagaanduiding
		{
			get
			{
				return this.sgt_3e_inhaaldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_3e_inhaaldatum_dagaanduidingField = value;
				base.RaisePropertyChanged("sgt_3e_inhaaldatum_dagaanduiding");
			}
		}

		[XmlElement] //[XmlElement(Order=42)]
		public CrmDateTime sgt_3e_speeldatum
		{
			get
			{
				return this.sgt_3e_speeldatumField;
			}
			set
			{
				this.sgt_3e_speeldatumField = value;
				base.RaisePropertyChanged("sgt_3e_speeldatum");
			}
		}

		[XmlElement] //[XmlElement(Order=43)]
		public string sgt_3e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_3e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_3e_speeldatum_dagaanduidingField = value;
				base.RaisePropertyChanged("sgt_3e_speeldatum_dagaanduiding");
			}
		}

		[XmlElement] //[XmlElement(Order=44)]
		public CrmDateTime sgt_4e_inhaaldatum
		{
			get
			{
				return this.sgt_4e_inhaaldatumField;
			}
			set
			{
				this.sgt_4e_inhaaldatumField = value;
				base.RaisePropertyChanged("sgt_4e_inhaaldatum");
			}
		}

		[XmlElement] //[XmlElement(Order=45)]
		public string sgt_4e_inhaaldatum_dagaanduiding
		{
			get
			{
				return this.sgt_4e_inhaaldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_4e_inhaaldatum_dagaanduidingField = value;
				base.RaisePropertyChanged("sgt_4e_inhaaldatum_dagaanduiding");
			}
		}

		[XmlElement] //[XmlElement(Order=46)]
		public CrmDateTime sgt_4e_speeldatum
		{
			get
			{
				return this.sgt_4e_speeldatumField;
			}
			set
			{
				this.sgt_4e_speeldatumField = value;
				base.RaisePropertyChanged("sgt_4e_speeldatum");
			}
		}

		[XmlElement] //[XmlElement(Order=47)]
		public string sgt_4e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_4e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_4e_speeldatum_dagaanduidingField = value;
				base.RaisePropertyChanged("sgt_4e_speeldatum_dagaanduiding");
			}
		}

		[XmlElement] //[XmlElement(Order=48)]
		public CrmDateTime sgt_5e_inhaaldatum
		{
			get
			{
				return this.sgt_5e_inhaaldatumField;
			}
			set
			{
				this.sgt_5e_inhaaldatumField = value;
				base.RaisePropertyChanged("sgt_5e_inhaaldatum");
			}
		}

		[XmlElement] //[XmlElement(Order=49)]
		public string sgt_5e_inhaaldatum_dagaanduiding
		{
			get
			{
				return this.sgt_5e_inhaaldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_5e_inhaaldatum_dagaanduidingField = value;
				base.RaisePropertyChanged("sgt_5e_inhaaldatum_dagaanduiding");
			}
		}

		[XmlElement] //[XmlElement(Order=50)]
		public CrmDateTime sgt_5e_speeldatum
		{
			get
			{
				return this.sgt_5e_speeldatumField;
			}
			set
			{
				this.sgt_5e_speeldatumField = value;
				base.RaisePropertyChanged("sgt_5e_speeldatum");
			}
		}

		[XmlElement] //[XmlElement(Order=51)]
		public string sgt_5e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_5e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_5e_speeldatum_dagaanduidingField = value;
				base.RaisePropertyChanged("sgt_5e_speeldatum_dagaanduiding");
			}
		}

		[XmlElement] //[XmlElement(Order=52)]
		public CrmDateTime sgt_6e_inhaaldatum
		{
			get
			{
				return this.sgt_6e_inhaaldatumField;
			}
			set
			{
				this.sgt_6e_inhaaldatumField = value;
				base.RaisePropertyChanged("sgt_6e_inhaaldatum");
			}
		}

		[XmlElement] //[XmlElement(Order=53)]
		public string sgt_6e_inhaaldatum_dagaanduiding
		{
			get
			{
				return this.sgt_6e_inhaaldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_6e_inhaaldatum_dagaanduidingField = value;
				base.RaisePropertyChanged("sgt_6e_inhaaldatum_dagaanduiding");
			}
		}

		[XmlElement] //[XmlElement(Order=54)]
		public CrmDateTime sgt_6e_speeldatum
		{
			get
			{
				return this.sgt_6e_speeldatumField;
			}
			set
			{
				this.sgt_6e_speeldatumField = value;
				base.RaisePropertyChanged("sgt_6e_speeldatum");
			}
		}

		[XmlElement] //[XmlElement(Order=55)]
		public string sgt_6e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_6e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_6e_speeldatum_dagaanduidingField = value;
				base.RaisePropertyChanged("sgt_6e_speeldatum_dagaanduiding");
			}
		}

		[XmlElement] //[XmlElement(Order=56)]
		public CrmDateTime sgt_7e_inhaaldatum
		{
			get
			{
				return this.sgt_7e_inhaaldatumField;
			}
			set
			{
				this.sgt_7e_inhaaldatumField = value;
				base.RaisePropertyChanged("sgt_7e_inhaaldatum");
			}
		}

		[XmlElement] //[XmlElement(Order=57)]
		public string sgt_7e_inhaaldatum_dagaanduiding
		{
			get
			{
				return this.sgt_7e_inhaaldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_7e_inhaaldatum_dagaanduidingField = value;
				base.RaisePropertyChanged("sgt_7e_inhaaldatum_dagaanduiding");
			}
		}

		[XmlElement] //[XmlElement(Order=58)]
		public CrmDateTime sgt_7e_speeldatum
		{
			get
			{
				return this.sgt_7e_speeldatumField;
			}
			set
			{
				this.sgt_7e_speeldatumField = value;
				base.RaisePropertyChanged("sgt_7e_speeldatum");
			}
		}

		[XmlElement] //[XmlElement(Order=59)]
		public string sgt_7e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_7e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_7e_speeldatum_dagaanduidingField = value;
				base.RaisePropertyChanged("sgt_7e_speeldatum_dagaanduiding");
			}
		}

		[XmlElement] //[XmlElement(Order=60)]
		public CrmDateTime sgt_8e_inhaaldatum
		{
			get
			{
				return this.sgt_8e_inhaaldatumField;
			}
			set
			{
				this.sgt_8e_inhaaldatumField = value;
				base.RaisePropertyChanged("sgt_8e_inhaaldatum");
			}
		}

		[XmlElement] //[XmlElement(Order=61)]
		public string sgt_8e_inhaaldatum_dagaanduiding
		{
			get
			{
				return this.sgt_8e_inhaaldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_8e_inhaaldatum_dagaanduidingField = value;
				base.RaisePropertyChanged("sgt_8e_inhaaldatum_dagaanduiding");
			}
		}

		[XmlElement] //[XmlElement(Order=62)]
		public CrmDateTime sgt_8e_speeldatum
		{
			get
			{
				return this.sgt_8e_speeldatumField;
			}
			set
			{
				this.sgt_8e_speeldatumField = value;
				base.RaisePropertyChanged("sgt_8e_speeldatum");
			}
		}

		[XmlElement] //[XmlElement(Order=63)]
		public string sgt_8e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_8e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_8e_speeldatum_dagaanduidingField = value;
				base.RaisePropertyChanged("sgt_8e_speeldatum_dagaanduiding");
			}
		}

		[XmlElement] //[XmlElement(Order=64)]
		public CrmDateTime sgt_9e_inhaaldatum
		{
			get
			{
				return this.sgt_9e_inhaaldatumField;
			}
			set
			{
				this.sgt_9e_inhaaldatumField = value;
				base.RaisePropertyChanged("sgt_9e_inhaaldatum");
			}
		}

		[XmlElement] //[XmlElement(Order=65)]
		public string sgt_9e_inhaaldatum_dagaanduiding
		{
			get
			{
				return this.sgt_9e_inhaaldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_9e_inhaaldatum_dagaanduidingField = value;
				base.RaisePropertyChanged("sgt_9e_inhaaldatum_dagaanduiding");
			}
		}

		[XmlElement] //[XmlElement(Order=66)]
		public CrmDateTime sgt_9e_speeldatum
		{
			get
			{
				return this.sgt_9e_speeldatumField;
			}
			set
			{
				this.sgt_9e_speeldatumField = value;
				base.RaisePropertyChanged("sgt_9e_speeldatum");
			}
		}

		[XmlElement] //[XmlElement(Order=67)]
		public string sgt_9e_speeldatum_dagaanduiding
		{
			get
			{
				return this.sgt_9e_speeldatum_dagaanduidingField;
			}
			set
			{
				this.sgt_9e_speeldatum_dagaanduidingField = value;
				base.RaisePropertyChanged("sgt_9e_speeldatum_dagaanduiding");
			}
		}

		[XmlElement("sgt_com_reeks_speeldatums")] //, Order=68)]
		public string sgt_com_reeks_speeldatums1
		{
			get
			{
				return this.sgt_com_reeks_speeldatums1Field;
			}
			set
			{
				this.sgt_com_reeks_speeldatums1Field = value;
				base.RaisePropertyChanged("sgt_com_reeks_speeldatums1");
			}
		}

		[XmlElement] //[XmlElement(Order=69)]
		public Key sgt_com_reeks_speeldatumsid
		{
			get
			{
				return this.sgt_com_reeks_speeldatumsidField;
			}
			set
			{
				this.sgt_com_reeks_speeldatumsidField = value;
				base.RaisePropertyChanged("sgt_com_reeks_speeldatumsid");
			}
		}

		[XmlElement] //[XmlElement(Order=70)]
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

		[XmlElement] //[XmlElement(Order=71)]
		public Sgt_com_reeks_speeldatumsStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=72)]
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

		[XmlElement] //[XmlElement(Order=73)]
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

		[XmlElement] //[XmlElement(Order=74)]
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

		public sgt_com_reeks_speeldatums()
		{
		}
	}
}