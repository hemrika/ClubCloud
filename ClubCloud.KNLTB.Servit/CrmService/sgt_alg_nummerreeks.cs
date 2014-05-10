using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_alg_nummerreeks : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup organizationidField;
		private CrmDateTime overriddencreatedonField;
		private string sgt_alg_naamField;
		private Key sgt_alg_nummerreeksidField;
		private CrmNumber sgt_alg_timeoutField;
		private string sgt_cultuurField;
		private string sgt_entiteitnaamField;
		private CrmDecimal sgt_huidig_nummerField;
		private string sgt_kenmerk_parentField;
		private string sgt_kenmerknaamField;
		private string sgt_maskerField;
		private Picklist sgt_soortField;
		private CrmDecimal sgt_stapField;
		private Sgt_alg_nummerreeksStateInfo statecodeField;
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
		public Key sgt_alg_nummerreeksid
		{
			get
			{
				return this.sgt_alg_nummerreeksidField;
			}
			set
			{
				this.sgt_alg_nummerreeksidField = value;
			}
		}
		public CrmNumber sgt_alg_timeout
		{
			get
			{
				return this.sgt_alg_timeoutField;
			}
			set
			{
				this.sgt_alg_timeoutField = value;
			}
		}
		public string sgt_cultuur
		{
			get
			{
				return this.sgt_cultuurField;
			}
			set
			{
				this.sgt_cultuurField = value;
			}
		}
		public string sgt_entiteitnaam
		{
			get
			{
				return this.sgt_entiteitnaamField;
			}
			set
			{
				this.sgt_entiteitnaamField = value;
			}
		}
		public CrmDecimal sgt_huidig_nummer
		{
			get
			{
				return this.sgt_huidig_nummerField;
			}
			set
			{
				this.sgt_huidig_nummerField = value;
			}
		}
		public string sgt_kenmerk_parent
		{
			get
			{
				return this.sgt_kenmerk_parentField;
			}
			set
			{
				this.sgt_kenmerk_parentField = value;
			}
		}
		public string sgt_kenmerknaam
		{
			get
			{
				return this.sgt_kenmerknaamField;
			}
			set
			{
				this.sgt_kenmerknaamField = value;
			}
		}
		public string sgt_masker
		{
			get
			{
				return this.sgt_maskerField;
			}
			set
			{
				this.sgt_maskerField = value;
			}
		}
		public Picklist sgt_soort
		{
			get
			{
				return this.sgt_soortField;
			}
			set
			{
				this.sgt_soortField = value;
			}
		}
		public CrmDecimal sgt_stap
		{
			get
			{
				return this.sgt_stapField;
			}
			set
			{
				this.sgt_stapField = value;
			}
		}
		public Sgt_alg_nummerreeksStateInfo statecode
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
