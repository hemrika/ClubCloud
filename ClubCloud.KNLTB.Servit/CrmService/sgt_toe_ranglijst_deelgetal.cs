using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_toe_ranglijst_deelgetal : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup organizationidField;
		private CrmDateTime overriddencreatedonField;
		private CrmDecimal sgt_deelgetalField;
		private Lookup sgt_ranglijstidField;
		private string sgt_toe_ranglijst_deelgetal1Field;
		private Key sgt_toe_ranglijst_deelgetalidField;
		private CrmNumber sgt_toernooien_tmField;
		private CrmNumber sgt_toernooien_vanafField;
		private Sgt_toe_ranglijst_deelgetalStateInfo statecodeField;
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
		public CrmDecimal sgt_deelgetal
		{
			get
			{
				return this.sgt_deelgetalField;
			}
			set
			{
				this.sgt_deelgetalField = value;
			}
		}
		public Lookup sgt_ranglijstid
		{
			get
			{
				return this.sgt_ranglijstidField;
			}
			set
			{
				this.sgt_ranglijstidField = value;
			}
		}
		[XmlElement("sgt_toe_ranglijst_deelgetal")]
		public string sgt_toe_ranglijst_deelgetal1
		{
			get
			{
				return this.sgt_toe_ranglijst_deelgetal1Field;
			}
			set
			{
				this.sgt_toe_ranglijst_deelgetal1Field = value;
			}
		}
		public Key sgt_toe_ranglijst_deelgetalid
		{
			get
			{
				return this.sgt_toe_ranglijst_deelgetalidField;
			}
			set
			{
				this.sgt_toe_ranglijst_deelgetalidField = value;
			}
		}
		public CrmNumber sgt_toernooien_tm
		{
			get
			{
				return this.sgt_toernooien_tmField;
			}
			set
			{
				this.sgt_toernooien_tmField = value;
			}
		}
		public CrmNumber sgt_toernooien_vanaf
		{
			get
			{
				return this.sgt_toernooien_vanafField;
			}
			set
			{
				this.sgt_toernooien_vanafField = value;
			}
		}
		public Sgt_toe_ranglijst_deelgetalStateInfo statecode
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
