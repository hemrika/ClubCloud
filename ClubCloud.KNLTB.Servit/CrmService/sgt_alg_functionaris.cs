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
	public class sgt_alg_functionaris : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private Key sgt_alg_functionarisidField;

		private string sgt_alg_nameField;

		private Lookup sgt_arbitragefunctionarisidField;

		private CrmBoolean sgt_autorisatie_gezetField;

		private Lookup sgt_basisorganisatieidField;

		private Lookup sgt_bestuursorgaanidField;

		private Lookup sgt_competentieidField;

		private Lookup sgt_districtidField;

		private Lookup sgt_functieidField;

		private Lookup sgt_functionarisidField;

		private CrmBoolean sgt_mailingField;

		private CrmBoolean sgt_tennis_magazineField;

		private CrmDateTime sgt_termijn_begintField;

		private CrmDateTime sgt_termijn_loopt_afField;

		private Sgt_alg_functionarisStateInfo statecodeField;

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
		public Key sgt_alg_functionarisid
		{
			get
			{
				return this.sgt_alg_functionarisidField;
			}
			set
			{
				this.sgt_alg_functionarisidField = value;
				base.RaisePropertyChanged("sgt_alg_functionarisid");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public string sgt_alg_name
		{
			get
			{
				return this.sgt_alg_nameField;
			}
			set
			{
				this.sgt_alg_nameField = value;
				base.RaisePropertyChanged("sgt_alg_name");
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
		public CrmBoolean sgt_autorisatie_gezet
		{
			get
			{
				return this.sgt_autorisatie_gezetField;
			}
			set
			{
				this.sgt_autorisatie_gezetField = value;
				base.RaisePropertyChanged("sgt_autorisatie_gezet");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public Lookup sgt_basisorganisatieid
		{
			get
			{
				return this.sgt_basisorganisatieidField;
			}
			set
			{
				this.sgt_basisorganisatieidField = value;
				base.RaisePropertyChanged("sgt_basisorganisatieid");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public Lookup sgt_bestuursorgaanid
		{
			get
			{
				return this.sgt_bestuursorgaanidField;
			}
			set
			{
				this.sgt_bestuursorgaanidField = value;
				base.RaisePropertyChanged("sgt_bestuursorgaanid");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public Lookup sgt_competentieid
		{
			get
			{
				return this.sgt_competentieidField;
			}
			set
			{
				this.sgt_competentieidField = value;
				base.RaisePropertyChanged("sgt_competentieid");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public Lookup sgt_districtid
		{
			get
			{
				return this.sgt_districtidField;
			}
			set
			{
				this.sgt_districtidField = value;
				base.RaisePropertyChanged("sgt_districtid");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
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

		[XmlElement] //[XmlElement(Order=17)]
		public Lookup sgt_functionarisid
		{
			get
			{
				return this.sgt_functionarisidField;
			}
			set
			{
				this.sgt_functionarisidField = value;
				base.RaisePropertyChanged("sgt_functionarisid");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public CrmBoolean sgt_mailing
		{
			get
			{
				return this.sgt_mailingField;
			}
			set
			{
				this.sgt_mailingField = value;
				base.RaisePropertyChanged("sgt_mailing");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
		public CrmBoolean sgt_tennis_magazine
		{
			get
			{
				return this.sgt_tennis_magazineField;
			}
			set
			{
				this.sgt_tennis_magazineField = value;
				base.RaisePropertyChanged("sgt_tennis_magazine");
			}
		}

		[XmlElement] //[XmlElement(Order=20)]
		public CrmDateTime sgt_termijn_begint
		{
			get
			{
				return this.sgt_termijn_begintField;
			}
			set
			{
				this.sgt_termijn_begintField = value;
				base.RaisePropertyChanged("sgt_termijn_begint");
			}
		}

		[XmlElement] //[XmlElement(Order=21)]
		public CrmDateTime sgt_termijn_loopt_af
		{
			get
			{
				return this.sgt_termijn_loopt_afField;
			}
			set
			{
				this.sgt_termijn_loopt_afField = value;
				base.RaisePropertyChanged("sgt_termijn_loopt_af");
			}
		}

		[XmlElement] //[XmlElement(Order=22)]
		public Sgt_alg_functionarisStateInfo statecode
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

		public sgt_alg_functionaris()
		{
		}
	}
}