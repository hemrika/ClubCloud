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
	public class sgt_toe_baansoort_toernooi : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private Lookup organizationidField;

		private CrmDateTime overriddencreatedonField;

		private Lookup sgt_baansoortField;

		private Lookup sgt_dagtoernooiidField;

		private string sgt_toe_baansoort_toernooi1Field;

		private Key sgt_toe_baansoort_toernooiidField;

		private Lookup sgt_toernooiidField;

		private Lookup sgt_verwerken_toernooiaanvraagidField;

		private Sgt_toe_baansoort_toernooiStateInfo statecodeField;

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
		public Lookup sgt_baansoort
		{
			get
			{
				return this.sgt_baansoortField;
			}
			set
			{
				this.sgt_baansoortField = value;
				base.RaisePropertyChanged("sgt_baansoort");
			}
		}

		[XmlElement] //[XmlElement(Order=8)]
		public Lookup sgt_dagtoernooiid
		{
			get
			{
				return this.sgt_dagtoernooiidField;
			}
			set
			{
				this.sgt_dagtoernooiidField = value;
				base.RaisePropertyChanged("sgt_dagtoernooiid");
			}
		}

		[XmlElement("sgt_toe_baansoort_toernooi")] //, Order=9)]
		public string sgt_toe_baansoort_toernooi1
		{
			get
			{
				return this.sgt_toe_baansoort_toernooi1Field;
			}
			set
			{
				this.sgt_toe_baansoort_toernooi1Field = value;
				base.RaisePropertyChanged("sgt_toe_baansoort_toernooi1");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public Key sgt_toe_baansoort_toernooiid
		{
			get
			{
				return this.sgt_toe_baansoort_toernooiidField;
			}
			set
			{
				this.sgt_toe_baansoort_toernooiidField = value;
				base.RaisePropertyChanged("sgt_toe_baansoort_toernooiid");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public Lookup sgt_toernooiid
		{
			get
			{
				return this.sgt_toernooiidField;
			}
			set
			{
				this.sgt_toernooiidField = value;
				base.RaisePropertyChanged("sgt_toernooiid");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public Lookup sgt_verwerken_toernooiaanvraagid
		{
			get
			{
				return this.sgt_verwerken_toernooiaanvraagidField;
			}
			set
			{
				this.sgt_verwerken_toernooiaanvraagidField = value;
				base.RaisePropertyChanged("sgt_verwerken_toernooiaanvraagid");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public Sgt_toe_baansoort_toernooiStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=14)]
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

		[XmlElement] //[XmlElement(Order=15)]
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

		[XmlElement] //[XmlElement(Order=16)]
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

		public sgt_toe_baansoort_toernooi()
		{
		}
	}
}