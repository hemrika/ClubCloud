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
	public class SetParentSystemUserRequest : Request
	{
		private Guid userIdField;

		private Guid parentIdField;

		private bool keepChildUsersField;

		[XmlElement] //[XmlElement(Order=2)]
		public bool KeepChildUsers
		{
			get
			{
				return this.keepChildUsersField;
			}
			set
			{
				this.keepChildUsersField = value;
				base.RaisePropertyChanged("KeepChildUsers");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public Guid ParentId
		{
			get
			{
				return this.parentIdField;
			}
			set
			{
				this.parentIdField = value;
				base.RaisePropertyChanged("ParentId");
			}
		}

		[XmlElement] //[XmlElement(Order=0)]
		public Guid UserId
		{
			get
			{
				return this.userIdField;
			}
			set
			{
				this.userIdField = value;
				base.RaisePropertyChanged("UserId");
			}
		}

		public SetParentSystemUserRequest()
		{
		}
	}
}