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
	public class sgt_alg_administratie : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private Lookup organizationidField;

		private CrmDateTime overriddencreatedonField;

		private Key sgt_alg_administratieidField;

		private string sgt_alg_nummerField;

		private string sgt_ba_plaatsField;

		private string sgt_ba_postcodeField;

		private string sgt_ba_straatField;

		private Lookup sgt_basisorganisatieidField;

		private string sgt_btwnrField;

		private Lookup sgt_districtidField;

		private string sgt_emailadresField;

		private string sgt_faxField;

		private string sgt_huidig_nummerField;

		private string sgt_kvknummerField;

		private string sgt_masker_volgnummerField;

		private string sgt_naam_administratieField;

		private string sgt_pa_plaatsField;

		private string sgt_pa_postcodeField;

		private string sgt_pa_straatField;

		private CrmBoolean sgt_primaire_administratieField;

		private string sgt_rekening_1Field;

		private string sgt_rekening_2Field;

		private string sgt_telefoonnummerField;

		private Sgt_alg_administratieStateInfo statecodeField;

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

		[XmlElement] //[XmlElement(Order=7)]
		public Key sgt_alg_administratieid
		{
			get
			{
				return this.sgt_alg_administratieidField;
			}
			set
			{
				this.sgt_alg_administratieidField = value;
				base.RaisePropertyChanged("sgt_alg_administratieid");
			}
		}

		[XmlElement] //[XmlElement(Order=8)]
		public string sgt_alg_nummer
		{
			get
			{
				return this.sgt_alg_nummerField;
			}
			set
			{
				this.sgt_alg_nummerField = value;
				base.RaisePropertyChanged("sgt_alg_nummer");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public string sgt_ba_plaats
		{
			get
			{
				return this.sgt_ba_plaatsField;
			}
			set
			{
				this.sgt_ba_plaatsField = value;
				base.RaisePropertyChanged("sgt_ba_plaats");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public string sgt_ba_postcode
		{
			get
			{
				return this.sgt_ba_postcodeField;
			}
			set
			{
				this.sgt_ba_postcodeField = value;
				base.RaisePropertyChanged("sgt_ba_postcode");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public string sgt_ba_straat
		{
			get
			{
				return this.sgt_ba_straatField;
			}
			set
			{
				this.sgt_ba_straatField = value;
				base.RaisePropertyChanged("sgt_ba_straat");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public Lookup sgt_basisorganisatieid
		{
			get
			{
				return this.sgt_basisorganisatieidField;
			}
			set
			{
				this.sgt_basisorganisatieidField = value;
				base.RaisePropertyChanged("sgt_basisorganisatieid");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public string sgt_btwnr
		{
			get
			{
				return this.sgt_btwnrField;
			}
			set
			{
				this.sgt_btwnrField = value;
				base.RaisePropertyChanged("sgt_btwnr");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
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

		[XmlElement] //[XmlElement(Order=15)]
		public string sgt_emailadres
		{
			get
			{
				return this.sgt_emailadresField;
			}
			set
			{
				this.sgt_emailadresField = value;
				base.RaisePropertyChanged("sgt_emailadres");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public string sgt_fax
		{
			get
			{
				return this.sgt_faxField;
			}
			set
			{
				this.sgt_faxField = value;
				base.RaisePropertyChanged("sgt_fax");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public string sgt_huidig_nummer
		{
			get
			{
				return this.sgt_huidig_nummerField;
			}
			set
			{
				this.sgt_huidig_nummerField = value;
				base.RaisePropertyChanged("sgt_huidig_nummer");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public string sgt_kvknummer
		{
			get
			{
				return this.sgt_kvknummerField;
			}
			set
			{
				this.sgt_kvknummerField = value;
				base.RaisePropertyChanged("sgt_kvknummer");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
		public string sgt_masker_volgnummer
		{
			get
			{
				return this.sgt_masker_volgnummerField;
			}
			set
			{
				this.sgt_masker_volgnummerField = value;
				base.RaisePropertyChanged("sgt_masker_volgnummer");
			}
		}

		[XmlElement] //[XmlElement(Order=20)]
		public string sgt_naam_administratie
		{
			get
			{
				return this.sgt_naam_administratieField;
			}
			set
			{
				this.sgt_naam_administratieField = value;
				base.RaisePropertyChanged("sgt_naam_administratie");
			}
		}

		[XmlElement] //[XmlElement(Order=21)]
		public string sgt_pa_plaats
		{
			get
			{
				return this.sgt_pa_plaatsField;
			}
			set
			{
				this.sgt_pa_plaatsField = value;
				base.RaisePropertyChanged("sgt_pa_plaats");
			}
		}

		[XmlElement] //[XmlElement(Order=22)]
		public string sgt_pa_postcode
		{
			get
			{
				return this.sgt_pa_postcodeField;
			}
			set
			{
				this.sgt_pa_postcodeField = value;
				base.RaisePropertyChanged("sgt_pa_postcode");
			}
		}

		[XmlElement] //[XmlElement(Order=23)]
		public string sgt_pa_straat
		{
			get
			{
				return this.sgt_pa_straatField;
			}
			set
			{
				this.sgt_pa_straatField = value;
				base.RaisePropertyChanged("sgt_pa_straat");
			}
		}

		[XmlElement] //[XmlElement(Order=24)]
		public CrmBoolean sgt_primaire_administratie
		{
			get
			{
				return this.sgt_primaire_administratieField;
			}
			set
			{
				this.sgt_primaire_administratieField = value;
				base.RaisePropertyChanged("sgt_primaire_administratie");
			}
		}

		[XmlElement] //[XmlElement(Order=25)]
		public string sgt_rekening_1
		{
			get
			{
				return this.sgt_rekening_1Field;
			}
			set
			{
				this.sgt_rekening_1Field = value;
				base.RaisePropertyChanged("sgt_rekening_1");
			}
		}

		[XmlElement] //[XmlElement(Order=26)]
		public string sgt_rekening_2
		{
			get
			{
				return this.sgt_rekening_2Field;
			}
			set
			{
				this.sgt_rekening_2Field = value;
				base.RaisePropertyChanged("sgt_rekening_2");
			}
		}

		[XmlElement] //[XmlElement(Order=27)]
		public string sgt_telefoonnummer
		{
			get
			{
				return this.sgt_telefoonnummerField;
			}
			set
			{
				this.sgt_telefoonnummerField = value;
				base.RaisePropertyChanged("sgt_telefoonnummer");
			}
		}

		[XmlElement] //[XmlElement(Order=28)]
		public Sgt_alg_administratieStateInfo statecode
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

		public sgt_alg_administratie()
		{
		}
	}
}