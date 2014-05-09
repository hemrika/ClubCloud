using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_bo_examen : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmDecimal exchangerateField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private string sgt_bo_examen1Field;
		private Key sgt_bo_examenidField;
		private CrmDateTime sgt_datum_examenField;
		private CrmMoney sgt_dummyField;
		private CrmMoney sgt_dummy_baseField;
		private CrmDateTime sgt_examen_datumField;
		private Lookup sgt_examensoortidField;
		private Lookup sgt_lokatieidField;
		private Lookup sgt_opleidingidField;
		private string sgt_plaatsField;
		private Sgt_bo_examenStateInfo statecodeField;
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
		[XmlElement(Order = 8)]
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
		[XmlElement("sgt_bo_examen", Order = 9)]
		public string sgt_bo_examen1
		{
			get
			{
				return this.sgt_bo_examen1Field;
			}
			set
			{
				this.sgt_bo_examen1Field = value;
				base.RaisePropertyChanged("sgt_bo_examen1");
			}
		}
		[XmlElement(Order = 10)]
		public Key sgt_bo_examenid
		{
			get
			{
				return this.sgt_bo_examenidField;
			}
			set
			{
				this.sgt_bo_examenidField = value;
				base.RaisePropertyChanged("sgt_bo_examenid");
			}
		}
		[XmlElement(Order = 11)]
		public CrmDateTime sgt_datum_examen
		{
			get
			{
				return this.sgt_datum_examenField;
			}
			set
			{
				this.sgt_datum_examenField = value;
				base.RaisePropertyChanged("sgt_datum_examen");
			}
		}
		[XmlElement(Order = 12)]
		public CrmMoney sgt_dummy
		{
			get
			{
				return this.sgt_dummyField;
			}
			set
			{
				this.sgt_dummyField = value;
				base.RaisePropertyChanged("sgt_dummy");
			}
		}
		[XmlElement(Order = 13)]
		public CrmMoney sgt_dummy_base
		{
			get
			{
				return this.sgt_dummy_baseField;
			}
			set
			{
				this.sgt_dummy_baseField = value;
				base.RaisePropertyChanged("sgt_dummy_base");
			}
		}
		[XmlElement(Order = 14)]
		public CrmDateTime sgt_examen_datum
		{
			get
			{
				return this.sgt_examen_datumField;
			}
			set
			{
				this.sgt_examen_datumField = value;
				base.RaisePropertyChanged("sgt_examen_datum");
			}
		}
		[XmlElement(Order = 15)]
		public Lookup sgt_examensoortid
		{
			get
			{
				return this.sgt_examensoortidField;
			}
			set
			{
				this.sgt_examensoortidField = value;
				base.RaisePropertyChanged("sgt_examensoortid");
			}
		}
		[XmlElement(Order = 16)]
		public Lookup sgt_lokatieid
		{
			get
			{
				return this.sgt_lokatieidField;
			}
			set
			{
				this.sgt_lokatieidField = value;
				base.RaisePropertyChanged("sgt_lokatieid");
			}
		}
		[XmlElement(Order = 17)]
		public Lookup sgt_opleidingid
		{
			get
			{
				return this.sgt_opleidingidField;
			}
			set
			{
				this.sgt_opleidingidField = value;
				base.RaisePropertyChanged("sgt_opleidingid");
			}
		}
		[XmlElement(Order = 18)]
		public string sgt_plaats
		{
			get
			{
				return this.sgt_plaatsField;
			}
			set
			{
				this.sgt_plaatsField = value;
				base.RaisePropertyChanged("sgt_plaats");
			}
		}
		[XmlElement(Order = 19)]
		public Sgt_bo_examenStateInfo statecode
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
		[XmlElement(Order = 20)]
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
		[XmlElement(Order = 21)]
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
		[XmlElement(Order = 22)]
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
		[XmlElement(Order = 23)]
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
