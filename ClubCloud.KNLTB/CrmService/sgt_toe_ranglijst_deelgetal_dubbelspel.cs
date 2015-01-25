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
	public class sgt_toe_ranglijst_deelgetal_dubbelspel : BusinessEntity
	{
		private Lookup createdbyField;

		private CrmDateTime createdonField;

		private CrmNumber importsequencenumberField;

		private Lookup modifiedbyField;

		private CrmDateTime modifiedonField;

		private Lookup organizationidField;

		private CrmDateTime overriddencreatedonField;

		private CrmDecimal sgt_deelgetalField;

		private string sgt_nameField;

		private Lookup sgt_ranglijstidField;

		private Key sgt_toe_ranglijst_deelgetal_dubbelspelidField;

		private CrmNumber sgt_toernooien_tmField;

		private CrmNumber sgt_toernooien_vanafField;

		private Sgt_toe_ranglijst_deelgetal_dubbelspelStateInfo statecodeField;

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
		public CrmDecimal sgt_deelgetal
		{
			get
			{
				return this.sgt_deelgetalField;
			}
			set
			{
				this.sgt_deelgetalField = value;
				base.RaisePropertyChanged("sgt_deelgetal");
			}
		}

		[XmlElement] //[XmlElement(Order=8)]
		public string sgt_name
		{
			get
			{
				return this.sgt_nameField;
			}
			set
			{
				this.sgt_nameField = value;
				base.RaisePropertyChanged("sgt_name");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
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

		[XmlElement] //[XmlElement(Order=10)]
		public Key sgt_toe_ranglijst_deelgetal_dubbelspelid
		{
			get
			{
				return this.sgt_toe_ranglijst_deelgetal_dubbelspelidField;
			}
			set
			{
				this.sgt_toe_ranglijst_deelgetal_dubbelspelidField = value;
				base.RaisePropertyChanged("sgt_toe_ranglijst_deelgetal_dubbelspelid");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public CrmNumber sgt_toernooien_tm
		{
			get
			{
				return this.sgt_toernooien_tmField;
			}
			set
			{
				this.sgt_toernooien_tmField = value;
				base.RaisePropertyChanged("sgt_toernooien_tm");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public CrmNumber sgt_toernooien_vanaf
		{
			get
			{
				return this.sgt_toernooien_vanafField;
			}
			set
			{
				this.sgt_toernooien_vanafField = value;
				base.RaisePropertyChanged("sgt_toernooien_vanaf");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public Sgt_toe_ranglijst_deelgetal_dubbelspelStateInfo statecode
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

		public sgt_toe_ranglijst_deelgetal_dubbelspel()
		{
		}
	}
}