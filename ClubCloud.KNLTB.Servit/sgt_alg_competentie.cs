using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_alg_competentie : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmDecimal exchangerateField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup organizationidField;
		private CrmDateTime overriddencreatedonField;
		private Key sgt_alg_competentieidField;
		private string sgt_alg_nameField;
		private Picklist sgt_arbitrageinzet_niveauField;
		private Lookup sgt_functieidField;
		private Picklist sgt_geldig_voorField;
		private CrmMoney sgt_vergoeding_per_dagField;
		private CrmMoney sgt_vergoeding_per_dag_baseField;
		private Sgt_alg_competentieStateInfo statecodeField;
		private Status statuscodeField;
		private CrmNumber timezoneruleversionnumberField;
		private Lookup transactioncurrencyidField;
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
		public CrmDecimal exchangerate
		{
			get
			{
				return this.exchangerateField;
			}
			set
			{
				this.exchangerateField = value;
				base.RaisePropertyChanged("exchangerate");
			}
		}
		[XmlElement(Order = 3)]
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
		[XmlElement(Order = 4)]
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
		[XmlElement(Order = 5)]
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
		[XmlElement(Order = 6)]
		public Lookup organizationid
		{
			get
			{
				return this.organizationidField;
			}
			set
			{
				this.organizationidField = value;
				base.RaisePropertyChanged("organizationid");
			}
		}
		[XmlElement(Order = 7)]
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
		[XmlElement(Order = 8)]
		public Key sgt_alg_competentieid
		{
			get
			{
				return this.sgt_alg_competentieidField;
			}
			set
			{
				this.sgt_alg_competentieidField = value;
				base.RaisePropertyChanged("sgt_alg_competentieid");
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
		public Picklist sgt_arbitrageinzet_niveau
		{
			get
			{
				return this.sgt_arbitrageinzet_niveauField;
			}
			set
			{
				this.sgt_arbitrageinzet_niveauField = value;
				base.RaisePropertyChanged("sgt_arbitrageinzet_niveau");
			}
		}
		[XmlElement(Order = 11)]
		public Lookup sgt_functieid
		{
			get
			{
				return this.sgt_functieidField;
			}
			set
			{
				this.sgt_functieidField = value;
				base.RaisePropertyChanged("sgt_functieid");
			}
		}
		[XmlElement(Order = 12)]
		public Picklist sgt_geldig_voor
		{
			get
			{
				return this.sgt_geldig_voorField;
			}
			set
			{
				this.sgt_geldig_voorField = value;
				base.RaisePropertyChanged("sgt_geldig_voor");
			}
		}
		[XmlElement(Order = 13)]
		public CrmMoney sgt_vergoeding_per_dag
		{
			get
			{
				return this.sgt_vergoeding_per_dagField;
			}
			set
			{
				this.sgt_vergoeding_per_dagField = value;
				base.RaisePropertyChanged("sgt_vergoeding_per_dag");
			}
		}
		[XmlElement(Order = 14)]
		public CrmMoney sgt_vergoeding_per_dag_base
		{
			get
			{
				return this.sgt_vergoeding_per_dag_baseField;
			}
			set
			{
				this.sgt_vergoeding_per_dag_baseField = value;
				base.RaisePropertyChanged("sgt_vergoeding_per_dag_base");
			}
		}
		[XmlElement(Order = 15)]
		public Sgt_alg_competentieStateInfo statecode
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
		[XmlElement(Order = 16)]
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
		[XmlElement(Order = 17)]
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
		[XmlElement(Order = 18)]
		public Lookup transactioncurrencyid
		{
			get
			{
				return this.transactioncurrencyidField;
			}
			set
			{
				this.transactioncurrencyidField = value;
				base.RaisePropertyChanged("transactioncurrencyid");
			}
		}
		[XmlElement(Order = 19)]
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
