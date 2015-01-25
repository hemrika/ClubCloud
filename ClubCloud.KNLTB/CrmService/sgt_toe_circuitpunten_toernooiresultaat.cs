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
	public class sgt_toe_circuitpunten_toernooiresultaat : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private CrmDecimal sgt_bonus_puntenField;

		private Lookup sgt_circuitidField;

		private CrmNumber sgt_circuitpuntenField;

		private Lookup sgt_speler_1idField;

		private Lookup sgt_speler_2idField;

		private CrmNumber sgt_strafpuntenField;

		private string sgt_toe_circuitpunten_toernooiresultaat1Field;

		private Key sgt_toe_circuitpunten_toernooiresultaatidField;

		private Lookup sgt_toernooi_afhandelingidField;

		private Lookup sgt_toernooionderdeelidField;

		private Lookup sgt_toernooiresultaatidField;

		private Sgt_toe_circuitpunten_toernooiresultaatStateInfo statecodeField;

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
		public CrmDecimal sgt_bonus_punten
		{
			get
			{
				return this.sgt_bonus_puntenField;
			}
			set
			{
				this.sgt_bonus_puntenField = value;
				base.RaisePropertyChanged("sgt_bonus_punten");
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
		public CrmNumber sgt_circuitpunten
		{
			get
			{
				return this.sgt_circuitpuntenField;
			}
			set
			{
				this.sgt_circuitpuntenField = value;
				base.RaisePropertyChanged("sgt_circuitpunten");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public Lookup sgt_speler_1id
		{
			get
			{
				return this.sgt_speler_1idField;
			}
			set
			{
				this.sgt_speler_1idField = value;
				base.RaisePropertyChanged("sgt_speler_1id");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public Lookup sgt_speler_2id
		{
			get
			{
				return this.sgt_speler_2idField;
			}
			set
			{
				this.sgt_speler_2idField = value;
				base.RaisePropertyChanged("sgt_speler_2id");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public CrmNumber sgt_strafpunten
		{
			get
			{
				return this.sgt_strafpuntenField;
			}
			set
			{
				this.sgt_strafpuntenField = value;
				base.RaisePropertyChanged("sgt_strafpunten");
			}
		}

		[XmlElement("sgt_toe_circuitpunten_toernooiresultaat")] //, Order=14)]
		public string sgt_toe_circuitpunten_toernooiresultaat1
		{
			get
			{
				return this.sgt_toe_circuitpunten_toernooiresultaat1Field;
			}
			set
			{
				this.sgt_toe_circuitpunten_toernooiresultaat1Field = value;
				base.RaisePropertyChanged("sgt_toe_circuitpunten_toernooiresultaat1");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public Key sgt_toe_circuitpunten_toernooiresultaatid
		{
			get
			{
				return this.sgt_toe_circuitpunten_toernooiresultaatidField;
			}
			set
			{
				this.sgt_toe_circuitpunten_toernooiresultaatidField = value;
				base.RaisePropertyChanged("sgt_toe_circuitpunten_toernooiresultaatid");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public Lookup sgt_toernooi_afhandelingid
		{
			get
			{
				return this.sgt_toernooi_afhandelingidField;
			}
			set
			{
				this.sgt_toernooi_afhandelingidField = value;
				base.RaisePropertyChanged("sgt_toernooi_afhandelingid");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public Lookup sgt_toernooionderdeelid
		{
			get
			{
				return this.sgt_toernooionderdeelidField;
			}
			set
			{
				this.sgt_toernooionderdeelidField = value;
				base.RaisePropertyChanged("sgt_toernooionderdeelid");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public Lookup sgt_toernooiresultaatid
		{
			get
			{
				return this.sgt_toernooiresultaatidField;
			}
			set
			{
				this.sgt_toernooiresultaatidField = value;
				base.RaisePropertyChanged("sgt_toernooiresultaatid");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
		public Sgt_toe_circuitpunten_toernooiresultaatStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=20)]
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

		[XmlElement] //[XmlElement(Order=21)]
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

		[XmlElement] //[XmlElement(Order=22)]
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

		public sgt_toe_circuitpunten_toernooiresultaat()
		{
		}
	}
}