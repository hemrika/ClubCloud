using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_toe_toernooi_aanvraagrecht : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private Lookup sgt_aanvraagformulier_dagtoernooi_idField;
		private Lookup sgt_aanvraagformulieridField;
		private Lookup sgt_bondsorganisatieidField;
		private string sgt_toe_toernooi_aanvraagrecht1Field;
		private Key sgt_toe_toernooi_aanvraagrechtidField;
		private Lookup sgt_toernooiorganisatieidField;
		private Lookup sgt_toernooisoortidField;
		private CrmBoolean sgt_vorig_jaarField;
		private Sgt_toe_toernooi_aanvraagrechtStateInfo statecodeField;
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
		public Lookup sgt_aanvraagformulier_dagtoernooi_id
		{
			get
			{
				return this.sgt_aanvraagformulier_dagtoernooi_idField;
			}
			set
			{
				this.sgt_aanvraagformulier_dagtoernooi_idField = value;
			}
		}
		public Lookup sgt_aanvraagformulierid
		{
			get
			{
				return this.sgt_aanvraagformulieridField;
			}
			set
			{
				this.sgt_aanvraagformulieridField = value;
			}
		}
		public Lookup sgt_bondsorganisatieid
		{
			get
			{
				return this.sgt_bondsorganisatieidField;
			}
			set
			{
				this.sgt_bondsorganisatieidField = value;
			}
		}
		[XmlElement("sgt_toe_toernooi_aanvraagrecht")]
		public string sgt_toe_toernooi_aanvraagrecht1
		{
			get
			{
				return this.sgt_toe_toernooi_aanvraagrecht1Field;
			}
			set
			{
				this.sgt_toe_toernooi_aanvraagrecht1Field = value;
			}
		}
		public Key sgt_toe_toernooi_aanvraagrechtid
		{
			get
			{
				return this.sgt_toe_toernooi_aanvraagrechtidField;
			}
			set
			{
				this.sgt_toe_toernooi_aanvraagrechtidField = value;
			}
		}
		public Lookup sgt_toernooiorganisatieid
		{
			get
			{
				return this.sgt_toernooiorganisatieidField;
			}
			set
			{
				this.sgt_toernooiorganisatieidField = value;
			}
		}
		public Lookup sgt_toernooisoortid
		{
			get
			{
				return this.sgt_toernooisoortidField;
			}
			set
			{
				this.sgt_toernooisoortidField = value;
			}
		}
		public CrmBoolean sgt_vorig_jaar
		{
			get
			{
				return this.sgt_vorig_jaarField;
			}
			set
			{
				this.sgt_vorig_jaarField = value;
			}
		}
		public Sgt_toe_toernooi_aanvraagrechtStateInfo statecode
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
