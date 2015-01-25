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
	public class sgt_dss_grenswaarden_speelsterkte : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private Lookup organizationidField;

		private CrmDateTime overriddencreatedonField;

		private Key sgt_dss_grenswaarden_speelsterkteidField;

		private string sgt_dss_naamField;

		private CrmDecimal sgt_rating_tm_dubbel_damesField;

		private CrmDecimal sgt_rating_tm_dubbel_herenField;

		private CrmDecimal sgt_rating_tm_enkel_damesField;

		private CrmDecimal sgt_rating_tm_enkel_herenField;

		private CrmDecimal sgt_rating_vanaf_dubbel_damesField;

		private CrmDecimal sgt_rating_vanaf_dubbel_herenField;

		private CrmDecimal sgt_rating_vanaf_enkel_damesField;

		private CrmDecimal sgt_rating_vanaf_enkel_herenField;

		private CrmNumber sgt_speelsterkteField;

		private Sgt_dss_grenswaarden_speelsterkteStateInfo statecodeField;

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
		public Key sgt_dss_grenswaarden_speelsterkteid
		{
			get
			{
				return this.sgt_dss_grenswaarden_speelsterkteidField;
			}
			set
			{
				this.sgt_dss_grenswaarden_speelsterkteidField = value;
				base.RaisePropertyChanged("sgt_dss_grenswaarden_speelsterkteid");
			}
		}

		[XmlElement] //[XmlElement(Order=8)]
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

		[XmlElement] //[XmlElement(Order=9)]
		public CrmDecimal sgt_rating_tm_dubbel_dames
		{
			get
			{
				return this.sgt_rating_tm_dubbel_damesField;
			}
			set
			{
				this.sgt_rating_tm_dubbel_damesField = value;
				base.RaisePropertyChanged("sgt_rating_tm_dubbel_dames");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public CrmDecimal sgt_rating_tm_dubbel_heren
		{
			get
			{
				return this.sgt_rating_tm_dubbel_herenField;
			}
			set
			{
				this.sgt_rating_tm_dubbel_herenField = value;
				base.RaisePropertyChanged("sgt_rating_tm_dubbel_heren");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public CrmDecimal sgt_rating_tm_enkel_dames
		{
			get
			{
				return this.sgt_rating_tm_enkel_damesField;
			}
			set
			{
				this.sgt_rating_tm_enkel_damesField = value;
				base.RaisePropertyChanged("sgt_rating_tm_enkel_dames");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public CrmDecimal sgt_rating_tm_enkel_heren
		{
			get
			{
				return this.sgt_rating_tm_enkel_herenField;
			}
			set
			{
				this.sgt_rating_tm_enkel_herenField = value;
				base.RaisePropertyChanged("sgt_rating_tm_enkel_heren");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public CrmDecimal sgt_rating_vanaf_dubbel_dames
		{
			get
			{
				return this.sgt_rating_vanaf_dubbel_damesField;
			}
			set
			{
				this.sgt_rating_vanaf_dubbel_damesField = value;
				base.RaisePropertyChanged("sgt_rating_vanaf_dubbel_dames");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public CrmDecimal sgt_rating_vanaf_dubbel_heren
		{
			get
			{
				return this.sgt_rating_vanaf_dubbel_herenField;
			}
			set
			{
				this.sgt_rating_vanaf_dubbel_herenField = value;
				base.RaisePropertyChanged("sgt_rating_vanaf_dubbel_heren");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public CrmDecimal sgt_rating_vanaf_enkel_dames
		{
			get
			{
				return this.sgt_rating_vanaf_enkel_damesField;
			}
			set
			{
				this.sgt_rating_vanaf_enkel_damesField = value;
				base.RaisePropertyChanged("sgt_rating_vanaf_enkel_dames");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public CrmDecimal sgt_rating_vanaf_enkel_heren
		{
			get
			{
				return this.sgt_rating_vanaf_enkel_herenField;
			}
			set
			{
				this.sgt_rating_vanaf_enkel_herenField = value;
				base.RaisePropertyChanged("sgt_rating_vanaf_enkel_heren");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public CrmNumber sgt_speelsterkte
		{
			get
			{
				return this.sgt_speelsterkteField;
			}
			set
			{
				this.sgt_speelsterkteField = value;
				base.RaisePropertyChanged("sgt_speelsterkte");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public Sgt_dss_grenswaarden_speelsterkteStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=19)]
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

		[XmlElement] //[XmlElement(Order=20)]
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

		[XmlElement] //[XmlElement(Order=21)]
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

		public sgt_dss_grenswaarden_speelsterkte()
		{
		}
	}
}