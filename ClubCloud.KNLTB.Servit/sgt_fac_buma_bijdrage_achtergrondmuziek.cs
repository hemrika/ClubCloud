using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_fac_buma_bijdrage_achtergrondmuziek : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmDecimal exchangerateField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup organizationidField;
		private CrmDateTime overriddencreatedonField;
		private CrmNumber sgt_aantal_m2_tmField;
		private CrmNumber sgt_aantal_m2_vanafField;
		private Picklist sgt_aantal_maanden_geopendField;
		private string sgt_alg_nameField;
		private CrmMoney sgt_bijdrageField;
		private CrmMoney sgt_bijdrage_baseField;
		private Key sgt_fac_buma_bijdrage_achtergrondmuziekidField;
		private Lookup sgt_soort_apparatuuridField;
		private Sgt_fac_buma_bijdrage_achtergrondmuziekStateInfo statecodeField;
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
		public CrmNumber sgt_aantal_m2_tm
		{
			get
			{
				return this.sgt_aantal_m2_tmField;
			}
			set
			{
				this.sgt_aantal_m2_tmField = value;
				base.RaisePropertyChanged("sgt_aantal_m2_tm");
			}
		}
		[XmlElement(Order = 9)]
		public CrmNumber sgt_aantal_m2_vanaf
		{
			get
			{
				return this.sgt_aantal_m2_vanafField;
			}
			set
			{
				this.sgt_aantal_m2_vanafField = value;
				base.RaisePropertyChanged("sgt_aantal_m2_vanaf");
			}
		}
		[XmlElement(Order = 10)]
		public Picklist sgt_aantal_maanden_geopend
		{
			get
			{
				return this.sgt_aantal_maanden_geopendField;
			}
			set
			{
				this.sgt_aantal_maanden_geopendField = value;
				base.RaisePropertyChanged("sgt_aantal_maanden_geopend");
			}
		}
		[XmlElement(Order = 11)]
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
		[XmlElement(Order = 12)]
		public CrmMoney sgt_bijdrage
		{
			get
			{
				return this.sgt_bijdrageField;
			}
			set
			{
				this.sgt_bijdrageField = value;
				base.RaisePropertyChanged("sgt_bijdrage");
			}
		}
		[XmlElement(Order = 13)]
		public CrmMoney sgt_bijdrage_base
		{
			get
			{
				return this.sgt_bijdrage_baseField;
			}
			set
			{
				this.sgt_bijdrage_baseField = value;
				base.RaisePropertyChanged("sgt_bijdrage_base");
			}
		}
		[XmlElement(Order = 14)]
		public Key sgt_fac_buma_bijdrage_achtergrondmuziekid
		{
			get
			{
				return this.sgt_fac_buma_bijdrage_achtergrondmuziekidField;
			}
			set
			{
				this.sgt_fac_buma_bijdrage_achtergrondmuziekidField = value;
				base.RaisePropertyChanged("sgt_fac_buma_bijdrage_achtergrondmuziekid");
			}
		}
		[XmlElement(Order = 15)]
		public Lookup sgt_soort_apparatuurid
		{
			get
			{
				return this.sgt_soort_apparatuuridField;
			}
			set
			{
				this.sgt_soort_apparatuuridField = value;
				base.RaisePropertyChanged("sgt_soort_apparatuurid");
			}
		}
		[XmlElement(Order = 16)]
		public Sgt_fac_buma_bijdrage_achtergrondmuziekStateInfo statecode
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
		[XmlElement(Order = 20)]
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
