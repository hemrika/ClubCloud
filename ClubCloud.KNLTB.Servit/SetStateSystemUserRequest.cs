using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSystemUserRequest : Request
	{
		private Guid entityIdField;
		private SystemUserState systemUserStateField;
		private int systemUserStatusField;
		[XmlElement(Order = 0)]
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
		[XmlElement(Order = 1)]
		public SystemUserState SystemUserState
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
		[XmlElement(Order = 2)]
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
	}
}
