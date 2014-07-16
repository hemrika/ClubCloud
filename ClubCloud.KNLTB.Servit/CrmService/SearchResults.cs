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
	public class SearchResults : INotifyPropertyChanged
	{
		private AppointmentProposal[] proposalsField;

		private ClubCloud.KNLTB.ServIt.CrmService.TraceInfo traceInfoField;

		[XmlArray] //[XmlArray(Order=0)]
		public AppointmentProposal[] Proposals
		{
			get
			{
				return this.proposalsField;
			}
			set
			{
				this.proposalsField = value;
				this.RaisePropertyChanged("Proposals");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public ClubCloud.KNLTB.ServIt.CrmService.TraceInfo TraceInfo
		{
			get
			{
				return this.traceInfoField;
			}
			set
			{
				this.traceInfoField = value;
				this.RaisePropertyChanged("TraceInfo");
			}
		}

		public SearchResults()
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