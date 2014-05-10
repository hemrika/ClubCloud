using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_toe_leeftijdscat_aanvraagformulier : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private Lookup sgt_aanvr_formulier_dagtoernooi_idField;
		private Lookup sgt_aanvr_formulier_toernooi_idField;
		private Lookup sgt_leeftijdscategorie_idField;
		private Key sgt_toe_leeftijdscat_aanvraagformulieridField;
		private string sgt_toe_nameField;
		private Sgt_toe_leeftijdscat_aanvraagformulierStateInfo statecodeField;
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
		public Lookup sgt_aanvr_formulier_dagtoernooi_id
		{
			get
			{
				return this.sgt_aanvr_formulier_dagtoernooi_idField;
			}
			set
			{
				this.sgt_aanvr_formulier_dagtoernooi_idField = value;
			}
		}
		public Lookup sgt_aanvr_formulier_toernooi_id
		{
			get
			{
				return this.sgt_aanvr_formulier_toernooi_idField;
			}
			set
			{
				this.sgt_aanvr_formulier_toernooi_idField = value;
			}
		}
		public Lookup sgt_leeftijdscategorie_id
		{
			get
			{
				return this.sgt_leeftijdscategorie_idField;
			}
			set
			{
				this.sgt_leeftijdscategorie_idField = value;
			}
		}
		public Key sgt_toe_leeftijdscat_aanvraagformulierid
		{
			get
			{
				return this.sgt_toe_leeftijdscat_aanvraagformulieridField;
			}
			set
			{
				this.sgt_toe_leeftijdscat_aanvraagformulieridField = value;
			}
		}
		public string sgt_toe_name
		{
			get
			{
				return this.sgt_toe_nameField;
			}
			set
			{
				this.sgt_toe_nameField = value;
			}
		}
		public Sgt_toe_leeftijdscat_aanvraagformulierStateInfo statecode
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
