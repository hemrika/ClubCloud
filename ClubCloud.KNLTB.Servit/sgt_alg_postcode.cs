using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_alg_postcode : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup organizationidField;
		private CrmDateTime overriddencreatedonField;
		private string sgt_alg_postcode1Field;
		private Key sgt_alg_postcodeidField;
		private string sgt_gemeente_nenField;
		private string sgt_huisnummer_tmField;
		private string sgt_huisnummer_vanField;
		private Lookup sgt_landcodeidField;
		private CrmBoolean sgt_onevenField;
		private string sgt_plaats_nenField;
		private string sgt_straat_nenField;
		private Sgt_alg_postcodeStateInfo statecodeField;
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
		[XmlElement("sgt_alg_postcode", Order = 7)]
		public string sgt_alg_postcode1
		{
			get
			{
				return this.sgt_alg_postcode1Field;
			}
			set
			{
				this.sgt_alg_postcode1Field = value;
				base.RaisePropertyChanged("sgt_alg_postcode1");
			}
		}
		[XmlElement(Order = 8)]
		public Key sgt_alg_postcodeid
		{
			get
			{
				return this.sgt_alg_postcodeidField;
			}
			set
			{
				this.sgt_alg_postcodeidField = value;
				base.RaisePropertyChanged("sgt_alg_postcodeid");
			}
		}
		[XmlElement(Order = 9)]
		public string sgt_gemeente_nen
		{
			get
			{
				return this.sgt_gemeente_nenField;
			}
			set
			{
				this.sgt_gemeente_nenField = value;
				base.RaisePropertyChanged("sgt_gemeente_nen");
			}
		}
		[XmlElement(Order = 10)]
		public string sgt_huisnummer_tm
		{
			get
			{
				return this.sgt_huisnummer_tmField;
			}
			set
			{
				this.sgt_huisnummer_tmField = value;
				base.RaisePropertyChanged("sgt_huisnummer_tm");
			}
		}
		[XmlElement(Order = 11)]
		public string sgt_huisnummer_van
		{
			get
			{
				return this.sgt_huisnummer_vanField;
			}
			set
			{
				this.sgt_huisnummer_vanField = value;
				base.RaisePropertyChanged("sgt_huisnummer_van");
			}
		}
		[XmlElement(Order = 12)]
		public Lookup sgt_landcodeid
		{
			get
			{
				return this.sgt_landcodeidField;
			}
			set
			{
				this.sgt_landcodeidField = value;
				base.RaisePropertyChanged("sgt_landcodeid");
			}
		}
		[XmlElement(Order = 13)]
		public CrmBoolean sgt_oneven
		{
			get
			{
				return this.sgt_onevenField;
			}
			set
			{
				this.sgt_onevenField = value;
				base.RaisePropertyChanged("sgt_oneven");
			}
		}
		[XmlElement(Order = 14)]
		public string sgt_plaats_nen
		{
			get
			{
				return this.sgt_plaats_nenField;
			}
			set
			{
				this.sgt_plaats_nenField = value;
				base.RaisePropertyChanged("sgt_plaats_nen");
			}
		}
		[XmlElement(Order = 15)]
		public string sgt_straat_nen
		{
			get
			{
				return this.sgt_straat_nenField;
			}
			set
			{
				this.sgt_straat_nenField = value;
				base.RaisePropertyChanged("sgt_straat_nen");
			}
		}
		[XmlElement(Order = 16)]
		public Sgt_alg_postcodeStateInfo statecode
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
		[XmlElement(Order = 17)]
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
		[XmlElement(Order = 18)]
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
		[XmlElement(Order = 19)]
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
