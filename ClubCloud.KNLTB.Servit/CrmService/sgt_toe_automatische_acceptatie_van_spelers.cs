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
		public CrmNumber sgt_aantal_ingeschreven_spelers
		{
			get
			{
				return this.sgt_aantal_ingeschreven_spelersField;
			}
			set
			{
				this.sgt_aantal_ingeschreven_spelersField = value;
			}
		}
		public CrmNumber sgt_aantal_niet_geaccepteerde_spelers
		{
			get
			{
				return this.sgt_aantal_niet_geaccepteerde_spelersField;
			}
			set
			{
				this.sgt_aantal_niet_geaccepteerde_spelersField = value;
			}
		}
		public CrmNumber sgt_aantal_spelers_geaccepteerd
		{
			get
			{
				return this.sgt_aantal_spelers_geaccepteerdField;
			}
			set
			{
				this.sgt_aantal_spelers_geaccepteerdField = value;
			}
		}
		public CrmNumber sgt_aantal_spelers_geaccepteerd_reservelijst
		{
			get
			{
				return this.sgt_aantal_spelers_geaccepteerd_reservelijstField;
			}
			set
			{
				this.sgt_aantal_spelers_geaccepteerd_reservelijstField = value;
			}
		}
		public CrmNumber sgt_aantal_spelers_reservelijst
		{
			get
			{
				return this.sgt_aantal_spelers_reservelijstField;
			}
			set
			{
				this.sgt_aantal_spelers_reservelijstField = value;
			}
		}
		public CrmNumber sgt_aantal_toernooien
		{
			get
			{
				return this.sgt_aantal_toernooienField;
			}
			set
			{
				this.sgt_aantal_toernooienField = value;
			}
		}
		public Picklist sgt_acceptatiecriterium1
		{
			get
			{
				return this.sgt_acceptatiecriterium1Field;
			}
			set
			{
				this.sgt_acceptatiecriterium1Field = value;
			}
		}
		public Picklist sgt_acceptatiecriterium2
		{
			get
			{
				return this.sgt_acceptatiecriterium2Field;
			}
			set
			{
				this.sgt_acceptatiecriterium2Field = value;
			}
		}
		public Picklist sgt_acceptatiecriterium3
		{
			get
			{
				return this.sgt_acceptatiecriterium3Field;
			}
			set
			{
				this.sgt_acceptatiecriterium3Field = value;
			}
		}
		public CrmBoolean sgt_accepteren
		{
			get
			{
				return this.sgt_accepterenField;
			}
			set
			{
				this.sgt_accepterenField = value;
			}
		}
		public CrmBoolean sgt_controle_acceptatie_enkelspel
		{
			get
			{
				return this.sgt_controle_acceptatie_enkelspelField;
			}
			set
			{
				this.sgt_controle_acceptatie_enkelspelField = value;
			}
		}
		public CrmDateTime sgt_datum_acceptatie
		{
			get
			{
				return this.sgt_datum_acceptatieField;
			}
			set
			{
				this.sgt_datum_acceptatieField = value;
			}
		}
		public CrmDateTime sgt_datum_tm
		{
			get
			{
				return this.sgt_datum_tmField;
			}
			set
			{
				this.sgt_datum_tmField = value;
			}
		}
		public CrmDateTime sgt_datum_vanaf
		{
			get
			{
				return this.sgt_datum_vanafField;
			}
			set
			{
				this.sgt_datum_vanafField = value;
			}
		}
		public Lookup sgt_geaccepteerd_doorid
		{
			get
			{
				return this.sgt_geaccepteerd_dooridField;
			}
			set
			{
				this.sgt_geaccepteerd_dooridField = value;
			}
		}
		public Picklist sgt_geslacht
		{
			get
			{
				return this.sgt_geslachtField;
			}
			set
			{
				this.sgt_geslachtField = value;
			}
		}
		public CrmNumber sgt_leeftijd_tm
		{
			get
			{
				return this.sgt_leeftijd_tmField;
			}
			set
			{
				this.sgt_leeftijd_tmField = value;
			}
		}
		public CrmNumber sgt_leeftijd_vanaf
		{
			get
			{
				return this.sgt_leeftijd_vanafField;
			}
			set
			{
				this.sgt_leeftijd_vanafField = value;
			}
		}
		public Lookup sgt_leeftijdscategorieid
		{
			get
			{
				return this.sgt_leeftijdscategorieidField;
			}
			set
			{
				this.sgt_leeftijdscategorieidField = value;
			}
		}
		public Picklist sgt_periode
		{
			get
			{
				return this.sgt_periodeField;
			}
			set
			{
				this.sgt_periodeField = value;
			}
		}
		public CrmDateTime sgt_ranglijst_datum
		{
			get
			{
				return this.sgt_ranglijst_datumField;
			}
			set
			{
				this.sgt_ranglijst_datumField = value;
			}
		}
		public Picklist sgt_ranglijst_geslacht
		{
			get
			{
				return this.sgt_ranglijst_geslachtField;
			}
			set
			{
				this.sgt_ranglijst_geslachtField = value;
			}
		}
		public Lookup sgt_ranglijst_groepid
		{
			get
			{
				return this.sgt_ranglijst_groepidField;
			}
			set
			{
				this.sgt_ranglijst_groepidField = value;
			}
		}
		public Picklist sgt_ranglijst_spelsoort
		{
			get
			{
				return this.sgt_ranglijst_spelsoortField;
			}
			set
			{
				this.sgt_ranglijst_spelsoortField = value;
			}
		}
		public CrmBoolean sgt_reservelijst
		{
			get
			{
				return this.sgt_reservelijstField;
			}
			set
			{
				this.sgt_reservelijstField = value;
			}
		}
		public CrmBoolean sgt_special_exempts_aanvullen
		{
			get
			{
				return this.sgt_special_exempts_aanvullenField;
			}
			set
			{
				this.sgt_special_exempts_aanvullenField = value;
			}
		}
		public Lookup sgt_speelsterkteid
		{
			get
			{
				return this.sgt_speelsterkteidField;
			}
			set
			{
				this.sgt_speelsterkteidField = value;
			}
		}
		public Picklist sgt_spelsoort
		{
			get
			{
				return this.sgt_spelsoortField;
			}
			set
			{
				this.sgt_spelsoortField = value;
			}
		}
		public Picklist sgt_status
		{
			get
			{
				return this.sgt_statusField;
			}
			set
			{
				this.sgt_statusField = value;
			}
		}
		public Picklist sgt_subcriterium_i1
		{
			get
			{
				return this.sgt_subcriterium_i1Field;
			}
			set
			{
				this.sgt_subcriterium_i1Field = value;
			}
		}
		public Picklist sgt_subcriterium_i2
		{
			get
			{
				return this.sgt_subcriterium_i2Field;
			}
			set
			{
				this.sgt_subcriterium_i2Field = value;
			}
		}
		public Picklist sgt_subcriterium_i3
		{
			get
			{
				return this.sgt_subcriterium_i3Field;
			}
			set
			{
				this.sgt_subcriterium_i3Field = value;
			}
		}
		public Picklist sgt_subcriterium_i4
		{
			get
			{
				return this.sgt_subcriterium_i4Field;
			}
			set
			{
				this.sgt_subcriterium_i4Field = value;
			}
		}
		public Picklist sgt_subcriterium_ii1
		{
			get
			{
				return this.sgt_subcriterium_ii1Field;
			}
			set
			{
				this.sgt_subcriterium_ii1Field = value;
			}
		}
		public Picklist sgt_subcriterium_ii2
		{
			get
			{
				return this.sgt_subcriterium_ii2Field;
			}
			set
			{
				this.sgt_subcriterium_ii2Field = value;
			}
		}
		public Picklist sgt_subcriterium_ii3
		{
			get
			{
				return this.sgt_subcriterium_ii3Field;
			}
			set
			{
				this.sgt_subcriterium_ii3Field = value;
			}
		}
		public Picklist sgt_subcriterium_ii4
		{
			get
			{
				return this.sgt_subcriterium_ii4Field;
			}
			set
			{
				this.sgt_subcriterium_ii4Field = value;
			}
		}
		public Picklist sgt_subcriterium_iii1
		{
			get
			{
				return this.sgt_subcriterium_iii1Field;
			}
			set
			{
				this.sgt_subcriterium_iii1Field = value;
			}
		}
		public Picklist sgt_subcriterium_iii2
		{
			get
			{
				return this.sgt_subcriterium_iii2Field;
			}
			set
			{
				this.sgt_subcriterium_iii2Field = value;
			}
		}
		public Picklist sgt_subcriterium_iii3
		{
			get
			{
				return this.sgt_subcriterium_iii3Field;
			}
			set
			{
				this.sgt_subcriterium_iii3Field = value;
			}
		}
		public Picklist sgt_subcriterium_iii4
		{
			get
			{
				return this.sgt_subcriterium_iii4Field;
			}
			set
			{
				this.sgt_subcriterium_iii4Field = value;
			}
		}
		[XmlElement("sgt_toe_automatische_acceptatie_van_spelers")]
		public string sgt_toe_automatische_acceptatie_van_spelers1
		{
			get
			{
				return this.sgt_toe_automatische_acceptatie_van_spelers1Field;
			}
			set
			{
				this.sgt_toe_automatische_acceptatie_van_spelers1Field = value;
			}
		}
		public Key sgt_toe_automatische_acceptatie_van_spelersid
		{
			get
			{
				return this.sgt_toe_automatische_acceptatie_van_spelersidField;
			}
			set
			{
				this.sgt_toe_automatische_acceptatie_van_spelersidField = value;
			}
		}
		public Lookup sgt_toernooi_afhandeling_id
		{
			get
			{
				return this.sgt_toernooi_afhandeling_idField;
			}
			set
			{
				this.sgt_toernooi_afhandeling_idField = value;
			}
		}
		public Lookup sgt_toernooi_onderdeelid
		{
			get
			{
				return this.sgt_toernooi_onderdeelidField;
			}
			set
			{
				this.sgt_toernooi_onderdeelidField = value;
			}
		}
		public Lookup sgt_toernooigroepid
		{
			get
			{
				return this.sgt_toernooigroepidField;
			}
			set
			{
				this.sgt_toernooigroepidField = value;
			}
		}
		public Lookup sgt_toernooikalenderid
		{
			get
			{
				return this.sgt_toernooikalenderidField;
			}
			set
			{
				this.sgt_toernooikalenderidField = value;
			}
		}
		public Lookup sgt_toernooischema_id
		{
			get
			{
				return this.sgt_toernooischema_idField;
			}
			set
			{
				this.sgt_toernooischema_idField = value;
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
		public string sgt_toernooiweek
		{
			get
			{
				return this.sgt_toernooiweekField;
			}
			set
			{
				this.sgt_toernooiweekField = value;
			}
		}
		public Sgt_toe_automatische_acceptatie_van_spelersStateInfo statecode
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
