using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_toe_toernooischema : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private Lookup sgt_basisschema_1_idField;
		private Lookup sgt_basisschema_2_idField;
		private Lookup sgt_basisschema_3_idField;
		private string sgt_beschrijvingField;
		private string sgt_omschrijvingField;
		private Lookup sgt_schemagrootteidField;
		private string sgt_toe_toernooischema1Field;
		private Key sgt_toe_toernooischemaidField;
		private Lookup sgt_toernooisoort_idField;
		private string sgt_verkorte_codeField;
		private Sgt_toe_toernooischemaStateInfo statecodeField;
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
		public Lookup sgt_basisschema_1_id
		{
			get
			{
				return this.sgt_basisschema_1_idField;
			}
			set
			{
				this.sgt_basisschema_1_idField = value;
			}
		}
		public Lookup sgt_basisschema_2_id
		{
			get
			{
				return this.sgt_basisschema_2_idField;
			}
			set
			{
				this.sgt_basisschema_2_idField = value;
			}
		}
		public Lookup sgt_basisschema_3_id
		{
			get
			{
				return this.sgt_basisschema_3_idField;
			}
			set
			{
				this.sgt_basisschema_3_idField = value;
			}
		}
		public string sgt_beschrijving
		{
			get
			{
				return this.sgt_beschrijvingField;
			}
			set
			{
				this.sgt_beschrijvingField = value;
			}
		}
		public string sgt_omschrijving
		{
			get
			{
				return this.sgt_omschrijvingField;
			}
			set
			{
				this.sgt_omschrijvingField = value;
			}
		}
		public Lookup sgt_schemagrootteid
		{
			get
			{
				return this.sgt_schemagrootteidField;
			}
			set
			{
				this.sgt_schemagrootteidField = value;
			}
		}
		[XmlElement("sgt_toe_toernooischema")]
		public string sgt_toe_toernooischema1
		{
			get
			{
				return this.sgt_toe_toernooischema1Field;
			}
			set
			{
				this.sgt_toe_toernooischema1Field = value;
			}
		}
		public Key sgt_toe_toernooischemaid
		{
			get
			{
				return this.sgt_toe_toernooischemaidField;
			}
			set
			{
				this.sgt_toe_toernooischemaidField = value;
			}
		}
		public Lookup sgt_toernooisoort_id
		{
			get
			{
				return this.sgt_toernooisoort_idField;
			}
			set
			{
				this.sgt_toernooisoort_idField = value;
			}
		}
		public string sgt_verkorte_code
		{
			get
			{
				return this.sgt_verkorte_codeField;
			}
			set
			{
				this.sgt_verkorte_codeField = value;
			}
		}
		public Sgt_toe_toernooischemaStateInfo statecode
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
