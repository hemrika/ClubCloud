using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_alg_servit1_contacthistorie : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private string sgt_alg_onderwerpField;
		private Key sgt_alg_servit1_contacthistorieidField;
		private Lookup sgt_basisorganisatieidField;
		private string sgt_beschrijvingField;
		private string sgt_bondsmedewerkerField;
		private string sgt_contact_vormField;
		private string sgt_contactpersoonField;
		private CrmDateTime sgt_datum_af_te_handelen_voorField;
		private CrmDateTime sgt_datum_afgeslotenField;
		private CrmDateTime sgt_datum_contactField;
		private Lookup sgt_persoonidField;
		private string sgt_soort_contactField;
		private Sgt_alg_servit1_contacthistorieStateInfo statecodeField;
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
		public string sgt_alg_onderwerp
		{
			get
			{
				return this.sgt_alg_onderwerpField;
			}
			set
			{
				this.sgt_alg_onderwerpField = value;
			}
		}
		public Key sgt_alg_servit1_contacthistorieid
		{
			get
			{
				return this.sgt_alg_servit1_contacthistorieidField;
			}
			set
			{
				this.sgt_alg_servit1_contacthistorieidField = value;
			}
		}
		public Lookup sgt_basisorganisatieid
		{
			get
			{
				return this.sgt_basisorganisatieidField;
			}
			set
			{
				this.sgt_basisorganisatieidField = value;
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
		public string sgt_bondsmedewerker
		{
			get
			{
				return this.sgt_bondsmedewerkerField;
			}
			set
			{
				this.sgt_bondsmedewerkerField = value;
			}
		}
		public string sgt_contact_vorm
		{
			get
			{
				return this.sgt_contact_vormField;
			}
			set
			{
				this.sgt_contact_vormField = value;
			}
		}
		public string sgt_contactpersoon
		{
			get
			{
				return this.sgt_contactpersoonField;
			}
			set
			{
				this.sgt_contactpersoonField = value;
			}
		}
		public CrmDateTime sgt_datum_af_te_handelen_voor
		{
			get
			{
				return this.sgt_datum_af_te_handelen_voorField;
			}
			set
			{
				this.sgt_datum_af_te_handelen_voorField = value;
			}
		}
		public CrmDateTime sgt_datum_afgesloten
		{
			get
			{
				return this.sgt_datum_afgeslotenField;
			}
			set
			{
				this.sgt_datum_afgeslotenField = value;
			}
		}
		public CrmDateTime sgt_datum_contact
		{
			get
			{
				return this.sgt_datum_contactField;
			}
			set
			{
				this.sgt_datum_contactField = value;
			}
		}
		public Lookup sgt_persoonid
		{
			get
			{
				return this.sgt_persoonidField;
			}
			set
			{
				this.sgt_persoonidField = value;
			}
		}
		public string sgt_soort_contact
		{
			get
			{
				return this.sgt_soort_contactField;
			}
			set
			{
				this.sgt_soort_contactField = value;
			}
		}
		public Sgt_alg_servit1_contacthistorieStateInfo statecode
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
