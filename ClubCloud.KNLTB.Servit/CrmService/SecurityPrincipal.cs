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
	public class SecurityPrincipal : INotifyPropertyChanged
	{
		private Guid principalIdField;

		private SecurityPrincipalType typeField;

		[XmlElement] //[XmlElement(Order=0)]
		public Guid PrincipalId
		{
			get
			{
				return this.principalIdField;
			}
			set
			{
				this.principalIdField = value;
				this.RaisePropertyChanged("PrincipalId");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public SecurityPrincipalType Type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
				this.RaisePropertyChanged("Type");
			}
		}

		public SecurityPrincipal()
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