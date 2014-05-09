using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2006/Scheduling")]
	[Serializable]
	public class ErrorInfo : INotifyPropertyChanged
	{
		private ResourceInfo[] resourceListField;
		private string errorCodeField;
		public event PropertyChangedEventHandler PropertyChanged;
		[XmlArray(Order = 0)]
		public ResourceInfo[] ResourceList
		{
			get
			{
				return this.resourceListField;
			}
			set
			{
				this.resourceListField = value;
				this.RaisePropertyChanged("ResourceList");
			}
		}
		[XmlElement(Order = 1)]
		public string ErrorCode
		{
			get
			{
				return this.errorCodeField;
			}
			set
			{
				this.errorCodeField = value;
				this.RaisePropertyChanged("ErrorCode");
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
