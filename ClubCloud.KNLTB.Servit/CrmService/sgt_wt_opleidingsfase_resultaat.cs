using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_wt_opleidingsfase_resultaat : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private Lookup sgt_cursistidField;
		private string sgt_fase_resultaatField;
		private Lookup sgt_opleidingidField;
		private Lookup sgt_opleidingsfaseidField;
		private Lookup sgt_opleidingsgroepidField;
		private Picklist sgt_resultaatField;
		private CrmDateTime sgt_resultaatdatumField;
		private CrmNumber sgt_volgordenummerField;
		private Key sgt_wt_opleidingsfase_resultaatidField;
		private Sgt_wt_opleidingsfase_resultaatStateInfo statecodeField;
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
		public Lookup sgt_cursistid
		{
			get
			{
				return this.sgt_cursistidField;
			}
			set
			{
				this.sgt_cursistidField = value;
			}
		}
		public string sgt_fase_resultaat
		{
			get
			{
				return this.sgt_fase_resultaatField;
			}
			set
			{
				this.sgt_fase_resultaatField = value;
			}
		}
		public Lookup sgt_opleidingid
		{
			get
			{
				return this.sgt_opleidingidField;
			}
			set
			{
				this.sgt_opleidingidField = value;
			}
		}
		public Lookup sgt_opleidingsfaseid
		{
			get
			{
				return this.sgt_opleidingsfaseidField;
			}
			set
			{
				this.sgt_opleidingsfaseidField = value;
			}
		}
		public Lookup sgt_opleidingsgroepid
		{
			get
			{
				return this.sgt_opleidingsgroepidField;
			}
			set
			{
				this.sgt_opleidingsgroepidField = value;
			}
		}
		public Picklist sgt_resultaat
		{
			get
			{
				return this.sgt_resultaatField;
			}
			set
			{
				this.sgt_resultaatField = value;
			}
		}
		public CrmDateTime sgt_resultaatdatum
		{
			get
			{
				return this.sgt_resultaatdatumField;
			}
			set
			{
				this.sgt_resultaatdatumField = value;
			}
		}
		public CrmNumber sgt_volgordenummer
		{
			get
			{
				return this.sgt_volgordenummerField;
			}
			set
			{
				this.sgt_volgordenummerField = value;
			}
		}
		public Key sgt_wt_opleidingsfase_resultaatid
		{
			get
			{
				return this.sgt_wt_opleidingsfase_resultaatidField;
			}
			set
			{
				this.sgt_wt_opleidingsfase_resultaatidField = value;
			}
		}
		public Sgt_wt_opleidingsfase_resultaatStateInfo statecode
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
