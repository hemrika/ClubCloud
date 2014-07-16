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
	public class sgt_dss_speelsterktemutatie : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private CrmNumber sgt_aantal_partijenField;

		private CrmDecimal sgt_basisgetalField;

		private string sgt_bondsnummerField;

		private CrmDateTime sgt_datum_aanpassing_spelersprofielField;

		private CrmBoolean sgt_doorgevoerd_in_spelersprofielField;

		private string sgt_dss_speelsterktemutatie1Field;

		private Key sgt_dss_speelsterktemutatieidField;

		private CrmDecimal sgt_eindejaarsratingField;

		private Picklist sgt_geslachtField;

		private CrmNumber sgt_ranglijstpositieField;

		private string sgt_reden_speelsterktemutatieField;

		private CrmNumber sgt_speelsterkteField;

		private Lookup sgt_speelsterkteidField;

		private Lookup sgt_speleridField;

		private Picklist sgt_speltypeField;

		private Sgt_dss_speelsterktemutatieStateInfo statecodeField;

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
		public CrmNumber sgt_aantal_partijen
		{
			get
			{
				return this.sgt_aantal_partijenField;
			}
			set
			{
				this.sgt_aantal_partijenField = value;
				base.RaisePropertyChanged("sgt_aantal_partijen");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public CrmDecimal sgt_basisgetal
		{
			get
			{
				return this.sgt_basisgetalField;
			}
			set
			{
				this.sgt_basisgetalField = value;
				base.RaisePropertyChanged("sgt_basisgetal");
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
		public CrmDateTime sgt_datum_aanpassing_spelersprofiel
		{
			get
			{
				return this.sgt_datum_aanpassing_spelersprofielField;
			}
			set
			{
				this.sgt_datum_aanpassing_spelersprofielField = value;
				base.RaisePropertyChanged("sgt_datum_aanpassing_spelersprofiel");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public CrmBoolean sgt_doorgevoerd_in_spelersprofiel
		{
			get
			{
				return this.sgt_doorgevoerd_in_spelersprofielField;
			}
			set
			{
				this.sgt_doorgevoerd_in_spelersprofielField = value;
				base.RaisePropertyChanged("sgt_doorgevoerd_in_spelersprofiel");
			}
		}

		[XmlElement("sgt_dss_speelsterktemutatie")] //, Order=13)]
		public string sgt_dss_speelsterktemutatie1
		{
			get
			{
				return this.sgt_dss_speelsterktemutatie1Field;
			}
			set
			{
				this.sgt_dss_speelsterktemutatie1Field = value;
				base.RaisePropertyChanged("sgt_dss_speelsterktemutatie1");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public Key sgt_dss_speelsterktemutatieid
		{
			get
			{
				return this.sgt_dss_speelsterktemutatieidField;
			}
			set
			{
				this.sgt_dss_speelsterktemutatieidField = value;
				base.RaisePropertyChanged("sgt_dss_speelsterktemutatieid");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public CrmDecimal sgt_eindejaarsrating
		{
			get
			{
				return this.sgt_eindejaarsratingField;
			}
			set
			{
				this.sgt_eindejaarsratingField = value;
				base.RaisePropertyChanged("sgt_eindejaarsrating");
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
		public CrmNumber sgt_ranglijstpositie
		{
			get
			{
				return this.sgt_ranglijstpositieField;
			}
			set
			{
				this.sgt_ranglijstpositieField = value;
				base.RaisePropertyChanged("sgt_ranglijstpositie");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public string sgt_reden_speelsterktemutatie
		{
			get
			{
				return this.sgt_reden_speelsterktemutatieField;
			}
			set
			{
				this.sgt_reden_speelsterktemutatieField = value;
				base.RaisePropertyChanged("sgt_reden_speelsterktemutatie");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
		public CrmNumber sgt_speelsterkte
		{
			get
			{
				return this.sgt_speelsterkteField;
			}
			set
			{
				this.sgt_speelsterkteField = value;
				base.RaisePropertyChanged("sgt_speelsterkte");
			}
		}

		[XmlElement] //[XmlElement(Order=20)]
		public Lookup sgt_speelsterkteid
		{
			get
			{
				return this.sgt_speelsterkteidField;
			}
			set
			{
				this.sgt_speelsterkteidField = value;
				base.RaisePropertyChanged("sgt_speelsterkteid");
			}
		}

		[XmlElement] //[XmlElement(Order=21)]
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

		[XmlElement] //[XmlElement(Order=22)]
		public Picklist sgt_speltype
		{
			get
			{
				return this.sgt_speltypeField;
			}
			set
			{
				this.sgt_speltypeField = value;
				base.RaisePropertyChanged("sgt_speltype");
			}
		}

		[XmlElement] //[XmlElement(Order=23)]
		public Sgt_dss_speelsterktemutatieStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=24)]
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

		[XmlElement] //[XmlElement(Order=25)]
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

		[XmlElement] //[XmlElement(Order=26)]
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

		public sgt_dss_speelsterktemutatie()
		{
		}
	}
}