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
	public class sgt_toe_circuitranglijst_logboek : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private CrmDateTime overriddencreatedonField;

		private Owner owneridField;

		private Lookup owningbusinessunitField;

		private Lookup sgt_circuitidField;

		private CrmBoolean sgt_circuitranglijst_genererenField;

		private CrmDateTime sgt_datum_circuitranglijstField;

		private CrmDateTime sgt_datum_genererenField;

		private CrmDateTime sgt_datum_laatste_circuitranglijstField;

		private CrmBoolean sgt_handmatig_aanmakenField;

		private CrmBoolean sgt_opnieuw_genererenField;

		private CrmBoolean sgt_publiceren_mijnknltbField;

		private Picklist sgt_statusField;

		private string sgt_toe_circuitranglijst_logboek1Field;

		private Key sgt_toe_circuitranglijst_logboekidField;

		private string sgt_week_tmField;

		private string sgt_week_vanafField;

		private Sgt_toe_circuitranglijst_logboekStateInfo statecodeField;

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
		public Lookup sgt_circuitid
		{
			get
			{
				return this.sgt_circuitidField;
			}
			set
			{
				this.sgt_circuitidField = value;
				base.RaisePropertyChanged("sgt_circuitid");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public CrmBoolean sgt_circuitranglijst_genereren
		{
			get
			{
				return this.sgt_circuitranglijst_genererenField;
			}
			set
			{
				this.sgt_circuitranglijst_genererenField = value;
				base.RaisePropertyChanged("sgt_circuitranglijst_genereren");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public CrmDateTime sgt_datum_circuitranglijst
		{
			get
			{
				return this.sgt_datum_circuitranglijstField;
			}
			set
			{
				this.sgt_datum_circuitranglijstField = value;
				base.RaisePropertyChanged("sgt_datum_circuitranglijst");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public CrmDateTime sgt_datum_genereren
		{
			get
			{
				return this.sgt_datum_genererenField;
			}
			set
			{
				this.sgt_datum_genererenField = value;
				base.RaisePropertyChanged("sgt_datum_genereren");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public CrmDateTime sgt_datum_laatste_circuitranglijst
		{
			get
			{
				return this.sgt_datum_laatste_circuitranglijstField;
			}
			set
			{
				this.sgt_datum_laatste_circuitranglijstField = value;
				base.RaisePropertyChanged("sgt_datum_laatste_circuitranglijst");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public CrmBoolean sgt_handmatig_aanmaken
		{
			get
			{
				return this.sgt_handmatig_aanmakenField;
			}
			set
			{
				this.sgt_handmatig_aanmakenField = value;
				base.RaisePropertyChanged("sgt_handmatig_aanmaken");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
		public CrmBoolean sgt_opnieuw_genereren
		{
			get
			{
				return this.sgt_opnieuw_genererenField;
			}
			set
			{
				this.sgt_opnieuw_genererenField = value;
				base.RaisePropertyChanged("sgt_opnieuw_genereren");
			}
		}

		[XmlElement] //[XmlElement(Order=15)]
		public CrmBoolean sgt_publiceren_mijnknltb
		{
			get
			{
				return this.sgt_publiceren_mijnknltbField;
			}
			set
			{
				this.sgt_publiceren_mijnknltbField = value;
				base.RaisePropertyChanged("sgt_publiceren_mijnknltb");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public Picklist sgt_status
		{
			get
			{
				return this.sgt_statusField;
			}
			set
			{
				this.sgt_statusField = value;
				base.RaisePropertyChanged("sgt_status");
			}
		}

		[XmlElement("sgt_toe_circuitranglijst_logboek")] //, Order=17)]
		public string sgt_toe_circuitranglijst_logboek1
		{
			get
			{
				return this.sgt_toe_circuitranglijst_logboek1Field;
			}
			set
			{
				this.sgt_toe_circuitranglijst_logboek1Field = value;
				base.RaisePropertyChanged("sgt_toe_circuitranglijst_logboek1");
			}
		}

		[XmlElement] //[XmlElement(Order=18)]
		public Key sgt_toe_circuitranglijst_logboekid
		{
			get
			{
				return this.sgt_toe_circuitranglijst_logboekidField;
			}
			set
			{
				this.sgt_toe_circuitranglijst_logboekidField = value;
				base.RaisePropertyChanged("sgt_toe_circuitranglijst_logboekid");
			}
		}

		[XmlElement] //[XmlElement(Order=19)]
		public string sgt_week_tm
		{
			get
			{
				return this.sgt_week_tmField;
			}
			set
			{
				this.sgt_week_tmField = value;
				base.RaisePropertyChanged("sgt_week_tm");
			}
		}

		[XmlElement] //[XmlElement(Order=20)]
		public string sgt_week_vanaf
		{
			get
			{
				return this.sgt_week_vanafField;
			}
			set
			{
				this.sgt_week_vanafField = value;
				base.RaisePropertyChanged("sgt_week_vanaf");
			}
		}

		[XmlElement] //[XmlElement(Order=21)]
		public Sgt_toe_circuitranglijst_logboekStateInfo statecode
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

		[XmlElement] //[XmlElement(Order=22)]
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

		[XmlElement] //[XmlElement(Order=23)]
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

		[XmlElement] //[XmlElement(Order=24)]
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

		public sgt_toe_circuitranglijst_logboek()
		{
		}
	}
}