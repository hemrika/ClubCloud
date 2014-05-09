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
    public class CrmAuthenticationToken : SoapHeader, INotifyPropertyChanged
	{
		private int authenticationTypeField;
		private string crmTicketField;
		private string organizationNameField;
		private Guid callerIdField;
		public event PropertyChangedEventHandler PropertyChanged;
		[XmlElement(Order = 0)]
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
		[XmlElement(Order = 1)]
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
		[XmlElement(Order = 2)]
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
		[XmlElement(Order = 3)]
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
