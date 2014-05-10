using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
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
		public CrmNumber sgt_aantal_partijen
		{
			get
			{
				return this.sgt_aantal_partijenField;
			}
			set
			{
				this.sgt_aantal_partijenField = value;
			}
		}
		public CrmDecimal sgt_basisgetal
		{
			get
			{
				return this.sgt_basisgetalField;
			}
			set
			{
				this.sgt_basisgetalField = value;
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
		public CrmDateTime sgt_datum_aanpassing_spelersprofiel
		{
			get
			{
				return this.sgt_datum_aanpassing_spelersprofielField;
			}
			set
			{
				this.sgt_datum_aanpassing_spelersprofielField = value;
			}
		}
		public CrmBoolean sgt_doorgevoerd_in_spelersprofiel
		{
			get
			{
				return this.sgt_doorgevoerd_in_spelersprofielField;
			}
			set
			{
				this.sgt_doorgevoerd_in_spelersprofielField = value;
			}
		}
		[XmlElement("sgt_dss_speelsterktemutatie")]
		public string sgt_dss_speelsterktemutatie1
		{
			get
			{
				return this.sgt_dss_speelsterktemutatie1Field;
			}
			set
			{
				this.sgt_dss_speelsterktemutatie1Field = value;
			}
		}
		public Key sgt_dss_speelsterktemutatieid
		{
			get
			{
				return this.sgt_dss_speelsterktemutatieidField;
			}
			set
			{
				this.sgt_dss_speelsterktemutatieidField = value;
			}
		}
		public CrmDecimal sgt_eindejaarsrating
		{
			get
			{
				return this.sgt_eindejaarsratingField;
			}
			set
			{
				this.sgt_eindejaarsratingField = value;
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
		public CrmNumber sgt_ranglijstpositie
		{
			get
			{
				return this.sgt_ranglijstpositieField;
			}
			set
			{
				this.sgt_ranglijstpositieField = value;
			}
		}
		public string sgt_reden_speelsterktemutatie
		{
			get
			{
				return this.sgt_reden_speelsterktemutatieField;
			}
			set
			{
				this.sgt_reden_speelsterktemutatieField = value;
			}
		}
		public CrmNumber sgt_speelsterkte
		{
			get
			{
				return this.sgt_speelsterkteField;
			}
			set
			{
				this.sgt_speelsterkteField = value;
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
		public Picklist sgt_speltype
		{
			get
			{
				return this.sgt_speltypeField;
			}
			set
			{
				this.sgt_speltypeField = value;
			}
		}
		public Sgt_dss_speelsterktemutatieStateInfo statecode
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
