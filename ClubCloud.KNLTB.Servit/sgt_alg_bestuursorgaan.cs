using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_alg_bestuursorgaan : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup organizationidField;
		private CrmDateTime overriddencreatedonField;
		private string sgt_alg_bestuursorgaan1Field;
		private Key sgt_alg_bestuursorgaanidField;
		private CrmBoolean sgt_automatisch_genererenField;
		private Lookup sgt_basisorganisatieidField;
		private string sgt_beschrijvingField;
		private CrmDateTime sgt_datum_tmField;
		private CrmDateTime sgt_datum_vanafField;
		private Lookup sgt_typebestuursorgaanidField;
		private string sgt_verkorte_codeField;
		private Sgt_alg_bestuursorgaanStateInfo statecodeField;
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
		[XmlElement("sgt_alg_bestuursorgaan", Order = 7)]
		public string sgt_alg_bestuursorgaan1
		{
			get
			{
				return this.sgt_alg_bestuursorgaan1Field;
			}
			set
			{
				this.sgt_alg_bestuursorgaan1Field = value;
				base.RaisePropertyChanged("sgt_alg_bestuursorgaan1");
			}
		}
		[XmlElement(Order = 8)]
		public Key sgt_alg_bestuursorgaanid
		{
			get
			{
				return this.sgt_alg_bestuursorgaanidField;
			}
			set
			{
				this.sgt_alg_bestuursorgaanidField = value;
				base.RaisePropertyChanged("sgt_alg_bestuursorgaanid");
			}
		}
		[XmlElement(Order = 9)]
		public CrmBoolean sgt_automatisch_genereren
		{
			get
			{
				return this.sgt_automatisch_genererenField;
			}
			set
			{
				this.sgt_automatisch_genererenField = value;
				base.RaisePropertyChanged("sgt_automatisch_genereren");
			}
		}
		[XmlElement(Order = 10)]
		public Lookup sgt_basisorganisatieid
		{
			get
			{
				return this.sgt_basisorganisatieidField;
			}
			set
			{
				this.sgt_basisorganisatieidField = value;
				base.RaisePropertyChanged("sgt_basisorganisatieid");
			}
		}
		[XmlElement(Order = 11)]
		public string sgt_beschrijving
		{
			get
			{
				return this.sgt_beschrijvingField;
			}
			set
			{
				this.sgt_beschrijvingField = value;
				base.RaisePropertyChanged("sgt_beschrijving");
			}
		}
		[XmlElement(Order = 12)]
		public CrmDateTime sgt_datum_tm
		{
			get
			{
				return this.sgt_datum_tmField;
			}
			set
			{
				this.sgt_datum_tmField = value;
				base.RaisePropertyChanged("sgt_datum_tm");
			}
		}
		[XmlElement(Order = 13)]
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
		[XmlElement(Order = 14)]
		public Lookup sgt_typebestuursorgaanid
		{
			get
			{
				return this.sgt_typebestuursorgaanidField;
			}
			set
			{
				this.sgt_typebestuursorgaanidField = value;
				base.RaisePropertyChanged("sgt_typebestuursorgaanid");
			}
		}
		[XmlElement(Order = 15)]
		public string sgt_verkorte_code
		{
			get
			{
				return this.sgt_verkorte_codeField;
			}
			set
			{
				this.sgt_verkorte_codeField = value;
				base.RaisePropertyChanged("sgt_verkorte_code");
			}
		}
		[XmlElement(Order = 16)]
		public Sgt_alg_bestuursorgaanStateInfo statecode
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
		[XmlElement(Order = 17)]
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
		[XmlElement(Order = 18)]
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
