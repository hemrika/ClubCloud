using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class sgt_alg_record_lock : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmNumber importsequencenumberField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup organizationidField;
		private CrmDateTime overriddencreatedonField;
		private string sgt_alg_nameField;
		private Key sgt_alg_record_lockidField;
		private string sgt_entity_idField;
		private string sgt_entity_nameField;
		private Picklist sgt_locktypeField;
		private string sgt_process_idField;
		private string sgt_process_nameField;
		private CrmDateTime sgt_timestampField;
		private Sgt_alg_record_lockStateInfo statecodeField;
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
		public Key sgt_alg_record_lockid
		{
			get
			{
				return this.sgt_alg_record_lockidField;
			}
			set
			{
				this.sgt_alg_record_lockidField = value;
				base.RaisePropertyChanged("sgt_alg_record_lockid");
			}
		}
		[XmlElement(Order = 9)]
		public string sgt_entity_id
		{
			get
			{
				return this.sgt_entity_idField;
			}
			set
			{
				this.sgt_entity_idField = value;
				base.RaisePropertyChanged("sgt_entity_id");
			}
		}
		[XmlElement(Order = 10)]
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
		[XmlElement(Order = 11)]
		public Picklist sgt_locktype
		{
			get
			{
				return this.sgt_locktypeField;
			}
			set
			{
				this.sgt_locktypeField = value;
				base.RaisePropertyChanged("sgt_locktype");
			}
		}
		[XmlElement(Order = 12)]
		public string sgt_process_id
		{
			get
			{
				return this.sgt_process_idField;
			}
			set
			{
				this.sgt_process_idField = value;
				base.RaisePropertyChanged("sgt_process_id");
			}
		}
		[XmlElement(Order = 13)]
		public string sgt_process_name
		{
			get
			{
				return this.sgt_process_nameField;
			}
			set
			{
				this.sgt_process_nameField = value;
				base.RaisePropertyChanged("sgt_process_name");
			}
		}
		[XmlElement(Order = 14)]
		public CrmDateTime sgt_timestamp
		{
			get
			{
				return this.sgt_timestampField;
			}
			set
			{
				this.sgt_timestampField = value;
				base.RaisePropertyChanged("sgt_timestamp");
			}
		}
		[XmlElement(Order = 15)]
		public Sgt_alg_record_lockStateInfo statecode
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
