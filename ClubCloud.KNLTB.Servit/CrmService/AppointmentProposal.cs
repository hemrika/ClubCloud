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
	public class AppointmentProposal : INotifyPropertyChanged
	{
		private CrmDateTime startField;

		private CrmDateTime endField;

		private Guid siteIdField;

		private string siteNameField;

		private ProposalParty[] proposalPartiesField;

		[XmlElement] //[XmlElement(Order=1)]
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

		[XmlArray] //[XmlArray(Order=4)]
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

		[XmlElement] //[XmlElement(Order=2)]
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

		[XmlElement] //[XmlElement(Order=3)]
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

		[XmlElement] //[XmlElement(Order=0)]
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

		public AppointmentProposal()
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