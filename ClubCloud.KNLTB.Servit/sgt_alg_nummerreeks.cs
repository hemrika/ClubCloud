using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_alg_nummerreeks : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup organizationidField;
		private CrmDateTime overriddencreatedonField;
		private string sgt_alg_naamField;
		private Key sgt_alg_nummerreeksidField;
		private CrmNumber sgt_alg_timeoutField;
		private string sgt_cultuurField;
		private string sgt_entiteitnaamField;
		private CrmDecimal sgt_huidig_nummerField;
		private string sgt_kenmerk_parentField;
		private string sgt_kenmerknaamField;
		private string sgt_maskerField;
		private Picklist sgt_soortField;
		private CrmDecimal sgt_stapField;
		private Sgt_alg_nummerreeksStateInfo statecodeField;
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
		[XmlElement(Order = 6)]
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
		[XmlElement(Order = 7)]
		public string sgt_alg_naam
		{
			get
			{
				return this.sgt_alg_naamField;
			}
			set
			{
				this.sgt_alg_naamField = value;
				base.RaisePropertyChanged("sgt_alg_naam");
			}
		}
		[XmlElement(Order = 8)]
		public Key sgt_alg_nummerreeksid
		{
			get
			{
				return this.sgt_alg_nummerreeksidField;
			}
			set
			{
				this.sgt_alg_nummerreeksidField = value;
				base.RaisePropertyChanged("sgt_alg_nummerreeksid");
			}
		}
		[XmlElement(Order = 9)]
		public CrmNumber sgt_alg_timeout
		{
			get
			{
				return this.sgt_alg_timeoutField;
			}
			set
			{
				this.sgt_alg_timeoutField = value;
				base.RaisePropertyChanged("sgt_alg_timeout");
			}
		}
		[XmlElement(Order = 10)]
		public string sgt_cultuur
		{
			get
			{
				return this.sgt_cultuurField;
			}
			set
			{
				this.sgt_cultuurField = value;
				base.RaisePropertyChanged("sgt_cultuur");
			}
		}
		[XmlElement(Order = 11)]
		public string sgt_entiteitnaam
		{
			get
			{
				return this.sgt_entiteitnaamField;
			}
			set
			{
				this.sgt_entiteitnaamField = value;
				base.RaisePropertyChanged("sgt_entiteitnaam");
			}
		}
		[XmlElement(Order = 12)]
		public CrmDecimal sgt_huidig_nummer
		{
			get
			{
				return this.sgt_huidig_nummerField;
			}
			set
			{
				this.sgt_huidig_nummerField = value;
				base.RaisePropertyChanged("sgt_huidig_nummer");
			}
		}
		[XmlElement(Order = 13)]
		public string sgt_kenmerk_parent
		{
			get
			{
				return this.sgt_kenmerk_parentField;
			}
			set
			{
				this.sgt_kenmerk_parentField = value;
				base.RaisePropertyChanged("sgt_kenmerk_parent");
			}
		}
		[XmlElement(Order = 14)]
		public string sgt_kenmerknaam
		{
			get
			{
				return this.sgt_kenmerknaamField;
			}
			set
			{
				this.sgt_kenmerknaamField = value;
				base.RaisePropertyChanged("sgt_kenmerknaam");
			}
		}
		[XmlElement(Order = 15)]
		public string sgt_masker
		{
			get
			{
				return this.sgt_maskerField;
			}
			set
			{
				this.sgt_maskerField = value;
				base.RaisePropertyChanged("sgt_masker");
			}
		}
		[XmlElement(Order = 16)]
		public Picklist sgt_soort
		{
			get
			{
				return this.sgt_soortField;
			}
			set
			{
				this.sgt_soortField = value;
				base.RaisePropertyChanged("sgt_soort");
			}
		}
		[XmlElement(Order = 17)]
		public CrmDecimal sgt_stap
		{
			get
			{
				return this.sgt_stapField;
			}
			set
			{
				this.sgt_stapField = value;
				base.RaisePropertyChanged("sgt_stap");
			}
		}
		[XmlElement(Order = 18)]
		public Sgt_alg_nummerreeksStateInfo statecode
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
