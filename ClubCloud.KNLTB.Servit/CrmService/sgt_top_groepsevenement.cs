using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_top_groepsevenement : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private string sgt_aantal_banenField;
		private Lookup sgt_accommodatieidField;
		private Lookup sgt_begeleideridField;
		private CrmDateTime sgt_datum_en_tijd_aanvangField;
		private CrmDateTime sgt_datum_en_tijd_eindeField;
		private Lookup sgt_groepidField;
		private string sgt_opmerkingField;
		private Lookup sgt_soortevenementidField;
		private Picklist sgt_top_dagField;
		private string sgt_top_groepsevenement1Field;
		private Key sgt_top_groepsevenementidField;
		private Sgt_top_groepsevenementStateInfo statecodeField;
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
		public string sgt_aantal_banen
		{
			get
			{
				return this.sgt_aantal_banenField;
			}
			set
			{
				this.sgt_aantal_banenField = value;
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
		public Lookup sgt_begeleiderid
		{
			get
			{
				return this.sgt_begeleideridField;
			}
			set
			{
				this.sgt_begeleideridField = value;
			}
		}
		public CrmDateTime sgt_datum_en_tijd_aanvang
		{
			get
			{
				return this.sgt_datum_en_tijd_aanvangField;
			}
			set
			{
				this.sgt_datum_en_tijd_aanvangField = value;
			}
		}
		public CrmDateTime sgt_datum_en_tijd_einde
		{
			get
			{
				return this.sgt_datum_en_tijd_eindeField;
			}
			set
			{
				this.sgt_datum_en_tijd_eindeField = value;
			}
		}
		public Lookup sgt_groepid
		{
			get
			{
				return this.sgt_groepidField;
			}
			set
			{
				this.sgt_groepidField = value;
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
		public Lookup sgt_soortevenementid
		{
			get
			{
				return this.sgt_soortevenementidField;
			}
			set
			{
				this.sgt_soortevenementidField = value;
			}
		}
		public Picklist sgt_top_dag
		{
			get
			{
				return this.sgt_top_dagField;
			}
			set
			{
				this.sgt_top_dagField = value;
			}
		}
		[XmlElement("sgt_top_groepsevenement")]
		public string sgt_top_groepsevenement1
		{
			get
			{
				return this.sgt_top_groepsevenement1Field;
			}
			set
			{
				this.sgt_top_groepsevenement1Field = value;
			}
		}
		public Key sgt_top_groepsevenementid
		{
			get
			{
				return this.sgt_top_groepsevenementidField;
			}
			set
			{
				this.sgt_top_groepsevenementidField = value;
			}
		}
		public Sgt_top_groepsevenementStateInfo statecode
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
