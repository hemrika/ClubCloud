using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_alg_postcode : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup organizationidField;
		private CrmDateTime overriddencreatedonField;
		private string sgt_alg_postcode1Field;
		private Key sgt_alg_postcodeidField;
		private string sgt_gemeente_nenField;
		private string sgt_huisnummer_tmField;
		private string sgt_huisnummer_vanField;
		private Lookup sgt_landcodeidField;
		private CrmBoolean sgt_onevenField;
		private string sgt_plaats_nenField;
		private string sgt_straat_nenField;
		private Sgt_alg_postcodeStateInfo statecodeField;
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
		public Lookup organizationid
		{
			get
			{
				return this.organizationidField;
			}
			set
			{
				this.organizationidField = value;
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
		[XmlElement("sgt_alg_postcode")]
		public string sgt_alg_postcode1
		{
			get
			{
				return this.sgt_alg_postcode1Field;
			}
			set
			{
				this.sgt_alg_postcode1Field = value;
			}
		}
		public Key sgt_alg_postcodeid
		{
			get
			{
				return this.sgt_alg_postcodeidField;
			}
			set
			{
				this.sgt_alg_postcodeidField = value;
			}
		}
		public string sgt_gemeente_nen
		{
			get
			{
				return this.sgt_gemeente_nenField;
			}
			set
			{
				this.sgt_gemeente_nenField = value;
			}
		}
		public string sgt_huisnummer_tm
		{
			get
			{
				return this.sgt_huisnummer_tmField;
			}
			set
			{
				this.sgt_huisnummer_tmField = value;
			}
		}
		public string sgt_huisnummer_van
		{
			get
			{
				return this.sgt_huisnummer_vanField;
			}
			set
			{
				this.sgt_huisnummer_vanField = value;
			}
		}
		public Lookup sgt_landcodeid
		{
			get
			{
				return this.sgt_landcodeidField;
			}
			set
			{
				this.sgt_landcodeidField = value;
			}
		}
		public CrmBoolean sgt_oneven
		{
			get
			{
				return this.sgt_onevenField;
			}
			set
			{
				this.sgt_onevenField = value;
			}
		}
		public string sgt_plaats_nen
		{
			get
			{
				return this.sgt_plaats_nenField;
			}
			set
			{
				this.sgt_plaats_nenField = value;
			}
		}
		public string sgt_straat_nen
		{
			get
			{
				return this.sgt_straat_nenField;
			}
			set
			{
				this.sgt_straat_nenField = value;
			}
		}
		public Sgt_alg_postcodeStateInfo statecode
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
