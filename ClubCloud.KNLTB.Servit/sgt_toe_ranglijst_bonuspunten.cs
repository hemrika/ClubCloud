using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_toe_ranglijst_bonuspunten : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup organizationidField;
		private CrmDateTime overriddencreatedonField;
		private CrmNumber sgt_bonuspuntenField;
		private CrmNumber sgt_plaats_tmField;
		private CrmNumber sgt_plaats_vanafField;
		private Lookup sgt_ranglijstidField;
		private string sgt_toe_ranglijst_bonuspunten1Field;
		private Key sgt_toe_ranglijst_bonuspuntenidField;
		private Sgt_toe_ranglijst_bonuspuntenStateInfo statecodeField;
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
		[XmlElement(Order = 6)]
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
		[XmlElement(Order = 7)]
		public CrmNumber sgt_bonuspunten
		{
			get
			{
				return this.sgt_bonuspuntenField;
			}
			set
			{
				this.sgt_bonuspuntenField = value;
				base.RaisePropertyChanged("sgt_bonuspunten");
			}
		}
		[XmlElement(Order = 8)]
		public CrmNumber sgt_plaats_tm
		{
			get
			{
				return this.sgt_plaats_tmField;
			}
			set
			{
				this.sgt_plaats_tmField = value;
				base.RaisePropertyChanged("sgt_plaats_tm");
			}
		}
		[XmlElement(Order = 9)]
		public CrmNumber sgt_plaats_vanaf
		{
			get
			{
				return this.sgt_plaats_vanafField;
			}
			set
			{
				this.sgt_plaats_vanafField = value;
				base.RaisePropertyChanged("sgt_plaats_vanaf");
			}
		}
		[XmlElement(Order = 10)]
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
		[XmlElement("sgt_toe_ranglijst_bonuspunten", Order = 11)]
		public string sgt_toe_ranglijst_bonuspunten1
		{
			get
			{
				return this.sgt_toe_ranglijst_bonuspunten1Field;
			}
			set
			{
				this.sgt_toe_ranglijst_bonuspunten1Field = value;
				base.RaisePropertyChanged("sgt_toe_ranglijst_bonuspunten1");
			}
		}
		[XmlElement(Order = 12)]
		public Key sgt_toe_ranglijst_bonuspuntenid
		{
			get
			{
				return this.sgt_toe_ranglijst_bonuspuntenidField;
			}
			set
			{
				this.sgt_toe_ranglijst_bonuspuntenidField = value;
				base.RaisePropertyChanged("sgt_toe_ranglijst_bonuspuntenid");
			}
		}
		[XmlElement(Order = 13)]
		public Sgt_toe_ranglijst_bonuspuntenStateInfo statecode
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
		[XmlElement(Order = 14)]
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
		[XmlElement(Order = 15)]
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
		[XmlElement(Order = 16)]
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
