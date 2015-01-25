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
	public class sgt_alg_gebeurtenistype : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private Lookup organizationidField;

		private CrmDateTime overriddencreatedonField;

		private CrmBoolean sgt_alg_campagnezichtbaarField;

		private string sgt_alg_gebeurtenistype1Field;

		private Key sgt_alg_gebeurtenistypeidField;

		private CrmBoolean sgt_alg_in_gesprek_metField;

		private CrmBoolean sgt_deelnemerslijst_tonenField;

		private CrmBoolean sgt_gebeurtenisnaam_automatisch_bepalenField;

		private CrmBoolean sgt_gesprokenField;

		private CrmBoolean sgt_inschrijfsectieField;

		private Sgt_alg_gebeurtenistypeStateInfo statecodeField;

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

		[XmlElement] //[XmlElement(Order=7)]
		public CrmBoolean sgt_alg_campagnezichtbaar
		{
			get
			{
				return this.sgt_alg_campagnezichtbaarField;
			}
			set
			{
				this.sgt_alg_campagnezichtbaarField = value;
				base.RaisePropertyChanged("sgt_alg_campagnezichtbaar");
			}
		}

		[XmlElement("sgt_alg_gebeurtenistype")] //, Order=8)]
		public string sgt_alg_gebeurtenistype1
		{
			get
			{
				return this.sgt_alg_gebeurtenistype1Field;
			}
			set
			{
				this.sgt_alg_gebeurtenistype1Field = value;
				base.RaisePropertyChanged("sgt_alg_gebeurtenistype1");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public Key sgt_alg_gebeurtenistypeid
		{
			get
			{
				return this.sgt_alg_gebeurtenistypeidField;
			}
			set
			{
				this.sgt_alg_gebeurtenistypeidField = value;
				base.RaisePropertyChanged("sgt_alg_gebeurtenistypeid");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public CrmBoolean sgt_alg_in_gesprek_met
		{
			get
			{
				return this.sgt_alg_in_gesprek_metField;
			}
			set
			{
				this.sgt_alg_in_gesprek_metField = value;
				base.RaisePropertyChanged("sgt_alg_in_gesprek_met");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public CrmBoolean sgt_deelnemerslijst_tonen
		{
			get
			{
				return this.sgt_deelnemerslijst_tonenField;
			}
			set
			{
				this.sgt_deelnemerslijst_tonenField = value;
				base.RaisePropertyChanged("sgt_deelnemerslijst_tonen");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public CrmBoolean sgt_gebeurtenisnaam_automatisch_bepalen
		{
			get
			{
				return this.sgt_gebeurtenisnaam_automatisch_bepalenField;
			}
			set
			{
				this.sgt_gebeurtenisnaam_automatisch_bepalenField = value;
				base.RaisePropertyChanged("sgt_gebeurtenisnaam_automatisch_bepalen");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public CrmBoolean sgt_gesproken
		{
			get
			{
				return this.sgt_gesprokenField;
			}
			set
			{
				this.sgt_gesprokenField = value;
				base.RaisePropertyChanged("sgt_gesproken");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public CrmBoolean sgt_inschrijfsectie
		{
			get
			{
				return this.sgt_inschrijfsectieField;
			}
			set
			{
				this.sgt_inschrijfsectieField = value;
				base.RaisePropertyChanged("sgt_inschrijfsectie");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public Sgt_alg_gebeurtenistypeStateInfo statecode
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

		public sgt_alg_gebeurtenistype()
		{
		}
	}
}