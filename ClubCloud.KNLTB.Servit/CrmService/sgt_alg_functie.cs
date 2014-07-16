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
	public class sgt_alg_functie : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private Lookup organizationidField;

		private CrmDateTime overriddencreatedonField;

		private string sgt_alg_functie1Field;

		private Key sgt_alg_functieidField;

		private CrmBoolean sgt_arbitrage_functionarisField;

		private CrmBoolean sgt_basisorganisatieField;

		private CrmBoolean sgt_basisorganisatie_termijn_opgevenField;

		private string sgt_beschrijvingField;

		private CrmBoolean sgt_bestuursorgaanField;

		private CrmBoolean sgt_bestuursorgaan_termijn_opgevenField;

		private CrmBoolean sgt_centre_courtField;

		private CrmBoolean sgt_controle_geheim_adresField;

		private CrmBoolean sgt_docentfunctionarisField;

		private Picklist sgt_functie_kenmerkField;

		private Picklist sgt_functiecoderingField;

		private string sgt_meervoudsnaamField;

		private string sgt_omschrijvingField;

		private CrmBoolean sgt_persoonField;

		private CrmBoolean sgt_persoon_termijn_opgevenField;

		private Lookup sgt_soort_lidmaatschapidField;

		private CrmBoolean sgt_toegang_crm_toegestaanField;

		private Picklist sgt_toegangsniveauField;

		private string sgt_verkorte_codeField;

		private Sgt_alg_functieStateInfo statecodeField;

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
		public Lookup organizationid
		{
			get
			{
				return this.organizationidField;
			}
			set
			{
				this.organizationidField = value;
				base.RaisePropertyChanged("organizationid");
			}
		}

		[XmlElement] //[XmlElement(Order=6)]
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

		[XmlElement("sgt_alg_functie")] //, Order=7)]
		public string sgt_alg_functie1
		{
			get
			{
				return this.sgt_alg_functie1Field;
			}
			set
			{
				this.sgt_alg_functie1Field = value;
				base.RaisePropertyChanged("sgt_alg_functie1");
			}
		}

		[XmlElement] //[XmlElement(Order=8)]
		public Key sgt_alg_functieid
		{
			get
			{
				return this.sgt_alg_functieidField;
			}
			set
			{
				this.sgt_alg_functieidField = value;
				base.RaisePropertyChanged("sgt_alg_functieid");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public CrmBoolean sgt_arbitrage_functionaris
		{
			get
			{
				return this.sgt_arbitrage_functionarisField;
			}
			set
			{
				this.sgt_arbitrage_functionarisField = value;
				base.RaisePropertyChanged("sgt_arbitrage_functionaris");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public CrmBoolean sgt_basisorganisatie
		{
			get
			{
				return this.sgt_basisorganisatieField;
			}
			set
			{
				this.sgt_basisorganisatieField = value;
				base.RaisePropertyChanged("sgt_basisorganisatie");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public CrmBoolean sgt_basisorganisatie_termijn_opgeven
		{
			get
			{
				return this.sgt_basisorganisatie_termijn_opgevenField;
			}
			set
			{
				this.sgt_basisorganisatie_termijn_opgevenField = value;
				base.RaisePropertyChanged("sgt_basisorganisatie_termijn_opgeven");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public string sgt_beschrijving
		{
			get
			{
				return this.sgt_beschrijvingField;
			}
			set
			{
				this.sgt_beschrijvingField = value;
				base.RaisePropertyChanged("sgt_beschrijving");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public CrmBoolean sgt_bestuursorgaan
		{
			get
			{
				return this.sgt_bestuursorgaanField;
			}
			set
			{
				this.sgt_bestuursorgaanField = value;
				base.RaisePropertyChanged("sgt_bestuursorgaan");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public CrmBoolean sgt_bestuursorgaan_termijn_opgeven
		{
			get
			{
				return this.sgt_bestuursorgaan_termijn_opgevenField;
			}
			set
			{
				this.sgt_bestuursorgaan_termijn_opgevenField = value;
				base.RaisePropertyChanged("sgt_bestuursorgaan_termijn_opgeven");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public CrmBoolean sgt_centre_court
		{
			get
			{
				return this.sgt_centre_courtField;
			}
			set
			{
				this.sgt_centre_courtField = value;
				base.RaisePropertyChanged("sgt_centre_court");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public CrmBoolean sgt_controle_geheim_adres
		{
			get
			{
				return this.sgt_controle_geheim_adresField;
			}
			set
			{
				this.sgt_controle_geheim_adresField = value;
				base.RaisePropertyChanged("sgt_controle_geheim_adres");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public CrmBoolean sgt_docentfunctionaris
		{
			get
			{
				return this.sgt_docentfunctionarisField;
			}
			set
			{
				this.sgt_docentfunctionarisField = value;
				base.RaisePropertyChanged("sgt_docentfunctionaris");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public Picklist sgt_functie_kenmerk
		{
			get
			{
				return this.sgt_functie_kenmerkField;
			}
			set
			{
				this.sgt_functie_kenmerkField = value;
				base.RaisePropertyChanged("sgt_functie_kenmerk");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
		public Picklist sgt_functiecodering
		{
			get
			{
				return this.sgt_functiecoderingField;
			}
			set
			{
				this.sgt_functiecoderingField = value;
				base.RaisePropertyChanged("sgt_functiecodering");
			}
		}

		[XmlElement] //[XmlElement(Order=20)]
		public string sgt_meervoudsnaam
		{
			get
			{
				return this.sgt_meervoudsnaamField;
			}
			set
			{
				this.sgt_meervoudsnaamField = value;
				base.RaisePropertyChanged("sgt_meervoudsnaam");
			}
		}

		[XmlElement] //[XmlElement(Order=21)]
		public string sgt_omschrijving
		{
			get
			{
				return this.sgt_omschrijvingField;
			}
			set
			{
				this.sgt_omschrijvingField = value;
				base.RaisePropertyChanged("sgt_omschrijving");
			}
		}

		[XmlElement] //[XmlElement(Order=22)]
		public CrmBoolean sgt_persoon
		{
			get
			{
				return this.sgt_persoonField;
			}
			set
			{
				this.sgt_persoonField = value;
				base.RaisePropertyChanged("sgt_persoon");
			}
		}

		[XmlElement] //[XmlElement(Order=23)]
		public CrmBoolean sgt_persoon_termijn_opgeven
		{
			get
			{
				return this.sgt_persoon_termijn_opgevenField;
			}
			set
			{
				this.sgt_persoon_termijn_opgevenField = value;
				base.RaisePropertyChanged("sgt_persoon_termijn_opgeven");
			}
		}

		[XmlElement] //[XmlElement(Order=24)]
		public Lookup sgt_soort_lidmaatschapid
		{
			get
			{
				return this.sgt_soort_lidmaatschapidField;
			}
			set
			{
				this.sgt_soort_lidmaatschapidField = value;
				base.RaisePropertyChanged("sgt_soort_lidmaatschapid");
			}
		}

		[XmlElement] //[XmlElement(Order=25)]
		public CrmBoolean sgt_toegang_crm_toegestaan
		{
			get
			{
				return this.sgt_toegang_crm_toegestaanField;
			}
			set
			{
				this.sgt_toegang_crm_toegestaanField = value;
				base.RaisePropertyChanged("sgt_toegang_crm_toegestaan");
			}
		}

		[XmlElement] //[XmlElement(Order=26)]
		public Picklist sgt_toegangsniveau
		{
			get
			{
				return this.sgt_toegangsniveauField;
			}
			set
			{
				this.sgt_toegangsniveauField = value;
				base.RaisePropertyChanged("sgt_toegangsniveau");
			}
		}

		[XmlElement] //[XmlElement(Order=27)]
		public string sgt_verkorte_code
		{
			get
			{
				return this.sgt_verkorte_codeField;
			}
			set
			{
				this.sgt_verkorte_codeField = value;
				base.RaisePropertyChanged("sgt_verkorte_code");
			}
		}

		[XmlElement] //[XmlElement(Order=28)]
		public Sgt_alg_functieStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=29)]
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

		[XmlElement] //[XmlElement(Order=30)]
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

		[XmlElement] //[XmlElement(Order=31)]
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

		public sgt_alg_functie()
		{
		}
	}
}