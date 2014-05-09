using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlInclude(typeof(TargetQueuedIncident)), XmlInclude(typeof(TargetQueuedAppointment)), XmlInclude(typeof(TargetQueuedTask)), XmlInclude(typeof(TargetQueuedServiceAppointment)), XmlInclude(typeof(TargetQueuedPhoneCall)), XmlInclude(typeof(TargetQueuedLetter)), XmlInclude(typeof(TargetQueuedFax)), XmlInclude(typeof(TargetQueuedEmail)), XmlInclude(typeof(TargetQueuedDynamic)), XmlInclude(typeof(TargetQueuedCampaignResponse)), XmlInclude(typeof(TargetQueuedCampaignActivity)), XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public abstract class TargetQueued : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
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
