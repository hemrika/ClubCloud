using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_arb_arbitrage_inzet_toernooien : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private string sgt_arb_arbitrage_inzet_toernooien1Field;
		private Key sgt_arb_arbitrage_inzet_toernooienidField;
		private Picklist sgt_dagField;
		private CrmDateTime sgt_inzet_datumField;
		private Lookup sgt_toernooi_aanvraag_verwerking_idField;
		private Lookup sgt_toernooiidField;
		private string sgt_toernooinummerField;
		private CrmNumber sgt_toernooiweekField;
		private string sgt_week_tmField;
		private string sgt_week_vanafField;
		private Sgt_arb_arbitrage_inzet_toernooienStateInfo statecodeField;
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
		[XmlElement("sgt_arb_arbitrage_inzet_toernooien", Order = 8)]
		public string sgt_arb_arbitrage_inzet_toernooien1
		{
			get
			{
				return this.sgt_arb_arbitrage_inzet_toernooien1Field;
			}
			set
			{
				this.sgt_arb_arbitrage_inzet_toernooien1Field = value;
				base.RaisePropertyChanged("sgt_arb_arbitrage_inzet_toernooien1");
			}
		}
		[XmlElement(Order = 9)]
		public Key sgt_arb_arbitrage_inzet_toernooienid
		{
			get
			{
				return this.sgt_arb_arbitrage_inzet_toernooienidField;
			}
			set
			{
				this.sgt_arb_arbitrage_inzet_toernooienidField = value;
				base.RaisePropertyChanged("sgt_arb_arbitrage_inzet_toernooienid");
			}
		}
		[XmlElement(Order = 10)]
		public Picklist sgt_dag
		{
			get
			{
				return this.sgt_dagField;
			}
			set
			{
				this.sgt_dagField = value;
				base.RaisePropertyChanged("sgt_dag");
			}
		}
		[XmlElement(Order = 11)]
		public CrmDateTime sgt_inzet_datum
		{
			get
			{
				return this.sgt_inzet_datumField;
			}
			set
			{
				this.sgt_inzet_datumField = value;
				base.RaisePropertyChanged("sgt_inzet_datum");
			}
		}
		[XmlElement(Order = 12)]
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
		[XmlElement(Order = 13)]
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
		[XmlElement(Order = 14)]
		public string sgt_toernooinummer
		{
			get
			{
				return this.sgt_toernooinummerField;
			}
			set
			{
				this.sgt_toernooinummerField = value;
				base.RaisePropertyChanged("sgt_toernooinummer");
			}
		}
		[XmlElement(Order = 15)]
		public CrmNumber sgt_toernooiweek
		{
			get
			{
				return this.sgt_toernooiweekField;
			}
			set
			{
				this.sgt_toernooiweekField = value;
				base.RaisePropertyChanged("sgt_toernooiweek");
			}
		}
		[XmlElement(Order = 16)]
		public string sgt_week_tm
		{
			get
			{
				return this.sgt_week_tmField;
			}
			set
			{
				this.sgt_week_tmField = value;
				base.RaisePropertyChanged("sgt_week_tm");
			}
		}
		[XmlElement(Order = 17)]
		public string sgt_week_vanaf
		{
			get
			{
				return this.sgt_week_vanafField;
			}
			set
			{
				this.sgt_week_vanafField = value;
				base.RaisePropertyChanged("sgt_week_vanaf");
			}
		}
		[XmlElement(Order = 18)]
		public Sgt_arb_arbitrage_inzet_toernooienStateInfo statecode
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
