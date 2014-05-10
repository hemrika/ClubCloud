using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_dss_correctiewaarde_basisgetal : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private CrmDecimal sgt_dames_dubbelField;
		private CrmDecimal sgt_dames_enkelField;
		private Key sgt_dss_correctiewaarde_basisgetalidField;
		private string sgt_dss_nameField;
		private CrmDecimal sgt_heren_dubbelField;
		private CrmDecimal sgt_heren_enkelField;
		private CrmNumber sgt_speelsterkteField;
		private Lookup sgt_speelsterktebepalingidField;
		private Sgt_dss_correctiewaarde_basisgetalStateInfo statecodeField;
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
		public CrmDecimal sgt_dames_dubbel
		{
			get
			{
				return this.sgt_dames_dubbelField;
			}
			set
			{
				this.sgt_dames_dubbelField = value;
			}
		}
		public CrmDecimal sgt_dames_enkel
		{
			get
			{
				return this.sgt_dames_enkelField;
			}
			set
			{
				this.sgt_dames_enkelField = value;
			}
		}
		public Key sgt_dss_correctiewaarde_basisgetalid
		{
			get
			{
				return this.sgt_dss_correctiewaarde_basisgetalidField;
			}
			set
			{
				this.sgt_dss_correctiewaarde_basisgetalidField = value;
			}
		}
		public string sgt_dss_name
		{
			get
			{
				return this.sgt_dss_nameField;
			}
			set
			{
				this.sgt_dss_nameField = value;
			}
		}
		public CrmDecimal sgt_heren_dubbel
		{
			get
			{
				return this.sgt_heren_dubbelField;
			}
			set
			{
				this.sgt_heren_dubbelField = value;
			}
		}
		public CrmDecimal sgt_heren_enkel
		{
			get
			{
				return this.sgt_heren_enkelField;
			}
			set
			{
				this.sgt_heren_enkelField = value;
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
		public Sgt_dss_correctiewaarde_basisgetalStateInfo statecode
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
