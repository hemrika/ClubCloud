using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[GeneratedCode("System.Xml", "4.0.30319.33440")]
	[Serializable]
	[XmlType(Namespace="http://schemas.microsoft.com/crm/2007/CoreTypes")]
    public class CorrelationToken : SoapHeader, INotifyPropertyChanged
	{
		private Guid correlationIdField;

		private CrmDateTime correlationUpdatedTimeField;

		private int depthField;

		[XmlElement] //[XmlElement(Order=0)]
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

		[XmlElement] //[XmlElement(Order=1)]
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

		[XmlElement] //[XmlElement(Order=2)]
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

		public CorrelationToken()
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