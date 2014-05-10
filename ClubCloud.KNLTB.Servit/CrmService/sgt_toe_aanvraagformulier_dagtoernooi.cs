using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_toe_aanvraagformulier_dagtoernooi : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private CrmBoolean sgt_aantal_banenField;
		private CrmBoolean sgt_aantal_partijenField;
		private CrmBoolean sgt_aanvraag_versturenField;
		private Lookup sgt_aanvraagrechten_kopieren_uitField;
		private Lookup sgt_bondsorganisatieField;
		private CrmBoolean sgt_categorieenField;
		private Lookup sgt_dagtoernooi_kopie_uit_idField;
		private CrmDateTime sgt_datum_aanvraag_versturenField;
		private Lookup sgt_districtidField;
		private CrmBoolean sgt_duur_partijenField;
		private CrmDateTime sgt_einde_aanvraagperiodeField;
		private CrmNumber sgt_herinnering_aantal_dagenField;
		private CrmBoolean sgt_innen_inschrijfgeldField;
		private CrmBoolean sgt_inschrijving_deelnameField;
		private CrmBoolean sgt_kwalificatietoernooiField;
		private CrmBoolean sgt_landelijkField;
		private CrmBoolean sgt_leeftijdField;
		private CrmBoolean sgt_leeftijd_deelnemersField;
		private CrmBoolean sgt_lunchField;
		private CrmBoolean sgt_manier_bevestigenField;
		private CrmBoolean sgt_nevenactiviteitenField;
		private Lookup sgt_regioidField;
		private CrmBoolean sgt_schemagrootteField;
		private CrmDateTime sgt_start_aanvraagperiodeField;
		private Picklist sgt_statusField;
		private string sgt_toe_aanvraagformulier_dagtoernooi1Field;
		private Key sgt_toe_aanvraagformulier_dagtoernooiidField;
		private CrmBoolean sgt_toernooi_organisatoren_vorig_jaarField;
		private Lookup sgt_toernooikalenderidField;
		private CrmBoolean sgt_toernooionderdelenField;
		private CrmBoolean sgt_toernooischemaField;
		private Lookup sgt_toernooisoortidField;
		private CrmBoolean sgt_tweede_voorkeursdatumField;
		private Sgt_toe_aanvraagformulier_dagtoernooiStateInfo statecodeField;
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
		public CrmBoolean sgt_aantal_banen
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
		public CrmBoolean sgt_aantal_partijen
		{
			get
			{
				return this.sgt_aantal_partijenField;
			}
			set
			{
				this.sgt_aantal_partijenField = value;
			}
		}
		public CrmBoolean sgt_aanvraag_versturen
		{
			get
			{
				return this.sgt_aanvraag_versturenField;
			}
			set
			{
				this.sgt_aanvraag_versturenField = value;
			}
		}
		public Lookup sgt_aanvraagrechten_kopieren_uit
		{
			get
			{
				return this.sgt_aanvraagrechten_kopieren_uitField;
			}
			set
			{
				this.sgt_aanvraagrechten_kopieren_uitField = value;
			}
		}
		public Lookup sgt_bondsorganisatie
		{
			get
			{
				return this.sgt_bondsorganisatieField;
			}
			set
			{
				this.sgt_bondsorganisatieField = value;
			}
		}
		public CrmBoolean sgt_categorieen
		{
			get
			{
				return this.sgt_categorieenField;
			}
			set
			{
				this.sgt_categorieenField = value;
			}
		}
		public Lookup sgt_dagtoernooi_kopie_uit_id
		{
			get
			{
				return this.sgt_dagtoernooi_kopie_uit_idField;
			}
			set
			{
				this.sgt_dagtoernooi_kopie_uit_idField = value;
			}
		}
		public CrmDateTime sgt_datum_aanvraag_versturen
		{
			get
			{
				return this.sgt_datum_aanvraag_versturenField;
			}
			set
			{
				this.sgt_datum_aanvraag_versturenField = value;
			}
		}
		public Lookup sgt_districtid
		{
			get
			{
				return this.sgt_districtidField;
			}
			set
			{
				this.sgt_districtidField = value;
			}
		}
		public CrmBoolean sgt_duur_partijen
		{
			get
			{
				return this.sgt_duur_partijenField;
			}
			set
			{
				this.sgt_duur_partijenField = value;
			}
		}
		public CrmDateTime sgt_einde_aanvraagperiode
		{
			get
			{
				return this.sgt_einde_aanvraagperiodeField;
			}
			set
			{
				this.sgt_einde_aanvraagperiodeField = value;
			}
		}
		public CrmNumber sgt_herinnering_aantal_dagen
		{
			get
			{
				return this.sgt_herinnering_aantal_dagenField;
			}
			set
			{
				this.sgt_herinnering_aantal_dagenField = value;
			}
		}
		public CrmBoolean sgt_innen_inschrijfgeld
		{
			get
			{
				return this.sgt_innen_inschrijfgeldField;
			}
			set
			{
				this.sgt_innen_inschrijfgeldField = value;
			}
		}
		public CrmBoolean sgt_inschrijving_deelname
		{
			get
			{
				return this.sgt_inschrijving_deelnameField;
			}
			set
			{
				this.sgt_inschrijving_deelnameField = value;
			}
		}
		public CrmBoolean sgt_kwalificatietoernooi
		{
			get
			{
				return this.sgt_kwalificatietoernooiField;
			}
			set
			{
				this.sgt_kwalificatietoernooiField = value;
			}
		}
		public CrmBoolean sgt_landelijk
		{
			get
			{
				return this.sgt_landelijkField;
			}
			set
			{
				this.sgt_landelijkField = value;
			}
		}
		public CrmBoolean sgt_leeftijd
		{
			get
			{
				return this.sgt_leeftijdField;
			}
			set
			{
				this.sgt_leeftijdField = value;
			}
		}
		public CrmBoolean sgt_leeftijd_deelnemers
		{
			get
			{
				return this.sgt_leeftijd_deelnemersField;
			}
			set
			{
				this.sgt_leeftijd_deelnemersField = value;
			}
		}
		public CrmBoolean sgt_lunch
		{
			get
			{
				return this.sgt_lunchField;
			}
			set
			{
				this.sgt_lunchField = value;
			}
		}
		public CrmBoolean sgt_manier_bevestigen
		{
			get
			{
				return this.sgt_manier_bevestigenField;
			}
			set
			{
				this.sgt_manier_bevestigenField = value;
			}
		}
		public CrmBoolean sgt_nevenactiviteiten
		{
			get
			{
				return this.sgt_nevenactiviteitenField;
			}
			set
			{
				this.sgt_nevenactiviteitenField = value;
			}
		}
		public Lookup sgt_regioid
		{
			get
			{
				return this.sgt_regioidField;
			}
			set
			{
				this.sgt_regioidField = value;
			}
		}
		public CrmBoolean sgt_schemagrootte
		{
			get
			{
				return this.sgt_schemagrootteField;
			}
			set
			{
				this.sgt_schemagrootteField = value;
			}
		}
		public CrmDateTime sgt_start_aanvraagperiode
		{
			get
			{
				return this.sgt_start_aanvraagperiodeField;
			}
			set
			{
				this.sgt_start_aanvraagperiodeField = value;
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
		[XmlElement("sgt_toe_aanvraagformulier_dagtoernooi")]
		public string sgt_toe_aanvraagformulier_dagtoernooi1
		{
			get
			{
				return this.sgt_toe_aanvraagformulier_dagtoernooi1Field;
			}
			set
			{
				this.sgt_toe_aanvraagformulier_dagtoernooi1Field = value;
			}
		}
		public Key sgt_toe_aanvraagformulier_dagtoernooiid
		{
			get
			{
				return this.sgt_toe_aanvraagformulier_dagtoernooiidField;
			}
			set
			{
				this.sgt_toe_aanvraagformulier_dagtoernooiidField = value;
			}
		}
		public CrmBoolean sgt_toernooi_organisatoren_vorig_jaar
		{
			get
			{
				return this.sgt_toernooi_organisatoren_vorig_jaarField;
			}
			set
			{
				this.sgt_toernooi_organisatoren_vorig_jaarField = value;
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
		public CrmBoolean sgt_toernooionderdelen
		{
			get
			{
				return this.sgt_toernooionderdelenField;
			}
			set
			{
				this.sgt_toernooionderdelenField = value;
			}
		}
		public CrmBoolean sgt_toernooischema
		{
			get
			{
				return this.sgt_toernooischemaField;
			}
			set
			{
				this.sgt_toernooischemaField = value;
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
		public CrmBoolean sgt_tweede_voorkeursdatum
		{
			get
			{
				return this.sgt_tweede_voorkeursdatumField;
			}
			set
			{
				this.sgt_tweede_voorkeursdatumField = value;
			}
		}
		public Sgt_toe_aanvraagformulier_dagtoernooiStateInfo statecode
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
