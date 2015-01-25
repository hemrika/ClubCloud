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
	public class sgt_dss_eindejaarsrating : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private CrmNumber sgt_aantal_partijen_dubbelField;

		private CrmNumber sgt_aantal_partijen_enkelField;

		private string sgt_bondsnummerField;

		private CrmDateTime sgt_datum_berekening_eindejaarsratingField;

		private string sgt_dss_eindejaarsrating1Field;

		private Key sgt_dss_eindejaarsratingidField;

		private CrmDecimal sgt_eindejaarsrating_dubbelField;

		private CrmDecimal sgt_eindejaarsrating_enkelField;

		private Picklist sgt_geslachtField;

		private CrmNumber sgt_speelsterkte_dubbel_voor_verwerkingField;

		private CrmNumber sgt_speelsterkte_enkel_voor_verwerkingField;

		private Lookup sgt_speelsterktebepalingidField;

		private Lookup sgt_speleridField;

		private Sgt_dss_eindejaarsratingStateInfo statecodeField;

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
		public CrmNumber sgt_aantal_partijen_dubbel
		{
			get
			{
				return this.sgt_aantal_partijen_dubbelField;
			}
			set
			{
				this.sgt_aantal_partijen_dubbelField = value;
				base.RaisePropertyChanged("sgt_aantal_partijen_dubbel");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public CrmNumber sgt_aantal_partijen_enkel
		{
			get
			{
				return this.sgt_aantal_partijen_enkelField;
			}
			set
			{
				this.sgt_aantal_partijen_enkelField = value;
				base.RaisePropertyChanged("sgt_aantal_partijen_enkel");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
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

		[XmlElement] //[XmlElement(Order=11)]
		public CrmDateTime sgt_datum_berekening_eindejaarsrating
		{
			get
			{
				return this.sgt_datum_berekening_eindejaarsratingField;
			}
			set
			{
				this.sgt_datum_berekening_eindejaarsratingField = value;
				base.RaisePropertyChanged("sgt_datum_berekening_eindejaarsrating");
			}
		}

		[XmlElement("sgt_dss_eindejaarsrating")] //, Order=12)]
		public string sgt_dss_eindejaarsrating1
		{
			get
			{
				return this.sgt_dss_eindejaarsrating1Field;
			}
			set
			{
				this.sgt_dss_eindejaarsrating1Field = value;
				base.RaisePropertyChanged("sgt_dss_eindejaarsrating1");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public Key sgt_dss_eindejaarsratingid
		{
			get
			{
				return this.sgt_dss_eindejaarsratingidField;
			}
			set
			{
				this.sgt_dss_eindejaarsratingidField = value;
				base.RaisePropertyChanged("sgt_dss_eindejaarsratingid");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public CrmDecimal sgt_eindejaarsrating_dubbel
		{
			get
			{
				return this.sgt_eindejaarsrating_dubbelField;
			}
			set
			{
				this.sgt_eindejaarsrating_dubbelField = value;
				base.RaisePropertyChanged("sgt_eindejaarsrating_dubbel");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public CrmDecimal sgt_eindejaarsrating_enkel
		{
			get
			{
				return this.sgt_eindejaarsrating_enkelField;
			}
			set
			{
				this.sgt_eindejaarsrating_enkelField = value;
				base.RaisePropertyChanged("sgt_eindejaarsrating_enkel");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public Picklist sgt_geslacht
		{
			get
			{
				return this.sgt_geslachtField;
			}
			set
			{
				this.sgt_geslachtField = value;
				base.RaisePropertyChanged("sgt_geslacht");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public CrmNumber sgt_speelsterkte_dubbel_voor_verwerking
		{
			get
			{
				return this.sgt_speelsterkte_dubbel_voor_verwerkingField;
			}
			set
			{
				this.sgt_speelsterkte_dubbel_voor_verwerkingField = value;
				base.RaisePropertyChanged("sgt_speelsterkte_dubbel_voor_verwerking");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public CrmNumber sgt_speelsterkte_enkel_voor_verwerking
		{
			get
			{
				return this.sgt_speelsterkte_enkel_voor_verwerkingField;
			}
			set
			{
				this.sgt_speelsterkte_enkel_voor_verwerkingField = value;
				base.RaisePropertyChanged("sgt_speelsterkte_enkel_voor_verwerking");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
		public Lookup sgt_speelsterktebepalingid
		{
			get
			{
				return this.sgt_speelsterktebepalingidField;
			}
			set
			{
				this.sgt_speelsterktebepalingidField = value;
				base.RaisePropertyChanged("sgt_speelsterktebepalingid");
			}
		}

		[XmlElement] //[XmlElement(Order=20)]
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

		[XmlElement] //[XmlElement(Order=21)]
		public Sgt_dss_eindejaarsratingStateInfo statecode
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

		public sgt_dss_eindejaarsrating()
		{
		}
	}
}