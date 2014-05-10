using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_toe_pb_interface_logboek_toernooien : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private string sgt_bondsnummerField;
		private CrmNumber sgt_interfaceberichtidField;
		private Picklist sgt_soort_interfaceField;
		private Picklist sgt_status_interfaceField;
		private string sgt_toe_lognummerField;
		private Lookup sgt_toe_pb_interface_logboek_toernooiField;
		private Key sgt_toe_pb_interface_logboek_toernooienidField;
		private Picklist sgt_type_interfaceField;
		private Sgt_toe_pb_interface_logboek_toernooienStateInfo statecodeField;
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
		public string sgt_bondsnummer
		{
			get
			{
				return this.sgt_bondsnummerField;
			}
			set
			{
				this.sgt_bondsnummerField = value;
			}
		}
		public CrmNumber sgt_interfaceberichtid
		{
			get
			{
				return this.sgt_interfaceberichtidField;
			}
			set
			{
				this.sgt_interfaceberichtidField = value;
			}
		}
		public Picklist sgt_soort_interface
		{
			get
			{
				return this.sgt_soort_interfaceField;
			}
			set
			{
				this.sgt_soort_interfaceField = value;
			}
		}
		public Picklist sgt_status_interface
		{
			get
			{
				return this.sgt_status_interfaceField;
			}
			set
			{
				this.sgt_status_interfaceField = value;
			}
		}
		public string sgt_toe_lognummer
		{
			get
			{
				return this.sgt_toe_lognummerField;
			}
			set
			{
				this.sgt_toe_lognummerField = value;
			}
		}
		public Lookup sgt_toe_pb_interface_logboek_toernooi
		{
			get
			{
				return this.sgt_toe_pb_interface_logboek_toernooiField;
			}
			set
			{
				this.sgt_toe_pb_interface_logboek_toernooiField = value;
			}
		}
		public Key sgt_toe_pb_interface_logboek_toernooienid
		{
			get
			{
				return this.sgt_toe_pb_interface_logboek_toernooienidField;
			}
			set
			{
				this.sgt_toe_pb_interface_logboek_toernooienidField = value;
			}
		}
		public Picklist sgt_type_interface
		{
			get
			{
				return this.sgt_type_interfaceField;
			}
			set
			{
				this.sgt_type_interfaceField = value;
			}
		}
		public Sgt_toe_pb_interface_logboek_toernooienStateInfo statecode
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
