using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_alg_email_samenvoegveld : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup organizationidField;
		private CrmDateTime overriddencreatedonField;
		private Key sgt_alg_email_samenvoegveldidField;
		private string sgt_alg_tagField;
		private string sgt_entiteitField;
		private CrmBoolean sgt_is_lijstField;
		private string sgt_kenmerkField;
		private string sgt_omschrijvingField;
		private Sgt_alg_email_samenvoegveldStateInfo statecodeField;
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
		public Key sgt_alg_email_samenvoegveldid
		{
			get
			{
				return this.sgt_alg_email_samenvoegveldidField;
			}
			set
			{
				this.sgt_alg_email_samenvoegveldidField = value;
				base.RaisePropertyChanged("sgt_alg_email_samenvoegveldid");
			}
		}
		[XmlElement(Order = 8)]
		public string sgt_alg_tag
		{
			get
			{
				return this.sgt_alg_tagField;
			}
			set
			{
				this.sgt_alg_tagField = value;
				base.RaisePropertyChanged("sgt_alg_tag");
			}
		}
		[XmlElement(Order = 9)]
		public string sgt_entiteit
		{
			get
			{
				return this.sgt_entiteitField;
			}
			set
			{
				this.sgt_entiteitField = value;
				base.RaisePropertyChanged("sgt_entiteit");
			}
		}
		[XmlElement(Order = 10)]
		public CrmBoolean sgt_is_lijst
		{
			get
			{
				return this.sgt_is_lijstField;
			}
			set
			{
				this.sgt_is_lijstField = value;
				base.RaisePropertyChanged("sgt_is_lijst");
			}
		}
		[XmlElement(Order = 11)]
		public string sgt_kenmerk
		{
			get
			{
				return this.sgt_kenmerkField;
			}
			set
			{
				this.sgt_kenmerkField = value;
				base.RaisePropertyChanged("sgt_kenmerk");
			}
		}
		[XmlElement(Order = 12)]
		public string sgt_omschrijving
		{
			get
			{
				return this.sgt_omschrijvingField;
			}
			set
			{
				this.sgt_omschrijvingField = value;
				base.RaisePropertyChanged("sgt_omschrijving");
			}
		}
		[XmlElement(Order = 13)]
		public Sgt_alg_email_samenvoegveldStateInfo statecode
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
