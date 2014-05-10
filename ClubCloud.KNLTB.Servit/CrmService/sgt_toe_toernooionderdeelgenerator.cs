using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
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
		public Lookup createdby
		{
			get
			{
				return this.createdbyField;
			}
			set
			{
				this.createdbyField = value;
			}
		}
		public CrmDateTime createdon
		{
			get
			{
				return this.createdonField;
			}
			set
			{
				this.createdonField = value;
			}
		}
		public CrmNumber importsequencenumber
		{
			get
			{
				return this.importsequencenumberField;
			}
			set
			{
				this.importsequencenumberField = value;
			}
		}
		public Lookup modifiedby
		{
			get
			{
				return this.modifiedbyField;
			}
			set
			{
				this.modifiedbyField = value;
			}
		}
		public CrmDateTime modifiedon
		{
			get
			{
				return this.modifiedonField;
			}
			set
			{
				this.modifiedonField = value;
			}
		}
		public CrmDateTime overriddencreatedon
		{
			get
			{
				return this.overriddencreatedonField;
			}
			set
			{
				this.overriddencreatedonField = value;
			}
		}
		public Owner ownerid
		{
			get
			{
				return this.owneridField;
			}
			set
			{
				this.owneridField = value;
			}
		}
		public Lookup owningbusinessunit
		{
			get
			{
				return this.owningbusinessunitField;
			}
			set
			{
				this.owningbusinessunitField = value;
			}
		}
		public CrmBoolean sgt_geslacht_gemengd
		{
			get
			{
				return this.sgt_geslacht_gemengdField;
			}
			set
			{
				this.sgt_geslacht_gemengdField = value;
			}
		}
		public CrmBoolean sgt_geslacht_man
		{
			get
			{
				return this.sgt_geslacht_manField;
			}
			set
			{
				this.sgt_geslacht_manField = value;
			}
		}
		public CrmBoolean sgt_geslacht_nvt
		{
			get
			{
				return this.sgt_geslacht_nvtField;
			}
			set
			{
				this.sgt_geslacht_nvtField = value;
			}
		}
		public CrmNumber sgt_leeftijd_tm
		{
			get
			{
				return this.sgt_leeftijd_tmField;
			}
			set
			{
				this.sgt_leeftijd_tmField = value;
			}
		}
		public CrmNumber sgt_leeftijd_vanaf
		{
			get
			{
				return this.sgt_leeftijd_vanafField;
			}
			set
			{
				this.sgt_leeftijd_vanafField = value;
			}
		}
		public Lookup sgt_leeftijdscategorieid
		{
			get
			{
				return this.sgt_leeftijdscategorieidField;
			}
			set
			{
				this.sgt_leeftijdscategorieidField = value;
			}
		}
		public Lookup sgt_schemagrootte_id
		{
			get
			{
				return this.sgt_schemagrootte_idField;
			}
			set
			{
				this.sgt_schemagrootte_idField = value;
			}
		}
		public Lookup sgt_speelsterkteid
		{
			get
			{
				return this.sgt_speelsterkteidField;
			}
			set
			{
				this.sgt_speelsterkteidField = value;
			}
		}
		public CrmBoolean sgt_spelsoort_dubbel
		{
			get
			{
				return this.sgt_spelsoort_dubbelField;
			}
			set
			{
				this.sgt_spelsoort_dubbelField = value;
			}
		}
		public CrmBoolean sgt_spelsoort_enkel
		{
			get
			{
				return this.sgt_spelsoort_enkelField;
			}
			set
			{
				this.sgt_spelsoort_enkelField = value;
			}
		}
		[XmlElement("sgt_toe_toernooionderdeelgenerator")]
		public string sgt_toe_toernooionderdeelgenerator1
		{
			get
			{
				return this.sgt_toe_toernooionderdeelgenerator1Field;
			}
			set
			{
				this.sgt_toe_toernooionderdeelgenerator1Field = value;
			}
		}
		public Key sgt_toe_toernooionderdeelgeneratorid
		{
			get
			{
				return this.sgt_toe_toernooionderdeelgeneratoridField;
			}
			set
			{
				this.sgt_toe_toernooionderdeelgeneratoridField = value;
			}
		}
		public Lookup sgt_toe_toernooisoortid
		{
			get
			{
				return this.sgt_toe_toernooisoortidField;
			}
			set
			{
				this.sgt_toe_toernooisoortidField = value;
			}
		}
		public Lookup sgt_toernooiid
		{
			get
			{
				return this.sgt_toernooiidField;
			}
			set
			{
				this.sgt_toernooiidField = value;
			}
		}
		public Lookup sgt_toernooischemaid
		{
			get
			{
				return this.sgt_toernooischemaidField;
			}
			set
			{
				this.sgt_toernooischemaidField = value;
			}
		}
		public CrmBoolean sgt_vrouw
		{
			get
			{
				return this.sgt_vrouwField;
			}
			set
			{
				this.sgt_vrouwField = value;
			}
		}
		public Lookup sgt_zwaarteid
		{
			get
			{
				return this.sgt_zwaarteidField;
			}
			set
			{
				this.sgt_zwaarteidField = value;
			}
		}
		public Sgt_toe_toernooionderdeelgeneratorStateInfo statecode
		{
			get
			{
				return this.statecodeField;
			}
			set
			{
				this.statecodeField = value;
			}
		}
		public Status statuscode
		{
			get
			{
				return this.statuscodeField;
			}
			set
			{
				this.statuscodeField = value;
			}
		}
		public CrmNumber timezoneruleversionnumber
		{
			get
			{
				return this.timezoneruleversionnumberField;
			}
			set
			{
				this.timezoneruleversionnumberField = value;
			}
		}
		public CrmNumber utcconversiontimezonecode
		{
			get
			{
				return this.utcconversiontimezonecodeField;
			}
			set
			{
				this.utcconversiontimezonecodeField = value;
			}
		}
	}
}
