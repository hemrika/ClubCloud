using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_alg_formulier_antwoord_veld : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private Key sgt_alg_formulier_antwoord_veldidField;
		private Lookup sgt_formulier_antwoord_idField;
		private string sgt_inhoudField;
		private string sgt_labelField;
		private string sgt_nameField;
		private CrmNumber sgt_sequenceField;
		private string sgt_volgordeField;
		private Sgt_alg_formulier_antwoord_veldStateInfo statecodeField;
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
		public Key sgt_alg_formulier_antwoord_veldid
		{
			get
			{
				return this.sgt_alg_formulier_antwoord_veldidField;
			}
			set
			{
				this.sgt_alg_formulier_antwoord_veldidField = value;
			}
		}
		public Lookup sgt_formulier_antwoord_id
		{
			get
			{
				return this.sgt_formulier_antwoord_idField;
			}
			set
			{
				this.sgt_formulier_antwoord_idField = value;
			}
		}
		public string sgt_inhoud
		{
			get
			{
				return this.sgt_inhoudField;
			}
			set
			{
				this.sgt_inhoudField = value;
			}
		}
		public string sgt_label
		{
			get
			{
				return this.sgt_labelField;
			}
			set
			{
				this.sgt_labelField = value;
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
		public CrmNumber sgt_sequence
		{
			get
			{
				return this.sgt_sequenceField;
			}
			set
			{
				this.sgt_sequenceField = value;
			}
		}
		public string sgt_volgorde
		{
			get
			{
				return this.sgt_volgordeField;
			}
			set
			{
				this.sgt_volgordeField = value;
			}
		}
		public Sgt_alg_formulier_antwoord_veldStateInfo statecode
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
