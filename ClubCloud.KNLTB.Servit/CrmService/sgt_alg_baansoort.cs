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
	public class sgt_alg_baansoort : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private Lookup organizationidField;

		private CrmDateTime overriddencreatedonField;

		private string sgt_alg_baansoort1Field;

		private Key sgt_alg_baansoortidField;

		private Lookup sgt_baantypeidField;

		private string sgt_beschrijvingField;

		private CrmBoolean sgt_gravelregel_arbitrageField;

		private string sgt_meervoudsnaamField;

		private string sgt_omschrijvingField;

		private string sgt_verkorte_codeField;

		private Sgt_alg_baansoortStateInfo statecodeField;

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
		public Lookup organizationid
		{
			get
			{
				return this.organizationidField;
			}
			set
			{
				this.organizationidField = value;
				base.RaisePropertyChanged("organizationid");
			}
		}

		[XmlElement] //[XmlElement(Order=6)]
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

		[XmlElement("sgt_alg_baansoort")] //, Order=7)]
		public string sgt_alg_baansoort1
		{
			get
			{
				return this.sgt_alg_baansoort1Field;
			}
			set
			{
				this.sgt_alg_baansoort1Field = value;
				base.RaisePropertyChanged("sgt_alg_baansoort1");
			}
		}

		[XmlElement] //[XmlElement(Order=8)]
		public Key sgt_alg_baansoortid
		{
			get
			{
				return this.sgt_alg_baansoortidField;
			}
			set
			{
				this.sgt_alg_baansoortidField = value;
				base.RaisePropertyChanged("sgt_alg_baansoortid");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public Lookup sgt_baantypeid
		{
			get
			{
				return this.sgt_baantypeidField;
			}
			set
			{
				this.sgt_baantypeidField = value;
				base.RaisePropertyChanged("sgt_baantypeid");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public string sgt_beschrijving
		{
			get
			{
				return this.sgt_beschrijvingField;
			}
			set
			{
				this.sgt_beschrijvingField = value;
				base.RaisePropertyChanged("sgt_beschrijving");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public CrmBoolean sgt_gravelregel_arbitrage
		{
			get
			{
				return this.sgt_gravelregel_arbitrageField;
			}
			set
			{
				this.sgt_gravelregel_arbitrageField = value;
				base.RaisePropertyChanged("sgt_gravelregel_arbitrage");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public string sgt_meervoudsnaam
		{
			get
			{
				return this.sgt_meervoudsnaamField;
			}
			set
			{
				this.sgt_meervoudsnaamField = value;
				base.RaisePropertyChanged("sgt_meervoudsnaam");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
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

		[XmlElement] //[XmlElement(Order=14)]
		public string sgt_verkorte_code
		{
			get
			{
				return this.sgt_verkorte_codeField;
			}
			set
			{
				this.sgt_verkorte_codeField = value;
				base.RaisePropertyChanged("sgt_verkorte_code");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public Sgt_alg_baansoortStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=16)]
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

		[XmlElement] //[XmlElement(Order=17)]
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

		[XmlElement] //[XmlElement(Order=18)]
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

		public sgt_alg_baansoort()
		{
		}
	}
}