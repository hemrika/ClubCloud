using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services.Protocols;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/CoreTypes")]
	[Serializable]
    public class CorrelationToken : SoapHeader, INotifyPropertyChanged
	{
		private Guid correlationIdField;
		private CrmDateTime correlationUpdatedTimeField;
		private int depthField;
		public event PropertyChangedEventHandler PropertyChanged;
		[XmlElement(Order = 0)]
		public Guid CorrelationId
		{
			get
			{
				return this.correlationIdField;
			}
			set
			{
				this.correlationIdField = value;
				this.RaisePropertyChanged("CorrelationId");
			}
		}
		[XmlElement(Order = 1)]
		public CrmDateTime CorrelationUpdatedTime
		{
			get
			{
				return this.correlationUpdatedTimeField;
			}
			set
			{
				this.correlationUpdatedTimeField = value;
				this.RaisePropertyChanged("CorrelationUpdatedTime");
			}
		}
		[XmlElement(Order = 2)]
		public int Depth
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
