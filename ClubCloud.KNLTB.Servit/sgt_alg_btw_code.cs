using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_alg_btw_code : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private Key sgt_alg_btw_codeidField;
		private string sgt_alg_codeField;
		private string sgt_btw_omschrijvingField;
		private CrmDecimal sgt_btw_percentageField;
		private Lookup sgt_grootboekcodeidField;
		private Sgt_alg_btw_codeStateInfo statecodeField;
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
		public Key sgt_alg_btw_codeid
		{
			get
			{
				return this.sgt_alg_btw_codeidField;
			}
			set
			{
				this.sgt_alg_btw_codeidField = value;
				base.RaisePropertyChanged("sgt_alg_btw_codeid");
			}
		}
		[XmlElement(Order = 9)]
		public string sgt_alg_code
		{
			get
			{
				return this.sgt_alg_codeField;
			}
			set
			{
				this.sgt_alg_codeField = value;
				base.RaisePropertyChanged("sgt_alg_code");
			}
		}
		[XmlElement(Order = 10)]
		public string sgt_btw_omschrijving
		{
			get
			{
				return this.sgt_btw_omschrijvingField;
			}
			set
			{
				this.sgt_btw_omschrijvingField = value;
				base.RaisePropertyChanged("sgt_btw_omschrijving");
			}
		}
		[XmlElement(Order = 11)]
		public CrmDecimal sgt_btw_percentage
		{
			get
			{
				return this.sgt_btw_percentageField;
			}
			set
			{
				this.sgt_btw_percentageField = value;
				base.RaisePropertyChanged("sgt_btw_percentage");
			}
		}
		[XmlElement(Order = 12)]
		public Lookup sgt_grootboekcodeid
		{
			get
			{
				return this.sgt_grootboekcodeidField;
			}
			set
			{
				this.sgt_grootboekcodeidField = value;
				base.RaisePropertyChanged("sgt_grootboekcodeid");
			}
		}
		[XmlElement(Order = 13)]
		public Sgt_alg_btw_codeStateInfo statecode
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
		[XmlElement(Order = 14)]
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
		[XmlElement(Order = 15)]
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
		[XmlElement(Order = 16)]
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
