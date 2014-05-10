using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_toe_schaduw_ranglijst_logboek : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup organizationidField;
		private CrmDateTime overriddencreatedonField;
		private CrmDateTime sgt_datum_genererenField;
		private CrmDateTime sgt_datum_laatste_schaduwranglijstField;
		private CrmBoolean sgt_genererenField;
		private string sgt_nameField;
		private CrmBoolean sgt_opnieuwField;
		private Lookup sgt_ranglijst_logboekidField;
		private Lookup sgt_schaduwranglijstidField;
		private Picklist sgt_statusField;
		private Key sgt_toe_schaduw_ranglijst_logboekidField;
		private Sgt_toe_schaduw_ranglijst_logboekStateInfo statecodeField;
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
		public CrmDateTime sgt_datum_laatste_schaduwranglijst
		{
			get
			{
				return this.sgt_datum_laatste_schaduwranglijstField;
			}
			set
			{
				this.sgt_datum_laatste_schaduwranglijstField = value;
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
		public string sgt_name
		{
			get
			{
				return this.sgt_nameField;
			}
			set
			{
				this.sgt_nameField = value;
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
		public Lookup sgt_ranglijst_logboekid
		{
			get
			{
				return this.sgt_ranglijst_logboekidField;
			}
			set
			{
				this.sgt_ranglijst_logboekidField = value;
			}
		}
		public Lookup sgt_schaduwranglijstid
		{
			get
			{
				return this.sgt_schaduwranglijstidField;
			}
			set
			{
				this.sgt_schaduwranglijstidField = value;
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
		public Key sgt_toe_schaduw_ranglijst_logboekid
		{
			get
			{
				return this.sgt_toe_schaduw_ranglijst_logboekidField;
			}
			set
			{
				this.sgt_toe_schaduw_ranglijst_logboekidField = value;
			}
		}
		public Sgt_toe_schaduw_ranglijst_logboekStateInfo statecode
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
