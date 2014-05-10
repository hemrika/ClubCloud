using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
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
		public CrmNumber anchoroffset
		{
			get
			{
				return this.anchoroffsetField;
			}
			set
			{
				this.anchoroffsetField = value;
			}
		}
		public UniqueIdentifier calendarid
		{
			get
			{
				return this.calendaridField;
			}
			set
			{
				this.calendaridField = value;
			}
		}
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
		public string description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
			}
		}
		public CrmNumber duration
		{
			get
			{
				return this.durationField;
			}
			set
			{
				this.durationField = value;
			}
		}
		public string granularity
		{
			get
			{
				return this.granularityField;
			}
			set
			{
				this.granularityField = value;
			}
		}
		public CrmNumber importsequencenumber
		{
			get
			{
				return this.importsequencenumberField;
			}
			set
			{
				this.importsequencenumberField = value;
			}
		}
		public Status initialstatuscode
		{
			get
			{
				return this.initialstatuscodeField;
			}
			set
			{
				this.initialstatuscodeField = value;
			}
		}
		public CrmBoolean isschedulable
		{
			get
			{
				return this.isschedulableField;
			}
			set
			{
				this.isschedulableField = value;
			}
		}
		public CrmBoolean isvisible
		{
			get
			{
				return this.isvisibleField;
			}
			set
			{
				this.isvisibleField = value;
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
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
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
		public CrmDateTime overriddencreatedon
		{
			get
			{
				return this.overriddencreatedonField;
			}
			set
			{
				this.overriddencreatedonField = value;
			}
		}
		public Lookup resourcespecid
		{
			get
			{
				return this.resourcespecidField;
			}
			set
			{
				this.resourcespecidField = value;
			}
		}
		public Key serviceid
		{
			get
			{
				return this.serviceidField;
			}
			set
			{
				this.serviceidField = value;
			}
		}
		public CrmBoolean showresources
		{
			get
			{
				return this.showresourcesField;
			}
			set
			{
				this.showresourcesField = value;
			}
		}
		public Lookup strategyid
		{
			get
			{
				return this.strategyidField;
			}
			set
			{
				this.strategyidField = value;
			}
		}
	}
}
