using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
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
		public CrmNumber sgt_aantal_jaar_hs_ingezet
		{
			get
			{
				return this.sgt_aantal_jaar_hs_ingezetField;
			}
			set
			{
				this.sgt_aantal_jaar_hs_ingezetField = value;
			}
		}
		public CrmNumber sgt_aantal_jaar_zelfde_hs
		{
			get
			{
				return this.sgt_aantal_jaar_zelfde_hsField;
			}
			set
			{
				this.sgt_aantal_jaar_zelfde_hsField = value;
			}
		}
		public string sgt_arb_arbitrage_toernooibehoefte
		{
			get
			{
				return this.sgt_arb_arbitrage_toernooibehoefteField;
			}
			set
			{
				this.sgt_arb_arbitrage_toernooibehoefteField = value;
			}
		}
		public Key sgt_arb_arbitragebehoefte_toernooienid
		{
			get
			{
				return this.sgt_arb_arbitragebehoefte_toernooienidField;
			}
			set
			{
				this.sgt_arb_arbitragebehoefte_toernooienidField = value;
			}
		}
		public string sgt_behoefte_opmerking
		{
			get
			{
				return this.sgt_behoefte_opmerkingField;
			}
			set
			{
				this.sgt_behoefte_opmerkingField = value;
			}
		}
		public Picklist sgt_behoefte_status
		{
			get
			{
				return this.sgt_behoefte_statusField;
			}
			set
			{
				this.sgt_behoefte_statusField = value;
			}
		}
		public Lookup sgt_hs_vorigjaarid
		{
			get
			{
				return this.sgt_hs_vorigjaaridField;
			}
			set
			{
				this.sgt_hs_vorigjaaridField = value;
			}
		}
		public Lookup sgt_organisatieid
		{
			get
			{
				return this.sgt_organisatieidField;
			}
			set
			{
				this.sgt_organisatieidField = value;
			}
		}
		public Lookup sgt_toernooi_aanvraag_verwerking_id
		{
			get
			{
				return this.sgt_toernooi_aanvraag_verwerking_idField;
			}
			set
			{
				this.sgt_toernooi_aanvraag_verwerking_idField = value;
			}
		}
		public Lookup sgt_toernooiid
		{
			get
			{
				return this.sgt_toernooiidField;
			}
			set
			{
				this.sgt_toernooiidField = value;
			}
		}
		public string sgt_toernooinummer
		{
			get
			{
				return this.sgt_toernooinummerField;
			}
			set
			{
				this.sgt_toernooinummerField = value;
			}
		}
		public Lookup sgt_toernooisoortid
		{
			get
			{
				return this.sgt_toernooisoortidField;
			}
			set
			{
				this.sgt_toernooisoortidField = value;
			}
		}
		public Lookup sgt_voorkeur_hs_2id
		{
			get
			{
				return this.sgt_voorkeur_hs_2idField;
			}
			set
			{
				this.sgt_voorkeur_hs_2idField = value;
			}
		}
		public Lookup sgt_voorkeur_hs_3id
		{
			get
			{
				return this.sgt_voorkeur_hs_3idField;
			}
			set
			{
				this.sgt_voorkeur_hs_3idField = value;
			}
		}
		public Lookup sgt_voorkeur_hs1id
		{
			get
			{
				return this.sgt_voorkeur_hs1idField;
			}
			set
			{
				this.sgt_voorkeur_hs1idField = value;
			}
		}
		public string sgt_week_tm
		{
			get
			{
				return this.sgt_week_tmField;
			}
			set
			{
				this.sgt_week_tmField = value;
			}
		}
		public string sgt_week_vanaf
		{
			get
			{
				return this.sgt_week_vanafField;
			}
			set
			{
				this.sgt_week_vanafField = value;
			}
		}
		public Sgt_arb_arbitragebehoefte_toernooienStateInfo statecode
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
