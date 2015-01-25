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
	public class sgt_alg_landcode : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private Lookup organizationidField;

		private CrmDateTime overriddencreatedonField;

		private CrmBoolean sgt_11_proefField;

		private string sgt_alg_landcode1Field;

		private Key sgt_alg_landcodeidField;

		private string sgt_formaat_bankrekeningField;

		private string sgt_formaat_postcodeField;

		private CrmBoolean sgt_huisnummer_voor_straatField;

		private string sgt_invoermasker_formaat_faxnummerField;

		private string sgt_invoermasker_formaat_telefoonField;

		private string sgt_ioc_landcodeField;

		private CrmBoolean sgt_lid_euField;

		private CrmBoolean sgt_lid_itfField;

		private string sgt_omschrijvingField;

		private CrmBoolean sgt_postcode_voor_plaatsField;

		private Sgt_alg_landcodeStateInfo statecodeField;

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
		public CrmBoolean sgt_11_proef
		{
			get
			{
				return this.sgt_11_proefField;
			}
			set
			{
				this.sgt_11_proefField = value;
				base.RaisePropertyChanged("sgt_11_proef");
			}
		}

		[XmlElement("sgt_alg_landcode")] //, Order=8)]
		public string sgt_alg_landcode1
		{
			get
			{
				return this.sgt_alg_landcode1Field;
			}
			set
			{
				this.sgt_alg_landcode1Field = value;
				base.RaisePropertyChanged("sgt_alg_landcode1");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public Key sgt_alg_landcodeid
		{
			get
			{
				return this.sgt_alg_landcodeidField;
			}
			set
			{
				this.sgt_alg_landcodeidField = value;
				base.RaisePropertyChanged("sgt_alg_landcodeid");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public string sgt_formaat_bankrekening
		{
			get
			{
				return this.sgt_formaat_bankrekeningField;
			}
			set
			{
				this.sgt_formaat_bankrekeningField = value;
				base.RaisePropertyChanged("sgt_formaat_bankrekening");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public string sgt_formaat_postcode
		{
			get
			{
				return this.sgt_formaat_postcodeField;
			}
			set
			{
				this.sgt_formaat_postcodeField = value;
				base.RaisePropertyChanged("sgt_formaat_postcode");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public CrmBoolean sgt_huisnummer_voor_straat
		{
			get
			{
				return this.sgt_huisnummer_voor_straatField;
			}
			set
			{
				this.sgt_huisnummer_voor_straatField = value;
				base.RaisePropertyChanged("sgt_huisnummer_voor_straat");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public string sgt_invoermasker_formaat_faxnummer
		{
			get
			{
				return this.sgt_invoermasker_formaat_faxnummerField;
			}
			set
			{
				this.sgt_invoermasker_formaat_faxnummerField = value;
				base.RaisePropertyChanged("sgt_invoermasker_formaat_faxnummer");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public string sgt_invoermasker_formaat_telefoon
		{
			get
			{
				return this.sgt_invoermasker_formaat_telefoonField;
			}
			set
			{
				this.sgt_invoermasker_formaat_telefoonField = value;
				base.RaisePropertyChanged("sgt_invoermasker_formaat_telefoon");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public string sgt_ioc_landcode
		{
			get
			{
				return this.sgt_ioc_landcodeField;
			}
			set
			{
				this.sgt_ioc_landcodeField = value;
				base.RaisePropertyChanged("sgt_ioc_landcode");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public CrmBoolean sgt_lid_eu
		{
			get
			{
				return this.sgt_lid_euField;
			}
			set
			{
				this.sgt_lid_euField = value;
				base.RaisePropertyChanged("sgt_lid_eu");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public CrmBoolean sgt_lid_itf
		{
			get
			{
				return this.sgt_lid_itfField;
			}
			set
			{
				this.sgt_lid_itfField = value;
				base.RaisePropertyChanged("sgt_lid_itf");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
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

		[XmlElement] //[XmlElement(Order=19)]
		public CrmBoolean sgt_postcode_voor_plaats
		{
			get
			{
				return this.sgt_postcode_voor_plaatsField;
			}
			set
			{
				this.sgt_postcode_voor_plaatsField = value;
				base.RaisePropertyChanged("sgt_postcode_voor_plaats");
			}
		}

		[XmlElement] //[XmlElement(Order=20)]
		public Sgt_alg_landcodeStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=21)]
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

		[XmlElement] //[XmlElement(Order=22)]
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

		[XmlElement] //[XmlElement(Order=23)]
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

		public sgt_alg_landcode()
		{
		}
	}
}