using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_toe_toernooi_in_interface_logboek : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private Lookup sgt_dagtoernooinaam_idField;
		private Lookup sgt_logboek_idField;
		private string sgt_nameField;
		private Key sgt_toe_toernooi_in_interface_logboekidField;
		private Lookup sgt_toernooiaanvraag_verwerking_idField;
		private Lookup sgt_toernooinaam_idField;
		private Sgt_toe_toernooi_in_interface_logboekStateInfo statecodeField;
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
		public Lookup sgt_dagtoernooinaam_id
		{
			get
			{
				return this.sgt_dagtoernooinaam_idField;
			}
			set
			{
				this.sgt_dagtoernooinaam_idField = value;
			}
		}
		public Lookup sgt_logboek_id
		{
			get
			{
				return this.sgt_logboek_idField;
			}
			set
			{
				this.sgt_logboek_idField = value;
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
		public Key sgt_toe_toernooi_in_interface_logboekid
		{
			get
			{
				return this.sgt_toe_toernooi_in_interface_logboekidField;
			}
			set
			{
				this.sgt_toe_toernooi_in_interface_logboekidField = value;
			}
		}
		public Lookup sgt_toernooiaanvraag_verwerking_id
		{
			get
			{
				return this.sgt_toernooiaanvraag_verwerking_idField;
			}
			set
			{
				this.sgt_toernooiaanvraag_verwerking_idField = value;
			}
		}
		public Lookup sgt_toernooinaam_id
		{
			get
			{
				return this.sgt_toernooinaam_idField;
			}
			set
			{
				this.sgt_toernooinaam_idField = value;
			}
		}
		public Sgt_toe_toernooi_in_interface_logboekStateInfo statecode
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
