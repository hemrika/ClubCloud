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
	public class sgt_alg_reisafstand : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private Lookup organizationidField;

		private CrmDateTime overriddencreatedonField;

		private string sgt_alg_naamField;

		private Key sgt_alg_reisafstandidField;

		private Lookup sgt_landcodeidField;

		private string sgt_naar_postcodeField;

		private CrmNumber sgt_reisafstandField;

		private CrmNumber sgt_reistijdField;

		private string sgt_van_postcodeField;

		private Sgt_alg_reisafstandStateInfo statecodeField;

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
		public string sgt_alg_naam
		{
			get
			{
				return this.sgt_alg_naamField;
			}
			set
			{
				this.sgt_alg_naamField = value;
				base.RaisePropertyChanged("sgt_alg_naam");
			}
		}

		[XmlElement] //[XmlElement(Order=8)]
		public Key sgt_alg_reisafstandid
		{
			get
			{
				return this.sgt_alg_reisafstandidField;
			}
			set
			{
				this.sgt_alg_reisafstandidField = value;
				base.RaisePropertyChanged("sgt_alg_reisafstandid");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
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

		[XmlElement] //[XmlElement(Order=10)]
		public string sgt_naar_postcode
		{
			get
			{
				return this.sgt_naar_postcodeField;
			}
			set
			{
				this.sgt_naar_postcodeField = value;
				base.RaisePropertyChanged("sgt_naar_postcode");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public CrmNumber sgt_reisafstand
		{
			get
			{
				return this.sgt_reisafstandField;
			}
			set
			{
				this.sgt_reisafstandField = value;
				base.RaisePropertyChanged("sgt_reisafstand");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public CrmNumber sgt_reistijd
		{
			get
			{
				return this.sgt_reistijdField;
			}
			set
			{
				this.sgt_reistijdField = value;
				base.RaisePropertyChanged("sgt_reistijd");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public string sgt_van_postcode
		{
			get
			{
				return this.sgt_van_postcodeField;
			}
			set
			{
				this.sgt_van_postcodeField = value;
				base.RaisePropertyChanged("sgt_van_postcode");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public Sgt_alg_reisafstandStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=15)]
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

		[XmlElement] //[XmlElement(Order=16)]
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

		[XmlElement] //[XmlElement(Order=17)]
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

		public sgt_alg_reisafstand()
		{
		}
	}
}