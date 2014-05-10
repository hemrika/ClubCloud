using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_arb_rapport_hoofdscheidsrechter : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private CrmNumber sgt_aantal_malen_sps_toegepastField;
		private CrmNumber sgt_aantal_sps_formulieren_bijgevoegdField;
		private CrmNumber sgt_aantal_sr_beoordelingsform_bijgevoegdField;
		private CrmNumber sgt_aantal_sr_declaratieform_bijgevoegdField;
		private CrmDateTime sgt_aanvangstijd_datumtijdField;
		private Lookup sgt_accommodatieidField;
		private Lookup sgt_afdelingidField;
		private string sgt_arb_nameField;
		private Key sgt_arb_rapport_hoofdscheidsrechteridField;
		private Lookup sgt_baansoortidField;
		private Lookup sgt_competitieidField;
		private CrmDateTime sgt_datum_tmField;
		private CrmDateTime sgt_datum_vanafField;
		private string sgt_eindtijdField;
		private Lookup sgt_hoofdscheidsrechteridField;
		private Lookup sgt_klassengroepidField;
		private Picklist sgt_locatieField;
		private string sgt_merk_ballenField;
		private Picklist sgt_nieuwe_ballenField;
		private string sgt_opmerkingenField;
		private Lookup sgt_piramideidField;
		private string sgt_plaatsField;
		private Lookup sgt_ploeg_thuisidField;
		private Lookup sgt_ploeg_uitidField;
		private Lookup sgt_ploegthuisidField;
		private Lookup sgt_ploeguitidField;
		private CrmDateTime sgt_speeldatumField;
		private string sgt_toelichtingField;
		private Lookup sgt_toernooi_aanvraag_verwerkingidField;
		private Lookup sgt_toernooiidField;
		private Lookup sgt_verenigingthuisidField;
		private Lookup sgt_vereniginguitidField;
		private Lookup sgt_wedstrijdidField;
		private Sgt_arb_rapport_hoofdscheidsrechterStateInfo statecodeField;
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
		public CrmNumber sgt_aantal_malen_sps_toegepast
		{
			get
			{
				return this.sgt_aantal_malen_sps_toegepastField;
			}
			set
			{
				this.sgt_aantal_malen_sps_toegepastField = value;
			}
		}
		public CrmNumber sgt_aantal_sps_formulieren_bijgevoegd
		{
			get
			{
				return this.sgt_aantal_sps_formulieren_bijgevoegdField;
			}
			set
			{
				this.sgt_aantal_sps_formulieren_bijgevoegdField = value;
			}
		}
		public CrmNumber sgt_aantal_sr_beoordelingsform_bijgevoegd
		{
			get
			{
				return this.sgt_aantal_sr_beoordelingsform_bijgevoegdField;
			}
			set
			{
				this.sgt_aantal_sr_beoordelingsform_bijgevoegdField = value;
			}
		}
		public CrmNumber sgt_aantal_sr_declaratieform_bijgevoegd
		{
			get
			{
				return this.sgt_aantal_sr_declaratieform_bijgevoegdField;
			}
			set
			{
				this.sgt_aantal_sr_declaratieform_bijgevoegdField = value;
			}
		}
		public CrmDateTime sgt_aanvangstijd_datumtijd
		{
			get
			{
				return this.sgt_aanvangstijd_datumtijdField;
			}
			set
			{
				this.sgt_aanvangstijd_datumtijdField = value;
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
		public Lookup sgt_afdelingid
		{
			get
			{
				return this.sgt_afdelingidField;
			}
			set
			{
				this.sgt_afdelingidField = value;
			}
		}
		public string sgt_arb_name
		{
			get
			{
				return this.sgt_arb_nameField;
			}
			set
			{
				this.sgt_arb_nameField = value;
			}
		}
		public Key sgt_arb_rapport_hoofdscheidsrechterid
		{
			get
			{
				return this.sgt_arb_rapport_hoofdscheidsrechteridField;
			}
			set
			{
				this.sgt_arb_rapport_hoofdscheidsrechteridField = value;
			}
		}
		public Lookup sgt_baansoortid
		{
			get
			{
				return this.sgt_baansoortidField;
			}
			set
			{
				this.sgt_baansoortidField = value;
			}
		}
		public Lookup sgt_competitieid
		{
			get
			{
				return this.sgt_competitieidField;
			}
			set
			{
				this.sgt_competitieidField = value;
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
		public string sgt_eindtijd
		{
			get
			{
				return this.sgt_eindtijdField;
			}
			set
			{
				this.sgt_eindtijdField = value;
			}
		}
		public Lookup sgt_hoofdscheidsrechterid
		{
			get
			{
				return this.sgt_hoofdscheidsrechteridField;
			}
			set
			{
				this.sgt_hoofdscheidsrechteridField = value;
			}
		}
		public Lookup sgt_klassengroepid
		{
			get
			{
				return this.sgt_klassengroepidField;
			}
			set
			{
				this.sgt_klassengroepidField = value;
			}
		}
		public Picklist sgt_locatie
		{
			get
			{
				return this.sgt_locatieField;
			}
			set
			{
				this.sgt_locatieField = value;
			}
		}
		public string sgt_merk_ballen
		{
			get
			{
				return this.sgt_merk_ballenField;
			}
			set
			{
				this.sgt_merk_ballenField = value;
			}
		}
		public Picklist sgt_nieuwe_ballen
		{
			get
			{
				return this.sgt_nieuwe_ballenField;
			}
			set
			{
				this.sgt_nieuwe_ballenField = value;
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
		public Lookup sgt_piramideid
		{
			get
			{
				return this.sgt_piramideidField;
			}
			set
			{
				this.sgt_piramideidField = value;
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
		public Lookup sgt_ploeg_thuisid
		{
			get
			{
				return this.sgt_ploeg_thuisidField;
			}
			set
			{
				this.sgt_ploeg_thuisidField = value;
			}
		}
		public Lookup sgt_ploeg_uitid
		{
			get
			{
				return this.sgt_ploeg_uitidField;
			}
			set
			{
				this.sgt_ploeg_uitidField = value;
			}
		}
		public Lookup sgt_ploegthuisid
		{
			get
			{
				return this.sgt_ploegthuisidField;
			}
			set
			{
				this.sgt_ploegthuisidField = value;
			}
		}
		public Lookup sgt_ploeguitid
		{
			get
			{
				return this.sgt_ploeguitidField;
			}
			set
			{
				this.sgt_ploeguitidField = value;
			}
		}
		public CrmDateTime sgt_speeldatum
		{
			get
			{
				return this.sgt_speeldatumField;
			}
			set
			{
				this.sgt_speeldatumField = value;
			}
		}
		public string sgt_toelichting
		{
			get
			{
				return this.sgt_toelichtingField;
			}
			set
			{
				this.sgt_toelichtingField = value;
			}
		}
		public Lookup sgt_toernooi_aanvraag_verwerkingid
		{
			get
			{
				return this.sgt_toernooi_aanvraag_verwerkingidField;
			}
			set
			{
				this.sgt_toernooi_aanvraag_verwerkingidField = value;
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
		public Lookup sgt_verenigingthuisid
		{
			get
			{
				return this.sgt_verenigingthuisidField;
			}
			set
			{
				this.sgt_verenigingthuisidField = value;
			}
		}
		public Lookup sgt_vereniginguitid
		{
			get
			{
				return this.sgt_vereniginguitidField;
			}
			set
			{
				this.sgt_vereniginguitidField = value;
			}
		}
		public Lookup sgt_wedstrijdid
		{
			get
			{
				return this.sgt_wedstrijdidField;
			}
			set
			{
				this.sgt_wedstrijdidField = value;
			}
		}
		public Sgt_arb_rapport_hoofdscheidsrechterStateInfo statecode
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
