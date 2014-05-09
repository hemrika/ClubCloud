using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class service : BusinessEntity
	{
		private CrmNumber anchoroffsetField;
		private UniqueIdentifier calendaridField;
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private string descriptionField;
		private CrmNumber durationField;
		private string granularityField;
		private CrmNumber importsequencenumberField;
		private Status initialstatuscodeField;
		private CrmBoolean isschedulableField;
		private CrmBoolean isvisibleField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private string nameField;
		private Lookup organizationidField;
		private CrmDateTime overriddencreatedonField;
		private Lookup resourcespecidField;
		private Key serviceidField;
		private CrmBoolean showresourcesField;
		private Lookup strategyidField;
		[XmlElement(Order = 0)]
		public CrmNumber anchoroffset
		{
			get
			{
				return this.anchoroffsetField;
			}
			set
			{
				this.anchoroffsetField = value;
				base.RaisePropertyChanged("anchoroffset");
			}
		}
		[XmlElement(Order = 1)]
		public UniqueIdentifier calendarid
		{
			get
			{
				return this.calendaridField;
			}
			set
			{
				this.calendaridField = value;
				base.RaisePropertyChanged("calendarid");
			}
		}
		[XmlElement(Order = 2)]
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
		[XmlElement(Order = 3)]
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
		[XmlElement(Order = 4)]
		public string description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
				base.RaisePropertyChanged("description");
			}
		}
		[XmlElement(Order = 5)]
		public CrmNumber duration
		{
			get
			{
				return this.durationField;
			}
			set
			{
				this.durationField = value;
				base.RaisePropertyChanged("duration");
			}
		}
		[XmlElement(Order = 6)]
		public string granularity
		{
			get
			{
				return this.granularityField;
			}
			set
			{
				this.granularityField = value;
				base.RaisePropertyChanged("granularity");
			}
		}
		[XmlElement(Order = 7)]
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
		[XmlElement(Order = 8)]
		public Status initialstatuscode
		{
			get
			{
				return this.initialstatuscodeField;
			}
			set
			{
				this.initialstatuscodeField = value;
				base.RaisePropertyChanged("initialstatuscode");
			}
		}
		[XmlElement(Order = 9)]
		public CrmBoolean isschedulable
		{
			get
			{
				return this.isschedulableField;
			}
			set
			{
				this.isschedulableField = value;
				base.RaisePropertyChanged("isschedulable");
			}
		}
		[XmlElement(Order = 10)]
		public CrmBoolean isvisible
		{
			get
			{
				return this.isvisibleField;
			}
			set
			{
				this.isvisibleField = value;
				base.RaisePropertyChanged("isvisible");
			}
		}
		[XmlElement(Order = 11)]
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
		[XmlElement(Order = 12)]
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
		[XmlElement(Order = 13)]
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
				base.RaisePropertyChanged("name");
			}
		}
		[XmlElement(Order = 14)]
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
		[XmlElement(Order = 15)]
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
		[XmlElement(Order = 16)]
		public Lookup resourcespecid
		{
			get
			{
				return this.resourcespecidField;
			}
			set
			{
				this.resourcespecidField = value;
				base.RaisePropertyChanged("resourcespecid");
			}
		}
		[XmlElement(Order = 17)]
		public Key serviceid
		{
			get
			{
				return this.serviceidField;
			}
			set
			{
				this.serviceidField = value;
				base.RaisePropertyChanged("serviceid");
			}
		}
		[XmlElement(Order = 18)]
		public CrmBoolean showresources
		{
			get
			{
				return this.showresourcesField;
			}
			set
			{
				this.showresourcesField = value;
				base.RaisePropertyChanged("showresources");
			}
		}
		[XmlElement(Order = 19)]
		public Lookup strategyid
		{
			get
			{
				return this.strategyidField;
			}
			set
			{
				this.strategyidField = value;
				base.RaisePropertyChanged("strategyid");
			}
		}
	}
}
