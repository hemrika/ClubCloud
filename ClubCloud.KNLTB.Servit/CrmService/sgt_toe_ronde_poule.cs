using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_toe_ronde_poule : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private Lookup sgt_accommodatieidField;
		private CrmBoolean sgt_eerste_wedstrijdField;
		private string sgt_pouleField;
		private Lookup sgt_speelschemaidField;
		private string sgt_toe_ronde_poule1Field;
		private Key sgt_toe_ronde_pouleidField;
		private Picklist sgt_type_rondeField;
		private string sgt_volgnummer_ronde_pouleField;
		private Sgt_toe_ronde_pouleStateInfo statecodeField;
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
		public Lookup sgt_accommodatieid
		{
			get
			{
				return this.sgt_accommodatieidField;
			}
			set
			{
				this.sgt_accommodatieidField = value;
			}
		}
		public CrmBoolean sgt_eerste_wedstrijd
		{
			get
			{
				return this.sgt_eerste_wedstrijdField;
			}
			set
			{
				this.sgt_eerste_wedstrijdField = value;
			}
		}
		public string sgt_poule
		{
			get
			{
				return this.sgt_pouleField;
			}
			set
			{
				this.sgt_pouleField = value;
			}
		}
		public Lookup sgt_speelschemaid
		{
			get
			{
				return this.sgt_speelschemaidField;
			}
			set
			{
				this.sgt_speelschemaidField = value;
			}
		}
		[XmlElement("sgt_toe_ronde_poule")]
		public string sgt_toe_ronde_poule1
		{
			get
			{
				return this.sgt_toe_ronde_poule1Field;
			}
			set
			{
				this.sgt_toe_ronde_poule1Field = value;
			}
		}
		public Key sgt_toe_ronde_pouleid
		{
			get
			{
				return this.sgt_toe_ronde_pouleidField;
			}
			set
			{
				this.sgt_toe_ronde_pouleidField = value;
			}
		}
		public Picklist sgt_type_ronde
		{
			get
			{
				return this.sgt_type_rondeField;
			}
			set
			{
				this.sgt_type_rondeField = value;
			}
		}
		public string sgt_volgnummer_ronde_poule
		{
			get
			{
				return this.sgt_volgnummer_ronde_pouleField;
			}
			set
			{
				this.sgt_volgnummer_ronde_pouleField = value;
			}
		}
		public Sgt_toe_ronde_pouleStateInfo statecode
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
