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
	public class sgt_alg_servit1_contacthistorie : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private string sgt_alg_onderwerpField;

		private Key sgt_alg_servit1_contacthistorieidField;

		private Lookup sgt_basisorganisatieidField;

		private string sgt_beschrijvingField;

		private string sgt_bondsmedewerkerField;

		private string sgt_contact_vormField;

		private string sgt_contactpersoonField;

		private CrmDateTime sgt_datum_af_te_handelen_voorField;

		private CrmDateTime sgt_datum_afgeslotenField;

		private CrmDateTime sgt_datum_contactField;

		private Lookup sgt_persoonidField;

		private string sgt_soort_contactField;

		private Sgt_alg_servit1_contacthistorieStateInfo statecodeField;

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
		public string sgt_alg_onderwerp
		{
			get
			{
				return this.sgt_alg_onderwerpField;
			}
			set
			{
				this.sgt_alg_onderwerpField = value;
				base.RaisePropertyChanged("sgt_alg_onderwerp");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public Key sgt_alg_servit1_contacthistorieid
		{
			get
			{
				return this.sgt_alg_servit1_contacthistorieidField;
			}
			set
			{
				this.sgt_alg_servit1_contacthistorieidField = value;
				base.RaisePropertyChanged("sgt_alg_servit1_contacthistorieid");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
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

		[XmlElement] //[XmlElement(Order=11)]
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

		[XmlElement] //[XmlElement(Order=12)]
		public string sgt_bondsmedewerker
		{
			get
			{
				return this.sgt_bondsmedewerkerField;
			}
			set
			{
				this.sgt_bondsmedewerkerField = value;
				base.RaisePropertyChanged("sgt_bondsmedewerker");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public string sgt_contact_vorm
		{
			get
			{
				return this.sgt_contact_vormField;
			}
			set
			{
				this.sgt_contact_vormField = value;
				base.RaisePropertyChanged("sgt_contact_vorm");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public string sgt_contactpersoon
		{
			get
			{
				return this.sgt_contactpersoonField;
			}
			set
			{
				this.sgt_contactpersoonField = value;
				base.RaisePropertyChanged("sgt_contactpersoon");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public CrmDateTime sgt_datum_af_te_handelen_voor
		{
			get
			{
				return this.sgt_datum_af_te_handelen_voorField;
			}
			set
			{
				this.sgt_datum_af_te_handelen_voorField = value;
				base.RaisePropertyChanged("sgt_datum_af_te_handelen_voor");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public CrmDateTime sgt_datum_afgesloten
		{
			get
			{
				return this.sgt_datum_afgeslotenField;
			}
			set
			{
				this.sgt_datum_afgeslotenField = value;
				base.RaisePropertyChanged("sgt_datum_afgesloten");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public CrmDateTime sgt_datum_contact
		{
			get
			{
				return this.sgt_datum_contactField;
			}
			set
			{
				this.sgt_datum_contactField = value;
				base.RaisePropertyChanged("sgt_datum_contact");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public Lookup sgt_persoonid
		{
			get
			{
				return this.sgt_persoonidField;
			}
			set
			{
				this.sgt_persoonidField = value;
				base.RaisePropertyChanged("sgt_persoonid");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
		public string sgt_soort_contact
		{
			get
			{
				return this.sgt_soort_contactField;
			}
			set
			{
				this.sgt_soort_contactField = value;
				base.RaisePropertyChanged("sgt_soort_contact");
			}
		}

		[XmlElement] //[XmlElement(Order=20)]
		public Sgt_alg_servit1_contacthistorieStateInfo statecode
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

		public sgt_alg_servit1_contacthistorie()
		{
		}
	}
}