using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_arbitrage_inzet_per_dag : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private Lookup sgt_arbiteridField;
		private string sgt_arbitrage_inzet_per_dag1Field;
		private Key sgt_arbitrage_inzet_per_dagidField;
		private Lookup sgt_arbitrage_inzet_toernooiField;
		private CrmDateTime sgt_datumField;
		private Lookup sgt_functieidField;
		private Picklist sgt_inzet_dagField;
		private CrmBoolean sgt_kandidaatField;
		private Picklist sgt_statusField;
		private Lookup sgt_toernooi_aanvraag_verwerking_idField;
		private Lookup sgt_toernooiidField;
		private Sgt_arbitrage_inzet_per_dagStateInfo statecodeField;
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
		public Lookup sgt_arbiterid
		{
			get
			{
				return this.sgt_arbiteridField;
			}
			set
			{
				this.sgt_arbiteridField = value;
				base.RaisePropertyChanged("sgt_arbiterid");
			}
		}
		[XmlElement("sgt_arbitrage_inzet_per_dag", Order = 9)]
		public string sgt_arbitrage_inzet_per_dag1
		{
			get
			{
				return this.sgt_arbitrage_inzet_per_dag1Field;
			}
			set
			{
				this.sgt_arbitrage_inzet_per_dag1Field = value;
				base.RaisePropertyChanged("sgt_arbitrage_inzet_per_dag1");
			}
		}
		[XmlElement(Order = 10)]
		public Key sgt_arbitrage_inzet_per_dagid
		{
			get
			{
				return this.sgt_arbitrage_inzet_per_dagidField;
			}
			set
			{
				this.sgt_arbitrage_inzet_per_dagidField = value;
				base.RaisePropertyChanged("sgt_arbitrage_inzet_per_dagid");
			}
		}
		[XmlElement(Order = 11)]
		public Lookup sgt_arbitrage_inzet_toernooi
		{
			get
			{
				return this.sgt_arbitrage_inzet_toernooiField;
			}
			set
			{
				this.sgt_arbitrage_inzet_toernooiField = value;
				base.RaisePropertyChanged("sgt_arbitrage_inzet_toernooi");
			}
		}
		[XmlElement(Order = 12)]
		public CrmDateTime sgt_datum
		{
			get
			{
				return this.sgt_datumField;
			}
			set
			{
				this.sgt_datumField = value;
				base.RaisePropertyChanged("sgt_datum");
			}
		}
		[XmlElement(Order = 13)]
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
		[XmlElement(Order = 14)]
		public Picklist sgt_inzet_dag
		{
			get
			{
				return this.sgt_inzet_dagField;
			}
			set
			{
				this.sgt_inzet_dagField = value;
				base.RaisePropertyChanged("sgt_inzet_dag");
			}
		}
		[XmlElement(Order = 15)]
		public CrmBoolean sgt_kandidaat
		{
			get
			{
				return this.sgt_kandidaatField;
			}
			set
			{
				this.sgt_kandidaatField = value;
				base.RaisePropertyChanged("sgt_kandidaat");
			}
		}
		[XmlElement(Order = 16)]
		public Picklist sgt_status
		{
			get
			{
				return this.sgt_statusField;
			}
			set
			{
				this.sgt_statusField = value;
				base.RaisePropertyChanged("sgt_status");
			}
		}
		[XmlElement(Order = 17)]
		public Lookup sgt_toernooi_aanvraag_verwerking_id
		{
			get
			{
				return this.sgt_toernooi_aanvraag_verwerking_idField;
			}
			set
			{
				this.sgt_toernooi_aanvraag_verwerking_idField = value;
				base.RaisePropertyChanged("sgt_toernooi_aanvraag_verwerking_id");
			}
		}
		[XmlElement(Order = 18)]
		public Lookup sgt_toernooiid
		{
			get
			{
				return this.sgt_toernooiidField;
			}
			set
			{
				this.sgt_toernooiidField = value;
				base.RaisePropertyChanged("sgt_toernooiid");
			}
		}
		[XmlElement(Order = 19)]
		public Sgt_arbitrage_inzet_per_dagStateInfo statecode
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
