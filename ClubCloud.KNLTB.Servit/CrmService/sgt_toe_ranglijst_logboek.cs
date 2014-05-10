using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_toe_ranglijst_logboek : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private Lookup sgt_bonus_ranglijst_logboekidField;
		private CrmDateTime sgt_datum_genererenField;
		private CrmDateTime sgt_datum_handmatige_ranglijstField;
		private CrmDateTime sgt_datum_laatste_ranglijstField;
		private CrmDateTime sgt_datum_tmField;
		private CrmDateTime sgt_datum_vanafField;
		private CrmBoolean sgt_genererenField;
		private CrmBoolean sgt_handmatigField;
		private CrmBoolean sgt_opnieuwField;
		private CrmBoolean sgt_publicerenField;
		private Lookup sgt_ranglijstidField;
		private Picklist sgt_statusField;
		private string sgt_tm_weekField;
		private string sgt_toe_ranglijst_logboek1Field;
		private Key sgt_toe_ranglijst_logboekidField;
		private string sgt_vanaf_weekField;
		private Sgt_toe_ranglijst_logboekStateInfo statecodeField;
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
		public Lookup sgt_bonus_ranglijst_logboekid
		{
			get
			{
				return this.sgt_bonus_ranglijst_logboekidField;
			}
			set
			{
				this.sgt_bonus_ranglijst_logboekidField = value;
			}
		}
		public CrmDateTime sgt_datum_genereren
		{
			get
			{
				return this.sgt_datum_genererenField;
			}
			set
			{
				this.sgt_datum_genererenField = value;
			}
		}
		public CrmDateTime sgt_datum_handmatige_ranglijst
		{
			get
			{
				return this.sgt_datum_handmatige_ranglijstField;
			}
			set
			{
				this.sgt_datum_handmatige_ranglijstField = value;
			}
		}
		public CrmDateTime sgt_datum_laatste_ranglijst
		{
			get
			{
				return this.sgt_datum_laatste_ranglijstField;
			}
			set
			{
				this.sgt_datum_laatste_ranglijstField = value;
			}
		}
		public CrmDateTime sgt_datum_tm
		{
			get
			{
				return this.sgt_datum_tmField;
			}
			set
			{
				this.sgt_datum_tmField = value;
			}
		}
		public CrmDateTime sgt_datum_vanaf
		{
			get
			{
				return this.sgt_datum_vanafField;
			}
			set
			{
				this.sgt_datum_vanafField = value;
			}
		}
		public CrmBoolean sgt_genereren
		{
			get
			{
				return this.sgt_genererenField;
			}
			set
			{
				this.sgt_genererenField = value;
			}
		}
		public CrmBoolean sgt_handmatig
		{
			get
			{
				return this.sgt_handmatigField;
			}
			set
			{
				this.sgt_handmatigField = value;
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
		public CrmBoolean sgt_publiceren
		{
			get
			{
				return this.sgt_publicerenField;
			}
			set
			{
				this.sgt_publicerenField = value;
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
		public Picklist sgt_status
		{
			get
			{
				return this.sgt_statusField;
			}
			set
			{
				this.sgt_statusField = value;
			}
		}
		public string sgt_tm_week
		{
			get
			{
				return this.sgt_tm_weekField;
			}
			set
			{
				this.sgt_tm_weekField = value;
			}
		}
		[XmlElement("sgt_toe_ranglijst_logboek")]
		public string sgt_toe_ranglijst_logboek1
		{
			get
			{
				return this.sgt_toe_ranglijst_logboek1Field;
			}
			set
			{
				this.sgt_toe_ranglijst_logboek1Field = value;
			}
		}
		public Key sgt_toe_ranglijst_logboekid
		{
			get
			{
				return this.sgt_toe_ranglijst_logboekidField;
			}
			set
			{
				this.sgt_toe_ranglijst_logboekidField = value;
			}
		}
		public string sgt_vanaf_week
		{
			get
			{
				return this.sgt_vanaf_weekField;
			}
			set
			{
				this.sgt_vanaf_weekField = value;
			}
		}
		public Sgt_toe_ranglijst_logboekStateInfo statecode
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
