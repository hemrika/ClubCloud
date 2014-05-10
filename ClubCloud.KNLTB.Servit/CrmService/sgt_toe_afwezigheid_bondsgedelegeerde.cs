using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_toe_afwezigheid_bondsgedelegeerde : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private CrmDateTime sgt_begindatumField;
		private Lookup sgt_bondsgedelegeerdeidField;
		private CrmDateTime sgt_einddatumField;
		private string sgt_toe_afwezigheid_bondsgedelegeerde1Field;
		private Key sgt_toe_afwezigheid_bondsgedelegeerdeidField;
		private string sgt_weeknummer_tmField;
		private string sgt_weeknummer_vanafField;
		private Sgt_toe_afwezigheid_bondsgedelegeerdeStateInfo statecodeField;
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
		public CrmDateTime sgt_begindatum
		{
			get
			{
				return this.sgt_begindatumField;
			}
			set
			{
				this.sgt_begindatumField = value;
			}
		}
		public Lookup sgt_bondsgedelegeerdeid
		{
			get
			{
				return this.sgt_bondsgedelegeerdeidField;
			}
			set
			{
				this.sgt_bondsgedelegeerdeidField = value;
			}
		}
		public CrmDateTime sgt_einddatum
		{
			get
			{
				return this.sgt_einddatumField;
			}
			set
			{
				this.sgt_einddatumField = value;
			}
		}
		[XmlElement("sgt_toe_afwezigheid_bondsgedelegeerde")]
		public string sgt_toe_afwezigheid_bondsgedelegeerde1
		{
			get
			{
				return this.sgt_toe_afwezigheid_bondsgedelegeerde1Field;
			}
			set
			{
				this.sgt_toe_afwezigheid_bondsgedelegeerde1Field = value;
			}
		}
		public Key sgt_toe_afwezigheid_bondsgedelegeerdeid
		{
			get
			{
				return this.sgt_toe_afwezigheid_bondsgedelegeerdeidField;
			}
			set
			{
				this.sgt_toe_afwezigheid_bondsgedelegeerdeidField = value;
			}
		}
		public string sgt_weeknummer_tm
		{
			get
			{
				return this.sgt_weeknummer_tmField;
			}
			set
			{
				this.sgt_weeknummer_tmField = value;
			}
		}
		public string sgt_weeknummer_vanaf
		{
			get
			{
				return this.sgt_weeknummer_vanafField;
			}
			set
			{
				this.sgt_weeknummer_vanafField = value;
			}
		}
		public Sgt_toe_afwezigheid_bondsgedelegeerdeStateInfo statecode
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
