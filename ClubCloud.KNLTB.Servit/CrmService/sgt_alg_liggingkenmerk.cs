using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_alg_liggingkenmerk : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup organizationidField;
		private CrmDateTime overriddencreatedonField;
		private string sgt_alg_liggingkenmerk1Field;
		private Key sgt_alg_liggingkenmerkidField;
		private string sgt_beschrijvingField;
		private string sgt_meervoudsnaamField;
		private string sgt_omschrijvingField;
		private string sgt_verkorte_codeField;
		private Sgt_alg_liggingkenmerkStateInfo statecodeField;
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
		[XmlElement("sgt_alg_liggingkenmerk")]
		public string sgt_alg_liggingkenmerk1
		{
			get
			{
				return this.sgt_alg_liggingkenmerk1Field;
			}
			set
			{
				this.sgt_alg_liggingkenmerk1Field = value;
			}
		}
		public Key sgt_alg_liggingkenmerkid
		{
			get
			{
				return this.sgt_alg_liggingkenmerkidField;
			}
			set
			{
				this.sgt_alg_liggingkenmerkidField = value;
			}
		}
		public string sgt_beschrijving
		{
			get
			{
				return this.sgt_beschrijvingField;
			}
			set
			{
				this.sgt_beschrijvingField = value;
			}
		}
		public string sgt_meervoudsnaam
		{
			get
			{
				return this.sgt_meervoudsnaamField;
			}
			set
			{
				this.sgt_meervoudsnaamField = value;
			}
		}
		public string sgt_omschrijving
		{
			get
			{
				return this.sgt_omschrijvingField;
			}
			set
			{
				this.sgt_omschrijvingField = value;
			}
		}
		public string sgt_verkorte_code
		{
			get
			{
				return this.sgt_verkorte_codeField;
			}
			set
			{
				this.sgt_verkorte_codeField = value;
			}
		}
		public Sgt_alg_liggingkenmerkStateInfo statecode
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