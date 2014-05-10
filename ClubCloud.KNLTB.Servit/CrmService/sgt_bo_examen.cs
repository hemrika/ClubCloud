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
		public CrmDecimal exchangerate
		{
			get
			{
				return this.exchangerateField;
			}
			set
			{
				this.exchangerateField = value;
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
		[XmlElement("sgt_bo_examen")]
		public string sgt_bo_examen1
		{
			get
			{
				return this.sgt_bo_examen1Field;
			}
			set
			{
				this.sgt_bo_examen1Field = value;
			}
		}
		public Key sgt_bo_examenid
		{
			get
			{
				return this.sgt_bo_examenidField;
			}
			set
			{
				this.sgt_bo_examenidField = value;
			}
		}
		public CrmDateTime sgt_datum_examen
		{
			get
			{
				return this.sgt_datum_examenField;
			}
			set
			{
				this.sgt_datum_examenField = value;
			}
		}
		public CrmMoney sgt_dummy
		{
			get
			{
				return this.sgt_dummyField;
			}
			set
			{
				this.sgt_dummyField = value;
			}
		}
		public CrmMoney sgt_dummy_base
		{
			get
			{
				return this.sgt_dummy_baseField;
			}
			set
			{
				this.sgt_dummy_baseField = value;
			}
		}
		public CrmDateTime sgt_examen_datum
		{
			get
			{
				return this.sgt_examen_datumField;
			}
			set
			{
				this.sgt_examen_datumField = value;
			}
		}
		public Lookup sgt_examensoortid
		{
			get
			{
				return this.sgt_examensoortidField;
			}
			set
			{
				this.sgt_examensoortidField = value;
			}
		}
		public Lookup sgt_lokatieid
		{
			get
			{
				return this.sgt_lokatieidField;
			}
			set
			{
				this.sgt_lokatieidField = value;
			}
		}
		public Lookup sgt_opleidingid
		{
			get
			{
				return this.sgt_opleidingidField;
			}
			set
			{
				this.sgt_opleidingidField = value;
			}
		}
		public string sgt_plaats
		{
			get
			{
				return this.sgt_plaatsField;
			}
			set
			{
				this.sgt_plaatsField = value;
			}
		}
		public Sgt_bo_examenStateInfo statecode
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
		public Lookup transactioncurrencyid
		{
			get
			{
				return this.transactioncurrencyidField;
			}
			set
			{
				this.transactioncurrencyidField = value;
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
