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
	public class sgt_dss_tussentijdse_rating : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private CrmDateTime sgt_datumField;

		private string sgt_dss_naamField;

		private Key sgt_dss_tussentijdse_ratingidField;

		private CrmDateTime sgt_peildatumField;

		private CrmDecimal sgt_rating_dubbelField;

		private CrmDecimal sgt_rating_enkelField;

		private Lookup sgt_speleridField;

		private Lookup sgt_tussentijdse_rating_peildatumidField;

		private Sgt_dss_tussentijdse_ratingStateInfo statecodeField;

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
		public CrmDateTime sgt_datum
		{
			get
			{
				return this.sgt_datumField;
			}
			set
			{
				this.sgt_datumField = value;
				base.RaisePropertyChanged("sgt_datum");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public string sgt_dss_naam
		{
			get
			{
				return this.sgt_dss_naamField;
			}
			set
			{
				this.sgt_dss_naamField = value;
				base.RaisePropertyChanged("sgt_dss_naam");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public Key sgt_dss_tussentijdse_ratingid
		{
			get
			{
				return this.sgt_dss_tussentijdse_ratingidField;
			}
			set
			{
				this.sgt_dss_tussentijdse_ratingidField = value;
				base.RaisePropertyChanged("sgt_dss_tussentijdse_ratingid");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public CrmDateTime sgt_peildatum
		{
			get
			{
				return this.sgt_peildatumField;
			}
			set
			{
				this.sgt_peildatumField = value;
				base.RaisePropertyChanged("sgt_peildatum");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public CrmDecimal sgt_rating_dubbel
		{
			get
			{
				return this.sgt_rating_dubbelField;
			}
			set
			{
				this.sgt_rating_dubbelField = value;
				base.RaisePropertyChanged("sgt_rating_dubbel");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public CrmDecimal sgt_rating_enkel
		{
			get
			{
				return this.sgt_rating_enkelField;
			}
			set
			{
				this.sgt_rating_enkelField = value;
				base.RaisePropertyChanged("sgt_rating_enkel");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public Lookup sgt_spelerid
		{
			get
			{
				return this.sgt_speleridField;
			}
			set
			{
				this.sgt_speleridField = value;
				base.RaisePropertyChanged("sgt_spelerid");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public Lookup sgt_tussentijdse_rating_peildatumid
		{
			get
			{
				return this.sgt_tussentijdse_rating_peildatumidField;
			}
			set
			{
				this.sgt_tussentijdse_rating_peildatumidField = value;
				base.RaisePropertyChanged("sgt_tussentijdse_rating_peildatumid");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public Sgt_dss_tussentijdse_ratingStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=17)]
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

		[XmlElement] //[XmlElement(Order=18)]
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

		[XmlElement] //[XmlElement(Order=19)]
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

		public sgt_dss_tussentijdse_rating()
		{
		}
	}
}