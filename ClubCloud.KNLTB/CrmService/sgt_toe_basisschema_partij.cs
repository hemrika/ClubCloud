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
	public class sgt_toe_basisschema_partij : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private string sgt_baanField;

		private Lookup sgt_basisschema_idField;

		private string sgt_basisschema_partij_kenmerkField;

		private Lookup sgt_basisschema_ronde_idField;

		private string sgt_plaatsing_bij_verlies_schemaspelers_thuisField;

		private string sgt_plaatsing_bij_verlies_schemaspelers_uitField;

		private string sgt_plaatsing_bij_verlies_speler_thuis_pwField;

		private string sgt_plaatsing_bij_verlies_speler_uit_pwField;

		private string sgt_plaatsing_bij_winst_schemaspeler_thuis_pwField;

		private string sgt_plaatsing_bij_winst_schemaspeler_uit_pwField;

		private string sgt_plaatsing_bij_winst_schemaspelers_thuisField;

		private string sgt_plaatsing_bij_winst_schemaspelers_uitField;

		private string sgt_schemaspeler_thuis_partnerwisselField;

		private string sgt_schemaspeler_uit_partnerwisselField;

		private string sgt_schemaspelers_thuisField;

		private string sgt_schemaspelers_uitField;

		private CrmNumber sgt_speeldagField;

		private string sgt_tijdField;

		private Key sgt_toe_basisschema_partijidField;

		private string sgt_volgnummer_partijField;

		private Sgt_toe_basisschema_partijStateInfo statecodeField;

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
		public string sgt_baan
		{
			get
			{
				return this.sgt_baanField;
			}
			set
			{
				this.sgt_baanField = value;
				base.RaisePropertyChanged("sgt_baan");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public Lookup sgt_basisschema_id
		{
			get
			{
				return this.sgt_basisschema_idField;
			}
			set
			{
				this.sgt_basisschema_idField = value;
				base.RaisePropertyChanged("sgt_basisschema_id");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public string sgt_basisschema_partij_kenmerk
		{
			get
			{
				return this.sgt_basisschema_partij_kenmerkField;
			}
			set
			{
				this.sgt_basisschema_partij_kenmerkField = value;
				base.RaisePropertyChanged("sgt_basisschema_partij_kenmerk");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public Lookup sgt_basisschema_ronde_id
		{
			get
			{
				return this.sgt_basisschema_ronde_idField;
			}
			set
			{
				this.sgt_basisschema_ronde_idField = value;
				base.RaisePropertyChanged("sgt_basisschema_ronde_id");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public string sgt_plaatsing_bij_verlies_schemaspelers_thuis
		{
			get
			{
				return this.sgt_plaatsing_bij_verlies_schemaspelers_thuisField;
			}
			set
			{
				this.sgt_plaatsing_bij_verlies_schemaspelers_thuisField = value;
				base.RaisePropertyChanged("sgt_plaatsing_bij_verlies_schemaspelers_thuis");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public string sgt_plaatsing_bij_verlies_schemaspelers_uit
		{
			get
			{
				return this.sgt_plaatsing_bij_verlies_schemaspelers_uitField;
			}
			set
			{
				this.sgt_plaatsing_bij_verlies_schemaspelers_uitField = value;
				base.RaisePropertyChanged("sgt_plaatsing_bij_verlies_schemaspelers_uit");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public string sgt_plaatsing_bij_verlies_speler_thuis_pw
		{
			get
			{
				return this.sgt_plaatsing_bij_verlies_speler_thuis_pwField;
			}
			set
			{
				this.sgt_plaatsing_bij_verlies_speler_thuis_pwField = value;
				base.RaisePropertyChanged("sgt_plaatsing_bij_verlies_speler_thuis_pw");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public string sgt_plaatsing_bij_verlies_speler_uit_pw
		{
			get
			{
				return this.sgt_plaatsing_bij_verlies_speler_uit_pwField;
			}
			set
			{
				this.sgt_plaatsing_bij_verlies_speler_uit_pwField = value;
				base.RaisePropertyChanged("sgt_plaatsing_bij_verlies_speler_uit_pw");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public string sgt_plaatsing_bij_winst_schemaspeler_thuis_pw
		{
			get
			{
				return this.sgt_plaatsing_bij_winst_schemaspeler_thuis_pwField;
			}
			set
			{
				this.sgt_plaatsing_bij_winst_schemaspeler_thuis_pwField = value;
				base.RaisePropertyChanged("sgt_plaatsing_bij_winst_schemaspeler_thuis_pw");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public string sgt_plaatsing_bij_winst_schemaspeler_uit_pw
		{
			get
			{
				return this.sgt_plaatsing_bij_winst_schemaspeler_uit_pwField;
			}
			set
			{
				this.sgt_plaatsing_bij_winst_schemaspeler_uit_pwField = value;
				base.RaisePropertyChanged("sgt_plaatsing_bij_winst_schemaspeler_uit_pw");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public string sgt_plaatsing_bij_winst_schemaspelers_thuis
		{
			get
			{
				return this.sgt_plaatsing_bij_winst_schemaspelers_thuisField;
			}
			set
			{
				this.sgt_plaatsing_bij_winst_schemaspelers_thuisField = value;
				base.RaisePropertyChanged("sgt_plaatsing_bij_winst_schemaspelers_thuis");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
		public string sgt_plaatsing_bij_winst_schemaspelers_uit
		{
			get
			{
				return this.sgt_plaatsing_bij_winst_schemaspelers_uitField;
			}
			set
			{
				this.sgt_plaatsing_bij_winst_schemaspelers_uitField = value;
				base.RaisePropertyChanged("sgt_plaatsing_bij_winst_schemaspelers_uit");
			}
		}

		[XmlElement] //[XmlElement(Order=20)]
		public string sgt_schemaspeler_thuis_partnerwissel
		{
			get
			{
				return this.sgt_schemaspeler_thuis_partnerwisselField;
			}
			set
			{
				this.sgt_schemaspeler_thuis_partnerwisselField = value;
				base.RaisePropertyChanged("sgt_schemaspeler_thuis_partnerwissel");
			}
		}

		[XmlElement] //[XmlElement(Order=21)]
		public string sgt_schemaspeler_uit_partnerwissel
		{
			get
			{
				return this.sgt_schemaspeler_uit_partnerwisselField;
			}
			set
			{
				this.sgt_schemaspeler_uit_partnerwisselField = value;
				base.RaisePropertyChanged("sgt_schemaspeler_uit_partnerwissel");
			}
		}

		[XmlElement] //[XmlElement(Order=22)]
		public string sgt_schemaspelers_thuis
		{
			get
			{
				return this.sgt_schemaspelers_thuisField;
			}
			set
			{
				this.sgt_schemaspelers_thuisField = value;
				base.RaisePropertyChanged("sgt_schemaspelers_thuis");
			}
		}

		[XmlElement] //[XmlElement(Order=23)]
		public string sgt_schemaspelers_uit
		{
			get
			{
				return this.sgt_schemaspelers_uitField;
			}
			set
			{
				this.sgt_schemaspelers_uitField = value;
				base.RaisePropertyChanged("sgt_schemaspelers_uit");
			}
		}

		[XmlElement] //[XmlElement(Order=24)]
		public CrmNumber sgt_speeldag
		{
			get
			{
				return this.sgt_speeldagField;
			}
			set
			{
				this.sgt_speeldagField = value;
				base.RaisePropertyChanged("sgt_speeldag");
			}
		}

		[XmlElement] //[XmlElement(Order=25)]
		public string sgt_tijd
		{
			get
			{
				return this.sgt_tijdField;
			}
			set
			{
				this.sgt_tijdField = value;
				base.RaisePropertyChanged("sgt_tijd");
			}
		}

		[XmlElement] //[XmlElement(Order=26)]
		public Key sgt_toe_basisschema_partijid
		{
			get
			{
				return this.sgt_toe_basisschema_partijidField;
			}
			set
			{
				this.sgt_toe_basisschema_partijidField = value;
				base.RaisePropertyChanged("sgt_toe_basisschema_partijid");
			}
		}

		[XmlElement] //[XmlElement(Order=27)]
		public string sgt_volgnummer_partij
		{
			get
			{
				return this.sgt_volgnummer_partijField;
			}
			set
			{
				this.sgt_volgnummer_partijField = value;
				base.RaisePropertyChanged("sgt_volgnummer_partij");
			}
		}

		[XmlElement] //[XmlElement(Order=28)]
		public Sgt_toe_basisschema_partijStateInfo statecode
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

		public sgt_toe_basisschema_partij()
		{
		}
	}
}