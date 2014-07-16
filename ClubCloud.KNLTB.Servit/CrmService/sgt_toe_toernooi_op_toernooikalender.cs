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
	public class sgt_toe_toernooi_op_toernooikalender : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private CrmDateTime sgt_begindatumField;

		private string sgt_definitief_week_tmField;

		private string sgt_definitief_week_vanafField;

		private CrmDateTime sgt_einddatumField;

		private string sgt_toe_naamField;

		private Key sgt_toe_toernooi_op_toernooikalenderidField;

		private Lookup sgt_toernooiafhandelingidField;

		private Lookup sgt_toernooikalenderidField;

		private string sgt_toernooinummerField;

		private Lookup sgt_toernooisoortidField;

		private Sgt_toe_toernooi_op_toernooikalenderStateInfo statecodeField;

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
		public CrmDateTime sgt_begindatum
		{
			get
			{
				return this.sgt_begindatumField;
			}
			set
			{
				this.sgt_begindatumField = value;
				base.RaisePropertyChanged("sgt_begindatum");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public string sgt_definitief_week_tm
		{
			get
			{
				return this.sgt_definitief_week_tmField;
			}
			set
			{
				this.sgt_definitief_week_tmField = value;
				base.RaisePropertyChanged("sgt_definitief_week_tm");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public string sgt_definitief_week_vanaf
		{
			get
			{
				return this.sgt_definitief_week_vanafField;
			}
			set
			{
				this.sgt_definitief_week_vanafField = value;
				base.RaisePropertyChanged("sgt_definitief_week_vanaf");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public CrmDateTime sgt_einddatum
		{
			get
			{
				return this.sgt_einddatumField;
			}
			set
			{
				this.sgt_einddatumField = value;
				base.RaisePropertyChanged("sgt_einddatum");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public string sgt_toe_naam
		{
			get
			{
				return this.sgt_toe_naamField;
			}
			set
			{
				this.sgt_toe_naamField = value;
				base.RaisePropertyChanged("sgt_toe_naam");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public Key sgt_toe_toernooi_op_toernooikalenderid
		{
			get
			{
				return this.sgt_toe_toernooi_op_toernooikalenderidField;
			}
			set
			{
				this.sgt_toe_toernooi_op_toernooikalenderidField = value;
				base.RaisePropertyChanged("sgt_toe_toernooi_op_toernooikalenderid");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public Lookup sgt_toernooiafhandelingid
		{
			get
			{
				return this.sgt_toernooiafhandelingidField;
			}
			set
			{
				this.sgt_toernooiafhandelingidField = value;
				base.RaisePropertyChanged("sgt_toernooiafhandelingid");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public Lookup sgt_toernooikalenderid
		{
			get
			{
				return this.sgt_toernooikalenderidField;
			}
			set
			{
				this.sgt_toernooikalenderidField = value;
				base.RaisePropertyChanged("sgt_toernooikalenderid");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public string sgt_toernooinummer
		{
			get
			{
				return this.sgt_toernooinummerField;
			}
			set
			{
				this.sgt_toernooinummerField = value;
				base.RaisePropertyChanged("sgt_toernooinummer");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
		public Lookup sgt_toernooisoortid
		{
			get
			{
				return this.sgt_toernooisoortidField;
			}
			set
			{
				this.sgt_toernooisoortidField = value;
				base.RaisePropertyChanged("sgt_toernooisoortid");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public Sgt_toe_toernooi_op_toernooikalenderStateInfo statecode
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

		public sgt_toe_toernooi_op_toernooikalender()
		{
		}
	}
}