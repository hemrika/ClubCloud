using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_com_beslissingswedstrijd : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private Lookup sgt_afdeling_idField;
		private string sgt_com_beslissingswedstrijd1Field;
		private Key sgt_com_beslissingswedstrijdidField;
		private Lookup sgt_competitie_idField;
		private Lookup sgt_klassengroep_idField;
		private CrmBoolean sgt_lotingField;
		private Lookup sgt_piramide_idField;
		private Lookup sgt_ploeg_thuis_idField;
		private Lookup sgt_ploeg_uit_idField;
		private CrmDateTime sgt_speeldatumField;
		private Picklist sgt_typeField;
		private Picklist sgt_uitslagField;
		private Lookup sgt_wedstrijdgegevens_idField;
		private Sgt_com_beslissingswedstrijdStateInfo statecodeField;
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
		public Lookup sgt_afdeling_id
		{
			get
			{
				return this.sgt_afdeling_idField;
			}
			set
			{
				this.sgt_afdeling_idField = value;
			}
		}
		[XmlElement("sgt_com_beslissingswedstrijd")]
		public string sgt_com_beslissingswedstrijd1
		{
			get
			{
				return this.sgt_com_beslissingswedstrijd1Field;
			}
			set
			{
				this.sgt_com_beslissingswedstrijd1Field = value;
			}
		}
		public Key sgt_com_beslissingswedstrijdid
		{
			get
			{
				return this.sgt_com_beslissingswedstrijdidField;
			}
			set
			{
				this.sgt_com_beslissingswedstrijdidField = value;
			}
		}
		public Lookup sgt_competitie_id
		{
			get
			{
				return this.sgt_competitie_idField;
			}
			set
			{
				this.sgt_competitie_idField = value;
			}
		}
		public Lookup sgt_klassengroep_id
		{
			get
			{
				return this.sgt_klassengroep_idField;
			}
			set
			{
				this.sgt_klassengroep_idField = value;
			}
		}
		public CrmBoolean sgt_loting
		{
			get
			{
				return this.sgt_lotingField;
			}
			set
			{
				this.sgt_lotingField = value;
			}
		}
		public Lookup sgt_piramide_id
		{
			get
			{
				return this.sgt_piramide_idField;
			}
			set
			{
				this.sgt_piramide_idField = value;
			}
		}
		public Lookup sgt_ploeg_thuis_id
		{
			get
			{
				return this.sgt_ploeg_thuis_idField;
			}
			set
			{
				this.sgt_ploeg_thuis_idField = value;
			}
		}
		public Lookup sgt_ploeg_uit_id
		{
			get
			{
				return this.sgt_ploeg_uit_idField;
			}
			set
			{
				this.sgt_ploeg_uit_idField = value;
			}
		}
		public CrmDateTime sgt_speeldatum
		{
			get
			{
				return this.sgt_speeldatumField;
			}
			set
			{
				this.sgt_speeldatumField = value;
			}
		}
		public Picklist sgt_type
		{
			get
			{
				return this.sgt_typeField;
			}
			set
			{
				this.sgt_typeField = value;
			}
		}
		public Picklist sgt_uitslag
		{
			get
			{
				return this.sgt_uitslagField;
			}
			set
			{
				this.sgt_uitslagField = value;
			}
		}
		public Lookup sgt_wedstrijdgegevens_id
		{
			get
			{
				return this.sgt_wedstrijdgegevens_idField;
			}
			set
			{
				this.sgt_wedstrijdgegevens_idField = value;
			}
		}
		public Sgt_com_beslissingswedstrijdStateInfo statecode
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
