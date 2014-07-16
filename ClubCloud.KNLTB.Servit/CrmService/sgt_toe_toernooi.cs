using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[GeneratedCode("System.Xml", "4.0.30319.33440")]
	[Serializable]
	[XmlType(Namespace="http://schemas.microsoft.com/crm/2007/WebServices")]
	public class sgt_toe_toernooi : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private string sgt_aanhef_tavField;

		private CrmNumber sgt_aantal_banenField;

		private Lookup sgt_aanvraagformulieridField;

		private Lookup sgt_accommodatieidField;

		private string sgt_afwijkingenField;

		private CrmDateTime sgt_begindatum_1Field;

		private CrmDateTime sgt_begindatum_2Field;

		private CrmDateTime sgt_begindatum_3Field;

		private CrmDateTime sgt_begindatum_werkelijkField;

		private Lookup sgt_bondsgedelegeerde_idField;

		private Lookup sgt_bondsgedelegeerdeidField;

		private Lookup sgt_bondsorganisatieidField;

		private Lookup sgt_contactpersoonidField;

		private CrmDateTime sgt_definitief_begindatumField;

		private CrmDateTime sgt_definitief_einddatumField;

		private string sgt_definitief_week_tmField;

		private string sgt_definitief_week_vanafField;

		private CrmBoolean sgt_dinsdagField;

		private Lookup sgt_district_idField;

		private CrmBoolean sgt_donderdagField;

		private CrmDateTime sgt_einddatum_1Field;

		private CrmDateTime sgt_einddatum_2Field;

		private CrmDateTime sgt_einddatum_3Field;

		private CrmDateTime sgt_einddatum_werkelijkField;

		private string sgt_emailField;

		private string sgt_huisnummerField;

		private CrmBoolean sgt_maandagField;

		private CrmNumber sgt_max_aantal_partijenField;

		private CrmBoolean sgt_op_afstandField;

		private string sgt_opmerkingenField;

		private string sgt_opmerkingen_toernooiField;

		private string sgt_plaatsField;

		private string sgt_postcodeField;

		private Picklist sgt_statusField;

		private string sgt_straatField;

		private CrmBoolean sgt_teamautorisaties_uitschakelenField;

		private string sgt_telefoonnummerField;

		private string sgt_toe_toernooi1Field;

		private Key sgt_toe_toernooiidField;

		private Lookup sgt_toernooi_afhandeling_vorig_jaarField;

		private Lookup sgt_toernooi_vorig_jaaridField;

		private string sgt_toernooinummerField;

		private Lookup sgt_toernooiorganisatieidField;

		private Lookup sgt_toernooisoortidField;

		private string sgt_toevoegingField;

		private CrmBoolean sgt_verlichtingField;

		private CrmBoolean sgt_volgnummer_negerenField;

		private Lookup sgt_voorkeur_hs1idField;

		private Lookup sgt_voorkeur_hs2idField;

		private Lookup sgt_voorkeur_hs3idField;

		private CrmBoolean sgt_vrijdagField;

		private string sgt_websiteField;

		private Lookup sgt_wedstrijdleideridField;

		private string sgt_week_tm_1Field;

		private string sgt_week_tm_2Field;

		private string sgt_week_tm_3Field;

		private string sgt_week_vanaf_1Field;

		private string sgt_week_vanaf_2Field;

		private string sgt_week_vanaf_3Field;

		private CrmBoolean sgt_woensdagField;

		private CrmBoolean sgt_zaterdagField;

		private CrmBoolean sgt_zondagField;

		private string sgt_zwaarteField;

		private Lookup sgt_zwaarteidField;

		private Sgt_toe_toernooiStateInfo statecodeField;

		private Status statuscodeField;

		private CrmNumber timezoneruleversionnumberField;

		private CrmNumber utcconversiontimezonecodeField;

		[XmlElement] //[XmlElement(Order=0)]
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

		[XmlElement] //[XmlElement(Order=1)]
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

		[XmlElement] //[XmlElement(Order=2)]
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

		[XmlElement] //[XmlElement(Order=3)]
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

		[XmlElement] //[XmlElement(Order=4)]
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

		[XmlElement] //[XmlElement(Order=5)]
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

		[XmlElement] //[XmlElement(Order=6)]
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

		[XmlElement] //[XmlElement(Order=7)]
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

		[XmlElement] //[XmlElement(Order=8)]
		public string sgt_aanhef_tav
		{
			get
			{
				return this.sgt_aanhef_tavField;
			}
			set
			{
				this.sgt_aanhef_tavField = value;
				base.RaisePropertyChanged("sgt_aanhef_tav");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public CrmNumber sgt_aantal_banen
		{
			get
			{
				return this.sgt_aantal_banenField;
			}
			set
			{
				this.sgt_aantal_banenField = value;
				base.RaisePropertyChanged("sgt_aantal_banen");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public Lookup sgt_aanvraagformulierid
		{
			get
			{
				return this.sgt_aanvraagformulieridField;
			}
			set
			{
				this.sgt_aanvraagformulieridField = value;
				base.RaisePropertyChanged("sgt_aanvraagformulierid");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public Lookup sgt_accommodatieid
		{
			get
			{
				return this.sgt_accommodatieidField;
			}
			set
			{
				this.sgt_accommodatieidField = value;
				base.RaisePropertyChanged("sgt_accommodatieid");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public string sgt_afwijkingen
		{
			get
			{
				return this.sgt_afwijkingenField;
			}
			set
			{
				this.sgt_afwijkingenField = value;
				base.RaisePropertyChanged("sgt_afwijkingen");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public CrmDateTime sgt_begindatum_1
		{
			get
			{
				return this.sgt_begindatum_1Field;
			}
			set
			{
				this.sgt_begindatum_1Field = value;
				base.RaisePropertyChanged("sgt_begindatum_1");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public CrmDateTime sgt_begindatum_2
		{
			get
			{
				return this.sgt_begindatum_2Field;
			}
			set
			{
				this.sgt_begindatum_2Field = value;
				base.RaisePropertyChanged("sgt_begindatum_2");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public CrmDateTime sgt_begindatum_3
		{
			get
			{
				return this.sgt_begindatum_3Field;
			}
			set
			{
				this.sgt_begindatum_3Field = value;
				base.RaisePropertyChanged("sgt_begindatum_3");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public CrmDateTime sgt_begindatum_werkelijk
		{
			get
			{
				return this.sgt_begindatum_werkelijkField;
			}
			set
			{
				this.sgt_begindatum_werkelijkField = value;
				base.RaisePropertyChanged("sgt_begindatum_werkelijk");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public Lookup sgt_bondsgedelegeerde_id
		{
			get
			{
				return this.sgt_bondsgedelegeerde_idField;
			}
			set
			{
				this.sgt_bondsgedelegeerde_idField = value;
				base.RaisePropertyChanged("sgt_bondsgedelegeerde_id");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public Lookup sgt_bondsgedelegeerdeid
		{
			get
			{
				return this.sgt_bondsgedelegeerdeidField;
			}
			set
			{
				this.sgt_bondsgedelegeerdeidField = value;
				base.RaisePropertyChanged("sgt_bondsgedelegeerdeid");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
		public Lookup sgt_bondsorganisatieid
		{
			get
			{
				return this.sgt_bondsorganisatieidField;
			}
			set
			{
				this.sgt_bondsorganisatieidField = value;
				base.RaisePropertyChanged("sgt_bondsorganisatieid");
			}
		}

		[XmlElement] //[XmlElement(Order=20)]
		public Lookup sgt_contactpersoonid
		{
			get
			{
				return this.sgt_contactpersoonidField;
			}
			set
			{
				this.sgt_contactpersoonidField = value;
				base.RaisePropertyChanged("sgt_contactpersoonid");
			}
		}

		[XmlElement] //[XmlElement(Order=21)]
		public CrmDateTime sgt_definitief_begindatum
		{
			get
			{
				return this.sgt_definitief_begindatumField;
			}
			set
			{
				this.sgt_definitief_begindatumField = value;
				base.RaisePropertyChanged("sgt_definitief_begindatum");
			}
		}

		[XmlElement] //[XmlElement(Order=22)]
		public CrmDateTime sgt_definitief_einddatum
		{
			get
			{
				return this.sgt_definitief_einddatumField;
			}
			set
			{
				this.sgt_definitief_einddatumField = value;
				base.RaisePropertyChanged("sgt_definitief_einddatum");
			}
		}

		[XmlElement] //[XmlElement(Order=23)]
		public string sgt_definitief_week_tm
		{
			get
			{
				return this.sgt_definitief_week_tmField;
			}
			set
			{
				this.sgt_definitief_week_tmField = value;
				base.RaisePropertyChanged("sgt_definitief_week_tm");
			}
		}

		[XmlElement] //[XmlElement(Order=24)]
		public string sgt_definitief_week_vanaf
		{
			get
			{
				return this.sgt_definitief_week_vanafField;
			}
			set
			{
				this.sgt_definitief_week_vanafField = value;
				base.RaisePropertyChanged("sgt_definitief_week_vanaf");
			}
		}

		[XmlElement] //[XmlElement(Order=25)]
		public CrmBoolean sgt_dinsdag
		{
			get
			{
				return this.sgt_dinsdagField;
			}
			set
			{
				this.sgt_dinsdagField = value;
				base.RaisePropertyChanged("sgt_dinsdag");
			}
		}

		[XmlElement] //[XmlElement(Order=26)]
		public Lookup sgt_district_id
		{
			get
			{
				return this.sgt_district_idField;
			}
			set
			{
				this.sgt_district_idField = value;
				base.RaisePropertyChanged("sgt_district_id");
			}
		}

		[XmlElement] //[XmlElement(Order=27)]
		public CrmBoolean sgt_donderdag
		{
			get
			{
				return this.sgt_donderdagField;
			}
			set
			{
				this.sgt_donderdagField = value;
				base.RaisePropertyChanged("sgt_donderdag");
			}
		}

		[XmlElement] //[XmlElement(Order=28)]
		public CrmDateTime sgt_einddatum_1
		{
			get
			{
				return this.sgt_einddatum_1Field;
			}
			set
			{
				this.sgt_einddatum_1Field = value;
				base.RaisePropertyChanged("sgt_einddatum_1");
			}
		}

		[XmlElement] //[XmlElement(Order=29)]
		public CrmDateTime sgt_einddatum_2
		{
			get
			{
				return this.sgt_einddatum_2Field;
			}
			set
			{
				this.sgt_einddatum_2Field = value;
				base.RaisePropertyChanged("sgt_einddatum_2");
			}
		}

		[XmlElement] //[XmlElement(Order=30)]
		public CrmDateTime sgt_einddatum_3
		{
			get
			{
				return this.sgt_einddatum_3Field;
			}
			set
			{
				this.sgt_einddatum_3Field = value;
				base.RaisePropertyChanged("sgt_einddatum_3");
			}
		}

		[XmlElement] //[XmlElement(Order=31)]
		public CrmDateTime sgt_einddatum_werkelijk
		{
			get
			{
				return this.sgt_einddatum_werkelijkField;
			}
			set
			{
				this.sgt_einddatum_werkelijkField = value;
				base.RaisePropertyChanged("sgt_einddatum_werkelijk");
			}
		}

		[XmlElement] //[XmlElement(Order=32)]
		public string sgt_email
		{
			get
			{
				return this.sgt_emailField;
			}
			set
			{
				this.sgt_emailField = value;
				base.RaisePropertyChanged("sgt_email");
			}
		}

		[XmlElement] //[XmlElement(Order=33)]
		public string sgt_huisnummer
		{
			get
			{
				return this.sgt_huisnummerField;
			}
			set
			{
				this.sgt_huisnummerField = value;
				base.RaisePropertyChanged("sgt_huisnummer");
			}
		}

		[XmlElement] //[XmlElement(Order=34)]
		public CrmBoolean sgt_maandag
		{
			get
			{
				return this.sgt_maandagField;
			}
			set
			{
				this.sgt_maandagField = value;
				base.RaisePropertyChanged("sgt_maandag");
			}
		}

		[XmlElement] //[XmlElement(Order=35)]
		public CrmNumber sgt_max_aantal_partijen
		{
			get
			{
				return this.sgt_max_aantal_partijenField;
			}
			set
			{
				this.sgt_max_aantal_partijenField = value;
				base.RaisePropertyChanged("sgt_max_aantal_partijen");
			}
		}

		[XmlElement] //[XmlElement(Order=36)]
		public CrmBoolean sgt_op_afstand
		{
			get
			{
				return this.sgt_op_afstandField;
			}
			set
			{
				this.sgt_op_afstandField = value;
				base.RaisePropertyChanged("sgt_op_afstand");
			}
		}

		[XmlElement] //[XmlElement(Order=37)]
		public string sgt_opmerkingen
		{
			get
			{
				return this.sgt_opmerkingenField;
			}
			set
			{
				this.sgt_opmerkingenField = value;
				base.RaisePropertyChanged("sgt_opmerkingen");
			}
		}

		[XmlElement] //[XmlElement(Order=38)]
		public string sgt_opmerkingen_toernooi
		{
			get
			{
				return this.sgt_opmerkingen_toernooiField;
			}
			set
			{
				this.sgt_opmerkingen_toernooiField = value;
				base.RaisePropertyChanged("sgt_opmerkingen_toernooi");
			}
		}

		[XmlElement] //[XmlElement(Order=39)]
		public string sgt_plaats
		{
			get
			{
				return this.sgt_plaatsField;
			}
			set
			{
				this.sgt_plaatsField = value;
				base.RaisePropertyChanged("sgt_plaats");
			}
		}

		[XmlElement] //[XmlElement(Order=40)]
		public string sgt_postcode
		{
			get
			{
				return this.sgt_postcodeField;
			}
			set
			{
				this.sgt_postcodeField = value;
				base.RaisePropertyChanged("sgt_postcode");
			}
		}

		[XmlElement] //[XmlElement(Order=41)]
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

		[XmlElement] //[XmlElement(Order=42)]
		public string sgt_straat
		{
			get
			{
				return this.sgt_straatField;
			}
			set
			{
				this.sgt_straatField = value;
				base.RaisePropertyChanged("sgt_straat");
			}
		}

		[XmlElement] //[XmlElement(Order=43)]
		public CrmBoolean sgt_teamautorisaties_uitschakelen
		{
			get
			{
				return this.sgt_teamautorisaties_uitschakelenField;
			}
			set
			{
				this.sgt_teamautorisaties_uitschakelenField = value;
				base.RaisePropertyChanged("sgt_teamautorisaties_uitschakelen");
			}
		}

		[XmlElement] //[XmlElement(Order=44)]
		public string sgt_telefoonnummer
		{
			get
			{
				return this.sgt_telefoonnummerField;
			}
			set
			{
				this.sgt_telefoonnummerField = value;
				base.RaisePropertyChanged("sgt_telefoonnummer");
			}
		}

		[XmlElement("sgt_toe_toernooi")] //, Order=45)]
		public string sgt_toe_toernooi1
		{
			get
			{
				return this.sgt_toe_toernooi1Field;
			}
			set
			{
				this.sgt_toe_toernooi1Field = value;
				base.RaisePropertyChanged("sgt_toe_toernooi1");
			}
		}

		[XmlElement] //[XmlElement(Order=46)]
		public Key sgt_toe_toernooiid
		{
			get
			{
				return this.sgt_toe_toernooiidField;
			}
			set
			{
				this.sgt_toe_toernooiidField = value;
				base.RaisePropertyChanged("sgt_toe_toernooiid");
			}
		}

		[XmlElement] //[XmlElement(Order=47)]
		public Lookup sgt_toernooi_afhandeling_vorig_jaar
		{
			get
			{
				return this.sgt_toernooi_afhandeling_vorig_jaarField;
			}
			set
			{
				this.sgt_toernooi_afhandeling_vorig_jaarField = value;
				base.RaisePropertyChanged("sgt_toernooi_afhandeling_vorig_jaar");
			}
		}

		[XmlElement] //[XmlElement(Order=48)]
		public Lookup sgt_toernooi_vorig_jaarid
		{
			get
			{
				return this.sgt_toernooi_vorig_jaaridField;
			}
			set
			{
				this.sgt_toernooi_vorig_jaaridField = value;
				base.RaisePropertyChanged("sgt_toernooi_vorig_jaarid");
			}
		}

		[XmlElement] //[XmlElement(Order=49)]
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

		[XmlElement] //[XmlElement(Order=50)]
		public Lookup sgt_toernooiorganisatieid
		{
			get
			{
				return this.sgt_toernooiorganisatieidField;
			}
			set
			{
				this.sgt_toernooiorganisatieidField = value;
				base.RaisePropertyChanged("sgt_toernooiorganisatieid");
			}
		}

		[XmlElement] //[XmlElement(Order=51)]
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

		[XmlElement] //[XmlElement(Order=52)]
		public string sgt_toevoeging
		{
			get
			{
				return this.sgt_toevoegingField;
			}
			set
			{
				this.sgt_toevoegingField = value;
				base.RaisePropertyChanged("sgt_toevoeging");
			}
		}

		[XmlElement] //[XmlElement(Order=53)]
		public CrmBoolean sgt_verlichting
		{
			get
			{
				return this.sgt_verlichtingField;
			}
			set
			{
				this.sgt_verlichtingField = value;
				base.RaisePropertyChanged("sgt_verlichting");
			}
		}

		[XmlElement] //[XmlElement(Order=54)]
		public CrmBoolean sgt_volgnummer_negeren
		{
			get
			{
				return this.sgt_volgnummer_negerenField;
			}
			set
			{
				this.sgt_volgnummer_negerenField = value;
				base.RaisePropertyChanged("sgt_volgnummer_negeren");
			}
		}

		[XmlElement] //[XmlElement(Order=55)]
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

		[XmlElement] //[XmlElement(Order=56)]
		public Lookup sgt_voorkeur_hs2id
		{
			get
			{
				return this.sgt_voorkeur_hs2idField;
			}
			set
			{
				this.sgt_voorkeur_hs2idField = value;
				base.RaisePropertyChanged("sgt_voorkeur_hs2id");
			}
		}

		[XmlElement] //[XmlElement(Order=57)]
		public Lookup sgt_voorkeur_hs3id
		{
			get
			{
				return this.sgt_voorkeur_hs3idField;
			}
			set
			{
				this.sgt_voorkeur_hs3idField = value;
				base.RaisePropertyChanged("sgt_voorkeur_hs3id");
			}
		}

		[XmlElement] //[XmlElement(Order=58)]
		public CrmBoolean sgt_vrijdag
		{
			get
			{
				return this.sgt_vrijdagField;
			}
			set
			{
				this.sgt_vrijdagField = value;
				base.RaisePropertyChanged("sgt_vrijdag");
			}
		}

		[XmlElement] //[XmlElement(Order=59)]
		public string sgt_website
		{
			get
			{
				return this.sgt_websiteField;
			}
			set
			{
				this.sgt_websiteField = value;
				base.RaisePropertyChanged("sgt_website");
			}
		}

		[XmlElement] //[XmlElement(Order=60)]
		public Lookup sgt_wedstrijdleiderid
		{
			get
			{
				return this.sgt_wedstrijdleideridField;
			}
			set
			{
				this.sgt_wedstrijdleideridField = value;
				base.RaisePropertyChanged("sgt_wedstrijdleiderid");
			}
		}

		[XmlElement] //[XmlElement(Order=61)]
		public string sgt_week_tm_1
		{
			get
			{
				return this.sgt_week_tm_1Field;
			}
			set
			{
				this.sgt_week_tm_1Field = value;
				base.RaisePropertyChanged("sgt_week_tm_1");
			}
		}

		[XmlElement] //[XmlElement(Order=62)]
		public string sgt_week_tm_2
		{
			get
			{
				return this.sgt_week_tm_2Field;
			}
			set
			{
				this.sgt_week_tm_2Field = value;
				base.RaisePropertyChanged("sgt_week_tm_2");
			}
		}

		[XmlElement] //[XmlElement(Order=63)]
		public string sgt_week_tm_3
		{
			get
			{
				return this.sgt_week_tm_3Field;
			}
			set
			{
				this.sgt_week_tm_3Field = value;
				base.RaisePropertyChanged("sgt_week_tm_3");
			}
		}

		[XmlElement] //[XmlElement(Order=64)]
		public string sgt_week_vanaf_1
		{
			get
			{
				return this.sgt_week_vanaf_1Field;
			}
			set
			{
				this.sgt_week_vanaf_1Field = value;
				base.RaisePropertyChanged("sgt_week_vanaf_1");
			}
		}

		[XmlElement] //[XmlElement(Order=65)]
		public string sgt_week_vanaf_2
		{
			get
			{
				return this.sgt_week_vanaf_2Field;
			}
			set
			{
				this.sgt_week_vanaf_2Field = value;
				base.RaisePropertyChanged("sgt_week_vanaf_2");
			}
		}

		[XmlElement] //[XmlElement(Order=66)]
		public string sgt_week_vanaf_3
		{
			get
			{
				return this.sgt_week_vanaf_3Field;
			}
			set
			{
				this.sgt_week_vanaf_3Field = value;
				base.RaisePropertyChanged("sgt_week_vanaf_3");
			}
		}

		[XmlElement] //[XmlElement(Order=67)]
		public CrmBoolean sgt_woensdag
		{
			get
			{
				return this.sgt_woensdagField;
			}
			set
			{
				this.sgt_woensdagField = value;
				base.RaisePropertyChanged("sgt_woensdag");
			}
		}

		[XmlElement] //[XmlElement(Order=68)]
		public CrmBoolean sgt_zaterdag
		{
			get
			{
				return this.sgt_zaterdagField;
			}
			set
			{
				this.sgt_zaterdagField = value;
				base.RaisePropertyChanged("sgt_zaterdag");
			}
		}

		[XmlElement] //[XmlElement(Order=69)]
		public CrmBoolean sgt_zondag
		{
			get
			{
				return this.sgt_zondagField;
			}
			set
			{
				this.sgt_zondagField = value;
				base.RaisePropertyChanged("sgt_zondag");
			}
		}

		[XmlElement] //[XmlElement(Order=70)]
		public string sgt_zwaarte
		{
			get
			{
				return this.sgt_zwaarteField;
			}
			set
			{
				this.sgt_zwaarteField = value;
				base.RaisePropertyChanged("sgt_zwaarte");
			}
		}

		[XmlElement] //[XmlElement(Order=71)]
		public Lookup sgt_zwaarteid
		{
			get
			{
				return this.sgt_zwaarteidField;
			}
			set
			{
				this.sgt_zwaarteidField = value;
				base.RaisePropertyChanged("sgt_zwaarteid");
			}
		}

		[XmlElement] //[XmlElement(Order=72)]
		public Sgt_toe_toernooiStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=73)]
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

		[XmlElement] //[XmlElement(Order=74)]
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

		[XmlElement] //[XmlElement(Order=75)]
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

		public sgt_toe_toernooi()
		{
		}
	}
}