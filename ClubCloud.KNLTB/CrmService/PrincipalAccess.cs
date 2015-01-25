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
	public class PrincipalAccess : INotifyPropertyChanged
	{
		private SecurityPrincipal principalField;

		private AccessRights accessMaskField;

		[XmlElement] //[XmlElement(Order=1)]
		public AccessRights AccessMask
		{
			get
			{
				return this.accessMaskField;
			}
			set
			{
				this.accessMaskField = value;
				this.RaisePropertyChanged("AccessMask");
			}
		}

		[XmlElement] //[XmlElement(Order=0)]
		public SecurityPrincipal Principal
		{
			get
			{
				return this.principalField;
			}
			set
			{
				this.principalField = value;
				this.RaisePropertyChanged("Principal");
			}
		}

		public PrincipalAccess()
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