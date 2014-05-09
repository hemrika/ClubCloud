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
		[XmlElement(Order = 0)]
		public Lookup createdby
		{
			get
			{
				return this.createdbyField;
			}
			set
			{
				this.createdbyField = value;
				base.RaisePropertyChanged("createdby");
			}
		}
		[XmlElement(Order = 1)]
		public CrmDateTime createdon
		{
			get
			{
				return this.createdonField;
			}
			set
			{
				this.createdonField = value;
				base.RaisePropertyChanged("createdon");
			}
		}
		[XmlElement(Order = 2)]
		public CrmNumber importsequencenumber
		{
			get
			{
				return this.importsequencenumberField;
			}
			set
			{
				this.importsequencenumberField = value;
				base.RaisePropertyChanged("importsequencenumber");
			}
		}
		[XmlElement(Order = 3)]
		public Lookup modifiedby
		{
			get
			{
				return this.modifiedbyField;
			}
			set
			{
				this.modifiedbyField = value;
				base.RaisePropertyChanged("modifiedby");
			}
		}
		[XmlElement(Order = 4)]
		public CrmDateTime modifiedon
		{
			get
			{
				return this.modifiedonField;
			}
			set
			{
				this.modifiedonField = value;
				base.RaisePropertyChanged("modifiedon");
			}
		}
		[XmlElement(Order = 5)]
		public CrmDateTime overriddencreatedon
		{
			get
			{
				return this.overriddencreatedonField;
			}
			set
			{
				this.overriddencreatedonField = value;
				base.RaisePropertyChanged("overriddencreatedon");
			}
		}
		[XmlElement(Order = 6)]
		public Owner ownerid
		{
			get
			{
				return this.owneridField;
			}
			set
			{
				this.owneridField = value;
				base.RaisePropertyChanged("ownerid");
			}
		}
		[XmlElement(Order = 7)]
		public Lookup owningbusinessunit
		{
			get
			{
				return this.owningbusinessunitField;
			}
			set
			{
				this.owningbusinessunitField = value;
				base.RaisePropertyChanged("owningbusinessunit");
			}
		}
		[XmlElement(Order = 8)]
		public Key sgt_alg_abonneeid
		{
			get
			{
				return this.sgt_alg_abonneeidField;
			}
			set
			{
				this.sgt_alg_abonneeidField = value;
				base.RaisePropertyChanged("sgt_alg_abonneeid");
			}
		}
		[XmlElement(Order = 9)]
		public string sgt_alg_name
		{
			get
			{
				return this.sgt_alg_nameField;
			}
			set
			{
				this.sgt_alg_nameField = value;
				base.RaisePropertyChanged("sgt_alg_name");
			}
		}
		[XmlElement(Order = 10)]
		public CrmDateTime sgt_datum_t_m
		{
			get
			{
				return this.sgt_datum_t_mField;
			}
			set
			{
				this.sgt_datum_t_mField = value;
				base.RaisePropertyChanged("sgt_datum_t_m");
			}
		}
		[XmlElement(Order = 11)]
		public CrmDateTime sgt_datum_vanaf
		{
			get
			{
				return this.sgt_datum_vanafField;
			}
			set
			{
				this.sgt_datum_vanafField = value;
				base.RaisePropertyChanged("sgt_datum_vanaf");
			}
		}
		[XmlElement(Order = 12)]
		public CrmBoolean sgt_gratis_abonnement
		{
			get
			{
				return this.sgt_gratis_abonnementField;
			}
			set
			{
				this.sgt_gratis_abonnementField = value;
				base.RaisePropertyChanged("sgt_gratis_abonnement");
			}
		}
		[XmlElement(Order = 13)]
		public Lookup sgt_persoonid
		{
			get
			{
				return this.sgt_persoonidField;
			}
			set
			{
				this.sgt_persoonidField = value;
				base.RaisePropertyChanged("sgt_persoonid");
			}
		}
		[XmlElement(Order = 14)]
		public Picklist sgt_reden_abonnement_cc
		{
			get
			{
				return this.sgt_reden_abonnement_ccField;
			}
			set
			{
				this.sgt_reden_abonnement_ccField = value;
				base.RaisePropertyChanged("sgt_reden_abonnement_cc");
			}
		}
		[XmlElement(Order = 15)]
		public Lookup sgt_soort_abonnementid
		{
			get
			{
				return this.sgt_soort_abonnementidField;
			}
			set
			{
				this.sgt_soort_abonnementidField = value;
				base.RaisePropertyChanged("sgt_soort_abonnementid");
			}
		}
		[XmlElement(Order = 16)]
		public Lookup sgt_verenigingid
		{
			get
			{
				return this.sgt_verenigingidField;
			}
			set
			{
				this.sgt_verenigingidField = value;
				base.RaisePropertyChanged("sgt_verenigingid");
			}
		}
		[XmlElement(Order = 17)]
		public CrmBoolean sgt_zichtbaar_op_mijnknltb
		{
			get
			{
				return this.sgt_zichtbaar_op_mijnknltbField;
			}
			set
			{
				this.sgt_zichtbaar_op_mijnknltbField = value;
				base.RaisePropertyChanged("sgt_zichtbaar_op_mijnknltb");
			}
		}
		[XmlElement(Order = 18)]
		public Sgt_alg_abonneeStateInfo statecode
		{
			get
			{
				return this.statecodeField;
			}
			set
			{
				this.statecodeField = value;
				base.RaisePropertyChanged("statecode");
			}
		}
		[XmlElement(Order = 19)]
		public Status statuscode
		{
			get
			{
				return this.statuscodeField;
			}
			set
			{
				this.statuscodeField = value;
				base.RaisePropertyChanged("statuscode");
			}
		}
		[XmlElement(Order = 20)]
		public CrmNumber timezoneruleversionnumber
		{
			get
			{
				return this.timezoneruleversionnumberField;
			}
			set
			{
				this.timezoneruleversionnumberField = value;
				base.RaisePropertyChanged("timezoneruleversionnumber");
			}
		}
		[XmlElement(Order = 21)]
		public CrmNumber utcconversiontimezonecode
		{
			get
			{
				return this.utcconversiontimezonecodeField;
			}
			set
			{
				this.utcconversiontimezonecodeField = value;
				base.RaisePropertyChanged("utcconversiontimezonecode");
			}
		}
	}
}
