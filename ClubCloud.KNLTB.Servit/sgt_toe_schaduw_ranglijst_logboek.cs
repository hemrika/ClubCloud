using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_toe_schaduw_ranglijst_logboek : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup organizationidField;
		private CrmDateTime overriddencreatedonField;
		private CrmDateTime sgt_datum_genererenField;
		private CrmDateTime sgt_datum_laatste_schaduwranglijstField;
		private CrmBoolean sgt_genererenField;
		private string sgt_nameField;
		private CrmBoolean sgt_opnieuwField;
		private Lookup sgt_ranglijst_logboekidField;
		private Lookup sgt_schaduwranglijstidField;
		private Picklist sgt_statusField;
		private Key sgt_toe_schaduw_ranglijst_logboekidField;
		private Sgt_toe_schaduw_ranglijst_logboekStateInfo statecodeField;
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
		[XmlElement(Order = 8)]
		public CrmDateTime sgt_datum_laatste_schaduwranglijst
		{
			get
			{
				return this.sgt_datum_laatste_schaduwranglijstField;
			}
			set
			{
				this.sgt_datum_laatste_schaduwranglijstField = value;
				base.RaisePropertyChanged("sgt_datum_laatste_schaduwranglijst");
			}
		}
		[XmlElement(Order = 9)]
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
		[XmlElement(Order = 10)]
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
		[XmlElement(Order = 11)]
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
		[XmlElement(Order = 12)]
		public Lookup sgt_ranglijst_logboekid
		{
			get
			{
				return this.sgt_ranglijst_logboekidField;
			}
			set
			{
				this.sgt_ranglijst_logboekidField = value;
				base.RaisePropertyChanged("sgt_ranglijst_logboekid");
			}
		}
		[XmlElement(Order = 13)]
		public Lookup sgt_schaduwranglijstid
		{
			get
			{
				return this.sgt_schaduwranglijstidField;
			}
			set
			{
				this.sgt_schaduwranglijstidField = value;
				base.RaisePropertyChanged("sgt_schaduwranglijstid");
			}
		}
		[XmlElement(Order = 14)]
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
		[XmlElement(Order = 15)]
		public Key sgt_toe_schaduw_ranglijst_logboekid
		{
			get
			{
				return this.sgt_toe_schaduw_ranglijst_logboekidField;
			}
			set
			{
				this.sgt_toe_schaduw_ranglijst_logboekidField = value;
				base.RaisePropertyChanged("sgt_toe_schaduw_ranglijst_logboekid");
			}
		}
		[XmlElement(Order = 16)]
		public Sgt_toe_schaduw_ranglijst_logboekStateInfo statecode
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
		[XmlElement(Order = 17)]
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
		[XmlElement(Order = 18)]
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
		[XmlElement(Order = 19)]
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
