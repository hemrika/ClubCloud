using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
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
		public CrmBoolean sgt_afwijkingen
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
		public CrmBoolean sgt_bondsgedelegeerde
		{
			get
			{
				return this.sgt_bondsgedelegeerdeField;
			}
			set
			{
				this.sgt_bondsgedelegeerdeField = value;
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
		public CrmBoolean sgt_contactpersoon
		{
			get
			{
				return this.sgt_contactpersoonField;
			}
			set
			{
				this.sgt_contactpersoonField = value;
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
		public CrmBoolean sgt_inschrijfbijdrage
		{
			get
			{
				return this.sgt_inschrijfbijdrageField;
			}
			set
			{
				this.sgt_inschrijfbijdrageField = value;
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
		public CrmBoolean sgt_max_aantal_partijen
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
		public CrmBoolean sgt_opmerkingen
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
		public CrmBoolean sgt_prijzengeld
		{
			get
			{
				return this.sgt_prijzengeldField;
			}
			set
			{
				this.sgt_prijzengeldField = value;
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
		public CrmBoolean sgt_schemasoort
		{
			get
			{
				return this.sgt_schemasoortField;
			}
			set
			{
				this.sgt_schemasoortField = value;
			}
		}
		public CrmBoolean sgt_speelsterkte
		{
			get
			{
				return this.sgt_speelsterkteField;
			}
			set
			{
				this.sgt_speelsterkteField = value;
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
		[XmlElement("sgt_toe_aanvraagformulier")]
		public string sgt_toe_aanvraagformulier1
		{
			get
			{
				return this.sgt_toe_aanvraagformulier1Field;
			}
			set
			{
				this.sgt_toe_aanvraagformulier1Field = value;
			}
		}
		public Key sgt_toe_aanvraagformulierid
		{
			get
			{
				return this.sgt_toe_aanvraagformulieridField;
			}
			set
			{
				this.sgt_toe_aanvraagformulieridField = value;
			}
		}
		public Lookup sgt_toernooien_kopie_uit_id
		{
			get
			{
				return this.sgt_toernooien_kopie_uit_idField;
			}
			set
			{
				this.sgt_toernooien_kopie_uit_idField = value;
			}
		}
		public Lookup sgt_toernooien_kopieren_uit
		{
			get
			{
				return this.sgt_toernooien_kopieren_uitField;
			}
			set
			{
				this.sgt_toernooien_kopieren_uitField = value;
			}
		}
		public CrmBoolean sgt_toernooionderdeelgenerator
		{
			get
			{
				return this.sgt_toernooionderdeelgeneratorField;
			}
			set
			{
				this.sgt_toernooionderdeelgeneratorField = value;
			}
		}
		public CrmBoolean sgt_toernooiorganisatoren_afgelopen_jaar
		{
			get
			{
				return this.sgt_toernooiorganisatoren_afgelopen_jaarField;
			}
			set
			{
				this.sgt_toernooiorganisatoren_afgelopen_jaarField = value;
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
		public CrmBoolean sgt_voorkeur_hs
		{
			get
			{
				return this.sgt_voorkeur_hsField;
			}
			set
			{
				this.sgt_voorkeur_hsField = value;
			}
		}
		public CrmBoolean sgt_zwaarte
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
		public Sgt_toe_aanvraagformulierStateInfo statecode
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
