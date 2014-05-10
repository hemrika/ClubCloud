using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_alg_landcode : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup organizationidField;
		private CrmDateTime overriddencreatedonField;
		private CrmBoolean sgt_11_proefField;
		private string sgt_alg_landcode1Field;
		private Key sgt_alg_landcodeidField;
		private string sgt_formaat_bankrekeningField;
		private string sgt_formaat_postcodeField;
		private CrmBoolean sgt_huisnummer_voor_straatField;
		private string sgt_invoermasker_formaat_faxnummerField;
		private string sgt_invoermasker_formaat_telefoonField;
		private string sgt_ioc_landcodeField;
		private CrmBoolean sgt_lid_euField;
		private CrmBoolean sgt_lid_itfField;
		private string sgt_omschrijvingField;
		private CrmBoolean sgt_postcode_voor_plaatsField;
		private Sgt_alg_landcodeStateInfo statecodeField;
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
		public CrmBoolean sgt_11_proef
		{
			get
			{
				return this.sgt_11_proefField;
			}
			set
			{
				this.sgt_11_proefField = value;
			}
		}
		[XmlElement("sgt_alg_landcode")]
		public string sgt_alg_landcode1
		{
			get
			{
				return this.sgt_alg_landcode1Field;
			}
			set
			{
				this.sgt_alg_landcode1Field = value;
			}
		}
		public Key sgt_alg_landcodeid
		{
			get
			{
				return this.sgt_alg_landcodeidField;
			}
			set
			{
				this.sgt_alg_landcodeidField = value;
			}
		}
		public string sgt_formaat_bankrekening
		{
			get
			{
				return this.sgt_formaat_bankrekeningField;
			}
			set
			{
				this.sgt_formaat_bankrekeningField = value;
			}
		}
		public string sgt_formaat_postcode
		{
			get
			{
				return this.sgt_formaat_postcodeField;
			}
			set
			{
				this.sgt_formaat_postcodeField = value;
			}
		}
		public CrmBoolean sgt_huisnummer_voor_straat
		{
			get
			{
				return this.sgt_huisnummer_voor_straatField;
			}
			set
			{
				this.sgt_huisnummer_voor_straatField = value;
			}
		}
		public string sgt_invoermasker_formaat_faxnummer
		{
			get
			{
				return this.sgt_invoermasker_formaat_faxnummerField;
			}
			set
			{
				this.sgt_invoermasker_formaat_faxnummerField = value;
			}
		}
		public string sgt_invoermasker_formaat_telefoon
		{
			get
			{
				return this.sgt_invoermasker_formaat_telefoonField;
			}
			set
			{
				this.sgt_invoermasker_formaat_telefoonField = value;
			}
		}
		public string sgt_ioc_landcode
		{
			get
			{
				return this.sgt_ioc_landcodeField;
			}
			set
			{
				this.sgt_ioc_landcodeField = value;
			}
		}
		public CrmBoolean sgt_lid_eu
		{
			get
			{
				return this.sgt_lid_euField;
			}
			set
			{
				this.sgt_lid_euField = value;
			}
		}
		public CrmBoolean sgt_lid_itf
		{
			get
			{
				return this.sgt_lid_itfField;
			}
			set
			{
				this.sgt_lid_itfField = value;
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
		public CrmBoolean sgt_postcode_voor_plaats
		{
			get
			{
				return this.sgt_postcode_voor_plaatsField;
			}
			set
			{
				this.sgt_postcode_voor_plaatsField = value;
			}
		}
		public Sgt_alg_landcodeStateInfo statecode
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
