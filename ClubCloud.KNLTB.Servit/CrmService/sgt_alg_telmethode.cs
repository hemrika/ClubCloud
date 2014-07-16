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
	public class sgt_alg_telmethode : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private Lookup organizationidField;

		private CrmDateTime overriddencreatedonField;

		private string sgt_alg_telmethode1Field;

		private Key sgt_alg_telmethodeidField;

		private string sgt_beschrijvingField;

		private CrmNumber sgt_bonuspunten_bij_setwinstField;

		private CrmBoolean sgt_kolom_uitslag_tonen_jnField;

		private string sgt_meervoudsnaamField;

		private string sgt_omschrijvingField;

		private CrmNumber sgt_punten_bij_afbreken_verschil_groter_dan_1Field;

		private CrmNumber sgt_punten_bij_afbreken_verschil_maximaal_1Field;

		private CrmNumber sgt_punten_bij_gelijkspelField;

		private CrmNumber sgt_punten_bij_gewonnen_tiebreakField;

		private CrmNumber sgt_punten_bij_verliesField;

		private CrmNumber sgt_punten_bij_verloren_tiebreakField;

		private CrmNumber sgt_punten_bij_winstField;

		private Picklist sgt_type_telmethodeField;

		private string sgt_verkorte_codeField;

		private Sgt_alg_telmethodeStateInfo statecodeField;

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

		[XmlElement("sgt_alg_telmethode")] //, Order=7)]
		public string sgt_alg_telmethode1
		{
			get
			{
				return this.sgt_alg_telmethode1Field;
			}
			set
			{
				this.sgt_alg_telmethode1Field = value;
				base.RaisePropertyChanged("sgt_alg_telmethode1");
			}
		}

		[XmlElement] //[XmlElement(Order=8)]
		public Key sgt_alg_telmethodeid
		{
			get
			{
				return this.sgt_alg_telmethodeidField;
			}
			set
			{
				this.sgt_alg_telmethodeidField = value;
				base.RaisePropertyChanged("sgt_alg_telmethodeid");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
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

		[XmlElement] //[XmlElement(Order=10)]
		public CrmNumber sgt_bonuspunten_bij_setwinst
		{
			get
			{
				return this.sgt_bonuspunten_bij_setwinstField;
			}
			set
			{
				this.sgt_bonuspunten_bij_setwinstField = value;
				base.RaisePropertyChanged("sgt_bonuspunten_bij_setwinst");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public CrmBoolean sgt_kolom_uitslag_tonen_jn
		{
			get
			{
				return this.sgt_kolom_uitslag_tonen_jnField;
			}
			set
			{
				this.sgt_kolom_uitslag_tonen_jnField = value;
				base.RaisePropertyChanged("sgt_kolom_uitslag_tonen_jn");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
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

		[XmlElement] //[XmlElement(Order=13)]
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

		[XmlElement] //[XmlElement(Order=14)]
		public CrmNumber sgt_punten_bij_afbreken_verschil_groter_dan_1
		{
			get
			{
				return this.sgt_punten_bij_afbreken_verschil_groter_dan_1Field;
			}
			set
			{
				this.sgt_punten_bij_afbreken_verschil_groter_dan_1Field = value;
				base.RaisePropertyChanged("sgt_punten_bij_afbreken_verschil_groter_dan_1");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public CrmNumber sgt_punten_bij_afbreken_verschil_maximaal_1
		{
			get
			{
				return this.sgt_punten_bij_afbreken_verschil_maximaal_1Field;
			}
			set
			{
				this.sgt_punten_bij_afbreken_verschil_maximaal_1Field = value;
				base.RaisePropertyChanged("sgt_punten_bij_afbreken_verschil_maximaal_1");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public CrmNumber sgt_punten_bij_gelijkspel
		{
			get
			{
				return this.sgt_punten_bij_gelijkspelField;
			}
			set
			{
				this.sgt_punten_bij_gelijkspelField = value;
				base.RaisePropertyChanged("sgt_punten_bij_gelijkspel");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public CrmNumber sgt_punten_bij_gewonnen_tiebreak
		{
			get
			{
				return this.sgt_punten_bij_gewonnen_tiebreakField;
			}
			set
			{
				this.sgt_punten_bij_gewonnen_tiebreakField = value;
				base.RaisePropertyChanged("sgt_punten_bij_gewonnen_tiebreak");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public CrmNumber sgt_punten_bij_verlies
		{
			get
			{
				return this.sgt_punten_bij_verliesField;
			}
			set
			{
				this.sgt_punten_bij_verliesField = value;
				base.RaisePropertyChanged("sgt_punten_bij_verlies");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
		public CrmNumber sgt_punten_bij_verloren_tiebreak
		{
			get
			{
				return this.sgt_punten_bij_verloren_tiebreakField;
			}
			set
			{
				this.sgt_punten_bij_verloren_tiebreakField = value;
				base.RaisePropertyChanged("sgt_punten_bij_verloren_tiebreak");
			}
		}

		[XmlElement] //[XmlElement(Order=20)]
		public CrmNumber sgt_punten_bij_winst
		{
			get
			{
				return this.sgt_punten_bij_winstField;
			}
			set
			{
				this.sgt_punten_bij_winstField = value;
				base.RaisePropertyChanged("sgt_punten_bij_winst");
			}
		}

		[XmlElement] //[XmlElement(Order=21)]
		public Picklist sgt_type_telmethode
		{
			get
			{
				return this.sgt_type_telmethodeField;
			}
			set
			{
				this.sgt_type_telmethodeField = value;
				base.RaisePropertyChanged("sgt_type_telmethode");
			}
		}

		[XmlElement] //[XmlElement(Order=22)]
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

		[XmlElement] //[XmlElement(Order=23)]
		public Sgt_alg_telmethodeStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=24)]
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

		[XmlElement] //[XmlElement(Order=25)]
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

		[XmlElement] //[XmlElement(Order=26)]
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

		public sgt_alg_telmethode()
		{
		}
	}
}