using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class queueitem : BusinessEntity
	{
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private CrmDateTime enteredonField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private Lookup objectidField;
		private EntityNameReference objecttypecodeField;
		private Lookup organizationidField;
		private CrmNumber priorityField;
		private Lookup queueidField;
		private Key queueitemidField;
		private string senderField;
		private CrmNumber stateField;
		private CrmNumber statusField;
		private CrmNumber timezoneruleversionnumberField;
		private string titleField;
		private string torecipientsField;
		private CrmNumber utcconversiontimezonecodeField;
		public Lookup createdby
		{
			get
			{
				return this.createdbyField;
			}
			set
			{
				this.createdbyField = value;
			}
		}
		public CrmDateTime createdon
		{
			get
			{
				return this.createdonField;
			}
			set
			{
				this.createdonField = value;
			}
		}
		public CrmDateTime enteredon
		{
			get
			{
				return this.enteredonField;
			}
			set
			{
				this.enteredonField = value;
			}
		}
		public Lookup modifiedby
		{
			get
			{
				return this.modifiedbyField;
			}
			set
			{
				this.modifiedbyField = value;
			}
		}
		public CrmDateTime modifiedon
		{
			get
			{
				return this.modifiedonField;
			}
			set
			{
				this.modifiedonField = value;
			}
		}
		public Lookup objectid
		{
			get
			{
				return this.objectidField;
			}
			set
			{
				this.objectidField = value;
			}
		}
		public EntityNameReference objecttypecode
		{
			get
			{
				return this.objecttypecodeField;
			}
			set
			{
				this.objecttypecodeField = value;
			}
		}
		public Lookup organizationid
		{
			get
			{
				return this.organizationidField;
			}
			set
			{
				this.organizationidField = value;
			}
		}
		public CrmNumber priority
		{
			get
			{
				return this.priorityField;
			}
			set
			{
				this.priorityField = value;
			}
		}
		public Lookup queueid
		{
			get
			{
				return this.queueidField;
			}
			set
			{
				this.queueidField = value;
			}
		}
		public Key queueitemid
		{
			get
			{
				return this.queueitemidField;
			}
			set
			{
				this.queueitemidField = value;
			}
		}
		public string sender
		{
			get
			{
				return this.senderField;
			}
			set
			{
				this.senderField = value;
			}
		}
		public CrmNumber state
		{
			get
			{
				return this.stateField;
			}
			set
			{
				this.stateField = value;
			}
		}
		public CrmNumber status
		{
			get
			{
				return this.statusField;
			}
			set
			{
				this.statusField = value;
			}
		}
		public CrmNumber timezoneruleversionnumber
		{
			get
			{
				return this.timezoneruleversionnumberField;
			}
			set
			{
				this.timezoneruleversionnumberField = value;
			}
		}
		public string title
		{
			get
			{
				return this.titleField;
			}
			set
			{
				this.titleField = value;
			}
		}
		public string torecipients
		{
			get
			{
				return this.torecipientsField;
			}
			set
			{
				this.torecipientsField = value;
			}
		}
		public CrmNumber utcconversiontimezonecode
		{
			get
			{
				return this.utcconversiontimezonecodeField;
			}
			set
			{
				this.utcconversiontimezonecodeField = value;
			}
		}
	}
}
