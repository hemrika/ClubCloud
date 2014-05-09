using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_com_speelschema_tegenovergesteld : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup organizationidField;
		private CrmDateTime overriddencreatedonField;
		private string sgt_com_naamField;
		private Key sgt_com_speelschema_tegenovergesteldidField;
		private CrmNumber sgt_ploegField;
		private Lookup sgt_speelschema_standaardidField;
		private CrmNumber sgt_tegenovergesteld_1Field;
		private CrmNumber sgt_tegenovergesteld_2Field;
		private Sgt_com_speelschema_tegenovergesteldStateInfo statecodeField;
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
		public string sgt_com_naam
		{
			get
			{
				return this.sgt_com_naamField;
			}
			set
			{
				this.sgt_com_naamField = value;
				base.RaisePropertyChanged("sgt_com_naam");
			}
		}
		[XmlElement(Order = 8)]
		public Key sgt_com_speelschema_tegenovergesteldid
		{
			get
			{
				return this.sgt_com_speelschema_tegenovergesteldidField;
			}
			set
			{
				this.sgt_com_speelschema_tegenovergesteldidField = value;
				base.RaisePropertyChanged("sgt_com_speelschema_tegenovergesteldid");
			}
		}
		[XmlElement(Order = 9)]
		public CrmNumber sgt_ploeg
		{
			get
			{
				return this.sgt_ploegField;
			}
			set
			{
				this.sgt_ploegField = value;
				base.RaisePropertyChanged("sgt_ploeg");
			}
		}
		[XmlElement(Order = 10)]
		public Lookup sgt_speelschema_standaardid
		{
			get
			{
				return this.sgt_speelschema_standaardidField;
			}
			set
			{
				this.sgt_speelschema_standaardidField = value;
				base.RaisePropertyChanged("sgt_speelschema_standaardid");
			}
		}
		[XmlElement(Order = 11)]
		public CrmNumber sgt_tegenovergesteld_1
		{
			get
			{
				return this.sgt_tegenovergesteld_1Field;
			}
			set
			{
				this.sgt_tegenovergesteld_1Field = value;
				base.RaisePropertyChanged("sgt_tegenovergesteld_1");
			}
		}
		[XmlElement(Order = 12)]
		public CrmNumber sgt_tegenovergesteld_2
		{
			get
			{
				return this.sgt_tegenovergesteld_2Field;
			}
			set
			{
				this.sgt_tegenovergesteld_2Field = value;
				base.RaisePropertyChanged("sgt_tegenovergesteld_2");
			}
		}
		[XmlElement(Order = 13)]
		public Sgt_com_speelschema_tegenovergesteldStateInfo statecode
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
