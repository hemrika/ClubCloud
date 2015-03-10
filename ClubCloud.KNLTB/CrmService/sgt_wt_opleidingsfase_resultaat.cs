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
	public class sgt_wt_opleidingsfase_resultaat : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private Lookup sgt_cursistidField;

		private string sgt_fase_resultaatField;

		private Lookup sgt_opleidingidField;

		private Lookup sgt_opleidingsfaseidField;

		private Lookup sgt_opleidingsgroepidField;

		private Picklist sgt_resultaatField;

		private CrmDateTime sgt_resultaatdatumField;

		private CrmNumber sgt_volgordenummerField;

		private Key sgt_wt_opleidingsfase_resultaatidField;

		private Sgt_wt_opleidingsfase_resultaatStateInfo statecodeField;

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
		public Lookup sgt_cursistid
		{
			get
			{
				return this.sgt_cursistidField;
			}
			set
			{
				this.sgt_cursistidField = value;
				base.RaisePropertyChanged("sgt_cursistid");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public string sgt_fase_resultaat
		{
			get
			{
				return this.sgt_fase_resultaatField;
			}
			set
			{
				this.sgt_fase_resultaatField = value;
				base.RaisePropertyChanged("sgt_fase_resultaat");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public Lookup sgt_opleidingid
		{
			get
			{
				return this.sgt_opleidingidField;
			}
			set
			{
				this.sgt_opleidingidField = value;
				base.RaisePropertyChanged("sgt_opleidingid");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public Lookup sgt_opleidingsfaseid
		{
			get
			{
				return this.sgt_opleidingsfaseidField;
			}
			set
			{
				this.sgt_opleidingsfaseidField = value;
				base.RaisePropertyChanged("sgt_opleidingsfaseid");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public Lookup sgt_opleidingsgroepid
		{
			get
			{
				return this.sgt_opleidingsgroepidField;
			}
			set
			{
				this.sgt_opleidingsgroepidField = value;
				base.RaisePropertyChanged("sgt_opleidingsgroepid");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public Picklist sgt_resultaat
		{
			get
			{
				return this.sgt_resultaatField;
			}
			set
			{
				this.sgt_resultaatField = value;
				base.RaisePropertyChanged("sgt_resultaat");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public CrmDateTime sgt_resultaatdatum
		{
			get
			{
				return this.sgt_resultaatdatumField;
			}
			set
			{
				this.sgt_resultaatdatumField = value;
				base.RaisePropertyChanged("sgt_resultaatdatum");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public CrmNumber sgt_volgordenummer
		{
			get
			{
				return this.sgt_volgordenummerField;
			}
			set
			{
				this.sgt_volgordenummerField = value;
				base.RaisePropertyChanged("sgt_volgordenummer");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public Key sgt_wt_opleidingsfase_resultaatid
		{
			get
			{
				return this.sgt_wt_opleidingsfase_resultaatidField;
			}
			set
			{
				this.sgt_wt_opleidingsfase_resultaatidField = value;
				base.RaisePropertyChanged("sgt_wt_opleidingsfase_resultaatid");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public Sgt_wt_opleidingsfase_resultaatStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=18)]
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

		[XmlElement] //[XmlElement(Order=19)]
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

		[XmlElement] //[XmlElement(Order=20)]
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

		public sgt_wt_opleidingsfase_resultaat()
		{
		}
	}
}