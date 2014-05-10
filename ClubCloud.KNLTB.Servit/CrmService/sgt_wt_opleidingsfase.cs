using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_wt_opleidingsfase : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private string sgt_externe_fasecodeField;
		private string sgt_interne_fasecodeField;
		private CrmBoolean sgt_negeren_na_resultaatField;
		private CrmBoolean sgt_niet_nodig_volgendefaseField;
		private Lookup sgt_opleidingidField;
		private CrmNumber sgt_volgordenummerField;
		private string sgt_wt_opleidingsfase1Field;
		private Key sgt_wt_opleidingsfaseidField;
		private Sgt_wt_opleidingsfaseStateInfo statecodeField;
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
		public string sgt_externe_fasecode
		{
			get
			{
				return this.sgt_externe_fasecodeField;
			}
			set
			{
				this.sgt_externe_fasecodeField = value;
			}
		}
		public string sgt_interne_fasecode
		{
			get
			{
				return this.sgt_interne_fasecodeField;
			}
			set
			{
				this.sgt_interne_fasecodeField = value;
			}
		}
		public CrmBoolean sgt_negeren_na_resultaat
		{
			get
			{
				return this.sgt_negeren_na_resultaatField;
			}
			set
			{
				this.sgt_negeren_na_resultaatField = value;
			}
		}
		public CrmBoolean sgt_niet_nodig_volgendefase
		{
			get
			{
				return this.sgt_niet_nodig_volgendefaseField;
			}
			set
			{
				this.sgt_niet_nodig_volgendefaseField = value;
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
		[XmlElement("sgt_wt_opleidingsfase")]
		public string sgt_wt_opleidingsfase1
		{
			get
			{
				return this.sgt_wt_opleidingsfase1Field;
			}
			set
			{
				this.sgt_wt_opleidingsfase1Field = value;
			}
		}
		public Key sgt_wt_opleidingsfaseid
		{
			get
			{
				return this.sgt_wt_opleidingsfaseidField;
			}
			set
			{
				this.sgt_wt_opleidingsfaseidField = value;
			}
		}
		public Sgt_wt_opleidingsfaseStateInfo statecode
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
