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
	public class sgt_fac_buma_bijdrage_amusementsmuziek : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmDecimal exchangerateField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private Lookup organizationidField;

		private CrmDateTime overriddencreatedonField;

		private CrmNumber sgt_aantal_dagen_tmField;

		private CrmNumber sgt_aantal_dagen_vanafField;

		private string sgt_alg_nameField;

		private Key sgt_fac_buma_bijdrage_amusementsmuziekidField;

		private CrmMoney sgt_prijs_extra_50m2Field;

		private CrmMoney sgt_prijs_extra_50m2_baseField;

		private CrmMoney sgt_prijs_tm_50m2Field;

		private CrmMoney sgt_prijs_tm_50m2_baseField;

		private Sgt_fac_buma_bijdrage_amusementsmuziekStateInfo statecodeField;

		private Status statuscodeField;

		private CrmNumber timezoneruleversionnumberField;

		private Lookup transactioncurrencyidField;

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
		public CrmDecimal exchangerate
		{
			get
			{
				return this.exchangerateField;
			}
			set
			{
				this.exchangerateField = value;
				base.RaisePropertyChanged("exchangerate");
			}
		}

		[XmlElement] //[XmlElement(Order=3)]
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

		[XmlElement] //[XmlElement(Order=4)]
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

		[XmlElement] //[XmlElement(Order=5)]
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

		[XmlElement] //[XmlElement(Order=6)]
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

		[XmlElement] //[XmlElement(Order=7)]
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

		[XmlElement] //[XmlElement(Order=8)]
		public CrmNumber sgt_aantal_dagen_tm
		{
			get
			{
				return this.sgt_aantal_dagen_tmField;
			}
			set
			{
				this.sgt_aantal_dagen_tmField = value;
				base.RaisePropertyChanged("sgt_aantal_dagen_tm");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public CrmNumber sgt_aantal_dagen_vanaf
		{
			get
			{
				return this.sgt_aantal_dagen_vanafField;
			}
			set
			{
				this.sgt_aantal_dagen_vanafField = value;
				base.RaisePropertyChanged("sgt_aantal_dagen_vanaf");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
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

		[XmlElement] //[XmlElement(Order=11)]
		public Key sgt_fac_buma_bijdrage_amusementsmuziekid
		{
			get
			{
				return this.sgt_fac_buma_bijdrage_amusementsmuziekidField;
			}
			set
			{
				this.sgt_fac_buma_bijdrage_amusementsmuziekidField = value;
				base.RaisePropertyChanged("sgt_fac_buma_bijdrage_amusementsmuziekid");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public CrmMoney sgt_prijs_extra_50m2
		{
			get
			{
				return this.sgt_prijs_extra_50m2Field;
			}
			set
			{
				this.sgt_prijs_extra_50m2Field = value;
				base.RaisePropertyChanged("sgt_prijs_extra_50m2");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public CrmMoney sgt_prijs_extra_50m2_base
		{
			get
			{
				return this.sgt_prijs_extra_50m2_baseField;
			}
			set
			{
				this.sgt_prijs_extra_50m2_baseField = value;
				base.RaisePropertyChanged("sgt_prijs_extra_50m2_base");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public CrmMoney sgt_prijs_tm_50m2
		{
			get
			{
				return this.sgt_prijs_tm_50m2Field;
			}
			set
			{
				this.sgt_prijs_tm_50m2Field = value;
				base.RaisePropertyChanged("sgt_prijs_tm_50m2");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public CrmMoney sgt_prijs_tm_50m2_base
		{
			get
			{
				return this.sgt_prijs_tm_50m2_baseField;
			}
			set
			{
				this.sgt_prijs_tm_50m2_baseField = value;
				base.RaisePropertyChanged("sgt_prijs_tm_50m2_base");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public Sgt_fac_buma_bijdrage_amusementsmuziekStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=17)]
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

		[XmlElement] //[XmlElement(Order=18)]
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

		[XmlElement] //[XmlElement(Order=19)]
		public Lookup transactioncurrencyid
		{
			get
			{
				return this.transactioncurrencyidField;
			}
			set
			{
				this.transactioncurrencyidField = value;
				base.RaisePropertyChanged("transactioncurrencyid");
			}
		}

		[XmlElement] //[XmlElement(Order=20)]
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

		public sgt_fac_buma_bijdrage_amusementsmuziek()
		{
		}
	}
}