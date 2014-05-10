using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_com_competitietype : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup organizationidField;
		private CrmDateTime overriddencreatedonField;
		private string sgt_beschrijvingField;
		private string sgt_com_competitietype1Field;
		private Key sgt_com_competitietypeidField;
		private CrmBoolean sgt_controle_vcl_certificaatField;
		private string sgt_meervoudsnaamField;
		private string sgt_omschrijvingField;
		private Picklist sgt_openstellen_voorField;
		private CrmBoolean sgt_resultaten_tellen_mee_voor_dssField;
		private string sgt_verkorte_codeField;
		private Sgt_com_competitietypeStateInfo statecodeField;
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
		[XmlElement("sgt_com_competitietype")]
		public string sgt_com_competitietype1
		{
			get
			{
				return this.sgt_com_competitietype1Field;
			}
			set
			{
				this.sgt_com_competitietype1Field = value;
			}
		}
		public Key sgt_com_competitietypeid
		{
			get
			{
				return this.sgt_com_competitietypeidField;
			}
			set
			{
				this.sgt_com_competitietypeidField = value;
			}
		}
		public CrmBoolean sgt_controle_vcl_certificaat
		{
			get
			{
				return this.sgt_controle_vcl_certificaatField;
			}
			set
			{
				this.sgt_controle_vcl_certificaatField = value;
			}
		}
		public string sgt_meervoudsnaam
		{
			get
			{
				return this.sgt_meervoudsnaamField;
			}
			set
			{
				this.sgt_meervoudsnaamField = value;
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
		public Picklist sgt_openstellen_voor
		{
			get
			{
				return this.sgt_openstellen_voorField;
			}
			set
			{
				this.sgt_openstellen_voorField = value;
			}
		}
		public CrmBoolean sgt_resultaten_tellen_mee_voor_dss
		{
			get
			{
				return this.sgt_resultaten_tellen_mee_voor_dssField;
			}
			set
			{
				this.sgt_resultaten_tellen_mee_voor_dssField = value;
			}
		}
		public string sgt_verkorte_code
		{
			get
			{
				return this.sgt_verkorte_codeField;
			}
			set
			{
				this.sgt_verkorte_codeField = value;
			}
		}
		public Sgt_com_competitietypeStateInfo statecode
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
