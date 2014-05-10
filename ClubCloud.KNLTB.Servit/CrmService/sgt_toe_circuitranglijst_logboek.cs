using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_toe_circuitranglijst_logboek : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private Lookup sgt_circuitidField;
		private CrmBoolean sgt_circuitranglijst_genererenField;
		private CrmDateTime sgt_datum_circuitranglijstField;
		private CrmDateTime sgt_datum_genererenField;
		private CrmDateTime sgt_datum_laatste_circuitranglijstField;
		private CrmBoolean sgt_handmatig_aanmakenField;
		private CrmBoolean sgt_opnieuw_genererenField;
		private CrmBoolean sgt_publiceren_mijnknltbField;
		private Picklist sgt_statusField;
		private string sgt_toe_circuitranglijst_logboek1Field;
		private Key sgt_toe_circuitranglijst_logboekidField;
		private string sgt_week_tmField;
		private string sgt_week_vanafField;
		private Sgt_toe_circuitranglijst_logboekStateInfo statecodeField;
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
		public Lookup sgt_circuitid
		{
			get
			{
				return this.sgt_circuitidField;
			}
			set
			{
				this.sgt_circuitidField = value;
			}
		}
		public CrmBoolean sgt_circuitranglijst_genereren
		{
			get
			{
				return this.sgt_circuitranglijst_genererenField;
			}
			set
			{
				this.sgt_circuitranglijst_genererenField = value;
			}
		}
		public CrmDateTime sgt_datum_circuitranglijst
		{
			get
			{
				return this.sgt_datum_circuitranglijstField;
			}
			set
			{
				this.sgt_datum_circuitranglijstField = value;
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
		public CrmDateTime sgt_datum_laatste_circuitranglijst
		{
			get
			{
				return this.sgt_datum_laatste_circuitranglijstField;
			}
			set
			{
				this.sgt_datum_laatste_circuitranglijstField = value;
			}
		}
		public CrmBoolean sgt_handmatig_aanmaken
		{
			get
			{
				return this.sgt_handmatig_aanmakenField;
			}
			set
			{
				this.sgt_handmatig_aanmakenField = value;
			}
		}
		public CrmBoolean sgt_opnieuw_genereren
		{
			get
			{
				return this.sgt_opnieuw_genererenField;
			}
			set
			{
				this.sgt_opnieuw_genererenField = value;
			}
		}
		public CrmBoolean sgt_publiceren_mijnknltb
		{
			get
			{
				return this.sgt_publiceren_mijnknltbField;
			}
			set
			{
				this.sgt_publiceren_mijnknltbField = value;
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
		[XmlElement("sgt_toe_circuitranglijst_logboek")]
		public string sgt_toe_circuitranglijst_logboek1
		{
			get
			{
				return this.sgt_toe_circuitranglijst_logboek1Field;
			}
			set
			{
				this.sgt_toe_circuitranglijst_logboek1Field = value;
			}
		}
		public Key sgt_toe_circuitranglijst_logboekid
		{
			get
			{
				return this.sgt_toe_circuitranglijst_logboekidField;
			}
			set
			{
				this.sgt_toe_circuitranglijst_logboekidField = value;
			}
		}
		public string sgt_week_tm
		{
			get
			{
				return this.sgt_week_tmField;
			}
			set
			{
				this.sgt_week_tmField = value;
			}
		}
		public string sgt_week_vanaf
		{
			get
			{
				return this.sgt_week_vanafField;
			}
			set
			{
				this.sgt_week_vanafField = value;
			}
		}
		public Sgt_toe_circuitranglijst_logboekStateInfo statecode
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
