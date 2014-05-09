using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_com_ploeginschrijving_afhandeling : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmDecimal exchangerateField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private CrmBoolean sgt_accepteren_ploegField;
		private Lookup sgt_afgehandeld_dooridField;
		private Lookup sgt_boete_idField;
		private CrmMoney sgt_boetebedragField;
		private CrmMoney sgt_boetebedrag_baseField;
		private string sgt_com_naamField;
		private Key sgt_com_ploeginschrijving_afhandelingidField;
		private Lookup sgt_competitie_idField;
		private CrmDateTime sgt_datum_accepterenField;
		private CrmDateTime sgt_datum_terugtrekkenField;
		private CrmDateTime sgt_datum_uitgevoerdField;
		private Lookup sgt_geaccepteerd_dooridField;
		private Lookup sgt_klassegroep_idField;
		private CrmBoolean sgt_onvoldoende_beschikbare_banenField;
		private Lookup sgt_piramide_idField;
		private CrmDecimal sgt_ploeg_speelsterkte_dField;
		private CrmDecimal sgt_ploeg_speelsterkte_eField;
		private CrmDecimal sgt_ploeggemiddeldeField;
		private Lookup sgt_ploegnaam_idField;
		private CrmBoolean sgt_promoveren_degraderenField;
		private Lookup sgt_teruggetrokken_dooridField;
		private CrmBoolean sgt_terugtrekkenField;
		private Lookup sgt_valuta_idField;
		private Lookup sgt_vereniging_idField;
		private CrmBoolean sgt_verenigingsrecht_intrekkenField;
		private Lookup sgt_verzoekklasse_naaridField;
		private Sgt_com_ploeginschrijving_afhandelingStateInfo statecodeField;
		private Status statuscodeField;
		private CrmNumber timezoneruleversionnumberField;
		private Lookup transactioncurrencyidField;
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
		public CrmDecimal exchangerate
		{
			get
			{
				return this.exchangerateField;
			}
			set
			{
				this.exchangerateField = value;
				base.RaisePropertyChanged("exchangerate");
			}
		}
		[XmlElement(Order = 3)]
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
		[XmlElement(Order = 4)]
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
		[XmlElement(Order = 5)]
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
		[XmlElement(Order = 6)]
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
		[XmlElement(Order = 7)]
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
		[XmlElement(Order = 8)]
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
		[XmlElement(Order = 9)]
		public CrmBoolean sgt_accepteren_ploeg
		{
			get
			{
				return this.sgt_accepteren_ploegField;
			}
			set
			{
				this.sgt_accepteren_ploegField = value;
				base.RaisePropertyChanged("sgt_accepteren_ploeg");
			}
		}
		[XmlElement(Order = 10)]
		public Lookup sgt_afgehandeld_doorid
		{
			get
			{
				return this.sgt_afgehandeld_dooridField;
			}
			set
			{
				this.sgt_afgehandeld_dooridField = value;
				base.RaisePropertyChanged("sgt_afgehandeld_doorid");
			}
		}
		[XmlElement(Order = 11)]
		public Lookup sgt_boete_id
		{
			get
			{
				return this.sgt_boete_idField;
			}
			set
			{
				this.sgt_boete_idField = value;
				base.RaisePropertyChanged("sgt_boete_id");
			}
		}
		[XmlElement(Order = 12)]
		public CrmMoney sgt_boetebedrag
		{
			get
			{
				return this.sgt_boetebedragField;
			}
			set
			{
				this.sgt_boetebedragField = value;
				base.RaisePropertyChanged("sgt_boetebedrag");
			}
		}
		[XmlElement(Order = 13)]
		public CrmMoney sgt_boetebedrag_base
		{
			get
			{
				return this.sgt_boetebedrag_baseField;
			}
			set
			{
				this.sgt_boetebedrag_baseField = value;
				base.RaisePropertyChanged("sgt_boetebedrag_base");
			}
		}
		[XmlElement(Order = 14)]
		public string sgt_com_naam
		{
			get
			{
				return this.sgt_com_naamField;
			}
			set
			{
				this.sgt_com_naamField = value;
				base.RaisePropertyChanged("sgt_com_naam");
			}
		}
		[XmlElement(Order = 15)]
		public Key sgt_com_ploeginschrijving_afhandelingid
		{
			get
			{
				return this.sgt_com_ploeginschrijving_afhandelingidField;
			}
			set
			{
				this.sgt_com_ploeginschrijving_afhandelingidField = value;
				base.RaisePropertyChanged("sgt_com_ploeginschrijving_afhandelingid");
			}
		}
		[XmlElement(Order = 16)]
		public Lookup sgt_competitie_id
		{
			get
			{
				return this.sgt_competitie_idField;
			}
			set
			{
				this.sgt_competitie_idField = value;
				base.RaisePropertyChanged("sgt_competitie_id");
			}
		}
		[XmlElement(Order = 17)]
		public CrmDateTime sgt_datum_accepteren
		{
			get
			{
				return this.sgt_datum_accepterenField;
			}
			set
			{
				this.sgt_datum_accepterenField = value;
				base.RaisePropertyChanged("sgt_datum_accepteren");
			}
		}
		[XmlElement(Order = 18)]
		public CrmDateTime sgt_datum_terugtrekken
		{
			get
			{
				return this.sgt_datum_terugtrekkenField;
			}
			set
			{
				this.sgt_datum_terugtrekkenField = value;
				base.RaisePropertyChanged("sgt_datum_terugtrekken");
			}
		}
		[XmlElement(Order = 19)]
		public CrmDateTime sgt_datum_uitgevoerd
		{
			get
			{
				return this.sgt_datum_uitgevoerdField;
			}
			set
			{
				this.sgt_datum_uitgevoerdField = value;
				base.RaisePropertyChanged("sgt_datum_uitgevoerd");
			}
		}
		[XmlElement(Order = 20)]
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
		[XmlElement(Order = 21)]
		public Lookup sgt_klassegroep_id
		{
			get
			{
				return this.sgt_klassegroep_idField;
			}
			set
			{
				this.sgt_klassegroep_idField = value;
				base.RaisePropertyChanged("sgt_klassegroep_id");
			}
		}
		[XmlElement(Order = 22)]
		public CrmBoolean sgt_onvoldoende_beschikbare_banen
		{
			get
			{
				return this.sgt_onvoldoende_beschikbare_banenField;
			}
			set
			{
				this.sgt_onvoldoende_beschikbare_banenField = value;
				base.RaisePropertyChanged("sgt_onvoldoende_beschikbare_banen");
			}
		}
		[XmlElement(Order = 23)]
		public Lookup sgt_piramide_id
		{
			get
			{
				return this.sgt_piramide_idField;
			}
			set
			{
				this.sgt_piramide_idField = value;
				base.RaisePropertyChanged("sgt_piramide_id");
			}
		}
		[XmlElement(Order = 24)]
		public CrmDecimal sgt_ploeg_speelsterkte_d
		{
			get
			{
				return this.sgt_ploeg_speelsterkte_dField;
			}
			set
			{
				this.sgt_ploeg_speelsterkte_dField = value;
				base.RaisePropertyChanged("sgt_ploeg_speelsterkte_d");
			}
		}
		[XmlElement(Order = 25)]
		public CrmDecimal sgt_ploeg_speelsterkte_e
		{
			get
			{
				return this.sgt_ploeg_speelsterkte_eField;
			}
			set
			{
				this.sgt_ploeg_speelsterkte_eField = value;
				base.RaisePropertyChanged("sgt_ploeg_speelsterkte_e");
			}
		}
		[XmlElement(Order = 26)]
		public CrmDecimal sgt_ploeggemiddelde
		{
			get
			{
				return this.sgt_ploeggemiddeldeField;
			}
			set
			{
				this.sgt_ploeggemiddeldeField = value;
				base.RaisePropertyChanged("sgt_ploeggemiddelde");
			}
		}
		[XmlElement(Order = 27)]
		public Lookup sgt_ploegnaam_id
		{
			get
			{
				return this.sgt_ploegnaam_idField;
			}
			set
			{
				this.sgt_ploegnaam_idField = value;
				base.RaisePropertyChanged("sgt_ploegnaam_id");
			}
		}
		[XmlElement(Order = 28)]
		public CrmBoolean sgt_promoveren_degraderen
		{
			get
			{
				return this.sgt_promoveren_degraderenField;
			}
			set
			{
				this.sgt_promoveren_degraderenField = value;
				base.RaisePropertyChanged("sgt_promoveren_degraderen");
			}
		}
		[XmlElement(Order = 29)]
		public Lookup sgt_teruggetrokken_doorid
		{
			get
			{
				return this.sgt_teruggetrokken_dooridField;
			}
			set
			{
				this.sgt_teruggetrokken_dooridField = value;
				base.RaisePropertyChanged("sgt_teruggetrokken_doorid");
			}
		}
		[XmlElement(Order = 30)]
		public CrmBoolean sgt_terugtrekken
		{
			get
			{
				return this.sgt_terugtrekkenField;
			}
			set
			{
				this.sgt_terugtrekkenField = value;
				base.RaisePropertyChanged("sgt_terugtrekken");
			}
		}
		[XmlElement(Order = 31)]
		public Lookup sgt_valuta_id
		{
			get
			{
				return this.sgt_valuta_idField;
			}
			set
			{
				this.sgt_valuta_idField = value;
				base.RaisePropertyChanged("sgt_valuta_id");
			}
		}
		[XmlElement(Order = 32)]
		public Lookup sgt_vereniging_id
		{
			get
			{
				return this.sgt_vereniging_idField;
			}
			set
			{
				this.sgt_vereniging_idField = value;
				base.RaisePropertyChanged("sgt_vereniging_id");
			}
		}
		[XmlElement(Order = 33)]
		public CrmBoolean sgt_verenigingsrecht_intrekken
		{
			get
			{
				return this.sgt_verenigingsrecht_intrekkenField;
			}
			set
			{
				this.sgt_verenigingsrecht_intrekkenField = value;
				base.RaisePropertyChanged("sgt_verenigingsrecht_intrekken");
			}
		}
		[XmlElement(Order = 34)]
		public Lookup sgt_verzoekklasse_naarid
		{
			get
			{
				return this.sgt_verzoekklasse_naaridField;
			}
			set
			{
				this.sgt_verzoekklasse_naaridField = value;
				base.RaisePropertyChanged("sgt_verzoekklasse_naarid");
			}
		}
		[XmlElement(Order = 35)]
		public Sgt_com_ploeginschrijving_afhandelingStateInfo statecode
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
		[XmlElement(Order = 36)]
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
		[XmlElement(Order = 37)]
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
		[XmlElement(Order = 38)]
		public Lookup transactioncurrencyid
		{
			get
			{
				return this.transactioncurrencyidField;
			}
			set
			{
				this.transactioncurrencyidField = value;
				base.RaisePropertyChanged("transactioncurrencyid");
			}
		}
		[XmlElement(Order = 39)]
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
