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
	public class sgt_toe_circuitpunten : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private Lookup organizationidField;

		private CrmDateTime overriddencreatedonField;

		private CrmNumber sgt_aantal_deelnemers_totField;

		private CrmNumber sgt_aantal_deelnemers_vanafField;

		private Lookup sgt_circuitidField;

		private CrmNumber sgt_circuitpunten_2de_jaarsField;

		private CrmNumber sgt_plaats_tmField;

		private CrmNumber sgt_plaats_vanafField;

		private CrmNumber sgt_puntenField;

		private string sgt_toe_circuitpunten1Field;

		private Key sgt_toe_circuitpuntenidField;

		private Lookup sgt_zwaarteidField;

		private Sgt_toe_circuitpuntenStateInfo statecodeField;

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
		public CrmNumber sgt_aantal_deelnemers_tot
		{
			get
			{
				return this.sgt_aantal_deelnemers_totField;
			}
			set
			{
				this.sgt_aantal_deelnemers_totField = value;
				base.RaisePropertyChanged("sgt_aantal_deelnemers_tot");
			}
		}

		[XmlElement] //[XmlElement(Order=8)]
		public CrmNumber sgt_aantal_deelnemers_vanaf
		{
			get
			{
				return this.sgt_aantal_deelnemers_vanafField;
			}
			set
			{
				this.sgt_aantal_deelnemers_vanafField = value;
				base.RaisePropertyChanged("sgt_aantal_deelnemers_vanaf");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public Lookup sgt_circuitid
		{
			get
			{
				return this.sgt_circuitidField;
			}
			set
			{
				this.sgt_circuitidField = value;
				base.RaisePropertyChanged("sgt_circuitid");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public CrmNumber sgt_circuitpunten_2de_jaars
		{
			get
			{
				return this.sgt_circuitpunten_2de_jaarsField;
			}
			set
			{
				this.sgt_circuitpunten_2de_jaarsField = value;
				base.RaisePropertyChanged("sgt_circuitpunten_2de_jaars");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public CrmNumber sgt_plaats_tm
		{
			get
			{
				return this.sgt_plaats_tmField;
			}
			set
			{
				this.sgt_plaats_tmField = value;
				base.RaisePropertyChanged("sgt_plaats_tm");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public CrmNumber sgt_plaats_vanaf
		{
			get
			{
				return this.sgt_plaats_vanafField;
			}
			set
			{
				this.sgt_plaats_vanafField = value;
				base.RaisePropertyChanged("sgt_plaats_vanaf");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public CrmNumber sgt_punten
		{
			get
			{
				return this.sgt_puntenField;
			}
			set
			{
				this.sgt_puntenField = value;
				base.RaisePropertyChanged("sgt_punten");
			}
		}

		[XmlElement("sgt_toe_circuitpunten")] //, Order=14)]
		public string sgt_toe_circuitpunten1
		{
			get
			{
				return this.sgt_toe_circuitpunten1Field;
			}
			set
			{
				this.sgt_toe_circuitpunten1Field = value;
				base.RaisePropertyChanged("sgt_toe_circuitpunten1");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public Key sgt_toe_circuitpuntenid
		{
			get
			{
				return this.sgt_toe_circuitpuntenidField;
			}
			set
			{
				this.sgt_toe_circuitpuntenidField = value;
				base.RaisePropertyChanged("sgt_toe_circuitpuntenid");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public Lookup sgt_zwaarteid
		{
			get
			{
				return this.sgt_zwaarteidField;
			}
			set
			{
				this.sgt_zwaarteidField = value;
				base.RaisePropertyChanged("sgt_zwaarteid");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public Sgt_toe_circuitpuntenStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=18)]
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

		[XmlElement] //[XmlElement(Order=19)]
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

		public sgt_toe_circuitpunten()
		{
		}
	}
}