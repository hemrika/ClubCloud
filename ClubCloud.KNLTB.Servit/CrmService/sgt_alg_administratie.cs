using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_alg_administratie : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup organizationidField;
		private CrmDateTime overriddencreatedonField;
		private Key sgt_alg_administratieidField;
		private string sgt_alg_nummerField;
		private string sgt_ba_plaatsField;
		private string sgt_ba_postcodeField;
		private string sgt_ba_straatField;
		private Lookup sgt_basisorganisatieidField;
		private string sgt_btwnrField;
		private Lookup sgt_districtidField;
		private string sgt_emailadresField;
		private string sgt_faxField;
		private string sgt_huidig_nummerField;
		private string sgt_kvknummerField;
		private string sgt_masker_volgnummerField;
		private string sgt_naam_administratieField;
		private string sgt_pa_plaatsField;
		private string sgt_pa_postcodeField;
		private string sgt_pa_straatField;
		private CrmBoolean sgt_primaire_administratieField;
		private string sgt_rekening_1Field;
		private string sgt_rekening_2Field;
		private string sgt_telefoonnummerField;
		private Sgt_alg_administratieStateInfo statecodeField;
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
		public Lookup organizationid
		{
			get
			{
				return this.organizationidField;
			}
			set
			{
				this.organizationidField = value;
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
		public Key sgt_alg_administratieid
		{
			get
			{
				return this.sgt_alg_administratieidField;
			}
			set
			{
				this.sgt_alg_administratieidField = value;
			}
		}
		public string sgt_alg_nummer
		{
			get
			{
				return this.sgt_alg_nummerField;
			}
			set
			{
				this.sgt_alg_nummerField = value;
			}
		}
		public string sgt_ba_plaats
		{
			get
			{
				return this.sgt_ba_plaatsField;
			}
			set
			{
				this.sgt_ba_plaatsField = value;
			}
		}
		public string sgt_ba_postcode
		{
			get
			{
				return this.sgt_ba_postcodeField;
			}
			set
			{
				this.sgt_ba_postcodeField = value;
			}
		}
		public string sgt_ba_straat
		{
			get
			{
				return this.sgt_ba_straatField;
			}
			set
			{
				this.sgt_ba_straatField = value;
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
		public string sgt_btwnr
		{
			get
			{
				return this.sgt_btwnrField;
			}
			set
			{
				this.sgt_btwnrField = value;
			}
		}
		public Lookup sgt_districtid
		{
			get
			{
				return this.sgt_districtidField;
			}
			set
			{
				this.sgt_districtidField = value;
			}
		}
		public string sgt_emailadres
		{
			get
			{
				return this.sgt_emailadresField;
			}
			set
			{
				this.sgt_emailadresField = value;
			}
		}
		public string sgt_fax
		{
			get
			{
				return this.sgt_faxField;
			}
			set
			{
				this.sgt_faxField = value;
			}
		}
		public string sgt_huidig_nummer
		{
			get
			{
				return this.sgt_huidig_nummerField;
			}
			set
			{
				this.sgt_huidig_nummerField = value;
			}
		}
		public string sgt_kvknummer
		{
			get
			{
				return this.sgt_kvknummerField;
			}
			set
			{
				this.sgt_kvknummerField = value;
			}
		}
		public string sgt_masker_volgnummer
		{
			get
			{
				return this.sgt_masker_volgnummerField;
			}
			set
			{
				this.sgt_masker_volgnummerField = value;
			}
		}
		public string sgt_naam_administratie
		{
			get
			{
				return this.sgt_naam_administratieField;
			}
			set
			{
				this.sgt_naam_administratieField = value;
			}
		}
		public string sgt_pa_plaats
		{
			get
			{
				return this.sgt_pa_plaatsField;
			}
			set
			{
				this.sgt_pa_plaatsField = value;
			}
		}
		public string sgt_pa_postcode
		{
			get
			{
				return this.sgt_pa_postcodeField;
			}
			set
			{
				this.sgt_pa_postcodeField = value;
			}
		}
		public string sgt_pa_straat
		{
			get
			{
				return this.sgt_pa_straatField;
			}
			set
			{
				this.sgt_pa_straatField = value;
			}
		}
		public CrmBoolean sgt_primaire_administratie
		{
			get
			{
				return this.sgt_primaire_administratieField;
			}
			set
			{
				this.sgt_primaire_administratieField = value;
			}
		}
		public string sgt_rekening_1
		{
			get
			{
				return this.sgt_rekening_1Field;
			}
			set
			{
				this.sgt_rekening_1Field = value;
			}
		}
		public string sgt_rekening_2
		{
			get
			{
				return this.sgt_rekening_2Field;
			}
			set
			{
				this.sgt_rekening_2Field = value;
			}
		}
		public string sgt_telefoonnummer
		{
			get
			{
				return this.sgt_telefoonnummerField;
			}
			set
			{
				this.sgt_telefoonnummerField = value;
			}
		}
		public Sgt_alg_administratieStateInfo statecode
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
