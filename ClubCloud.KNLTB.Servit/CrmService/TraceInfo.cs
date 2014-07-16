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
	public class TraceInfo : INotifyPropertyChanged
	{
		private ErrorInfo[] errorInfoListField;

		[XmlArray] //[XmlArray(Order=0)]
		public ErrorInfo[] ErrorInfoList
		{
			get
			{
				return this.errorInfoListField;
			}
			set
			{
				this.errorInfoListField = value;
				this.RaisePropertyChanged("ErrorInfoList");
			}
		}

		public TraceInfo()
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