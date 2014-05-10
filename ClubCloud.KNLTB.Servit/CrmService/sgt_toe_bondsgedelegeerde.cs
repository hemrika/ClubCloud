using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_toe_bondsgedelegeerde : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private Lookup sgt_bondsgedelegeerde_idField;
		private CrmBoolean sgt_e_mail_zichtbaarField;
		private CrmBoolean sgt_mobiel_zichtbaarField;
		private string sgt_opmerkingenField;
		private CrmBoolean sgt_overdag_beschikbaarField;
		private CrmBoolean sgt_telefoon_zichtbaarField;
		private string sgt_toe_bondsgedelegeerde1Field;
		private Key sgt_toe_bondsgedelegeerdeidField;
		private Lookup sgt_toernooikalender_idField;
		private Sgt_toe_bondsgedelegeerdeStateInfo statecodeField;
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
		public Lookup sgt_bondsgedelegeerde_id
		{
			get
			{
				return this.sgt_bondsgedelegeerde_idField;
			}
			set
			{
				this.sgt_bondsgedelegeerde_idField = value;
			}
		}
		public CrmBoolean sgt_e_mail_zichtbaar
		{
			get
			{
				return this.sgt_e_mail_zichtbaarField;
			}
			set
			{
				this.sgt_e_mail_zichtbaarField = value;
			}
		}
		public CrmBoolean sgt_mobiel_zichtbaar
		{
			get
			{
				return this.sgt_mobiel_zichtbaarField;
			}
			set
			{
				this.sgt_mobiel_zichtbaarField = value;
			}
		}
		public string sgt_opmerkingen
		{
			get
			{
				return this.sgt_opmerkingenField;
			}
			set
			{
				this.sgt_opmerkingenField = value;
			}
		}
		public CrmBoolean sgt_overdag_beschikbaar
		{
			get
			{
				return this.sgt_overdag_beschikbaarField;
			}
			set
			{
				this.sgt_overdag_beschikbaarField = value;
			}
		}
		public CrmBoolean sgt_telefoon_zichtbaar
		{
			get
			{
				return this.sgt_telefoon_zichtbaarField;
			}
			set
			{
				this.sgt_telefoon_zichtbaarField = value;
			}
		}
		[XmlElement("sgt_toe_bondsgedelegeerde")]
		public string sgt_toe_bondsgedelegeerde1
		{
			get
			{
				return this.sgt_toe_bondsgedelegeerde1Field;
			}
			set
			{
				this.sgt_toe_bondsgedelegeerde1Field = value;
			}
		}
		public Key sgt_toe_bondsgedelegeerdeid
		{
			get
			{
				return this.sgt_toe_bondsgedelegeerdeidField;
			}
			set
			{
				this.sgt_toe_bondsgedelegeerdeidField = value;
			}
		}
		public Lookup sgt_toernooikalender_id
		{
			get
			{
				return this.sgt_toernooikalender_idField;
			}
			set
			{
				this.sgt_toernooikalender_idField = value;
			}
		}
		public Sgt_toe_bondsgedelegeerdeStateInfo statecode
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
