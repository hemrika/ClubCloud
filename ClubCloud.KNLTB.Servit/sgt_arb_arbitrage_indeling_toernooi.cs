using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_arb_arbitrage_indeling_toernooi : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private string sgt_arb_arbitrage_indeling_toernooi1Field;
		private Key sgt_arb_arbitrage_indeling_toernooiidField;
		private CrmBoolean sgt_automatisch_indelenField;
		private CrmDateTime sgt_datum_herstartField;
		private CrmDateTime sgt_datum_indelenField;
		private CrmBoolean sgt_herstartenField;
		private string sgt_reden_statusField;
		private Picklist sgt_statusField;
		private Lookup sgt_toernooikalenderidField;
		private Sgt_arb_arbitrage_indeling_toernooiStateInfo statecodeField;
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
		[XmlElement("sgt_arb_arbitrage_indeling_toernooi", Order = 8)]
		public string sgt_arb_arbitrage_indeling_toernooi1
		{
			get
			{
				return this.sgt_arb_arbitrage_indeling_toernooi1Field;
			}
			set
			{
				this.sgt_arb_arbitrage_indeling_toernooi1Field = value;
				base.RaisePropertyChanged("sgt_arb_arbitrage_indeling_toernooi1");
			}
		}
		[XmlElement(Order = 9)]
		public Key sgt_arb_arbitrage_indeling_toernooiid
		{
			get
			{
				return this.sgt_arb_arbitrage_indeling_toernooiidField;
			}
			set
			{
				this.sgt_arb_arbitrage_indeling_toernooiidField = value;
				base.RaisePropertyChanged("sgt_arb_arbitrage_indeling_toernooiid");
			}
		}
		[XmlElement(Order = 10)]
		public CrmBoolean sgt_automatisch_indelen
		{
			get
			{
				return this.sgt_automatisch_indelenField;
			}
			set
			{
				this.sgt_automatisch_indelenField = value;
				base.RaisePropertyChanged("sgt_automatisch_indelen");
			}
		}
		[XmlElement(Order = 11)]
		public CrmDateTime sgt_datum_herstart
		{
			get
			{
				return this.sgt_datum_herstartField;
			}
			set
			{
				this.sgt_datum_herstartField = value;
				base.RaisePropertyChanged("sgt_datum_herstart");
			}
		}
		[XmlElement(Order = 12)]
		public CrmDateTime sgt_datum_indelen
		{
			get
			{
				return this.sgt_datum_indelenField;
			}
			set
			{
				this.sgt_datum_indelenField = value;
				base.RaisePropertyChanged("sgt_datum_indelen");
			}
		}
		[XmlElement(Order = 13)]
		public CrmBoolean sgt_herstarten
		{
			get
			{
				return this.sgt_herstartenField;
			}
			set
			{
				this.sgt_herstartenField = value;
				base.RaisePropertyChanged("sgt_herstarten");
			}
		}
		[XmlElement(Order = 14)]
		public string sgt_reden_status
		{
			get
			{
				return this.sgt_reden_statusField;
			}
			set
			{
				this.sgt_reden_statusField = value;
				base.RaisePropertyChanged("sgt_reden_status");
			}
		}
		[XmlElement(Order = 15)]
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
		[XmlElement(Order = 16)]
		public Lookup sgt_toernooikalenderid
		{
			get
			{
				return this.sgt_toernooikalenderidField;
			}
			set
			{
				this.sgt_toernooikalenderidField = value;
				base.RaisePropertyChanged("sgt_toernooikalenderid");
			}
		}
		[XmlElement(Order = 17)]
		public Sgt_arb_arbitrage_indeling_toernooiStateInfo statecode
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
		[XmlElement(Order = 18)]
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
		[XmlElement(Order = 19)]
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
