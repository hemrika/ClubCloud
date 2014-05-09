using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2006/CoreTypes")]
	[Serializable]
	public class PrincipalAccess : INotifyPropertyChanged
	{
		private SecurityPrincipal principalField;
		private AccessRights accessMaskField;
		public event PropertyChangedEventHandler PropertyChanged;
		[XmlElement(Order = 0)]
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
		[XmlElement(Order = 1)]
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
