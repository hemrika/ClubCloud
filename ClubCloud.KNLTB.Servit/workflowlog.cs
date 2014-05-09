using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class workflowlog : BusinessEntity
	{
		private string activitynameField;
		private Lookup asyncoperationidField;
		private CrmDateTime completedonField;
		private Lookup createdbyField;
		private CrmDateTime createdonField;
		private string descriptionField;
		private CrmNumber errorcodeField;
		private string messageField;
		private Lookup modifiedbyField;
		private CrmDateTime modifiedonField;
		private UniqueIdentifier owningbusinessunitField;
		private UniqueIdentifier owninguserField;
		private Lookup regardingobjectidField;
		private string stagenameField;
		private Picklist statusField;
		private string stepnameField;
		private Key workflowlogidField;
		[XmlElement(Order = 0)]
		public string activityname
		{
			get
			{
				return this.activitynameField;
			}
			set
			{
				this.activitynameField = value;
				base.RaisePropertyChanged("activityname");
			}
		}
		[XmlElement(Order = 1)]
		public Lookup asyncoperationid
		{
			get
			{
				return this.asyncoperationidField;
			}
			set
			{
				this.asyncoperationidField = value;
				base.RaisePropertyChanged("asyncoperationid");
			}
		}
		[XmlElement(Order = 2)]
		public CrmDateTime completedon
		{
			get
			{
				return this.completedonField;
			}
			set
			{
				this.completedonField = value;
				base.RaisePropertyChanged("completedon");
			}
		}
		[XmlElement(Order = 3)]
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
		[XmlElement(Order = 4)]
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
		[XmlElement(Order = 5)]
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
		[XmlElement(Order = 6)]
		public CrmNumber errorcode
		{
			get
			{
				return this.errorcodeField;
			}
			set
			{
				this.errorcodeField = value;
				base.RaisePropertyChanged("errorcode");
			}
		}
		[XmlElement(Order = 7)]
		public string message
		{
			get
			{
				return this.messageField;
			}
			set
			{
				this.messageField = value;
				base.RaisePropertyChanged("message");
			}
		}
		[XmlElement(Order = 8)]
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
		[XmlElement(Order = 9)]
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
		[XmlElement(Order = 10)]
		public UniqueIdentifier owningbusinessunit
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
		[XmlElement(Order = 11)]
		public UniqueIdentifier owninguser
		{
			get
			{
				return this.owninguserField;
			}
			set
			{
				this.owninguserField = value;
				base.RaisePropertyChanged("owninguser");
			}
		}
		[XmlElement(Order = 12)]
		public Lookup regardingobjectid
		{
			get
			{
				return this.regardingobjectidField;
			}
			set
			{
				this.regardingobjectidField = value;
				base.RaisePropertyChanged("regardingobjectid");
			}
		}
		[XmlElement(Order = 13)]
		public string stagename
		{
			get
			{
				return this.stagenameField;
			}
			set
			{
				this.stagenameField = value;
				base.RaisePropertyChanged("stagename");
			}
		}
		[XmlElement(Order = 14)]
		public Picklist status
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
		[XmlElement(Order = 15)]
		public string stepname
		{
			get
			{
				return this.stepnameField;
			}
			set
			{
				this.stepnameField = value;
				base.RaisePropertyChanged("stepname");
			}
		}
		[XmlElement(Order = 16)]
		public Key workflowlogid
		{
			get
			{
				return this.workflowlogidField;
			}
			set
			{
				this.workflowlogidField = value;
				base.RaisePropertyChanged("workflowlogid");
			}
		}
	}
}
