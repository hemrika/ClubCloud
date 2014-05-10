using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_com_controle_dispensatie : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private Key sgt_com_controle_dispensatieidField;
		private string sgt_com_naamField;
		private Lookup sgt_competitie_aidField;
		private Lookup sgt_competitie_bidField;
		private Lookup sgt_controle_dispensatie_logboekidField;
		private string sgt_extra_informatieField;
		private Lookup sgt_piramide_aidField;
		private Lookup sgt_piramide_bidField;
		private Lookup sgt_ploeg_aidField;
		private Lookup sgt_ploeg_bidField;
		private Picklist sgt_redenField;
		private Lookup sgt_speleridField;
		private Lookup sgt_spelersdispensatieidField;
		private Lookup sgt_vereniging_aidField;
		private Lookup sgt_vereniging_bidField;
		private Sgt_com_controle_dispensatieStateInfo statecodeField;
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
		public Key sgt_com_controle_dispensatieid
		{
			get
			{
				return this.sgt_com_controle_dispensatieidField;
			}
			set
			{
				this.sgt_com_controle_dispensatieidField = value;
			}
		}
		public string sgt_com_naam
		{
			get
			{
				return this.sgt_com_naamField;
			}
			set
			{
				this.sgt_com_naamField = value;
			}
		}
		public Lookup sgt_competitie_aid
		{
			get
			{
				return this.sgt_competitie_aidField;
			}
			set
			{
				this.sgt_competitie_aidField = value;
			}
		}
		public Lookup sgt_competitie_bid
		{
			get
			{
				return this.sgt_competitie_bidField;
			}
			set
			{
				this.sgt_competitie_bidField = value;
			}
		}
		public Lookup sgt_controle_dispensatie_logboekid
		{
			get
			{
				return this.sgt_controle_dispensatie_logboekidField;
			}
			set
			{
				this.sgt_controle_dispensatie_logboekidField = value;
			}
		}
		public string sgt_extra_informatie
		{
			get
			{
				return this.sgt_extra_informatieField;
			}
			set
			{
				this.sgt_extra_informatieField = value;
			}
		}
		public Lookup sgt_piramide_aid
		{
			get
			{
				return this.sgt_piramide_aidField;
			}
			set
			{
				this.sgt_piramide_aidField = value;
			}
		}
		public Lookup sgt_piramide_bid
		{
			get
			{
				return this.sgt_piramide_bidField;
			}
			set
			{
				this.sgt_piramide_bidField = value;
			}
		}
		public Lookup sgt_ploeg_aid
		{
			get
			{
				return this.sgt_ploeg_aidField;
			}
			set
			{
				this.sgt_ploeg_aidField = value;
			}
		}
		public Lookup sgt_ploeg_bid
		{
			get
			{
				return this.sgt_ploeg_bidField;
			}
			set
			{
				this.sgt_ploeg_bidField = value;
			}
		}
		public Picklist sgt_reden
		{
			get
			{
				return this.sgt_redenField;
			}
			set
			{
				this.sgt_redenField = value;
			}
		}
		public Lookup sgt_spelerid
		{
			get
			{
				return this.sgt_speleridField;
			}
			set
			{
				this.sgt_speleridField = value;
			}
		}
		public Lookup sgt_spelersdispensatieid
		{
			get
			{
				return this.sgt_spelersdispensatieidField;
			}
			set
			{
				this.sgt_spelersdispensatieidField = value;
			}
		}
		public Lookup sgt_vereniging_aid
		{
			get
			{
				return this.sgt_vereniging_aidField;
			}
			set
			{
				this.sgt_vereniging_aidField = value;
			}
		}
		public Lookup sgt_vereniging_bid
		{
			get
			{
				return this.sgt_vereniging_bidField;
			}
			set
			{
				this.sgt_vereniging_bidField = value;
			}
		}
		public Sgt_com_controle_dispensatieStateInfo statecode
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
