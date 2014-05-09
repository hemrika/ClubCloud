using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_arb_arbitragebehoefte_toernooien : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private CrmNumber sgt_aantal_jaar_hs_ingezetField;
		private CrmNumber sgt_aantal_jaar_zelfde_hsField;
		private string sgt_arb_arbitrage_toernooibehoefteField;
		private Key sgt_arb_arbitragebehoefte_toernooienidField;
		private string sgt_behoefte_opmerkingField;
		private Picklist sgt_behoefte_statusField;
		private Lookup sgt_hs_vorigjaaridField;
		private Lookup sgt_organisatieidField;
		private Lookup sgt_toernooi_aanvraag_verwerking_idField;
		private Lookup sgt_toernooiidField;
		private string sgt_toernooinummerField;
		private Lookup sgt_toernooisoortidField;
		private Lookup sgt_voorkeur_hs_2idField;
		private Lookup sgt_voorkeur_hs_3idField;
		private Lookup sgt_voorkeur_hs1idField;
		private string sgt_week_tmField;
		private string sgt_week_vanafField;
		private Sgt_arb_arbitragebehoefte_toernooienStateInfo statecodeField;
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
		public CrmNumber sgt_aantal_jaar_hs_ingezet
		{
			get
			{
				return this.sgt_aantal_jaar_hs_ingezetField;
			}
			set
			{
				this.sgt_aantal_jaar_hs_ingezetField = value;
				base.RaisePropertyChanged("sgt_aantal_jaar_hs_ingezet");
			}
		}
		[XmlElement(Order = 9)]
		public CrmNumber sgt_aantal_jaar_zelfde_hs
		{
			get
			{
				return this.sgt_aantal_jaar_zelfde_hsField;
			}
			set
			{
				this.sgt_aantal_jaar_zelfde_hsField = value;
				base.RaisePropertyChanged("sgt_aantal_jaar_zelfde_hs");
			}
		}
		[XmlElement(Order = 10)]
		public string sgt_arb_arbitrage_toernooibehoefte
		{
			get
			{
				return this.sgt_arb_arbitrage_toernooibehoefteField;
			}
			set
			{
				this.sgt_arb_arbitrage_toernooibehoefteField = value;
				base.RaisePropertyChanged("sgt_arb_arbitrage_toernooibehoefte");
			}
		}
		[XmlElement(Order = 11)]
		public Key sgt_arb_arbitragebehoefte_toernooienid
		{
			get
			{
				return this.sgt_arb_arbitragebehoefte_toernooienidField;
			}
			set
			{
				this.sgt_arb_arbitragebehoefte_toernooienidField = value;
				base.RaisePropertyChanged("sgt_arb_arbitragebehoefte_toernooienid");
			}
		}
		[XmlElement(Order = 12)]
		public string sgt_behoefte_opmerking
		{
			get
			{
				return this.sgt_behoefte_opmerkingField;
			}
			set
			{
				this.sgt_behoefte_opmerkingField = value;
				base.RaisePropertyChanged("sgt_behoefte_opmerking");
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
		public Lookup sgt_hs_vorigjaarid
		{
			get
			{
				return this.sgt_hs_vorigjaaridField;
			}
			set
			{
				this.sgt_hs_vorigjaaridField = value;
				base.RaisePropertyChanged("sgt_hs_vorigjaarid");
			}
		}
		[XmlElement(Order = 15)]
		public Lookup sgt_organisatieid
		{
			get
			{
				return this.sgt_organisatieidField;
			}
			set
			{
				this.sgt_organisatieidField = value;
				base.RaisePropertyChanged("sgt_organisatieid");
			}
		}
		[XmlElement(Order = 16)]
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
		[XmlElement(Order = 17)]
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
		[XmlElement(Order = 18)]
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
		[XmlElement(Order = 19)]
		public Lookup sgt_toernooisoortid
		{
			get
			{
				return this.sgt_toernooisoortidField;
			}
			set
			{
				this.sgt_toernooisoortidField = value;
				base.RaisePropertyChanged("sgt_toernooisoortid");
			}
		}
		[XmlElement(Order = 20)]
		public Lookup sgt_voorkeur_hs_2id
		{
			get
			{
				return this.sgt_voorkeur_hs_2idField;
			}
			set
			{
				this.sgt_voorkeur_hs_2idField = value;
				base.RaisePropertyChanged("sgt_voorkeur_hs_2id");
			}
		}
		[XmlElement(Order = 21)]
		public Lookup sgt_voorkeur_hs_3id
		{
			get
			{
				return this.sgt_voorkeur_hs_3idField;
			}
			set
			{
				this.sgt_voorkeur_hs_3idField = value;
				base.RaisePropertyChanged("sgt_voorkeur_hs_3id");
			}
		}
		[XmlElement(Order = 22)]
		public Lookup sgt_voorkeur_hs1id
		{
			get
			{
				return this.sgt_voorkeur_hs1idField;
			}
			set
			{
				this.sgt_voorkeur_hs1idField = value;
				base.RaisePropertyChanged("sgt_voorkeur_hs1id");
			}
		}
		[XmlElement(Order = 23)]
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
		[XmlElement(Order = 24)]
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
		[XmlElement(Order = 25)]
		public Sgt_arb_arbitragebehoefte_toernooienStateInfo statecode
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
		[XmlElement(Order = 26)]
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
		[XmlElement(Order = 27)]
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
		[XmlElement(Order = 28)]
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
