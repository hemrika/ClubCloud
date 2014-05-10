using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_com_ploeg : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private string sgt_aangepaste_ploegnaamField;
		private CrmDateTime sgt_aanmelddatumField;
		private Key sgt_com_ploegidField;
		private string sgt_com_ploegnaamField;
		private Lookup sgt_competitie_idField;
		private Lookup sgt_competitieinschrijvingidField;
		private Lookup sgt_klassegroep_idField;
		private Lookup sgt_piramideidField;
		private CrmBoolean sgt_ploegen_op_zelfde_dag_en_dagdeelField;
		private Lookup sgt_ploegidField;
		private CrmNumber sgt_ploegnummerField;
		private string sgt_promotie_toelichtingField;
		private CrmBoolean sgt_spelen_op_1_locatie_mogelijkField;
		private Lookup sgt_vereniging_idField;
		private Lookup sgt_verzoekklasse_idField;
		private Sgt_com_ploegStateInfo statecodeField;
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
		public string sgt_aangepaste_ploegnaam
		{
			get
			{
				return this.sgt_aangepaste_ploegnaamField;
			}
			set
			{
				this.sgt_aangepaste_ploegnaamField = value;
			}
		}
		public CrmDateTime sgt_aanmelddatum
		{
			get
			{
				return this.sgt_aanmelddatumField;
			}
			set
			{
				this.sgt_aanmelddatumField = value;
			}
		}
		public Key sgt_com_ploegid
		{
			get
			{
				return this.sgt_com_ploegidField;
			}
			set
			{
				this.sgt_com_ploegidField = value;
			}
		}
		public string sgt_com_ploegnaam
		{
			get
			{
				return this.sgt_com_ploegnaamField;
			}
			set
			{
				this.sgt_com_ploegnaamField = value;
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
		public Lookup sgt_competitieinschrijvingid
		{
			get
			{
				return this.sgt_competitieinschrijvingidField;
			}
			set
			{
				this.sgt_competitieinschrijvingidField = value;
			}
		}
		public Lookup sgt_klassegroep_id
		{
			get
			{
				return this.sgt_klassegroep_idField;
			}
			set
			{
				this.sgt_klassegroep_idField = value;
			}
		}
		public Lookup sgt_piramideid
		{
			get
			{
				return this.sgt_piramideidField;
			}
			set
			{
				this.sgt_piramideidField = value;
			}
		}
		public CrmBoolean sgt_ploegen_op_zelfde_dag_en_dagdeel
		{
			get
			{
				return this.sgt_ploegen_op_zelfde_dag_en_dagdeelField;
			}
			set
			{
				this.sgt_ploegen_op_zelfde_dag_en_dagdeelField = value;
			}
		}
		public Lookup sgt_ploegid
		{
			get
			{
				return this.sgt_ploegidField;
			}
			set
			{
				this.sgt_ploegidField = value;
			}
		}
		public CrmNumber sgt_ploegnummer
		{
			get
			{
				return this.sgt_ploegnummerField;
			}
			set
			{
				this.sgt_ploegnummerField = value;
			}
		}
		public string sgt_promotie_toelichting
		{
			get
			{
				return this.sgt_promotie_toelichtingField;
			}
			set
			{
				this.sgt_promotie_toelichtingField = value;
			}
		}
		public CrmBoolean sgt_spelen_op_1_locatie_mogelijk
		{
			get
			{
				return this.sgt_spelen_op_1_locatie_mogelijkField;
			}
			set
			{
				this.sgt_spelen_op_1_locatie_mogelijkField = value;
			}
		}
		public Lookup sgt_vereniging_id
		{
			get
			{
				return this.sgt_vereniging_idField;
			}
			set
			{
				this.sgt_vereniging_idField = value;
			}
		}
		public Lookup sgt_verzoekklasse_id
		{
			get
			{
				return this.sgt_verzoekklasse_idField;
			}
			set
			{
				this.sgt_verzoekklasse_idField = value;
			}
		}
		public Sgt_com_ploegStateInfo statecode
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
