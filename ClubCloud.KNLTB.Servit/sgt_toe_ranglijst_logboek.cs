using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_toe_ranglijst_logboek : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private Lookup sgt_bonus_ranglijst_logboekidField;
		private CrmDateTime sgt_datum_genererenField;
		private CrmDateTime sgt_datum_handmatige_ranglijstField;
		private CrmDateTime sgt_datum_laatste_ranglijstField;
		private CrmDateTime sgt_datum_tmField;
		private CrmDateTime sgt_datum_vanafField;
		private CrmBoolean sgt_genererenField;
		private CrmBoolean sgt_handmatigField;
		private CrmBoolean sgt_opnieuwField;
		private CrmBoolean sgt_publicerenField;
		private Lookup sgt_ranglijstidField;
		private Picklist sgt_statusField;
		private string sgt_tm_weekField;
		private string sgt_toe_ranglijst_logboek1Field;
		private Key sgt_toe_ranglijst_logboekidField;
		private string sgt_vanaf_weekField;
		private Sgt_toe_ranglijst_logboekStateInfo statecodeField;
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
		[XmlElement(Order = 6)]
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
		[XmlElement(Order = 7)]
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
		[XmlElement(Order = 8)]
		public Lookup sgt_bonus_ranglijst_logboekid
		{
			get
			{
				return this.sgt_bonus_ranglijst_logboekidField;
			}
			set
			{
				this.sgt_bonus_ranglijst_logboekidField = value;
				base.RaisePropertyChanged("sgt_bonus_ranglijst_logboekid");
			}
		}
		[XmlElement(Order = 9)]
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
		[XmlElement(Order = 10)]
		public CrmDateTime sgt_datum_handmatige_ranglijst
		{
			get
			{
				return this.sgt_datum_handmatige_ranglijstField;
			}
			set
			{
				this.sgt_datum_handmatige_ranglijstField = value;
				base.RaisePropertyChanged("sgt_datum_handmatige_ranglijst");
			}
		}
		[XmlElement(Order = 11)]
		public CrmDateTime sgt_datum_laatste_ranglijst
		{
			get
			{
				return this.sgt_datum_laatste_ranglijstField;
			}
			set
			{
				this.sgt_datum_laatste_ranglijstField = value;
				base.RaisePropertyChanged("sgt_datum_laatste_ranglijst");
			}
		}
		[XmlElement(Order = 12)]
		public CrmDateTime sgt_datum_tm
		{
			get
			{
				return this.sgt_datum_tmField;
			}
			set
			{
				this.sgt_datum_tmField = value;
				base.RaisePropertyChanged("sgt_datum_tm");
			}
		}
		[XmlElement(Order = 13)]
		public CrmDateTime sgt_datum_vanaf
		{
			get
			{
				return this.sgt_datum_vanafField;
			}
			set
			{
				this.sgt_datum_vanafField = value;
				base.RaisePropertyChanged("sgt_datum_vanaf");
			}
		}
		[XmlElement(Order = 14)]
		public CrmBoolean sgt_genereren
		{
			get
			{
				return this.sgt_genererenField;
			}
			set
			{
				this.sgt_genererenField = value;
				base.RaisePropertyChanged("sgt_genereren");
			}
		}
		[XmlElement(Order = 15)]
		public CrmBoolean sgt_handmatig
		{
			get
			{
				return this.sgt_handmatigField;
			}
			set
			{
				this.sgt_handmatigField = value;
				base.RaisePropertyChanged("sgt_handmatig");
			}
		}
		[XmlElement(Order = 16)]
		public CrmBoolean sgt_opnieuw
		{
			get
			{
				return this.sgt_opnieuwField;
			}
			set
			{
				this.sgt_opnieuwField = value;
				base.RaisePropertyChanged("sgt_opnieuw");
			}
		}
		[XmlElement(Order = 17)]
		public CrmBoolean sgt_publiceren
		{
			get
			{
				return this.sgt_publicerenField;
			}
			set
			{
				this.sgt_publicerenField = value;
				base.RaisePropertyChanged("sgt_publiceren");
			}
		}
		[XmlElement(Order = 18)]
		public Lookup sgt_ranglijstid
		{
			get
			{
				return this.sgt_ranglijstidField;
			}
			set
			{
				this.sgt_ranglijstidField = value;
				base.RaisePropertyChanged("sgt_ranglijstid");
			}
		}
		[XmlElement(Order = 19)]
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
		[XmlElement(Order = 20)]
		public string sgt_tm_week
		{
			get
			{
				return this.sgt_tm_weekField;
			}
			set
			{
				this.sgt_tm_weekField = value;
				base.RaisePropertyChanged("sgt_tm_week");
			}
		}
		[XmlElement("sgt_toe_ranglijst_logboek", Order = 21)]
		public string sgt_toe_ranglijst_logboek1
		{
			get
			{
				return this.sgt_toe_ranglijst_logboek1Field;
			}
			set
			{
				this.sgt_toe_ranglijst_logboek1Field = value;
				base.RaisePropertyChanged("sgt_toe_ranglijst_logboek1");
			}
		}
		[XmlElement(Order = 22)]
		public Key sgt_toe_ranglijst_logboekid
		{
			get
			{
				return this.sgt_toe_ranglijst_logboekidField;
			}
			set
			{
				this.sgt_toe_ranglijst_logboekidField = value;
				base.RaisePropertyChanged("sgt_toe_ranglijst_logboekid");
			}
		}
		[XmlElement(Order = 23)]
		public string sgt_vanaf_week
		{
			get
			{
				return this.sgt_vanaf_weekField;
			}
			set
			{
				this.sgt_vanaf_weekField = value;
				base.RaisePropertyChanged("sgt_vanaf_week");
			}
		}
		[XmlElement(Order = 24)]
		public Sgt_toe_ranglijst_logboekStateInfo statecode
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
		[XmlElement(Order = 25)]
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
		[XmlElement(Order = 26)]
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
		[XmlElement(Order = 27)]
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
