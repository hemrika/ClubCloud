using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_toe_afwezigheid_bondsgedelegeerde : BusinessEntity
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
		private Lookup sgt_bondsgedelegeerdeidField;
		private CrmDateTime sgt_einddatumField;
		private string sgt_toe_afwezigheid_bondsgedelegeerde1Field;
		private Key sgt_toe_afwezigheid_bondsgedelegeerdeidField;
		private string sgt_weeknummer_tmField;
		private string sgt_weeknummer_vanafField;
		private Sgt_toe_afwezigheid_bondsgedelegeerdeStateInfo statecodeField;
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
		[XmlElement(Order = 9)]
		public Lookup sgt_bondsgedelegeerdeid
		{
			get
			{
				return this.sgt_bondsgedelegeerdeidField;
			}
			set
			{
				this.sgt_bondsgedelegeerdeidField = value;
				base.RaisePropertyChanged("sgt_bondsgedelegeerdeid");
			}
		}
		[XmlElement(Order = 10)]
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
		[XmlElement("sgt_toe_afwezigheid_bondsgedelegeerde", Order = 11)]
		public string sgt_toe_afwezigheid_bondsgedelegeerde1
		{
			get
			{
				return this.sgt_toe_afwezigheid_bondsgedelegeerde1Field;
			}
			set
			{
				this.sgt_toe_afwezigheid_bondsgedelegeerde1Field = value;
				base.RaisePropertyChanged("sgt_toe_afwezigheid_bondsgedelegeerde1");
			}
		}
		[XmlElement(Order = 12)]
		public Key sgt_toe_afwezigheid_bondsgedelegeerdeid
		{
			get
			{
				return this.sgt_toe_afwezigheid_bondsgedelegeerdeidField;
			}
			set
			{
				this.sgt_toe_afwezigheid_bondsgedelegeerdeidField = value;
				base.RaisePropertyChanged("sgt_toe_afwezigheid_bondsgedelegeerdeid");
			}
		}
		[XmlElement(Order = 13)]
		public string sgt_weeknummer_tm
		{
			get
			{
				return this.sgt_weeknummer_tmField;
			}
			set
			{
				this.sgt_weeknummer_tmField = value;
				base.RaisePropertyChanged("sgt_weeknummer_tm");
			}
		}
		[XmlElement(Order = 14)]
		public string sgt_weeknummer_vanaf
		{
			get
			{
				return this.sgt_weeknummer_vanafField;
			}
			set
			{
				this.sgt_weeknummer_vanafField = value;
				base.RaisePropertyChanged("sgt_weeknummer_vanaf");
			}
		}
		[XmlElement(Order = 15)]
		public Sgt_toe_afwezigheid_bondsgedelegeerdeStateInfo statecode
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
		[XmlElement(Order = 16)]
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
		[XmlElement(Order = 17)]
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
		[XmlElement(Order = 18)]
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
