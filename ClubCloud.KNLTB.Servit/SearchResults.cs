using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2006/Scheduling")]
	[Serializable]
	public class SearchResults : INotifyPropertyChanged
	{
		private AppointmentProposal[] proposalsField;
		private TraceInfo traceInfoField;
		public event PropertyChangedEventHandler PropertyChanged;
		[XmlArray(Order = 0)]
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
		[XmlElement(Order = 1)]
		public TraceInfo TraceInfo
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
