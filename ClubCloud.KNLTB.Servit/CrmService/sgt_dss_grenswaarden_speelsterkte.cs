using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_dss_grenswaarden_speelsterkte : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup organizationidField;
		private CrmDateTime overriddencreatedonField;
		private Key sgt_dss_grenswaarden_speelsterkteidField;
		private string sgt_dss_naamField;
		private CrmDecimal sgt_rating_tm_dubbel_damesField;
		private CrmDecimal sgt_rating_tm_dubbel_herenField;
		private CrmDecimal sgt_rating_tm_enkel_damesField;
		private CrmDecimal sgt_rating_tm_enkel_herenField;
		private CrmDecimal sgt_rating_vanaf_dubbel_damesField;
		private CrmDecimal sgt_rating_vanaf_dubbel_herenField;
		private CrmDecimal sgt_rating_vanaf_enkel_damesField;
		private CrmDecimal sgt_rating_vanaf_enkel_herenField;
		private CrmNumber sgt_speelsterkteField;
		private Sgt_dss_grenswaarden_speelsterkteStateInfo statecodeField;
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
		public Key sgt_dss_grenswaarden_speelsterkteid
		{
			get
			{
				return this.sgt_dss_grenswaarden_speelsterkteidField;
			}
			set
			{
				this.sgt_dss_grenswaarden_speelsterkteidField = value;
			}
		}
		public string sgt_dss_naam
		{
			get
			{
				return this.sgt_dss_naamField;
			}
			set
			{
				this.sgt_dss_naamField = value;
			}
		}
		public CrmDecimal sgt_rating_tm_dubbel_dames
		{
			get
			{
				return this.sgt_rating_tm_dubbel_damesField;
			}
			set
			{
				this.sgt_rating_tm_dubbel_damesField = value;
			}
		}
		public CrmDecimal sgt_rating_tm_dubbel_heren
		{
			get
			{
				return this.sgt_rating_tm_dubbel_herenField;
			}
			set
			{
				this.sgt_rating_tm_dubbel_herenField = value;
			}
		}
		public CrmDecimal sgt_rating_tm_enkel_dames
		{
			get
			{
				return this.sgt_rating_tm_enkel_damesField;
			}
			set
			{
				this.sgt_rating_tm_enkel_damesField = value;
			}
		}
		public CrmDecimal sgt_rating_tm_enkel_heren
		{
			get
			{
				return this.sgt_rating_tm_enkel_herenField;
			}
			set
			{
				this.sgt_rating_tm_enkel_herenField = value;
			}
		}
		public CrmDecimal sgt_rating_vanaf_dubbel_dames
		{
			get
			{
				return this.sgt_rating_vanaf_dubbel_damesField;
			}
			set
			{
				this.sgt_rating_vanaf_dubbel_damesField = value;
			}
		}
		public CrmDecimal sgt_rating_vanaf_dubbel_heren
		{
			get
			{
				return this.sgt_rating_vanaf_dubbel_herenField;
			}
			set
			{
				this.sgt_rating_vanaf_dubbel_herenField = value;
			}
		}
		public CrmDecimal sgt_rating_vanaf_enkel_dames
		{
			get
			{
				return this.sgt_rating_vanaf_enkel_damesField;
			}
			set
			{
				this.sgt_rating_vanaf_enkel_damesField = value;
			}
		}
		public CrmDecimal sgt_rating_vanaf_enkel_heren
		{
			get
			{
				return this.sgt_rating_vanaf_enkel_herenField;
			}
			set
			{
				this.sgt_rating_vanaf_enkel_herenField = value;
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
		public Sgt_dss_grenswaarden_speelsterkteStateInfo statecode
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
