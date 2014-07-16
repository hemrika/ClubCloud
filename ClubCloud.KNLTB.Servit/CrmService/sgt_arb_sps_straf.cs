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
	public class sgt_arb_sps_straf : BusinessEntity
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

		private Key sgt_arb_sps_strafidField;

		private Lookup sgt_arbitragefunctionarisidField;

		private string sgt_bondsnummerField;

		private string sgt_bondsnummer_spelerField;

		private Picklist sgt_codeField;

		private Lookup sgt_gestraftespelersidField;

		private string sgt_naam_spelerField;

		private string sgt_omschrijvingField;

		private Lookup sgt_speleridField;

		private string sgt_standField;

		private Picklist sgt_straf_ivm_gedragField;

		private Picklist sgt_straf_ivm_tijdField;

		private Sgt_arb_sps_strafStateInfo statecodeField;

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
		public Key sgt_arb_sps_strafid
		{
			get
			{
				return this.sgt_arb_sps_strafidField;
			}
			set
			{
				this.sgt_arb_sps_strafidField = value;
				base.RaisePropertyChanged("sgt_arb_sps_strafid");
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
		public string sgt_bondsnummer
		{
			get
			{
				return this.sgt_bondsnummerField;
			}
			set
			{
				this.sgt_bondsnummerField = value;
				base.RaisePropertyChanged("sgt_bondsnummer");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public string sgt_bondsnummer_speler
		{
			get
			{
				return this.sgt_bondsnummer_spelerField;
			}
			set
			{
				this.sgt_bondsnummer_spelerField = value;
				base.RaisePropertyChanged("sgt_bondsnummer_speler");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public Picklist sgt_code
		{
			get
			{
				return this.sgt_codeField;
			}
			set
			{
				this.sgt_codeField = value;
				base.RaisePropertyChanged("sgt_code");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public Lookup sgt_gestraftespelersid
		{
			get
			{
				return this.sgt_gestraftespelersidField;
			}
			set
			{
				this.sgt_gestraftespelersidField = value;
				base.RaisePropertyChanged("sgt_gestraftespelersid");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public string sgt_naam_speler
		{
			get
			{
				return this.sgt_naam_spelerField;
			}
			set
			{
				this.sgt_naam_spelerField = value;
				base.RaisePropertyChanged("sgt_naam_speler");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public string sgt_omschrijving
		{
			get
			{
				return this.sgt_omschrijvingField;
			}
			set
			{
				this.sgt_omschrijvingField = value;
				base.RaisePropertyChanged("sgt_omschrijving");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public Lookup sgt_spelerid
		{
			get
			{
				return this.sgt_speleridField;
			}
			set
			{
				this.sgt_speleridField = value;
				base.RaisePropertyChanged("sgt_spelerid");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public string sgt_stand
		{
			get
			{
				return this.sgt_standField;
			}
			set
			{
				this.sgt_standField = value;
				base.RaisePropertyChanged("sgt_stand");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
		public Picklist sgt_straf_ivm_gedrag
		{
			get
			{
				return this.sgt_straf_ivm_gedragField;
			}
			set
			{
				this.sgt_straf_ivm_gedragField = value;
				base.RaisePropertyChanged("sgt_straf_ivm_gedrag");
			}
		}

		[XmlElement] //[XmlElement(Order=20)]
		public Picklist sgt_straf_ivm_tijd
		{
			get
			{
				return this.sgt_straf_ivm_tijdField;
			}
			set
			{
				this.sgt_straf_ivm_tijdField = value;
				base.RaisePropertyChanged("sgt_straf_ivm_tijd");
			}
		}

		[XmlElement] //[XmlElement(Order=21)]
		public Sgt_arb_sps_strafStateInfo statecode
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

		public sgt_arb_sps_straf()
		{
		}
	}
}