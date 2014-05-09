using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2006/Scheduling")]
	[Serializable]
	public class RequiredResource : INotifyPropertyChanged
	{
		private Guid resourceIdField;
		private Guid resourceSpecIdField;
		public event PropertyChangedEventHandler PropertyChanged;
		[XmlElement(Order = 0)]
		public Guid ResourceId
		{
			get
			{
				return this.resourceIdField;
			}
			set
			{
				this.resourceIdField = value;
				this.RaisePropertyChanged("ResourceId");
			}
		}
		[XmlElement(Order = 1)]
		public Guid ResourceSpecId
		{
			get
			{
				return this.resourceSpecIdField;
			}
			set
			{
				this.resourceSpecIdField = value;
				this.RaisePropertyChanged("ResourceSpecId");
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
