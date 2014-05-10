using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_alg_abonnee : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private Key sgt_alg_abonneeidField;
		private string sgt_alg_nameField;
		private CrmDateTime sgt_datum_t_mField;
		private CrmDateTime sgt_datum_vanafField;
		private CrmBoolean sgt_gratis_abonnementField;
		private Lookup sgt_persoonidField;
		private Picklist sgt_reden_abonnement_ccField;
		private Lookup sgt_soort_abonnementidField;
		private Lookup sgt_verenigingidField;
		private CrmBoolean sgt_zichtbaar_op_mijnknltbField;
		private Sgt_alg_abonneeStateInfo statecodeField;
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
		public Key sgt_alg_abonneeid
		{
			get
			{
				return this.sgt_alg_abonneeidField;
			}
			set
			{
				this.sgt_alg_abonneeidField = value;
			}
		}
		public string sgt_alg_name
		{
			get
			{
				return this.sgt_alg_nameField;
			}
			set
			{
				this.sgt_alg_nameField = value;
			}
		}
		public CrmDateTime sgt_datum_t_m
		{
			get
			{
				return this.sgt_datum_t_mField;
			}
			set
			{
				this.sgt_datum_t_mField = value;
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
		public CrmBoolean sgt_gratis_abonnement
		{
			get
			{
				return this.sgt_gratis_abonnementField;
			}
			set
			{
				this.sgt_gratis_abonnementField = value;
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
		public Picklist sgt_reden_abonnement_cc
		{
			get
			{
				return this.sgt_reden_abonnement_ccField;
			}
			set
			{
				this.sgt_reden_abonnement_ccField = value;
			}
		}
		public Lookup sgt_soort_abonnementid
		{
			get
			{
				return this.sgt_soort_abonnementidField;
			}
			set
			{
				this.sgt_soort_abonnementidField = value;
			}
		}
		public Lookup sgt_verenigingid
		{
			get
			{
				return this.sgt_verenigingidField;
			}
			set
			{
				this.sgt_verenigingidField = value;
			}
		}
		public CrmBoolean sgt_zichtbaar_op_mijnknltb
		{
			get
			{
				return this.sgt_zichtbaar_op_mijnknltbField;
			}
			set
			{
				this.sgt_zichtbaar_op_mijnknltbField = value;
			}
		}
		public Sgt_alg_abonneeStateInfo statecode
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
