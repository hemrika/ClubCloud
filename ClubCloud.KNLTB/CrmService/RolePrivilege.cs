using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Xml.Serialization;

namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[GeneratedCode("System.Xml", "4.0.30319.33440")]
	[Serializable]
	[XmlType(Namespace="http://schemas.microsoft.com/crm/2006/CoreTypes")]
	public class RolePrivilege : INotifyPropertyChanged
	{
		private PrivilegeDepth depthField;

		private Guid privilegeIdField;

		[XmlElement] //[XmlElement(Order=0)]
		public PrivilegeDepth Depth
		{
			get
			{
				return this.depthField;
			}
			set
			{
				this.depthField = value;
				this.RaisePropertyChanged("Depth");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public Guid PrivilegeId
		{
			get
			{
				return this.privilegeIdField;
			}
			set
			{
				this.privilegeIdField = value;
				this.RaisePropertyChanged("PrivilegeId");
			}
		}

		public RolePrivilege()
		{
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;
	}
}