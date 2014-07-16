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
	public class sgt_toe_toernooionderdeelgenerator : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private CrmBoolean sgt_geslacht_gemengdField;

		private CrmBoolean sgt_geslacht_manField;

		private CrmBoolean sgt_geslacht_nvtField;

		private CrmNumber sgt_leeftijd_tmField;

		private CrmNumber sgt_leeftijd_vanafField;

		private Lookup sgt_leeftijdscategorieidField;

		private Lookup sgt_schemagrootte_idField;

		private Lookup sgt_speelsterkteidField;

		private CrmBoolean sgt_spelsoort_dubbelField;

		private CrmBoolean sgt_spelsoort_enkelField;

		private string sgt_toe_toernooionderdeelgenerator1Field;

		private Key sgt_toe_toernooionderdeelgeneratoridField;

		private Lookup sgt_toe_toernooisoortidField;

		private Lookup sgt_toernooiidField;

		private Lookup sgt_toernooischemaidField;

		private CrmBoolean sgt_vrouwField;

		private Lookup sgt_zwaarteidField;

		private Sgt_toe_toernooionderdeelgeneratorStateInfo statecodeField;

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
		public CrmBoolean sgt_geslacht_gemengd
		{
			get
			{
				return this.sgt_geslacht_gemengdField;
			}
			set
			{
				this.sgt_geslacht_gemengdField = value;
				base.RaisePropertyChanged("sgt_geslacht_gemengd");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public CrmBoolean sgt_geslacht_man
		{
			get
			{
				return this.sgt_geslacht_manField;
			}
			set
			{
				this.sgt_geslacht_manField = value;
				base.RaisePropertyChanged("sgt_geslacht_man");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public CrmBoolean sgt_geslacht_nvt
		{
			get
			{
				return this.sgt_geslacht_nvtField;
			}
			set
			{
				this.sgt_geslacht_nvtField = value;
				base.RaisePropertyChanged("sgt_geslacht_nvt");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public CrmNumber sgt_leeftijd_tm
		{
			get
			{
				return this.sgt_leeftijd_tmField;
			}
			set
			{
				this.sgt_leeftijd_tmField = value;
				base.RaisePropertyChanged("sgt_leeftijd_tm");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public CrmNumber sgt_leeftijd_vanaf
		{
			get
			{
				return this.sgt_leeftijd_vanafField;
			}
			set
			{
				this.sgt_leeftijd_vanafField = value;
				base.RaisePropertyChanged("sgt_leeftijd_vanaf");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public Lookup sgt_leeftijdscategorieid
		{
			get
			{
				return this.sgt_leeftijdscategorieidField;
			}
			set
			{
				this.sgt_leeftijdscategorieidField = value;
				base.RaisePropertyChanged("sgt_leeftijdscategorieid");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public Lookup sgt_schemagrootte_id
		{
			get
			{
				return this.sgt_schemagrootte_idField;
			}
			set
			{
				this.sgt_schemagrootte_idField = value;
				base.RaisePropertyChanged("sgt_schemagrootte_id");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
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

		[XmlElement] //[XmlElement(Order=16)]
		public CrmBoolean sgt_spelsoort_dubbel
		{
			get
			{
				return this.sgt_spelsoort_dubbelField;
			}
			set
			{
				this.sgt_spelsoort_dubbelField = value;
				base.RaisePropertyChanged("sgt_spelsoort_dubbel");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public CrmBoolean sgt_spelsoort_enkel
		{
			get
			{
				return this.sgt_spelsoort_enkelField;
			}
			set
			{
				this.sgt_spelsoort_enkelField = value;
				base.RaisePropertyChanged("sgt_spelsoort_enkel");
			}
		}

		[XmlElement("sgt_toe_toernooionderdeelgenerator")] //, Order=18)]
		public string sgt_toe_toernooionderdeelgenerator1
		{
			get
			{
				return this.sgt_toe_toernooionderdeelgenerator1Field;
			}
			set
			{
				this.sgt_toe_toernooionderdeelgenerator1Field = value;
				base.RaisePropertyChanged("sgt_toe_toernooionderdeelgenerator1");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
		public Key sgt_toe_toernooionderdeelgeneratorid
		{
			get
			{
				return this.sgt_toe_toernooionderdeelgeneratoridField;
			}
			set
			{
				this.sgt_toe_toernooionderdeelgeneratoridField = value;
				base.RaisePropertyChanged("sgt_toe_toernooionderdeelgeneratorid");
			}
		}

		[XmlElement] //[XmlElement(Order=20)]
		public Lookup sgt_toe_toernooisoortid
		{
			get
			{
				return this.sgt_toe_toernooisoortidField;
			}
			set
			{
				this.sgt_toe_toernooisoortidField = value;
				base.RaisePropertyChanged("sgt_toe_toernooisoortid");
			}
		}

		[XmlElement] //[XmlElement(Order=21)]
		public Lookup sgt_toernooiid
		{
			get
			{
				return this.sgt_toernooiidField;
			}
			set
			{
				this.sgt_toernooiidField = value;
				base.RaisePropertyChanged("sgt_toernooiid");
			}
		}

		[XmlElement] //[XmlElement(Order=22)]
		public Lookup sgt_toernooischemaid
		{
			get
			{
				return this.sgt_toernooischemaidField;
			}
			set
			{
				this.sgt_toernooischemaidField = value;
				base.RaisePropertyChanged("sgt_toernooischemaid");
			}
		}

		[XmlElement] //[XmlElement(Order=23)]
		public CrmBoolean sgt_vrouw
		{
			get
			{
				return this.sgt_vrouwField;
			}
			set
			{
				this.sgt_vrouwField = value;
				base.RaisePropertyChanged("sgt_vrouw");
			}
		}

		[XmlElement] //[XmlElement(Order=24)]
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

		[XmlElement] //[XmlElement(Order=25)]
		public Sgt_toe_toernooionderdeelgeneratorStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=26)]
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

		[XmlElement] //[XmlElement(Order=27)]
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

		[XmlElement] //[XmlElement(Order=28)]
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

		public sgt_toe_toernooionderdeelgenerator()
		{
		}
	}
}