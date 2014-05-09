using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2006/CoreTypes")]
	[Serializable]
	public class SecurityPrincipal : INotifyPropertyChanged
	{
		private Guid principalIdField;
		private SecurityPrincipalType typeField;
		public event PropertyChangedEventHandler PropertyChanged;
		[XmlElement(Order = 0)]
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
		[XmlElement(Order = 1)]
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
		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
