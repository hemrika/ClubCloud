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
	public class sgt_toe_aanvraagformulier : BusinessEntity
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

		private CrmBoolean sgt_aanvraag_versturenField;

		private Lookup sgt_aanvraagrechten_kopieren_uitField;

		private CrmBoolean sgt_afwijkingenField;

		private CrmBoolean sgt_bondsgedelegeerdeField;

		private Lookup sgt_bondsorganisatieidField;

		private CrmBoolean sgt_contactpersoonField;

		private CrmDateTime sgt_datum_aanvraag_versturenField;

		private Lookup sgt_districtidField;

		private CrmDateTime sgt_einde_aanvraagperiodeField;

		private CrmBoolean sgt_email_aanvraagperiode_verstr_verstuurdField;

		private CrmBoolean sgt_email_bericht_toe_aanvragen_verstuurdField;

		private CrmBoolean sgt_email_her_toe_aanvragen_verstuurdField;

		private CrmNumber sgt_herinnering_aantal_dagenField;

		private CrmBoolean sgt_inschrijfbijdrageField;

		private CrmBoolean sgt_kwalificatietoernooiField;

		private CrmBoolean sgt_landelijkField;

		private CrmBoolean sgt_leeftijdField;

		private CrmBoolean sgt_max_aantal_partijenField;

		private CrmBoolean sgt_opmerkingenField;

		private CrmBoolean sgt_prijzengeldField;

		private Lookup sgt_regioidField;

		private CrmBoolean sgt_schemagrootteField;

		private CrmBoolean sgt_schemasoortField;

		private CrmBoolean sgt_speelsterkteField;

		private CrmDateTime sgt_start_aanvraagperiodeField;

		private Picklist sgt_statusField;

		private string sgt_toe_aanvraagformulier1Field;

		private Key sgt_toe_aanvraagformulieridField;

		private Lookup sgt_toernooien_kopie_uit_idField;

		private Lookup sgt_toernooien_kopieren_uitField;

		private CrmBoolean sgt_toernooionderdeelgeneratorField;

		private CrmBoolean sgt_toernooiorganisatoren_afgelopen_jaarField;

		private CrmBoolean sgt_toernooischemaField;

		private Lookup sgt_toernooisoortidField;

		private CrmBoolean sgt_verlichtingField;

		private CrmBoolean sgt_voorkeur_hsField;

		private CrmBoolean sgt_zwaarteField;

		private Sgt_toe_aanvraagformulierStateInfo statecodeField;

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

		[XmlElement] //[XmlElement(Order=9)]
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

		[XmlElement] //[XmlElement(Order=10)]
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

		[XmlElement] //[XmlElement(Order=11)]
		public CrmBoolean sgt_afwijkingen
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

		[XmlElement] //[XmlElement(Order=12)]
		public CrmBoolean sgt_bondsgedelegeerde
		{
			get
			{
				return this.sgt_bondsgedelegeerdeField;
			}
			set
			{
				this.sgt_bondsgedelegeerdeField = value;
				base.RaisePropertyChanged("sgt_bondsgedelegeerde");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
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

		[XmlElement] //[XmlElement(Order=14)]
		public CrmBoolean sgt_contactpersoon
		{
			get
			{
				return this.sgt_contactpersoonField;
			}
			set
			{
				this.sgt_contactpersoonField = value;
				base.RaisePropertyChanged("sgt_contactpersoon");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
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

		[XmlElement] //[XmlElement(Order=16)]
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

		[XmlElement] //[XmlElement(Order=17)]
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

		[XmlElement] //[XmlElement(Order=18)]
		public CrmBoolean sgt_email_aanvraagperiode_verstr_verstuurd
		{
			get
			{
				return this.sgt_email_aanvraagperiode_verstr_verstuurdField;
			}
			set
			{
				this.sgt_email_aanvraagperiode_verstr_verstuurdField = value;
				base.RaisePropertyChanged("sgt_email_aanvraagperiode_verstr_verstuurd");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
		public CrmBoolean sgt_email_bericht_toe_aanvragen_verstuurd
		{
			get
			{
				return this.sgt_email_bericht_toe_aanvragen_verstuurdField;
			}
			set
			{
				this.sgt_email_bericht_toe_aanvragen_verstuurdField = value;
				base.RaisePropertyChanged("sgt_email_bericht_toe_aanvragen_verstuurd");
			}
		}

		[XmlElement] //[XmlElement(Order=20)]
		public CrmBoolean sgt_email_her_toe_aanvragen_verstuurd
		{
			get
			{
				return this.sgt_email_her_toe_aanvragen_verstuurdField;
			}
			set
			{
				this.sgt_email_her_toe_aanvragen_verstuurdField = value;
				base.RaisePropertyChanged("sgt_email_her_toe_aanvragen_verstuurd");
			}
		}

		[XmlElement] //[XmlElement(Order=21)]
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

		[XmlElement] //[XmlElement(Order=22)]
		public CrmBoolean sgt_inschrijfbijdrage
		{
			get
			{
				return this.sgt_inschrijfbijdrageField;
			}
			set
			{
				this.sgt_inschrijfbijdrageField = value;
				base.RaisePropertyChanged("sgt_inschrijfbijdrage");
			}
		}

		[XmlElement] //[XmlElement(Order=23)]
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

		[XmlElement] //[XmlElement(Order=24)]
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

		[XmlElement] //[XmlElement(Order=25)]
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

		[XmlElement] //[XmlElement(Order=26)]
		public CrmBoolean sgt_max_aantal_partijen
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

		[XmlElement] //[XmlElement(Order=27)]
		public CrmBoolean sgt_opmerkingen
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

		[XmlElement] //[XmlElement(Order=28)]
		public CrmBoolean sgt_prijzengeld
		{
			get
			{
				return this.sgt_prijzengeldField;
			}
			set
			{
				this.sgt_prijzengeldField = value;
				base.RaisePropertyChanged("sgt_prijzengeld");
			}
		}

		[XmlElement] //[XmlElement(Order=29)]
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

		[XmlElement] //[XmlElement(Order=30)]
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

		[XmlElement] //[XmlElement(Order=31)]
		public CrmBoolean sgt_schemasoort
		{
			get
			{
				return this.sgt_schemasoortField;
			}
			set
			{
				this.sgt_schemasoortField = value;
				base.RaisePropertyChanged("sgt_schemasoort");
			}
		}

		[XmlElement] //[XmlElement(Order=32)]
		public CrmBoolean sgt_speelsterkte
		{
			get
			{
				return this.sgt_speelsterkteField;
			}
			set
			{
				this.sgt_speelsterkteField = value;
				base.RaisePropertyChanged("sgt_speelsterkte");
			}
		}

		[XmlElement] //[XmlElement(Order=33)]
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

		[XmlElement] //[XmlElement(Order=34)]
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

		[XmlElement("sgt_toe_aanvraagformulier")] //, Order=35)]
		public string sgt_toe_aanvraagformulier1
		{
			get
			{
				return this.sgt_toe_aanvraagformulier1Field;
			}
			set
			{
				this.sgt_toe_aanvraagformulier1Field = value;
				base.RaisePropertyChanged("sgt_toe_aanvraagformulier1");
			}
		}

		[XmlElement] //[XmlElement(Order=36)]
		public Key sgt_toe_aanvraagformulierid
		{
			get
			{
				return this.sgt_toe_aanvraagformulieridField;
			}
			set
			{
				this.sgt_toe_aanvraagformulieridField = value;
				base.RaisePropertyChanged("sgt_toe_aanvraagformulierid");
			}
		}

		[XmlElement] //[XmlElement(Order=37)]
		public Lookup sgt_toernooien_kopie_uit_id
		{
			get
			{
				return this.sgt_toernooien_kopie_uit_idField;
			}
			set
			{
				this.sgt_toernooien_kopie_uit_idField = value;
				base.RaisePropertyChanged("sgt_toernooien_kopie_uit_id");
			}
		}

		[XmlElement] //[XmlElement(Order=38)]
		public Lookup sgt_toernooien_kopieren_uit
		{
			get
			{
				return this.sgt_toernooien_kopieren_uitField;
			}
			set
			{
				this.sgt_toernooien_kopieren_uitField = value;
				base.RaisePropertyChanged("sgt_toernooien_kopieren_uit");
			}
		}

		[XmlElement] //[XmlElement(Order=39)]
		public CrmBoolean sgt_toernooionderdeelgenerator
		{
			get
			{
				return this.sgt_toernooionderdeelgeneratorField;
			}
			set
			{
				this.sgt_toernooionderdeelgeneratorField = value;
				base.RaisePropertyChanged("sgt_toernooionderdeelgenerator");
			}
		}

		[XmlElement] //[XmlElement(Order=40)]
		public CrmBoolean sgt_toernooiorganisatoren_afgelopen_jaar
		{
			get
			{
				return this.sgt_toernooiorganisatoren_afgelopen_jaarField;
			}
			set
			{
				this.sgt_toernooiorganisatoren_afgelopen_jaarField = value;
				base.RaisePropertyChanged("sgt_toernooiorganisatoren_afgelopen_jaar");
			}
		}

		[XmlElement] //[XmlElement(Order=41)]
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

		[XmlElement] //[XmlElement(Order=42)]
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

		[XmlElement] //[XmlElement(Order=43)]
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

		[XmlElement] //[XmlElement(Order=44)]
		public CrmBoolean sgt_voorkeur_hs
		{
			get
			{
				return this.sgt_voorkeur_hsField;
			}
			set
			{
				this.sgt_voorkeur_hsField = value;
				base.RaisePropertyChanged("sgt_voorkeur_hs");
			}
		}

		[XmlElement] //[XmlElement(Order=45)]
		public CrmBoolean sgt_zwaarte
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

		[XmlElement] //[XmlElement(Order=46)]
		public Sgt_toe_aanvraagformulierStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=47)]
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

		[XmlElement] //[XmlElement(Order=48)]
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

		[XmlElement] //[XmlElement(Order=49)]
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

		public sgt_toe_aanvraagformulier()
		{
		}
	}
}