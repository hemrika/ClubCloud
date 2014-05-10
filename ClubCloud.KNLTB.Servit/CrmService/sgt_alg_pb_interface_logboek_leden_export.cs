using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_alg_pb_interface_logboek_leden_export : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private string sgt_alg_lognummerField;
		private Key sgt_alg_pb_interface_logboek_leden_exportidField;
		private CrmBoolean sgt_automatisch_gestartField;
		private Lookup sgt_pb_interface_logboekidField;
		private Picklist sgt_statusField;
		private CrmDateTime sgt_verwerkingsdatumField;
		private Sgt_alg_pb_interface_logboek_leden_exportStateInfo statecodeField;
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
		public string sgt_alg_lognummer
		{
			get
			{
				return this.sgt_alg_lognummerField;
			}
			set
			{
				this.sgt_alg_lognummerField = value;
			}
		}
		public Key sgt_alg_pb_interface_logboek_leden_exportid
		{
			get
			{
				return this.sgt_alg_pb_interface_logboek_leden_exportidField;
			}
			set
			{
				this.sgt_alg_pb_interface_logboek_leden_exportidField = value;
			}
		}
		public CrmBoolean sgt_automatisch_gestart
		{
			get
			{
				return this.sgt_automatisch_gestartField;
			}
			set
			{
				this.sgt_automatisch_gestartField = value;
			}
		}
		public Lookup sgt_pb_interface_logboekid
		{
			get
			{
				return this.sgt_pb_interface_logboekidField;
			}
			set
			{
				this.sgt_pb_interface_logboekidField = value;
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
		public CrmDateTime sgt_verwerkingsdatum
		{
			get
			{
				return this.sgt_verwerkingsdatumField;
			}
			set
			{
				this.sgt_verwerkingsdatumField = value;
			}
		}
		public Sgt_alg_pb_interface_logboek_leden_exportStateInfo statecode
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
