using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_alg_reisafstand : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup organizationidField;
		private CrmDateTime overriddencreatedonField;
		private string sgt_alg_naamField;
		private Key sgt_alg_reisafstandidField;
		private Lookup sgt_landcodeidField;
		private string sgt_naar_postcodeField;
		private CrmNumber sgt_reisafstandField;
		private CrmNumber sgt_reistijdField;
		private string sgt_van_postcodeField;
		private Sgt_alg_reisafstandStateInfo statecodeField;
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
		public string sgt_alg_naam
		{
			get
			{
				return this.sgt_alg_naamField;
			}
			set
			{
				this.sgt_alg_naamField = value;
			}
		}
		public Key sgt_alg_reisafstandid
		{
			get
			{
				return this.sgt_alg_reisafstandidField;
			}
			set
			{
				this.sgt_alg_reisafstandidField = value;
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
		public string sgt_naar_postcode
		{
			get
			{
				return this.sgt_naar_postcodeField;
			}
			set
			{
				this.sgt_naar_postcodeField = value;
			}
		}
		public CrmNumber sgt_reisafstand
		{
			get
			{
				return this.sgt_reisafstandField;
			}
			set
			{
				this.sgt_reisafstandField = value;
			}
		}
		public CrmNumber sgt_reistijd
		{
			get
			{
				return this.sgt_reistijdField;
			}
			set
			{
				this.sgt_reistijdField = value;
			}
		}
		public string sgt_van_postcode
		{
			get
			{
				return this.sgt_van_postcodeField;
			}
			set
			{
				this.sgt_van_postcodeField = value;
			}
		}
		public Sgt_alg_reisafstandStateInfo statecode
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
