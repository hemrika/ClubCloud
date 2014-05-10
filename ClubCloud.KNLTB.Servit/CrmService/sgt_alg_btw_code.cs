using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_alg_btw_code : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private Key sgt_alg_btw_codeidField;
		private string sgt_alg_codeField;
		private string sgt_btw_omschrijvingField;
		private CrmDecimal sgt_btw_percentageField;
		private Lookup sgt_grootboekcodeidField;
		private Sgt_alg_btw_codeStateInfo statecodeField;
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
		public Key sgt_alg_btw_codeid
		{
			get
			{
				return this.sgt_alg_btw_codeidField;
			}
			set
			{
				this.sgt_alg_btw_codeidField = value;
			}
		}
		public string sgt_alg_code
		{
			get
			{
				return this.sgt_alg_codeField;
			}
			set
			{
				this.sgt_alg_codeField = value;
			}
		}
		public string sgt_btw_omschrijving
		{
			get
			{
				return this.sgt_btw_omschrijvingField;
			}
			set
			{
				this.sgt_btw_omschrijvingField = value;
			}
		}
		public CrmDecimal sgt_btw_percentage
		{
			get
			{
				return this.sgt_btw_percentageField;
			}
			set
			{
				this.sgt_btw_percentageField = value;
			}
		}
		public Lookup sgt_grootboekcodeid
		{
			get
			{
				return this.sgt_grootboekcodeidField;
			}
			set
			{
				this.sgt_grootboekcodeidField = value;
			}
		}
		public Sgt_alg_btw_codeStateInfo statecode
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
