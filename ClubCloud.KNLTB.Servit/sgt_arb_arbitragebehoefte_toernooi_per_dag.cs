using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_arb_arbitragebehoefte_toernooi_per_dag : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private CrmNumber sgt_aantalField;
		private string sgt_arb_arbitragebehoefte_toernooi_per_daField;
		private Key sgt_arb_arbitragebehoefte_toernooi_per_dagidField;
		private Lookup sgt_arbitragebehoefteidField;
		private Picklist sgt_arbitragedagField;
		private Picklist sgt_behoefte_statusField;
		private CrmDateTime sgt_datumField;
		private Lookup sgt_functieidField;
		private CrmNumber sgt_reglementair_aantalField;
		private Lookup sgt_toernooi_aanvraag_verwerking_idField;
		private Lookup sgt_toernooiidField;
		private CrmNumber sgt_toernooiweekField;
		private Sgt_arb_arbitragebehoefte_toernooi_per_dagStateInfo statecodeField;
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
		public CrmNumber sgt_aantal
		{
			get
			{
				return this.sgt_aantalField;
			}
			set
			{
				this.sgt_aantalField = value;
				base.RaisePropertyChanged("sgt_aantal");
			}
		}
		[XmlElement(Order = 9)]
		public string sgt_arb_arbitragebehoefte_toernooi_per_da
		{
			get
			{
				return this.sgt_arb_arbitragebehoefte_toernooi_per_daField;
			}
			set
			{
				this.sgt_arb_arbitragebehoefte_toernooi_per_daField = value;
				base.RaisePropertyChanged("sgt_arb_arbitragebehoefte_toernooi_per_da");
			}
		}
		[XmlElement(Order = 10)]
		public Key sgt_arb_arbitragebehoefte_toernooi_per_dagid
		{
			get
			{
				return this.sgt_arb_arbitragebehoefte_toernooi_per_dagidField;
			}
			set
			{
				this.sgt_arb_arbitragebehoefte_toernooi_per_dagidField = value;
				base.RaisePropertyChanged("sgt_arb_arbitragebehoefte_toernooi_per_dagid");
			}
		}
		[XmlElement(Order = 11)]
		public Lookup sgt_arbitragebehoefteid
		{
			get
			{
				return this.sgt_arbitragebehoefteidField;
			}
			set
			{
				this.sgt_arbitragebehoefteidField = value;
				base.RaisePropertyChanged("sgt_arbitragebehoefteid");
			}
		}
		[XmlElement(Order = 12)]
		public Picklist sgt_arbitragedag
		{
			get
			{
				return this.sgt_arbitragedagField;
			}
			set
			{
				this.sgt_arbitragedagField = value;
				base.RaisePropertyChanged("sgt_arbitragedag");
			}
		}
		[XmlElement(Order = 13)]
		public Picklist sgt_behoefte_status
		{
			get
			{
				return this.sgt_behoefte_statusField;
			}
			set
			{
				this.sgt_behoefte_statusField = value;
				base.RaisePropertyChanged("sgt_behoefte_status");
			}
		}
		[XmlElement(Order = 14)]
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
		[XmlElement(Order = 15)]
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
		[XmlElement(Order = 16)]
		public CrmNumber sgt_reglementair_aantal
		{
			get
			{
				return this.sgt_reglementair_aantalField;
			}
			set
			{
				this.sgt_reglementair_aantalField = value;
				base.RaisePropertyChanged("sgt_reglementair_aantal");
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
		[XmlElement(Order = 20)]
		public Sgt_arb_arbitragebehoefte_toernooi_per_dagStateInfo statecode
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
		[XmlElement(Order = 21)]
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
		[XmlElement(Order = 22)]
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
