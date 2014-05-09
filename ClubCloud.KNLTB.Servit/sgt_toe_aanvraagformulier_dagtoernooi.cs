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
		public CrmBoolean sgt_aantal_banen
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
		[XmlElement(Order = 9)]
		public CrmBoolean sgt_aantal_partijen
		{
			get
			{
				return this.sgt_aantal_partijenField;
			}
			set
			{
				this.sgt_aantal_partijenField = value;
				base.RaisePropertyChanged("sgt_aantal_partijen");
			}
		}
		[XmlElement(Order = 10)]
		public CrmBoolean sgt_aanvraag_versturen
		{
			get
			{
				return this.sgt_aanvraag_versturenField;
			}
			set
			{
				this.sgt_aanvraag_versturenField = value;
				base.RaisePropertyChanged("sgt_aanvraag_versturen");
			}
		}
		[XmlElement(Order = 11)]
		public Lookup sgt_aanvraagrechten_kopieren_uit
		{
			get
			{
				return this.sgt_aanvraagrechten_kopieren_uitField;
			}
			set
			{
				this.sgt_aanvraagrechten_kopieren_uitField = value;
				base.RaisePropertyChanged("sgt_aanvraagrechten_kopieren_uit");
			}
		}
		[XmlElement(Order = 12)]
		public Lookup sgt_bondsorganisatie
		{
			get
			{
				return this.sgt_bondsorganisatieField;
			}
			set
			{
				this.sgt_bondsorganisatieField = value;
				base.RaisePropertyChanged("sgt_bondsorganisatie");
			}
		}
		[XmlElement(Order = 13)]
		public CrmBoolean sgt_categorieen
		{
			get
			{
				return this.sgt_categorieenField;
			}
			set
			{
				this.sgt_categorieenField = value;
				base.RaisePropertyChanged("sgt_categorieen");
			}
		}
		[XmlElement(Order = 14)]
		public Lookup sgt_dagtoernooi_kopie_uit_id
		{
			get
			{
				return this.sgt_dagtoernooi_kopie_uit_idField;
			}
			set
			{
				this.sgt_dagtoernooi_kopie_uit_idField = value;
				base.RaisePropertyChanged("sgt_dagtoernooi_kopie_uit_id");
			}
		}
		[XmlElement(Order = 15)]
		public CrmDateTime sgt_datum_aanvraag_versturen
		{
			get
			{
				return this.sgt_datum_aanvraag_versturenField;
			}
			set
			{
				this.sgt_datum_aanvraag_versturenField = value;
				base.RaisePropertyChanged("sgt_datum_aanvraag_versturen");
			}
		}
		[XmlElement(Order = 16)]
		public Lookup sgt_districtid
		{
			get
			{
				return this.sgt_districtidField;
			}
			set
			{
				this.sgt_districtidField = value;
				base.RaisePropertyChanged("sgt_districtid");
			}
		}
		[XmlElement(Order = 17)]
		public CrmBoolean sgt_duur_partijen
		{
			get
			{
				return this.sgt_duur_partijenField;
			}
			set
			{
				this.sgt_duur_partijenField = value;
				base.RaisePropertyChanged("sgt_duur_partijen");
			}
		}
		[XmlElement(Order = 18)]
		public CrmDateTime sgt_einde_aanvraagperiode
		{
			get
			{
				return this.sgt_einde_aanvraagperiodeField;
			}
			set
			{
				this.sgt_einde_aanvraagperiodeField = value;
				base.RaisePropertyChanged("sgt_einde_aanvraagperiode");
			}
		}
		[XmlElement(Order = 19)]
		public CrmNumber sgt_herinnering_aantal_dagen
		{
			get
			{
				return this.sgt_herinnering_aantal_dagenField;
			}
			set
			{
				this.sgt_herinnering_aantal_dagenField = value;
				base.RaisePropertyChanged("sgt_herinnering_aantal_dagen");
			}
		}
		[XmlElement(Order = 20)]
		public CrmBoolean sgt_innen_inschrijfgeld
		{
			get
			{
				return this.sgt_innen_inschrijfgeldField;
			}
			set
			{
				this.sgt_innen_inschrijfgeldField = value;
				base.RaisePropertyChanged("sgt_innen_inschrijfgeld");
			}
		}
		[XmlElement(Order = 21)]
		public CrmBoolean sgt_inschrijving_deelname
		{
			get
			{
				return this.sgt_inschrijving_deelnameField;
			}
			set
			{
				this.sgt_inschrijving_deelnameField = value;
				base.RaisePropertyChanged("sgt_inschrijving_deelname");
			}
		}
		[XmlElement(Order = 22)]
		public CrmBoolean sgt_kwalificatietoernooi
		{
			get
			{
				return this.sgt_kwalificatietoernooiField;
			}
			set
			{
				this.sgt_kwalificatietoernooiField = value;
				base.RaisePropertyChanged("sgt_kwalificatietoernooi");
			}
		}
		[XmlElement(Order = 23)]
		public CrmBoolean sgt_landelijk
		{
			get
			{
				return this.sgt_landelijkField;
			}
			set
			{
				this.sgt_landelijkField = value;
				base.RaisePropertyChanged("sgt_landelijk");
			}
		}
		[XmlElement(Order = 24)]
		public CrmBoolean sgt_leeftijd
		{
			get
			{
				return this.sgt_leeftijdField;
			}
			set
			{
				this.sgt_leeftijdField = value;
				base.RaisePropertyChanged("sgt_leeftijd");
			}
		}
		[XmlElement(Order = 25)]
		public CrmBoolean sgt_leeftijd_deelnemers
		{
			get
			{
				return this.sgt_leeftijd_deelnemersField;
			}
			set
			{
				this.sgt_leeftijd_deelnemersField = value;
				base.RaisePropertyChanged("sgt_leeftijd_deelnemers");
			}
		}
		[XmlElement(Order = 26)]
		public CrmBoolean sgt_lunch
		{
			get
			{
				return this.sgt_lunchField;
			}
			set
			{
				this.sgt_lunchField = value;
				base.RaisePropertyChanged("sgt_lunch");
			}
		}
		[XmlElement(Order = 27)]
		public CrmBoolean sgt_manier_bevestigen
		{
			get
			{
				return this.sgt_manier_bevestigenField;
			}
			set
			{
				this.sgt_manier_bevestigenField = value;
				base.RaisePropertyChanged("sgt_manier_bevestigen");
			}
		}
		[XmlElement(Order = 28)]
		public CrmBoolean sgt_nevenactiviteiten
		{
			get
			{
				return this.sgt_nevenactiviteitenField;
			}
			set
			{
				this.sgt_nevenactiviteitenField = value;
				base.RaisePropertyChanged("sgt_nevenactiviteiten");
			}
		}
		[XmlElement(Order = 29)]
		public Lookup sgt_regioid
		{
			get
			{
				return this.sgt_regioidField;
			}
			set
			{
				this.sgt_regioidField = value;
				base.RaisePropertyChanged("sgt_regioid");
			}
		}
		[XmlElement(Order = 30)]
		public CrmBoolean sgt_schemagrootte
		{
			get
			{
				return this.sgt_schemagrootteField;
			}
			set
			{
				this.sgt_schemagrootteField = value;
				base.RaisePropertyChanged("sgt_schemagrootte");
			}
		}
		[XmlElement(Order = 31)]
		public CrmDateTime sgt_start_aanvraagperiode
		{
			get
			{
				return this.sgt_start_aanvraagperiodeField;
			}
			set
			{
				this.sgt_start_aanvraagperiodeField = value;
				base.RaisePropertyChanged("sgt_start_aanvraagperiode");
			}
		}
		[XmlElement(Order = 32)]
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
		[XmlElement("sgt_toe_aanvraagformulier_dagtoernooi", Order = 33)]
		public string sgt_toe_aanvraagformulier_dagtoernooi1
		{
			get
			{
				return this.sgt_toe_aanvraagformulier_dagtoernooi1Field;
			}
			set
			{
				this.sgt_toe_aanvraagformulier_dagtoernooi1Field = value;
				base.RaisePropertyChanged("sgt_toe_aanvraagformulier_dagtoernooi1");
			}
		}
		[XmlElement(Order = 34)]
		public Key sgt_toe_aanvraagformulier_dagtoernooiid
		{
			get
			{
				return this.sgt_toe_aanvraagformulier_dagtoernooiidField;
			}
			set
			{
				this.sgt_toe_aanvraagformulier_dagtoernooiidField = value;
				base.RaisePropertyChanged("sgt_toe_aanvraagformulier_dagtoernooiid");
			}
		}
		[XmlElement(Order = 35)]
		public CrmBoolean sgt_toernooi_organisatoren_vorig_jaar
		{
			get
			{
				return this.sgt_toernooi_organisatoren_vorig_jaarField;
			}
			set
			{
				this.sgt_toernooi_organisatoren_vorig_jaarField = value;
				base.RaisePropertyChanged("sgt_toernooi_organisatoren_vorig_jaar");
			}
		}
		[XmlElement(Order = 36)]
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
		[XmlElement(Order = 37)]
		public CrmBoolean sgt_toernooionderdelen
		{
			get
			{
				return this.sgt_toernooionderdelenField;
			}
			set
			{
				this.sgt_toernooionderdelenField = value;
				base.RaisePropertyChanged("sgt_toernooionderdelen");
			}
		}
		[XmlElement(Order = 38)]
		public CrmBoolean sgt_toernooischema
		{
			get
			{
				return this.sgt_toernooischemaField;
			}
			set
			{
				this.sgt_toernooischemaField = value;
				base.RaisePropertyChanged("sgt_toernooischema");
			}
		}
		[XmlElement(Order = 39)]
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
		[XmlElement(Order = 40)]
		public CrmBoolean sgt_tweede_voorkeursdatum
		{
			get
			{
				return this.sgt_tweede_voorkeursdatumField;
			}
			set
			{
				this.sgt_tweede_voorkeursdatumField = value;
				base.RaisePropertyChanged("sgt_tweede_voorkeursdatum");
			}
		}
		[XmlElement(Order = 41)]
		public Sgt_toe_aanvraagformulier_dagtoernooiStateInfo statecode
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
		[XmlElement(Order = 42)]
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
		[XmlElement(Order = 43)]
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
		[XmlElement(Order = 44)]
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
