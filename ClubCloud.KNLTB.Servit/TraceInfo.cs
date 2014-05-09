using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2006/Scheduling")]
	[Serializable]
	public class TraceInfo : INotifyPropertyChanged
	{
		private ErrorInfo[] errorInfoListField;
		public event PropertyChangedEventHandler PropertyChanged;
		[XmlArray(Order = 0)]
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
