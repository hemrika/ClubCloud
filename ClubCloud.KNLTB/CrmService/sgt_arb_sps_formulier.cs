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
	public class sgt_arb_sps_formulier : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private string sgt_arb_nameField;

		private Key sgt_arb_sps_formulieridField;

		private Lookup sgt_arbitragefunctionarisidField;

		private CrmDateTime sgt_datumField;

		private string sgt_speler1_thuisField;

		private string sgt_speler1_uitField;

		private Lookup sgt_speler1idField;

		private string sgt_speler2_thuisField;

		private string sgt_speler2_uitField;

		private Lookup sgt_speler2idField;

		private Lookup sgt_spsformulieridField;

		private Lookup sgt_tegenstander1idField;

		private Lookup sgt_tegenstander2idField;

		private Sgt_arb_sps_formulierStateInfo statecodeField;

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

		[XmlElement] //[XmlElement(Order=9)]
		public Key sgt_arb_sps_formulierid
		{
			get
			{
				return this.sgt_arb_sps_formulieridField;
			}
			set
			{
				this.sgt_arb_sps_formulieridField = value;
				base.RaisePropertyChanged("sgt_arb_sps_formulierid");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
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

		[XmlElement] //[XmlElement(Order=11)]
		public CrmDateTime sgt_datum
		{
			get
			{
				return this.sgt_datumField;
			}
			set
			{
				this.sgt_datumField = value;
				base.RaisePropertyChanged("sgt_datum");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public string sgt_speler1_thuis
		{
			get
			{
				return this.sgt_speler1_thuisField;
			}
			set
			{
				this.sgt_speler1_thuisField = value;
				base.RaisePropertyChanged("sgt_speler1_thuis");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public string sgt_speler1_uit
		{
			get
			{
				return this.sgt_speler1_uitField;
			}
			set
			{
				this.sgt_speler1_uitField = value;
				base.RaisePropertyChanged("sgt_speler1_uit");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public Lookup sgt_speler1id
		{
			get
			{
				return this.sgt_speler1idField;
			}
			set
			{
				this.sgt_speler1idField = value;
				base.RaisePropertyChanged("sgt_speler1id");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public string sgt_speler2_thuis
		{
			get
			{
				return this.sgt_speler2_thuisField;
			}
			set
			{
				this.sgt_speler2_thuisField = value;
				base.RaisePropertyChanged("sgt_speler2_thuis");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public string sgt_speler2_uit
		{
			get
			{
				return this.sgt_speler2_uitField;
			}
			set
			{
				this.sgt_speler2_uitField = value;
				base.RaisePropertyChanged("sgt_speler2_uit");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public Lookup sgt_speler2id
		{
			get
			{
				return this.sgt_speler2idField;
			}
			set
			{
				this.sgt_speler2idField = value;
				base.RaisePropertyChanged("sgt_speler2id");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public Lookup sgt_spsformulierid
		{
			get
			{
				return this.sgt_spsformulieridField;
			}
			set
			{
				this.sgt_spsformulieridField = value;
				base.RaisePropertyChanged("sgt_spsformulierid");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
		public Lookup sgt_tegenstander1id
		{
			get
			{
				return this.sgt_tegenstander1idField;
			}
			set
			{
				this.sgt_tegenstander1idField = value;
				base.RaisePropertyChanged("sgt_tegenstander1id");
			}
		}

		[XmlElement] //[XmlElement(Order=20)]
		public Lookup sgt_tegenstander2id
		{
			get
			{
				return this.sgt_tegenstander2idField;
			}
			set
			{
				this.sgt_tegenstander2idField = value;
				base.RaisePropertyChanged("sgt_tegenstander2id");
			}
		}

		[XmlElement] //[XmlElement(Order=21)]
		public Sgt_arb_sps_formulierStateInfo statecode
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

		public sgt_arb_sps_formulier()
		{
		}
	}
}