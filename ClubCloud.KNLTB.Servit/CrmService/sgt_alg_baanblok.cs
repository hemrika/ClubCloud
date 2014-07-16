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
	public class sgt_alg_baanblok : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private Lookup sgt_aangelegddooridField;

		private CrmNumber sgt_aantal_banen_afgekeurdField;

		private CrmNumber sgt_aantal_banen_dispensatieField;

		private CrmNumber sgt_aantal_banen_goedgekeurdField;

		private CrmNumber sgt_aantal_banen_te_keurenField;

		private Lookup sgt_accommodatieidField;

		private string sgt_alg_baanblok1Field;

		private Key sgt_alg_baanblokidField;

		private CrmNumber sgt_baanblok_m2Field;

		private Lookup sgt_baansoortidField;

		private Lookup sgt_baantypeidField;

		private string sgt_bouwjaar_bbField;

		private CrmDateTime sgt_datum_keuring_verlichtingField;

		private string sgt_eigendom_opmerkingField;

		private Lookup sgt_eigendomidField;

		private Lookup sgt_gekeurddooridField;

		private Picklist sgt_lichtpunthoogteField;

		private Picklist sgt_lichtpuntsterkteField;

		private Picklist sgt_locatie_bbField;

		private Picklist sgt_maatvoering_speelveldField;

		private Picklist sgt_maatvoering_uitlopenField;

		private string sgt_soort_obstakelsField;

		private Picklist sgt_soort_verlichtingField;

		private Picklist sgt_status_verlichtingField;

		private CrmBoolean sgt_vaste_obstakelsField;

		private CrmBoolean sgt_verlichtingField;

		private Sgt_alg_baanblokStateInfo statecodeField;

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
		public Lookup sgt_aangelegddoorid
		{
			get
			{
				return this.sgt_aangelegddooridField;
			}
			set
			{
				this.sgt_aangelegddooridField = value;
				base.RaisePropertyChanged("sgt_aangelegddoorid");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public CrmNumber sgt_aantal_banen_afgekeurd
		{
			get
			{
				return this.sgt_aantal_banen_afgekeurdField;
			}
			set
			{
				this.sgt_aantal_banen_afgekeurdField = value;
				base.RaisePropertyChanged("sgt_aantal_banen_afgekeurd");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public CrmNumber sgt_aantal_banen_dispensatie
		{
			get
			{
				return this.sgt_aantal_banen_dispensatieField;
			}
			set
			{
				this.sgt_aantal_banen_dispensatieField = value;
				base.RaisePropertyChanged("sgt_aantal_banen_dispensatie");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public CrmNumber sgt_aantal_banen_goedgekeurd
		{
			get
			{
				return this.sgt_aantal_banen_goedgekeurdField;
			}
			set
			{
				this.sgt_aantal_banen_goedgekeurdField = value;
				base.RaisePropertyChanged("sgt_aantal_banen_goedgekeurd");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public CrmNumber sgt_aantal_banen_te_keuren
		{
			get
			{
				return this.sgt_aantal_banen_te_keurenField;
			}
			set
			{
				this.sgt_aantal_banen_te_keurenField = value;
				base.RaisePropertyChanged("sgt_aantal_banen_te_keuren");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public Lookup sgt_accommodatieid
		{
			get
			{
				return this.sgt_accommodatieidField;
			}
			set
			{
				this.sgt_accommodatieidField = value;
				base.RaisePropertyChanged("sgt_accommodatieid");
			}
		}

		[XmlElement("sgt_alg_baanblok")] //, Order=14)]
		public string sgt_alg_baanblok1
		{
			get
			{
				return this.sgt_alg_baanblok1Field;
			}
			set
			{
				this.sgt_alg_baanblok1Field = value;
				base.RaisePropertyChanged("sgt_alg_baanblok1");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public Key sgt_alg_baanblokid
		{
			get
			{
				return this.sgt_alg_baanblokidField;
			}
			set
			{
				this.sgt_alg_baanblokidField = value;
				base.RaisePropertyChanged("sgt_alg_baanblokid");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public CrmNumber sgt_baanblok_m2
		{
			get
			{
				return this.sgt_baanblok_m2Field;
			}
			set
			{
				this.sgt_baanblok_m2Field = value;
				base.RaisePropertyChanged("sgt_baanblok_m2");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public Lookup sgt_baansoortid
		{
			get
			{
				return this.sgt_baansoortidField;
			}
			set
			{
				this.sgt_baansoortidField = value;
				base.RaisePropertyChanged("sgt_baansoortid");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public Lookup sgt_baantypeid
		{
			get
			{
				return this.sgt_baantypeidField;
			}
			set
			{
				this.sgt_baantypeidField = value;
				base.RaisePropertyChanged("sgt_baantypeid");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
		public string sgt_bouwjaar_bb
		{
			get
			{
				return this.sgt_bouwjaar_bbField;
			}
			set
			{
				this.sgt_bouwjaar_bbField = value;
				base.RaisePropertyChanged("sgt_bouwjaar_bb");
			}
		}

		[XmlElement] //[XmlElement(Order=20)]
		public CrmDateTime sgt_datum_keuring_verlichting
		{
			get
			{
				return this.sgt_datum_keuring_verlichtingField;
			}
			set
			{
				this.sgt_datum_keuring_verlichtingField = value;
				base.RaisePropertyChanged("sgt_datum_keuring_verlichting");
			}
		}

		[XmlElement] //[XmlElement(Order=21)]
		public string sgt_eigendom_opmerking
		{
			get
			{
				return this.sgt_eigendom_opmerkingField;
			}
			set
			{
				this.sgt_eigendom_opmerkingField = value;
				base.RaisePropertyChanged("sgt_eigendom_opmerking");
			}
		}

		[XmlElement] //[XmlElement(Order=22)]
		public Lookup sgt_eigendomid
		{
			get
			{
				return this.sgt_eigendomidField;
			}
			set
			{
				this.sgt_eigendomidField = value;
				base.RaisePropertyChanged("sgt_eigendomid");
			}
		}

		[XmlElement] //[XmlElement(Order=23)]
		public Lookup sgt_gekeurddoorid
		{
			get
			{
				return this.sgt_gekeurddooridField;
			}
			set
			{
				this.sgt_gekeurddooridField = value;
				base.RaisePropertyChanged("sgt_gekeurddoorid");
			}
		}

		[XmlElement] //[XmlElement(Order=24)]
		public Picklist sgt_lichtpunthoogte
		{
			get
			{
				return this.sgt_lichtpunthoogteField;
			}
			set
			{
				this.sgt_lichtpunthoogteField = value;
				base.RaisePropertyChanged("sgt_lichtpunthoogte");
			}
		}

		[XmlElement] //[XmlElement(Order=25)]
		public Picklist sgt_lichtpuntsterkte
		{
			get
			{
				return this.sgt_lichtpuntsterkteField;
			}
			set
			{
				this.sgt_lichtpuntsterkteField = value;
				base.RaisePropertyChanged("sgt_lichtpuntsterkte");
			}
		}

		[XmlElement] //[XmlElement(Order=26)]
		public Picklist sgt_locatie_bb
		{
			get
			{
				return this.sgt_locatie_bbField;
			}
			set
			{
				this.sgt_locatie_bbField = value;
				base.RaisePropertyChanged("sgt_locatie_bb");
			}
		}

		[XmlElement] //[XmlElement(Order=27)]
		public Picklist sgt_maatvoering_speelveld
		{
			get
			{
				return this.sgt_maatvoering_speelveldField;
			}
			set
			{
				this.sgt_maatvoering_speelveldField = value;
				base.RaisePropertyChanged("sgt_maatvoering_speelveld");
			}
		}

		[XmlElement] //[XmlElement(Order=28)]
		public Picklist sgt_maatvoering_uitlopen
		{
			get
			{
				return this.sgt_maatvoering_uitlopenField;
			}
			set
			{
				this.sgt_maatvoering_uitlopenField = value;
				base.RaisePropertyChanged("sgt_maatvoering_uitlopen");
			}
		}

		[XmlElement] //[XmlElement(Order=29)]
		public string sgt_soort_obstakels
		{
			get
			{
				return this.sgt_soort_obstakelsField;
			}
			set
			{
				this.sgt_soort_obstakelsField = value;
				base.RaisePropertyChanged("sgt_soort_obstakels");
			}
		}

		[XmlElement] //[XmlElement(Order=30)]
		public Picklist sgt_soort_verlichting
		{
			get
			{
				return this.sgt_soort_verlichtingField;
			}
			set
			{
				this.sgt_soort_verlichtingField = value;
				base.RaisePropertyChanged("sgt_soort_verlichting");
			}
		}

		[XmlElement] //[XmlElement(Order=31)]
		public Picklist sgt_status_verlichting
		{
			get
			{
				return this.sgt_status_verlichtingField;
			}
			set
			{
				this.sgt_status_verlichtingField = value;
				base.RaisePropertyChanged("sgt_status_verlichting");
			}
		}

		[XmlElement] //[XmlElement(Order=32)]
		public CrmBoolean sgt_vaste_obstakels
		{
			get
			{
				return this.sgt_vaste_obstakelsField;
			}
			set
			{
				this.sgt_vaste_obstakelsField = value;
				base.RaisePropertyChanged("sgt_vaste_obstakels");
			}
		}

		[XmlElement] //[XmlElement(Order=33)]
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

		[XmlElement] //[XmlElement(Order=34)]
		public Sgt_alg_baanblokStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=35)]
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

		[XmlElement] //[XmlElement(Order=36)]
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

		[XmlElement] //[XmlElement(Order=37)]
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

		public sgt_alg_baanblok()
		{
		}
	}
}