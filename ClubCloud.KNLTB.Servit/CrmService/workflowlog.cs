using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
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
		public string activityname
		{
			get
			{
				return this.activitynameField;
			}
			set
			{
				this.activitynameField = value;
			}
		}
		public Lookup asyncoperationid
		{
			get
			{
				return this.asyncoperationidField;
			}
			set
			{
				this.asyncoperationidField = value;
			}
		}
		public CrmDateTime completedon
		{
			get
			{
				return this.completedonField;
			}
			set
			{
				this.completedonField = value;
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
		public CrmNumber errorcode
		{
			get
			{
				return this.errorcodeField;
			}
			set
			{
				this.errorcodeField = value;
			}
		}
		public string message
		{
			get
			{
				return this.messageField;
			}
			set
			{
				this.messageField = value;
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
		public UniqueIdentifier owningbusinessunit
		{
			get
			{
				return this.owningbusinessunitField;
			}
			set
			{
				this.owningbusinessunitField = value;
			}
		}
		public UniqueIdentifier owninguser
		{
			get
			{
				return this.owninguserField;
			}
			set
			{
				this.owninguserField = value;
			}
		}
		public Lookup regardingobjectid
		{
			get
			{
				return this.regardingobjectidField;
			}
			set
			{
				this.regardingobjectidField = value;
			}
		}
		public string stagename
		{
			get
			{
				return this.stagenameField;
			}
			set
			{
				this.stagenameField = value;
			}
		}
		public Picklist status
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
		public string stepname
		{
			get
			{
				return this.stepnameField;
			}
			set
			{
				this.stepnameField = value;
			}
		}
		public Key workflowlogid
		{
			get
			{
				return this.workflowlogidField;
			}
			set
			{
				this.workflowlogidField = value;
			}
		}
	}
}
