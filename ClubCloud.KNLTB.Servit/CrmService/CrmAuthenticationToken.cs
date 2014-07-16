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
    public class CrmAuthenticationToken : SoapHeader, INotifyPropertyChanged
	{
		private int authenticationTypeField;

		private string crmTicketField;

		private string organizationNameField;

		private Guid callerIdField;

		[XmlElement] //[XmlElement(Order=0)]
		public int AuthenticationType
		{
			get
			{
				return this.authenticationTypeField;
			}
			set
			{
				this.authenticationTypeField = value;
				this.RaisePropertyChanged("AuthenticationType");
			}
		}

		[XmlElement] //[XmlElement(Order=3)]
		public Guid CallerId
		{
			get
			{
				return this.callerIdField;
			}
			set
			{
				this.callerIdField = value;
				this.RaisePropertyChanged("CallerId");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public string CrmTicket
		{
			get
			{
				return this.crmTicketField;
			}
			set
			{
				this.crmTicketField = value;
				this.RaisePropertyChanged("CrmTicket");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public string OrganizationName
		{
			get
			{
				return this.organizationNameField;
			}
			set
			{
				this.organizationNameField = value;
				this.RaisePropertyChanged("OrganizationName");
			}
		}

		public CrmAuthenticationToken()
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