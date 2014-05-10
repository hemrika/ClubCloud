using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
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
		public CrmNumber sgt_aantal_partijen_dubbel
		{
			get
			{
				return this.sgt_aantal_partijen_dubbelField;
			}
			set
			{
				this.sgt_aantal_partijen_dubbelField = value;
			}
		}
		public CrmNumber sgt_aantal_partijen_enkel
		{
			get
			{
				return this.sgt_aantal_partijen_enkelField;
			}
			set
			{
				this.sgt_aantal_partijen_enkelField = value;
			}
		}
		public string sgt_bondsnummer
		{
			get
			{
				return this.sgt_bondsnummerField;
			}
			set
			{
				this.sgt_bondsnummerField = value;
			}
		}
		public CrmDateTime sgt_datum_berekening_eindejaarsrating
		{
			get
			{
				return this.sgt_datum_berekening_eindejaarsratingField;
			}
			set
			{
				this.sgt_datum_berekening_eindejaarsratingField = value;
			}
		}
		[XmlElement("sgt_dss_eindejaarsrating")]
		public string sgt_dss_eindejaarsrating1
		{
			get
			{
				return this.sgt_dss_eindejaarsrating1Field;
			}
			set
			{
				this.sgt_dss_eindejaarsrating1Field = value;
			}
		}
		public Key sgt_dss_eindejaarsratingid
		{
			get
			{
				return this.sgt_dss_eindejaarsratingidField;
			}
			set
			{
				this.sgt_dss_eindejaarsratingidField = value;
			}
		}
		public CrmDecimal sgt_eindejaarsrating_dubbel
		{
			get
			{
				return this.sgt_eindejaarsrating_dubbelField;
			}
			set
			{
				this.sgt_eindejaarsrating_dubbelField = value;
			}
		}
		public CrmDecimal sgt_eindejaarsrating_enkel
		{
			get
			{
				return this.sgt_eindejaarsrating_enkelField;
			}
			set
			{
				this.sgt_eindejaarsrating_enkelField = value;
			}
		}
		public Picklist sgt_geslacht
		{
			get
			{
				return this.sgt_geslachtField;
			}
			set
			{
				this.sgt_geslachtField = value;
			}
		}
		public CrmNumber sgt_speelsterkte_dubbel_voor_verwerking
		{
			get
			{
				return this.sgt_speelsterkte_dubbel_voor_verwerkingField;
			}
			set
			{
				this.sgt_speelsterkte_dubbel_voor_verwerkingField = value;
			}
		}
		public CrmNumber sgt_speelsterkte_enkel_voor_verwerking
		{
			get
			{
				return this.sgt_speelsterkte_enkel_voor_verwerkingField;
			}
			set
			{
				this.sgt_speelsterkte_enkel_voor_verwerkingField = value;
			}
		}
		public Lookup sgt_speelsterktebepalingid
		{
			get
			{
				return this.sgt_speelsterktebepalingidField;
			}
			set
			{
				this.sgt_speelsterktebepalingidField = value;
			}
		}
		public Lookup sgt_spelerid
		{
			get
			{
				return this.sgt_speleridField;
			}
			set
			{
				this.sgt_speleridField = value;
			}
		}
		public Sgt_dss_eindejaarsratingStateInfo statecode
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
