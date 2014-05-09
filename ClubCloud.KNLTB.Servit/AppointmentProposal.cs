using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2006/Scheduling")]
	[Serializable]
	public class AppointmentProposal : INotifyPropertyChanged
	{
		private CrmDateTime startField;
		private CrmDateTime endField;
		private Guid siteIdField;
		private string siteNameField;
		private ProposalParty[] proposalPartiesField;
		public event PropertyChangedEventHandler PropertyChanged;
		[XmlElement(Order = 0)]
		public CrmDateTime Start
		{
			get
			{
				return this.startField;
			}
			set
			{
				this.startField = value;
				this.RaisePropertyChanged("Start");
			}
		}
		[XmlElement(Order = 1)]
		public CrmDateTime End
		{
			get
			{
				return this.endField;
			}
			set
			{
				this.endField = value;
				this.RaisePropertyChanged("End");
			}
		}
		[XmlElement(Order = 2)]
		public Guid SiteId
		{
			get
			{
				return this.siteIdField;
			}
			set
			{
				this.siteIdField = value;
				this.RaisePropertyChanged("SiteId");
			}
		}
		[XmlElement(Order = 3)]
		public string SiteName
		{
			get
			{
				return this.siteNameField;
			}
			set
			{
				this.siteNameField = value;
				this.RaisePropertyChanged("SiteName");
			}
		}
		[XmlArray(Order = 4)]
		public ProposalParty[] ProposalParties
		{
			get
			{
				return this.proposalPartiesField;
			}
			set
			{
				this.proposalPartiesField = value;
				this.RaisePropertyChanged("ProposalParties");
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
