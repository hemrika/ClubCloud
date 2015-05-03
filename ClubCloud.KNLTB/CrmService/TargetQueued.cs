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
    /*
	[XmlInclude(typeof(TargetQueuedAppointment))]
	[XmlInclude(typeof(TargetQueuedCampaignActivity))]
	[XmlInclude(typeof(TargetQueuedCampaignResponse))]
	[XmlInclude(typeof(TargetQueuedDynamic))]
	[XmlInclude(typeof(TargetQueuedEmail))]
	[XmlInclude(typeof(TargetQueuedFax))]
	[XmlInclude(typeof(TargetQueuedIncident))]
	[XmlInclude(typeof(TargetQueuedLetter))]
	[XmlInclude(typeof(TargetQueuedPhoneCall))]
	[XmlInclude(typeof(TargetQueuedServiceAppointment))]
	[XmlInclude(typeof(TargetQueuedTask))]
    */
    [XmlSerializerAssembly(AssemblyName = "ClubCloud.KNLTB.XmlSerializers")]
	[XmlType(Namespace="http://schemas.microsoft.com/crm/2007/WebServices")]
	public abstract class TargetQueued : INotifyPropertyChanged
	{
		protected TargetQueued()
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