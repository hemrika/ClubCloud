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
	[XmlType(Namespace="http://schemas.microsoft.com/crm/2006/Scheduling")]
	public class ErrorInfo : INotifyPropertyChanged
	{
		private ResourceInfo[] resourceListField;

		private string errorCodeField;

		[XmlElement] //[XmlElement(Order=1)]
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

		[XmlArray] //[XmlArray(Order=0)]
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

		public ErrorInfo()
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