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
		public CrmDateTime sgt_arb_behoefte_datum_genereren
		{
			get
			{
				return this.sgt_arb_behoefte_datum_genererenField;
			}
			set
			{
				this.sgt_arb_behoefte_datum_genererenField = value;
			}
		}
		public Lookup sgt_arb_behoefte_gegeneerd_door
		{
			get
			{
				return this.sgt_arb_behoefte_gegeneerd_doorField;
			}
			set
			{
				this.sgt_arb_behoefte_gegeneerd_doorField = value;
			}
		}
		public CrmBoolean sgt_arb_behoefte_genereren
		{
			get
			{
				return this.sgt_arb_behoefte_genererenField;
			}
			set
			{
				this.sgt_arb_behoefte_genererenField = value;
			}
		}
		public CrmBoolean sgt_arb_behoefte_opnieuw
		{
			get
			{
				return this.sgt_arb_behoefte_opnieuwField;
			}
			set
			{
				this.sgt_arb_behoefte_opnieuwField = value;
			}
		}
		public CrmDateTime sgt_arb_inzet_datum_genereren
		{
			get
			{
				return this.sgt_arb_inzet_datum_genererenField;
			}
			set
			{
				this.sgt_arb_inzet_datum_genererenField = value;
			}
		}
		public Lookup sgt_arb_inzet_gegenereerd_door
		{
			get
			{
				return this.sgt_arb_inzet_gegenereerd_doorField;
			}
			set
			{
				this.sgt_arb_inzet_gegenereerd_doorField = value;
			}
		}
		public CrmBoolean sgt_arb_inzet_genereren
		{
			get
			{
				return this.sgt_arb_inzet_genererenField;
			}
			set
			{
				this.sgt_arb_inzet_genererenField = value;
			}
		}
		public CrmBoolean sgt_arb_inzet_opnieuw
		{
			get
			{
				return this.sgt_arb_inzet_opnieuwField;
			}
			set
			{
				this.sgt_arb_inzet_opnieuwField = value;
			}
		}
		public Picklist sgt_arbitrageniveau
		{
			get
			{
				return this.sgt_arbitrageniveauField;
			}
			set
			{
				this.sgt_arbitrageniveauField = value;
			}
		}
		public Key sgt_com_competitie_indelingid
		{
			get
			{
				return this.sgt_com_competitie_indelingidField;
			}
			set
			{
				this.sgt_com_competitie_indelingidField = value;
			}
		}
		public string sgt_com_naam
		{
			get
			{
				return this.sgt_com_naamField;
			}
			set
			{
				this.sgt_com_naamField = value;
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
		public CrmDateTime sgt_indelen_ploegen_datum
		{
			get
			{
				return this.sgt_indelen_ploegen_datumField;
			}
			set
			{
				this.sgt_indelen_ploegen_datumField = value;
			}
		}
		public CrmBoolean sgt_indelen_ploegen_indelen
		{
			get
			{
				return this.sgt_indelen_ploegen_indelenField;
			}
			set
			{
				this.sgt_indelen_ploegen_indelenField = value;
			}
		}
		public Lookup sgt_indelen_ploegen_ingedeeld_door
		{
			get
			{
				return this.sgt_indelen_ploegen_ingedeeld_doorField;
			}
			set
			{
				this.sgt_indelen_ploegen_ingedeeld_doorField = value;
			}
		}
		public CrmBoolean sgt_indelen_ploegen_opnieuw
		{
			get
			{
				return this.sgt_indelen_ploegen_opnieuwField;
			}
			set
			{
				this.sgt_indelen_ploegen_opnieuwField = value;
			}
		}
		public CrmBoolean sgt_wedstrijdprogramma_aanmaken
		{
			get
			{
				return this.sgt_wedstrijdprogramma_aanmakenField;
			}
			set
			{
				this.sgt_wedstrijdprogramma_aanmakenField = value;
			}
		}
		public CrmDateTime sgt_wedstrijdprogramma_datum_aangemaakt
		{
			get
			{
				return this.sgt_wedstrijdprogramma_datum_aangemaaktField;
			}
			set
			{
				this.sgt_wedstrijdprogramma_datum_aangemaaktField = value;
			}
		}
		public Lookup sgt_wedstrijdprogramma_gemaakt_doorid
		{
			get
			{
				return this.sgt_wedstrijdprogramma_gemaakt_dooridField;
			}
			set
			{
				this.sgt_wedstrijdprogramma_gemaakt_dooridField = value;
			}
		}
		public CrmBoolean sgt_wedstrijdprogramma_opnieuw
		{
			get
			{
				return this.sgt_wedstrijdprogramma_opnieuwField;
			}
			set
			{
				this.sgt_wedstrijdprogramma_opnieuwField = value;
			}
		}
		public Sgt_com_competitie_indelingStateInfo statecode
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
