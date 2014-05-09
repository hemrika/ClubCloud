using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_toe_automatische_acceptatie_van_spelers : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private CrmNumber sgt_aantal_ingeschreven_spelersField;
		private CrmNumber sgt_aantal_niet_geaccepteerde_spelersField;
		private CrmNumber sgt_aantal_spelers_geaccepteerdField;
		private CrmNumber sgt_aantal_spelers_geaccepteerd_reservelijstField;
		private CrmNumber sgt_aantal_spelers_reservelijstField;
		private CrmNumber sgt_aantal_toernooienField;
		private Picklist sgt_acceptatiecriterium1Field;
		private Picklist sgt_acceptatiecriterium2Field;
		private Picklist sgt_acceptatiecriterium3Field;
		private CrmBoolean sgt_accepterenField;
		private CrmBoolean sgt_controle_acceptatie_enkelspelField;
		private CrmDateTime sgt_datum_acceptatieField;
		private CrmDateTime sgt_datum_tmField;
		private CrmDateTime sgt_datum_vanafField;
		private Lookup sgt_geaccepteerd_dooridField;
		private Picklist sgt_geslachtField;
		private CrmNumber sgt_leeftijd_tmField;
		private CrmNumber sgt_leeftijd_vanafField;
		private Lookup sgt_leeftijdscategorieidField;
		private Picklist sgt_periodeField;
		private CrmDateTime sgt_ranglijst_datumField;
		private Picklist sgt_ranglijst_geslachtField;
		private Lookup sgt_ranglijst_groepidField;
		private Picklist sgt_ranglijst_spelsoortField;
		private CrmBoolean sgt_reservelijstField;
		private CrmBoolean sgt_special_exempts_aanvullenField;
		private Lookup sgt_speelsterkteidField;
		private Picklist sgt_spelsoortField;
		private Picklist sgt_statusField;
		private Picklist sgt_subcriterium_i1Field;
		private Picklist sgt_subcriterium_i2Field;
		private Picklist sgt_subcriterium_i3Field;
		private Picklist sgt_subcriterium_i4Field;
		private Picklist sgt_subcriterium_ii1Field;
		private Picklist sgt_subcriterium_ii2Field;
		private Picklist sgt_subcriterium_ii3Field;
		private Picklist sgt_subcriterium_ii4Field;
		private Picklist sgt_subcriterium_iii1Field;
		private Picklist sgt_subcriterium_iii2Field;
		private Picklist sgt_subcriterium_iii3Field;
		private Picklist sgt_subcriterium_iii4Field;
		private string sgt_toe_automatische_acceptatie_van_spelers1Field;
		private Key sgt_toe_automatische_acceptatie_van_spelersidField;
		private Lookup sgt_toernooi_afhandeling_idField;
		private Lookup sgt_toernooi_onderdeelidField;
		private Lookup sgt_toernooigroepidField;
		private Lookup sgt_toernooikalenderidField;
		private Lookup sgt_toernooischema_idField;
		private Lookup sgt_toernooisoortidField;
		private string sgt_toernooiweekField;
		private Sgt_toe_automatische_acceptatie_van_spelersStateInfo statecodeField;
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
		public CrmNumber sgt_aantal_ingeschreven_spelers
		{
			get
			{
				return this.sgt_aantal_ingeschreven_spelersField;
			}
			set
			{
				this.sgt_aantal_ingeschreven_spelersField = value;
				base.RaisePropertyChanged("sgt_aantal_ingeschreven_spelers");
			}
		}
		[XmlElement(Order = 9)]
		public CrmNumber sgt_aantal_niet_geaccepteerde_spelers
		{
			get
			{
				return this.sgt_aantal_niet_geaccepteerde_spelersField;
			}
			set
			{
				this.sgt_aantal_niet_geaccepteerde_spelersField = value;
				base.RaisePropertyChanged("sgt_aantal_niet_geaccepteerde_spelers");
			}
		}
		[XmlElement(Order = 10)]
		public CrmNumber sgt_aantal_spelers_geaccepteerd
		{
			get
			{
				return this.sgt_aantal_spelers_geaccepteerdField;
			}
			set
			{
				this.sgt_aantal_spelers_geaccepteerdField = value;
				base.RaisePropertyChanged("sgt_aantal_spelers_geaccepteerd");
			}
		}
		[XmlElement(Order = 11)]
		public CrmNumber sgt_aantal_spelers_geaccepteerd_reservelijst
		{
			get
			{
				return this.sgt_aantal_spelers_geaccepteerd_reservelijstField;
			}
			set
			{
				this.sgt_aantal_spelers_geaccepteerd_reservelijstField = value;
				base.RaisePropertyChanged("sgt_aantal_spelers_geaccepteerd_reservelijst");
			}
		}
		[XmlElement(Order = 12)]
		public CrmNumber sgt_aantal_spelers_reservelijst
		{
			get
			{
				return this.sgt_aantal_spelers_reservelijstField;
			}
			set
			{
				this.sgt_aantal_spelers_reservelijstField = value;
				base.RaisePropertyChanged("sgt_aantal_spelers_reservelijst");
			}
		}
		[XmlElement(Order = 13)]
		public CrmNumber sgt_aantal_toernooien
		{
			get
			{
				return this.sgt_aantal_toernooienField;
			}
			set
			{
				this.sgt_aantal_toernooienField = value;
				base.RaisePropertyChanged("sgt_aantal_toernooien");
			}
		}
		[XmlElement(Order = 14)]
		public Picklist sgt_acceptatiecriterium1
		{
			get
			{
				return this.sgt_acceptatiecriterium1Field;
			}
			set
			{
				this.sgt_acceptatiecriterium1Field = value;
				base.RaisePropertyChanged("sgt_acceptatiecriterium1");
			}
		}
		[XmlElement(Order = 15)]
		public Picklist sgt_acceptatiecriterium2
		{
			get
			{
				return this.sgt_acceptatiecriterium2Field;
			}
			set
			{
				this.sgt_acceptatiecriterium2Field = value;
				base.RaisePropertyChanged("sgt_acceptatiecriterium2");
			}
		}
		[XmlElement(Order = 16)]
		public Picklist sgt_acceptatiecriterium3
		{
			get
			{
				return this.sgt_acceptatiecriterium3Field;
			}
			set
			{
				this.sgt_acceptatiecriterium3Field = value;
				base.RaisePropertyChanged("sgt_acceptatiecriterium3");
			}
		}
		[XmlElement(Order = 17)]
		public CrmBoolean sgt_accepteren
		{
			get
			{
				return this.sgt_accepterenField;
			}
			set
			{
				this.sgt_accepterenField = value;
				base.RaisePropertyChanged("sgt_accepteren");
			}
		}
		[XmlElement(Order = 18)]
		public CrmBoolean sgt_controle_acceptatie_enkelspel
		{
			get
			{
				return this.sgt_controle_acceptatie_enkelspelField;
			}
			set
			{
				this.sgt_controle_acceptatie_enkelspelField = value;
				base.RaisePropertyChanged("sgt_controle_acceptatie_enkelspel");
			}
		}
		[XmlElement(Order = 19)]
		public CrmDateTime sgt_datum_acceptatie
		{
			get
			{
				return this.sgt_datum_acceptatieField;
			}
			set
			{
				this.sgt_datum_acceptatieField = value;
				base.RaisePropertyChanged("sgt_datum_acceptatie");
			}
		}
		[XmlElement(Order = 20)]
		public CrmDateTime sgt_datum_tm
		{
			get
			{
				return this.sgt_datum_tmField;
			}
			set
			{
				this.sgt_datum_tmField = value;
				base.RaisePropertyChanged("sgt_datum_tm");
			}
		}
		[XmlElement(Order = 21)]
		public CrmDateTime sgt_datum_vanaf
		{
			get
			{
				return this.sgt_datum_vanafField;
			}
			set
			{
				this.sgt_datum_vanafField = value;
				base.RaisePropertyChanged("sgt_datum_vanaf");
			}
		}
		[XmlElement(Order = 22)]
		public Lookup sgt_geaccepteerd_doorid
		{
			get
			{
				return this.sgt_geaccepteerd_dooridField;
			}
			set
			{
				this.sgt_geaccepteerd_dooridField = value;
				base.RaisePropertyChanged("sgt_geaccepteerd_doorid");
			}
		}
		[XmlElement(Order = 23)]
		public Picklist sgt_geslacht
		{
			get
			{
				return this.sgt_geslachtField;
			}
			set
			{
				this.sgt_geslachtField = value;
				base.RaisePropertyChanged("sgt_geslacht");
			}
		}
		[XmlElement(Order = 24)]
		public CrmNumber sgt_leeftijd_tm
		{
			get
			{
				return this.sgt_leeftijd_tmField;
			}
			set
			{
				this.sgt_leeftijd_tmField = value;
				base.RaisePropertyChanged("sgt_leeftijd_tm");
			}
		}
		[XmlElement(Order = 25)]
		public CrmNumber sgt_leeftijd_vanaf
		{
			get
			{
				return this.sgt_leeftijd_vanafField;
			}
			set
			{
				this.sgt_leeftijd_vanafField = value;
				base.RaisePropertyChanged("sgt_leeftijd_vanaf");
			}
		}
		[XmlElement(Order = 26)]
		public Lookup sgt_leeftijdscategorieid
		{
			get
			{
				return this.sgt_leeftijdscategorieidField;
			}
			set
			{
				this.sgt_leeftijdscategorieidField = value;
				base.RaisePropertyChanged("sgt_leeftijdscategorieid");
			}
		}
		[XmlElement(Order = 27)]
		public Picklist sgt_periode
		{
			get
			{
				return this.sgt_periodeField;
			}
			set
			{
				this.sgt_periodeField = value;
				base.RaisePropertyChanged("sgt_periode");
			}
		}
		[XmlElement(Order = 28)]
		public CrmDateTime sgt_ranglijst_datum
		{
			get
			{
				return this.sgt_ranglijst_datumField;
			}
			set
			{
				this.sgt_ranglijst_datumField = value;
				base.RaisePropertyChanged("sgt_ranglijst_datum");
			}
		}
		[XmlElement(Order = 29)]
		public Picklist sgt_ranglijst_geslacht
		{
			get
			{
				return this.sgt_ranglijst_geslachtField;
			}
			set
			{
				this.sgt_ranglijst_geslachtField = value;
				base.RaisePropertyChanged("sgt_ranglijst_geslacht");
			}
		}
		[XmlElement(Order = 30)]
		public Lookup sgt_ranglijst_groepid
		{
			get
			{
				return this.sgt_ranglijst_groepidField;
			}
			set
			{
				this.sgt_ranglijst_groepidField = value;
				base.RaisePropertyChanged("sgt_ranglijst_groepid");
			}
		}
		[XmlElement(Order = 31)]
		public Picklist sgt_ranglijst_spelsoort
		{
			get
			{
				return this.sgt_ranglijst_spelsoortField;
			}
			set
			{
				this.sgt_ranglijst_spelsoortField = value;
				base.RaisePropertyChanged("sgt_ranglijst_spelsoort");
			}
		}
		[XmlElement(Order = 32)]
		public CrmBoolean sgt_reservelijst
		{
			get
			{
				return this.sgt_reservelijstField;
			}
			set
			{
				this.sgt_reservelijstField = value;
				base.RaisePropertyChanged("sgt_reservelijst");
			}
		}
		[XmlElement(Order = 33)]
		public CrmBoolean sgt_special_exempts_aanvullen
		{
			get
			{
				return this.sgt_special_exempts_aanvullenField;
			}
			set
			{
				this.sgt_special_exempts_aanvullenField = value;
				base.RaisePropertyChanged("sgt_special_exempts_aanvullen");
			}
		}
		[XmlElement(Order = 34)]
		public Lookup sgt_speelsterkteid
		{
			get
			{
				return this.sgt_speelsterkteidField;
			}
			set
			{
				this.sgt_speelsterkteidField = value;
				base.RaisePropertyChanged("sgt_speelsterkteid");
			}
		}
		[XmlElement(Order = 35)]
		public Picklist sgt_spelsoort
		{
			get
			{
				return this.sgt_spelsoortField;
			}
			set
			{
				this.sgt_spelsoortField = value;
				base.RaisePropertyChanged("sgt_spelsoort");
			}
		}
		[XmlElement(Order = 36)]
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
		[XmlElement(Order = 37)]
		public Picklist sgt_subcriterium_i1
		{
			get
			{
				return this.sgt_subcriterium_i1Field;
			}
			set
			{
				this.sgt_subcriterium_i1Field = value;
				base.RaisePropertyChanged("sgt_subcriterium_i1");
			}
		}
		[XmlElement(Order = 38)]
		public Picklist sgt_subcriterium_i2
		{
			get
			{
				return this.sgt_subcriterium_i2Field;
			}
			set
			{
				this.sgt_subcriterium_i2Field = value;
				base.RaisePropertyChanged("sgt_subcriterium_i2");
			}
		}
		[XmlElement(Order = 39)]
		public Picklist sgt_subcriterium_i3
		{
			get
			{
				return this.sgt_subcriterium_i3Field;
			}
			set
			{
				this.sgt_subcriterium_i3Field = value;
				base.RaisePropertyChanged("sgt_subcriterium_i3");
			}
		}
		[XmlElement(Order = 40)]
		public Picklist sgt_subcriterium_i4
		{
			get
			{
				return this.sgt_subcriterium_i4Field;
			}
			set
			{
				this.sgt_subcriterium_i4Field = value;
				base.RaisePropertyChanged("sgt_subcriterium_i4");
			}
		}
		[XmlElement(Order = 41)]
		public Picklist sgt_subcriterium_ii1
		{
			get
			{
				return this.sgt_subcriterium_ii1Field;
			}
			set
			{
				this.sgt_subcriterium_ii1Field = value;
				base.RaisePropertyChanged("sgt_subcriterium_ii1");
			}
		}
		[XmlElement(Order = 42)]
		public Picklist sgt_subcriterium_ii2
		{
			get
			{
				return this.sgt_subcriterium_ii2Field;
			}
			set
			{
				this.sgt_subcriterium_ii2Field = value;
				base.RaisePropertyChanged("sgt_subcriterium_ii2");
			}
		}
		[XmlElement(Order = 43)]
		public Picklist sgt_subcriterium_ii3
		{
			get
			{
				return this.sgt_subcriterium_ii3Field;
			}
			set
			{
				this.sgt_subcriterium_ii3Field = value;
				base.RaisePropertyChanged("sgt_subcriterium_ii3");
			}
		}
		[XmlElement(Order = 44)]
		public Picklist sgt_subcriterium_ii4
		{
			get
			{
				return this.sgt_subcriterium_ii4Field;
			}
			set
			{
				this.sgt_subcriterium_ii4Field = value;
				base.RaisePropertyChanged("sgt_subcriterium_ii4");
			}
		}
		[XmlElement(Order = 45)]
		public Picklist sgt_subcriterium_iii1
		{
			get
			{
				return this.sgt_subcriterium_iii1Field;
			}
			set
			{
				this.sgt_subcriterium_iii1Field = value;
				base.RaisePropertyChanged("sgt_subcriterium_iii1");
			}
		}
		[XmlElement(Order = 46)]
		public Picklist sgt_subcriterium_iii2
		{
			get
			{
				return this.sgt_subcriterium_iii2Field;
			}
			set
			{
				this.sgt_subcriterium_iii2Field = value;
				base.RaisePropertyChanged("sgt_subcriterium_iii2");
			}
		}
		[XmlElement(Order = 47)]
		public Picklist sgt_subcriterium_iii3
		{
			get
			{
				return this.sgt_subcriterium_iii3Field;
			}
			set
			{
				this.sgt_subcriterium_iii3Field = value;
				base.RaisePropertyChanged("sgt_subcriterium_iii3");
			}
		}
		[XmlElement(Order = 48)]
		public Picklist sgt_subcriterium_iii4
		{
			get
			{
				return this.sgt_subcriterium_iii4Field;
			}
			set
			{
				this.sgt_subcriterium_iii4Field = value;
				base.RaisePropertyChanged("sgt_subcriterium_iii4");
			}
		}
		[XmlElement("sgt_toe_automatische_acceptatie_van_spelers", Order = 49)]
		public string sgt_toe_automatische_acceptatie_van_spelers1
		{
			get
			{
				return this.sgt_toe_automatische_acceptatie_van_spelers1Field;
			}
			set
			{
				this.sgt_toe_automatische_acceptatie_van_spelers1Field = value;
				base.RaisePropertyChanged("sgt_toe_automatische_acceptatie_van_spelers1");
			}
		}
		[XmlElement(Order = 50)]
		public Key sgt_toe_automatische_acceptatie_van_spelersid
		{
			get
			{
				return this.sgt_toe_automatische_acceptatie_van_spelersidField;
			}
			set
			{
				this.sgt_toe_automatische_acceptatie_van_spelersidField = value;
				base.RaisePropertyChanged("sgt_toe_automatische_acceptatie_van_spelersid");
			}
		}
		[XmlElement(Order = 51)]
		public Lookup sgt_toernooi_afhandeling_id
		{
			get
			{
				return this.sgt_toernooi_afhandeling_idField;
			}
			set
			{
				this.sgt_toernooi_afhandeling_idField = value;
				base.RaisePropertyChanged("sgt_toernooi_afhandeling_id");
			}
		}
		[XmlElement(Order = 52)]
		public Lookup sgt_toernooi_onderdeelid
		{
			get
			{
				return this.sgt_toernooi_onderdeelidField;
			}
			set
			{
				this.sgt_toernooi_onderdeelidField = value;
				base.RaisePropertyChanged("sgt_toernooi_onderdeelid");
			}
		}
		[XmlElement(Order = 53)]
		public Lookup sgt_toernooigroepid
		{
			get
			{
				return this.sgt_toernooigroepidField;
			}
			set
			{
				this.sgt_toernooigroepidField = value;
				base.RaisePropertyChanged("sgt_toernooigroepid");
			}
		}
		[XmlElement(Order = 54)]
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
		[XmlElement(Order = 55)]
		public Lookup sgt_toernooischema_id
		{
			get
			{
				return this.sgt_toernooischema_idField;
			}
			set
			{
				this.sgt_toernooischema_idField = value;
				base.RaisePropertyChanged("sgt_toernooischema_id");
			}
		}
		[XmlElement(Order = 56)]
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
		[XmlElement(Order = 57)]
		public string sgt_toernooiweek
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
		[XmlElement(Order = 58)]
		public Sgt_toe_automatische_acceptatie_van_spelersStateInfo statecode
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
		[XmlElement(Order = 59)]
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
		[XmlElement(Order = 60)]
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
		[XmlElement(Order = 61)]
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
