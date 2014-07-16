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
	public class sgt_wt_opleidingsfase : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private string sgt_externe_fasecodeField;

		private string sgt_interne_fasecodeField;

		private CrmBoolean sgt_negeren_na_resultaatField;

		private CrmBoolean sgt_niet_nodig_volgendefaseField;

		private Lookup sgt_opleidingidField;

		private CrmNumber sgt_volgordenummerField;

		private string sgt_wt_opleidingsfase1Field;

		private Key sgt_wt_opleidingsfaseidField;

		private Sgt_wt_opleidingsfaseStateInfo statecodeField;

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
		public string sgt_externe_fasecode
		{
			get
			{
				return this.sgt_externe_fasecodeField;
			}
			set
			{
				this.sgt_externe_fasecodeField = value;
				base.RaisePropertyChanged("sgt_externe_fasecode");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public string sgt_interne_fasecode
		{
			get
			{
				return this.sgt_interne_fasecodeField;
			}
			set
			{
				this.sgt_interne_fasecodeField = value;
				base.RaisePropertyChanged("sgt_interne_fasecode");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public CrmBoolean sgt_negeren_na_resultaat
		{
			get
			{
				return this.sgt_negeren_na_resultaatField;
			}
			set
			{
				this.sgt_negeren_na_resultaatField = value;
				base.RaisePropertyChanged("sgt_negeren_na_resultaat");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public CrmBoolean sgt_niet_nodig_volgendefase
		{
			get
			{
				return this.sgt_niet_nodig_volgendefaseField;
			}
			set
			{
				this.sgt_niet_nodig_volgendefaseField = value;
				base.RaisePropertyChanged("sgt_niet_nodig_volgendefase");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
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

		[XmlElement] //[XmlElement(Order=13)]
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

		[XmlElement("sgt_wt_opleidingsfase")] //, Order=14)]
		public string sgt_wt_opleidingsfase1
		{
			get
			{
				return this.sgt_wt_opleidingsfase1Field;
			}
			set
			{
				this.sgt_wt_opleidingsfase1Field = value;
				base.RaisePropertyChanged("sgt_wt_opleidingsfase1");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public Key sgt_wt_opleidingsfaseid
		{
			get
			{
				return this.sgt_wt_opleidingsfaseidField;
			}
			set
			{
				this.sgt_wt_opleidingsfaseidField = value;
				base.RaisePropertyChanged("sgt_wt_opleidingsfaseid");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public Sgt_wt_opleidingsfaseStateInfo statecode
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

		public sgt_wt_opleidingsfase()
		{
		}
	}
}