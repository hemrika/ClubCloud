using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_bo_licentie_logboek : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private string sgt_bo_licentie_logboek1Field;
		private Key sgt_bo_licentie_logboekidField;
		private CrmDateTime sgt_datum_exportField;
		private CrmBoolean sgt_export_aanmakenField;
		private string sgt_extra_info_exporterenField;
		private string sgt_licentie_geldig_tmField;
		private string sgt_licentie_geldig_vanafField;
		private Lookup sgt_licentieidField;
		private string sgt_lognummerField;
		private CrmBoolean sgt_opnieuwField;
		private Picklist sgt_status_exportenField;
		private Sgt_bo_licentie_logboekStateInfo statecodeField;
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
		[XmlElement("sgt_bo_licentie_logboek")]
		public string sgt_bo_licentie_logboek1
		{
			get
			{
				return this.sgt_bo_licentie_logboek1Field;
			}
			set
			{
				this.sgt_bo_licentie_logboek1Field = value;
			}
		}
		public Key sgt_bo_licentie_logboekid
		{
			get
			{
				return this.sgt_bo_licentie_logboekidField;
			}
			set
			{
				this.sgt_bo_licentie_logboekidField = value;
			}
		}
		public CrmDateTime sgt_datum_export
		{
			get
			{
				return this.sgt_datum_exportField;
			}
			set
			{
				this.sgt_datum_exportField = value;
			}
		}
		public CrmBoolean sgt_export_aanmaken
		{
			get
			{
				return this.sgt_export_aanmakenField;
			}
			set
			{
				this.sgt_export_aanmakenField = value;
			}
		}
		public string sgt_extra_info_exporteren
		{
			get
			{
				return this.sgt_extra_info_exporterenField;
			}
			set
			{
				this.sgt_extra_info_exporterenField = value;
			}
		}
		public string sgt_licentie_geldig_tm
		{
			get
			{
				return this.sgt_licentie_geldig_tmField;
			}
			set
			{
				this.sgt_licentie_geldig_tmField = value;
			}
		}
		public string sgt_licentie_geldig_vanaf
		{
			get
			{
				return this.sgt_licentie_geldig_vanafField;
			}
			set
			{
				this.sgt_licentie_geldig_vanafField = value;
			}
		}
		public Lookup sgt_licentieid
		{
			get
			{
				return this.sgt_licentieidField;
			}
			set
			{
				this.sgt_licentieidField = value;
			}
		}
		public string sgt_lognummer
		{
			get
			{
				return this.sgt_lognummerField;
			}
			set
			{
				this.sgt_lognummerField = value;
			}
		}
		public CrmBoolean sgt_opnieuw
		{
			get
			{
				return this.sgt_opnieuwField;
			}
			set
			{
				this.sgt_opnieuwField = value;
			}
		}
		public Picklist sgt_status_exporten
		{
			get
			{
				return this.sgt_status_exportenField;
			}
			set
			{
				this.sgt_status_exportenField = value;
			}
		}
		public Sgt_bo_licentie_logboekStateInfo statecode
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
