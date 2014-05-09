using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_autorisatie_entiteit_gekoppeld : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private CrmDateTime overriddencreatedonField;
		private Owner owneridField;
		private Lookup owningbusinessunitField;
		private string sgt_autorisatie_attibuteField;
		private Key sgt_autorisatie_entiteit_gekoppeldidField;
		private string sgt_autorisatie_entity_gekoppeldField;
		private Lookup sgt_autorisatie_entityidField;
		private CrmNumber sgt_grantrightsField;
		private string sgt_nameField;
		private Sgt_autorisatie_entiteit_gekoppeldStateInfo statecodeField;
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
		public string sgt_autorisatie_attibute
		{
			get
			{
				return this.sgt_autorisatie_attibuteField;
			}
			set
			{
				this.sgt_autorisatie_attibuteField = value;
				base.RaisePropertyChanged("sgt_autorisatie_attibute");
			}
		}
		[XmlElement(Order = 9)]
		public Key sgt_autorisatie_entiteit_gekoppeldid
		{
			get
			{
				return this.sgt_autorisatie_entiteit_gekoppeldidField;
			}
			set
			{
				this.sgt_autorisatie_entiteit_gekoppeldidField = value;
				base.RaisePropertyChanged("sgt_autorisatie_entiteit_gekoppeldid");
			}
		}
		[XmlElement(Order = 10)]
		public string sgt_autorisatie_entity_gekoppeld
		{
			get
			{
				return this.sgt_autorisatie_entity_gekoppeldField;
			}
			set
			{
				this.sgt_autorisatie_entity_gekoppeldField = value;
				base.RaisePropertyChanged("sgt_autorisatie_entity_gekoppeld");
			}
		}
		[XmlElement(Order = 11)]
		public Lookup sgt_autorisatie_entityid
		{
			get
			{
				return this.sgt_autorisatie_entityidField;
			}
			set
			{
				this.sgt_autorisatie_entityidField = value;
				base.RaisePropertyChanged("sgt_autorisatie_entityid");
			}
		}
		[XmlElement(Order = 12)]
		public CrmNumber sgt_grantrights
		{
			get
			{
				return this.sgt_grantrightsField;
			}
			set
			{
				this.sgt_grantrightsField = value;
				base.RaisePropertyChanged("sgt_grantrights");
			}
		}
		[XmlElement(Order = 13)]
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
		[XmlElement(Order = 14)]
		public Sgt_autorisatie_entiteit_gekoppeldStateInfo statecode
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
		[XmlElement(Order = 15)]
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
		[XmlElement(Order = 16)]
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
		[XmlElement(Order = 17)]
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
