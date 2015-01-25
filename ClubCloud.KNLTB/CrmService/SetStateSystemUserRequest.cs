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
	public class SetStateSystemUserRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.SystemUserState systemUserStateField;

		private int systemUserStatusField;

		[XmlElement] //[XmlElement(Order=0)]
		public Guid EntityId
		{
			get
			{
				return this.entityIdField;
			}
			set
			{
				this.entityIdField = value;
				base.RaisePropertyChanged("EntityId");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public ClubCloud.KNLTB.ServIt.CrmService.SystemUserState SystemUserState
		{
			get
			{
				return this.systemUserStateField;
			}
			set
			{
				this.systemUserStateField = value;
				base.RaisePropertyChanged("SystemUserState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int SystemUserStatus
		{
			get
			{
				return this.systemUserStatusField;
			}
			set
			{
				this.systemUserStatusField = value;
				base.RaisePropertyChanged("SystemUserStatus");
			}
		}

		public SetStateSystemUserRequest()
		{
		}
	}
}