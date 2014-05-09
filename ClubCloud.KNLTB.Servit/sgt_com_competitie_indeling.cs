using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_com_competitie_indeling : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private CrmDateTime sgt_arb_behoefte_datum_genererenField;
		private Lookup sgt_arb_behoefte_gegeneerd_doorField;
		private CrmBoolean sgt_arb_behoefte_genererenField;
		private CrmBoolean sgt_arb_behoefte_opnieuwField;
		private CrmDateTime sgt_arb_inzet_datum_genererenField;
		private Lookup sgt_arb_inzet_gegenereerd_doorField;
		private CrmBoolean sgt_arb_inzet_genererenField;
		private CrmBoolean sgt_arb_inzet_opnieuwField;
		private Picklist sgt_arbitrageniveauField;
		private Key sgt_com_competitie_indelingidField;
		private string sgt_com_naamField;
		private Lookup sgt_competitieidField;
		private CrmDateTime sgt_indelen_ploegen_datumField;
		private CrmBoolean sgt_indelen_ploegen_indelenField;
		private Lookup sgt_indelen_ploegen_ingedeeld_doorField;
		private CrmBoolean sgt_indelen_ploegen_opnieuwField;
		private CrmBoolean sgt_wedstrijdprogramma_aanmakenField;
		private CrmDateTime sgt_wedstrijdprogramma_datum_aangemaaktField;
		private Lookup sgt_wedstrijdprogramma_gemaakt_dooridField;
		private CrmBoolean sgt_wedstrijdprogramma_opnieuwField;
		private Sgt_com_competitie_indelingStateInfo statecodeField;
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
		public CrmDateTime sgt_arb_behoefte_datum_genereren
		{
			get
			{
				return this.sgt_arb_behoefte_datum_genererenField;
			}
			set
			{
				this.sgt_arb_behoefte_datum_genererenField = value;
				base.RaisePropertyChanged("sgt_arb_behoefte_datum_genereren");
			}
		}
		[XmlElement(Order = 9)]
		public Lookup sgt_arb_behoefte_gegeneerd_door
		{
			get
			{
				return this.sgt_arb_behoefte_gegeneerd_doorField;
			}
			set
			{
				this.sgt_arb_behoefte_gegeneerd_doorField = value;
				base.RaisePropertyChanged("sgt_arb_behoefte_gegeneerd_door");
			}
		}
		[XmlElement(Order = 10)]
		public CrmBoolean sgt_arb_behoefte_genereren
		{
			get
			{
				return this.sgt_arb_behoefte_genererenField;
			}
			set
			{
				this.sgt_arb_behoefte_genererenField = value;
				base.RaisePropertyChanged("sgt_arb_behoefte_genereren");
			}
		}
		[XmlElement(Order = 11)]
		public CrmBoolean sgt_arb_behoefte_opnieuw
		{
			get
			{
				return this.sgt_arb_behoefte_opnieuwField;
			}
			set
			{
				this.sgt_arb_behoefte_opnieuwField = value;
				base.RaisePropertyChanged("sgt_arb_behoefte_opnieuw");
			}
		}
		[XmlElement(Order = 12)]
		public CrmDateTime sgt_arb_inzet_datum_genereren
		{
			get
			{
				return this.sgt_arb_inzet_datum_genererenField;
			}
			set
			{
				this.sgt_arb_inzet_datum_genererenField = value;
				base.RaisePropertyChanged("sgt_arb_inzet_datum_genereren");
			}
		}
		[XmlElement(Order = 13)]
		public Lookup sgt_arb_inzet_gegenereerd_door
		{
			get
			{
				return this.sgt_arb_inzet_gegenereerd_doorField;
			}
			set
			{
				this.sgt_arb_inzet_gegenereerd_doorField = value;
				base.RaisePropertyChanged("sgt_arb_inzet_gegenereerd_door");
			}
		}
		[XmlElement(Order = 14)]
		public CrmBoolean sgt_arb_inzet_genereren
		{
			get
			{
				return this.sgt_arb_inzet_genererenField;
			}
			set
			{
				this.sgt_arb_inzet_genererenField = value;
				base.RaisePropertyChanged("sgt_arb_inzet_genereren");
			}
		}
		[XmlElement(Order = 15)]
		public CrmBoolean sgt_arb_inzet_opnieuw
		{
			get
			{
				return this.sgt_arb_inzet_opnieuwField;
			}
			set
			{
				this.sgt_arb_inzet_opnieuwField = value;
				base.RaisePropertyChanged("sgt_arb_inzet_opnieuw");
			}
		}
		[XmlElement(Order = 16)]
		public Picklist sgt_arbitrageniveau
		{
			get
			{
				return this.sgt_arbitrageniveauField;
			}
			set
			{
				this.sgt_arbitrageniveauField = value;
				base.RaisePropertyChanged("sgt_arbitrageniveau");
			}
		}
		[XmlElement(Order = 17)]
		public Key sgt_com_competitie_indelingid
		{
			get
			{
				return this.sgt_com_competitie_indelingidField;
			}
			set
			{
				this.sgt_com_competitie_indelingidField = value;
				base.RaisePropertyChanged("sgt_com_competitie_indelingid");
			}
		}
		[XmlElement(Order = 18)]
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
		[XmlElement(Order = 19)]
		public Lookup sgt_competitieid
		{
			get
			{
				return this.sgt_competitieidField;
			}
			set
			{
				this.sgt_competitieidField = value;
				base.RaisePropertyChanged("sgt_competitieid");
			}
		}
		[XmlElement(Order = 20)]
		public CrmDateTime sgt_indelen_ploegen_datum
		{
			get
			{
				return this.sgt_indelen_ploegen_datumField;
			}
			set
			{
				this.sgt_indelen_ploegen_datumField = value;
				base.RaisePropertyChanged("sgt_indelen_ploegen_datum");
			}
		}
		[XmlElement(Order = 21)]
		public CrmBoolean sgt_indelen_ploegen_indelen
		{
			get
			{
				return this.sgt_indelen_ploegen_indelenField;
			}
			set
			{
				this.sgt_indelen_ploegen_indelenField = value;
				base.RaisePropertyChanged("sgt_indelen_ploegen_indelen");
			}
		}
		[XmlElement(Order = 22)]
		public Lookup sgt_indelen_ploegen_ingedeeld_door
		{
			get
			{
				return this.sgt_indelen_ploegen_ingedeeld_doorField;
			}
			set
			{
				this.sgt_indelen_ploegen_ingedeeld_doorField = value;
				base.RaisePropertyChanged("sgt_indelen_ploegen_ingedeeld_door");
			}
		}
		[XmlElement(Order = 23)]
		public CrmBoolean sgt_indelen_ploegen_opnieuw
		{
			get
			{
				return this.sgt_indelen_ploegen_opnieuwField;
			}
			set
			{
				this.sgt_indelen_ploegen_opnieuwField = value;
				base.RaisePropertyChanged("sgt_indelen_ploegen_opnieuw");
			}
		}
		[XmlElement(Order = 24)]
		public CrmBoolean sgt_wedstrijdprogramma_aanmaken
		{
			get
			{
				return this.sgt_wedstrijdprogramma_aanmakenField;
			}
			set
			{
				this.sgt_wedstrijdprogramma_aanmakenField = value;
				base.RaisePropertyChanged("sgt_wedstrijdprogramma_aanmaken");
			}
		}
		[XmlElement(Order = 25)]
		public CrmDateTime sgt_wedstrijdprogramma_datum_aangemaakt
		{
			get
			{
				return this.sgt_wedstrijdprogramma_datum_aangemaaktField;
			}
			set
			{
				this.sgt_wedstrijdprogramma_datum_aangemaaktField = value;
				base.RaisePropertyChanged("sgt_wedstrijdprogramma_datum_aangemaakt");
			}
		}
		[XmlElement(Order = 26)]
		public Lookup sgt_wedstrijdprogramma_gemaakt_doorid
		{
			get
			{
				return this.sgt_wedstrijdprogramma_gemaakt_dooridField;
			}
			set
			{
				this.sgt_wedstrijdprogramma_gemaakt_dooridField = value;
				base.RaisePropertyChanged("sgt_wedstrijdprogramma_gemaakt_doorid");
			}
		}
		[XmlElement(Order = 27)]
		public CrmBoolean sgt_wedstrijdprogramma_opnieuw
		{
			get
			{
				return this.sgt_wedstrijdprogramma_opnieuwField;
			}
			set
			{
				this.sgt_wedstrijdprogramma_opnieuwField = value;
				base.RaisePropertyChanged("sgt_wedstrijdprogramma_opnieuw");
			}
		}
		[XmlElement(Order = 28)]
		public Sgt_com_competitie_indelingStateInfo statecode
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
		[XmlElement(Order = 29)]
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
		[XmlElement(Order = 30)]
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
		[XmlElement(Order = 31)]
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
