using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_alg_occ_enabled_entity : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup organizationidField;
		private CrmDateTime overriddencreatedonField;
		private string sgt_alg_nameField;
		private Key sgt_alg_occ_enabled_entityidField;
		private string sgt_entity_nameField;
		private CrmBoolean sgt_fail_on_errorField;
		private string sgt_id_attribute_nameField;
		private string sgt_timestamp_attribute_nameField;
		private Sgt_alg_occ_enabled_entityStateInfo statecodeField;
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
		public string sgt_alg_name
		{
			get
			{
				return this.sgt_alg_nameField;
			}
			set
			{
				this.sgt_alg_nameField = value;
				base.RaisePropertyChanged("sgt_alg_name");
			}
		}
		[XmlElement(Order = 8)]
		public Key sgt_alg_occ_enabled_entityid
		{
			get
			{
				return this.sgt_alg_occ_enabled_entityidField;
			}
			set
			{
				this.sgt_alg_occ_enabled_entityidField = value;
				base.RaisePropertyChanged("sgt_alg_occ_enabled_entityid");
			}
		}
		[XmlElement(Order = 9)]
		public string sgt_entity_name
		{
			get
			{
				return this.sgt_entity_nameField;
			}
			set
			{
				this.sgt_entity_nameField = value;
				base.RaisePropertyChanged("sgt_entity_name");
			}
		}
		[XmlElement(Order = 10)]
		public CrmBoolean sgt_fail_on_error
		{
			get
			{
				return this.sgt_fail_on_errorField;
			}
			set
			{
				this.sgt_fail_on_errorField = value;
				base.RaisePropertyChanged("sgt_fail_on_error");
			}
		}
		[XmlElement(Order = 11)]
		public string sgt_id_attribute_name
		{
			get
			{
				return this.sgt_id_attribute_nameField;
			}
			set
			{
				this.sgt_id_attribute_nameField = value;
				base.RaisePropertyChanged("sgt_id_attribute_name");
			}
		}
		[XmlElement(Order = 12)]
		public string sgt_timestamp_attribute_name
		{
			get
			{
				return this.sgt_timestamp_attribute_nameField;
			}
			set
			{
				this.sgt_timestamp_attribute_nameField = value;
				base.RaisePropertyChanged("sgt_timestamp_attribute_name");
			}
		}
		[XmlElement(Order = 13)]
		public Sgt_alg_occ_enabled_entityStateInfo statecode
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
