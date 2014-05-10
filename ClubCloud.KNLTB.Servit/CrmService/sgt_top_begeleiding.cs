using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_top_begeleiding : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private CrmDateTime sgt_datum_tmField;
		private CrmDateTime sgt_datum_vanafField;
		private Picklist sgt_functioneert_alsField;
		private string sgt_opmerkingField;
		private Lookup sgt_persoonlijkebegeleideridField;
		private string sgt_rol_andersField;
		private Lookup sgt_tennisseridField;
		private string sgt_top_begeleiding1Field;
		private Key sgt_top_begeleidingidField;
		private Sgt_top_begeleidingStateInfo statecodeField;
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
		public CrmDateTime sgt_datum_tm
		{
			get
			{
				return this.sgt_datum_tmField;
			}
			set
			{
				this.sgt_datum_tmField = value;
			}
		}
		public CrmDateTime sgt_datum_vanaf
		{
			get
			{
				return this.sgt_datum_vanafField;
			}
			set
			{
				this.sgt_datum_vanafField = value;
			}
		}
		public Picklist sgt_functioneert_als
		{
			get
			{
				return this.sgt_functioneert_alsField;
			}
			set
			{
				this.sgt_functioneert_alsField = value;
			}
		}
		public string sgt_opmerking
		{
			get
			{
				return this.sgt_opmerkingField;
			}
			set
			{
				this.sgt_opmerkingField = value;
			}
		}
		public Lookup sgt_persoonlijkebegeleiderid
		{
			get
			{
				return this.sgt_persoonlijkebegeleideridField;
			}
			set
			{
				this.sgt_persoonlijkebegeleideridField = value;
			}
		}
		public string sgt_rol_anders
		{
			get
			{
				return this.sgt_rol_andersField;
			}
			set
			{
				this.sgt_rol_andersField = value;
			}
		}
		public Lookup sgt_tennisserid
		{
			get
			{
				return this.sgt_tennisseridField;
			}
			set
			{
				this.sgt_tennisseridField = value;
			}
		}
		[XmlElement("sgt_top_begeleiding")]
		public string sgt_top_begeleiding1
		{
			get
			{
				return this.sgt_top_begeleiding1Field;
			}
			set
			{
				this.sgt_top_begeleiding1Field = value;
			}
		}
		public Key sgt_top_begeleidingid
		{
			get
			{
				return this.sgt_top_begeleidingidField;
			}
			set
			{
				this.sgt_top_begeleidingidField = value;
			}
		}
		public Sgt_top_begeleidingStateInfo statecode
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
