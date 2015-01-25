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
		public CrmDateTime enteredon
		{
			get
			{
				return this.enteredonField;
			}
			set
			{
				this.enteredonField = value;
				base.RaisePropertyChanged("enteredon");
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
		public Lookup objectid
		{
			get
			{
				return this.objectidField;
			}
			set
			{
				this.objectidField = value;
				base.RaisePropertyChanged("objectid");
			}
		}

		[XmlElement] //[XmlElement(Order=6)]
		public EntityNameReference objecttypecode
		{
			get
			{
				return this.objecttypecodeField;
			}
			set
			{
				this.objecttypecodeField = value;
				base.RaisePropertyChanged("objecttypecode");
			}
		}

		[XmlElement] //[XmlElement(Order=7)]
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

		[XmlElement] //[XmlElement(Order=8)]
		public CrmNumber priority
		{
			get
			{
				return this.priorityField;
			}
			set
			{
				this.priorityField = value;
				base.RaisePropertyChanged("priority");
			}
		}

		[XmlElement] //[XmlElement(Order=9)]
		public Lookup queueid
		{
			get
			{
				return this.queueidField;
			}
			set
			{
				this.queueidField = value;
				base.RaisePropertyChanged("queueid");
			}
		}

		[XmlElement] //[XmlElement(Order=10)]
		public Key queueitemid
		{
			get
			{
				return this.queueitemidField;
			}
			set
			{
				this.queueitemidField = value;
				base.RaisePropertyChanged("queueitemid");
			}
		}

		[XmlElement] //[XmlElement(Order=11)]
		public string sender
		{
			get
			{
				return this.senderField;
			}
			set
			{
				this.senderField = value;
				base.RaisePropertyChanged("sender");
			}
		}

		[XmlElement] //[XmlElement(Order=12)]
		public CrmNumber state
		{
			get
			{
				return this.stateField;
			}
			set
			{
				this.stateField = value;
				base.RaisePropertyChanged("state");
			}
		}

		[XmlElement] //[XmlElement(Order=13)]
		public CrmNumber status
		{
			get
			{
				return this.statusField;
			}
			set
			{
				this.statusField = value;
				base.RaisePropertyChanged("status");
			}
		}

		[XmlElement] //[XmlElement(Order=14)]
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

		[XmlElement] //[XmlElement(Order=15)]
		public string title
		{
			get
			{
				return this.titleField;
			}
			set
			{
				this.titleField = value;
				base.RaisePropertyChanged("title");
			}
		}

		[XmlElement] //[XmlElement(Order=16)]
		public string torecipients
		{
			get
			{
				return this.torecipientsField;
			}
			set
			{
				this.torecipientsField = value;
				base.RaisePropertyChanged("torecipients");
			}
		}

		[XmlElement] //[XmlElement(Order=17)]
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

		public queueitem()
		{
		}
	}
}