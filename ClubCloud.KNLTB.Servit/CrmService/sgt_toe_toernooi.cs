using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
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
		public string sgt_aanhef_tav
		{
			get
			{
				return this.sgt_aanhef_tavField;
			}
			set
			{
				this.sgt_aanhef_tavField = value;
			}
		}
		public CrmNumber sgt_aantal_banen
		{
			get
			{
				return this.sgt_aantal_banenField;
			}
			set
			{
				this.sgt_aantal_banenField = value;
			}
		}
		public Lookup sgt_aanvraagformulierid
		{
			get
			{
				return this.sgt_aanvraagformulieridField;
			}
			set
			{
				this.sgt_aanvraagformulieridField = value;
			}
		}
		public Lookup sgt_accommodatieid
		{
			get
			{
				return this.sgt_accommodatieidField;
			}
			set
			{
				this.sgt_accommodatieidField = value;
			}
		}
		public string sgt_afwijkingen
		{
			get
			{
				return this.sgt_afwijkingenField;
			}
			set
			{
				this.sgt_afwijkingenField = value;
			}
		}
		public CrmDateTime sgt_begindatum_1
		{
			get
			{
				return this.sgt_begindatum_1Field;
			}
			set
			{
				this.sgt_begindatum_1Field = value;
			}
		}
		public CrmDateTime sgt_begindatum_2
		{
			get
			{
				return this.sgt_begindatum_2Field;
			}
			set
			{
				this.sgt_begindatum_2Field = value;
			}
		}
		public CrmDateTime sgt_begindatum_3
		{
			get
			{
				return this.sgt_begindatum_3Field;
			}
			set
			{
				this.sgt_begindatum_3Field = value;
			}
		}
		public CrmDateTime sgt_begindatum_werkelijk
		{
			get
			{
				return this.sgt_begindatum_werkelijkField;
			}
			set
			{
				this.sgt_begindatum_werkelijkField = value;
			}
		}
		public Lookup sgt_bondsgedelegeerde_id
		{
			get
			{
				return this.sgt_bondsgedelegeerde_idField;
			}
			set
			{
				this.sgt_bondsgedelegeerde_idField = value;
			}
		}
		public Lookup sgt_bondsgedelegeerdeid
		{
			get
			{
				return this.sgt_bondsgedelegeerdeidField;
			}
			set
			{
				this.sgt_bondsgedelegeerdeidField = value;
			}
		}
		public Lookup sgt_bondsorganisatieid
		{
			get
			{
				return this.sgt_bondsorganisatieidField;
			}
			set
			{
				this.sgt_bondsorganisatieidField = value;
			}
		}
		public Lookup sgt_contactpersoonid
		{
			get
			{
				return this.sgt_contactpersoonidField;
			}
			set
			{
				this.sgt_contactpersoonidField = value;
			}
		}
		public CrmDateTime sgt_definitief_begindatum
		{
			get
			{
				return this.sgt_definitief_begindatumField;
			}
			set
			{
				this.sgt_definitief_begindatumField = value;
			}
		}
		public CrmDateTime sgt_definitief_einddatum
		{
			get
			{
				return this.sgt_definitief_einddatumField;
			}
			set
			{
				this.sgt_definitief_einddatumField = value;
			}
		}
		public string sgt_definitief_week_tm
		{
			get
			{
				return this.sgt_definitief_week_tmField;
			}
			set
			{
				this.sgt_definitief_week_tmField = value;
			}
		}
		public string sgt_definitief_week_vanaf
		{
			get
			{
				return this.sgt_definitief_week_vanafField;
			}
			set
			{
				this.sgt_definitief_week_vanafField = value;
			}
		}
		public CrmBoolean sgt_dinsdag
		{
			get
			{
				return this.sgt_dinsdagField;
			}
			set
			{
				this.sgt_dinsdagField = value;
			}
		}
		public Lookup sgt_district_id
		{
			get
			{
				return this.sgt_district_idField;
			}
			set
			{
				this.sgt_district_idField = value;
			}
		}
		public CrmBoolean sgt_donderdag
		{
			get
			{
				return this.sgt_donderdagField;
			}
			set
			{
				this.sgt_donderdagField = value;
			}
		}
		public CrmDateTime sgt_einddatum_1
		{
			get
			{
				return this.sgt_einddatum_1Field;
			}
			set
			{
				this.sgt_einddatum_1Field = value;
			}
		}
		public CrmDateTime sgt_einddatum_2
		{
			get
			{
				return this.sgt_einddatum_2Field;
			}
			set
			{
				this.sgt_einddatum_2Field = value;
			}
		}
		public CrmDateTime sgt_einddatum_3
		{
			get
			{
				return this.sgt_einddatum_3Field;
			}
			set
			{
				this.sgt_einddatum_3Field = value;
			}
		}
		public CrmDateTime sgt_einddatum_werkelijk
		{
			get
			{
				return this.sgt_einddatum_werkelijkField;
			}
			set
			{
				this.sgt_einddatum_werkelijkField = value;
			}
		}
		public string sgt_email
		{
			get
			{
				return this.sgt_emailField;
			}
			set
			{
				this.sgt_emailField = value;
			}
		}
		public string sgt_huisnummer
		{
			get
			{
				return this.sgt_huisnummerField;
			}
			set
			{
				this.sgt_huisnummerField = value;
			}
		}
		public CrmBoolean sgt_maandag
		{
			get
			{
				return this.sgt_maandagField;
			}
			set
			{
				this.sgt_maandagField = value;
			}
		}
		public CrmNumber sgt_max_aantal_partijen
		{
			get
			{
				return this.sgt_max_aantal_partijenField;
			}
			set
			{
				this.sgt_max_aantal_partijenField = value;
			}
		}
		public CrmBoolean sgt_op_afstand
		{
			get
			{
				return this.sgt_op_afstandField;
			}
			set
			{
				this.sgt_op_afstandField = value;
			}
		}
		public string sgt_opmerkingen
		{
			get
			{
				return this.sgt_opmerkingenField;
			}
			set
			{
				this.sgt_opmerkingenField = value;
			}
		}
		public string sgt_opmerkingen_toernooi
		{
			get
			{
				return this.sgt_opmerkingen_toernooiField;
			}
			set
			{
				this.sgt_opmerkingen_toernooiField = value;
			}
		}
		public string sgt_plaats
		{
			get
			{
				return this.sgt_plaatsField;
			}
			set
			{
				this.sgt_plaatsField = value;
			}
		}
		public string sgt_postcode
		{
			get
			{
				return this.sgt_postcodeField;
			}
			set
			{
				this.sgt_postcodeField = value;
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
		public string sgt_straat
		{
			get
			{
				return this.sgt_straatField;
			}
			set
			{
				this.sgt_straatField = value;
			}
		}
		public CrmBoolean sgt_teamautorisaties_uitschakelen
		{
			get
			{
				return this.sgt_teamautorisaties_uitschakelenField;
			}
			set
			{
				this.sgt_teamautorisaties_uitschakelenField = value;
			}
		}
		public string sgt_telefoonnummer
		{
			get
			{
				return this.sgt_telefoonnummerField;
			}
			set
			{
				this.sgt_telefoonnummerField = value;
			}
		}
		[XmlElement("sgt_toe_toernooi")]
		public string sgt_toe_toernooi1
		{
			get
			{
				return this.sgt_toe_toernooi1Field;
			}
			set
			{
				this.sgt_toe_toernooi1Field = value;
			}
		}
		public Key sgt_toe_toernooiid
		{
			get
			{
				return this.sgt_toe_toernooiidField;
			}
			set
			{
				this.sgt_toe_toernooiidField = value;
			}
		}
		public Lookup sgt_toernooi_afhandeling_vorig_jaar
		{
			get
			{
				return this.sgt_toernooi_afhandeling_vorig_jaarField;
			}
			set
			{
				this.sgt_toernooi_afhandeling_vorig_jaarField = value;
			}
		}
		public Lookup sgt_toernooi_vorig_jaarid
		{
			get
			{
				return this.sgt_toernooi_vorig_jaaridField;
			}
			set
			{
				this.sgt_toernooi_vorig_jaaridField = value;
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
		public Lookup sgt_toernooiorganisatieid
		{
			get
			{
				return this.sgt_toernooiorganisatieidField;
			}
			set
			{
				this.sgt_toernooiorganisatieidField = value;
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
		public string sgt_toevoeging
		{
			get
			{
				return this.sgt_toevoegingField;
			}
			set
			{
				this.sgt_toevoegingField = value;
			}
		}
		public CrmBoolean sgt_verlichting
		{
			get
			{
				return this.sgt_verlichtingField;
			}
			set
			{
				this.sgt_verlichtingField = value;
			}
		}
		public CrmBoolean sgt_volgnummer_negeren
		{
			get
			{
				return this.sgt_volgnummer_negerenField;
			}
			set
			{
				this.sgt_volgnummer_negerenField = value;
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
		public Lookup sgt_voorkeur_hs2id
		{
			get
			{
				return this.sgt_voorkeur_hs2idField;
			}
			set
			{
				this.sgt_voorkeur_hs2idField = value;
			}
		}
		public Lookup sgt_voorkeur_hs3id
		{
			get
			{
				return this.sgt_voorkeur_hs3idField;
			}
			set
			{
				this.sgt_voorkeur_hs3idField = value;
			}
		}
		public CrmBoolean sgt_vrijdag
		{
			get
			{
				return this.sgt_vrijdagField;
			}
			set
			{
				this.sgt_vrijdagField = value;
			}
		}
		public string sgt_website
		{
			get
			{
				return this.sgt_websiteField;
			}
			set
			{
				this.sgt_websiteField = value;
			}
		}
		public Lookup sgt_wedstrijdleiderid
		{
			get
			{
				return this.sgt_wedstrijdleideridField;
			}
			set
			{
				this.sgt_wedstrijdleideridField = value;
			}
		}
		public string sgt_week_tm_1
		{
			get
			{
				return this.sgt_week_tm_1Field;
			}
			set
			{
				this.sgt_week_tm_1Field = value;
			}
		}
		public string sgt_week_tm_2
		{
			get
			{
				return this.sgt_week_tm_2Field;
			}
			set
			{
				this.sgt_week_tm_2Field = value;
			}
		}
		public string sgt_week_tm_3
		{
			get
			{
				return this.sgt_week_tm_3Field;
			}
			set
			{
				this.sgt_week_tm_3Field = value;
			}
		}
		public string sgt_week_vanaf_1
		{
			get
			{
				return this.sgt_week_vanaf_1Field;
			}
			set
			{
				this.sgt_week_vanaf_1Field = value;
			}
		}
		public string sgt_week_vanaf_2
		{
			get
			{
				return this.sgt_week_vanaf_2Field;
			}
			set
			{
				this.sgt_week_vanaf_2Field = value;
			}
		}
		public string sgt_week_vanaf_3
		{
			get
			{
				return this.sgt_week_vanaf_3Field;
			}
			set
			{
				this.sgt_week_vanaf_3Field = value;
			}
		}
		public CrmBoolean sgt_woensdag
		{
			get
			{
				return this.sgt_woensdagField;
			}
			set
			{
				this.sgt_woensdagField = value;
			}
		}
		public CrmBoolean sgt_zaterdag
		{
			get
			{
				return this.sgt_zaterdagField;
			}
			set
			{
				this.sgt_zaterdagField = value;
			}
		}
		public CrmBoolean sgt_zondag
		{
			get
			{
				return this.sgt_zondagField;
			}
			set
			{
				this.sgt_zondagField = value;
			}
		}
		public string sgt_zwaarte
		{
			get
			{
				return this.sgt_zwaarteField;
			}
			set
			{
				this.sgt_zwaarteField = value;
			}
		}
		public Lookup sgt_zwaarteid
		{
			get
			{
				return this.sgt_zwaarteidField;
			}
			set
			{
				this.sgt_zwaarteidField = value;
			}
		}
		public Sgt_toe_toernooiStateInfo statecode
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
