using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[GeneratedCode("System.Xml", "4.0.30319.33440")]
	[Serializable]
	[XmlType(Namespace="http://schemas.microsoft.com/crm/2007/WebServices")]
	public class WhoAmIResponse : Response
	{
		private Guid userIdField;

		private Guid businessUnitIdField;

		private Guid organizationIdField;

		[XmlElement] //[XmlElement(Order=1)]
		public Guid BusinessUnitId
		{
			get
			{
				return this.businessUnitIdField;
			}
			set
			{
				this.businessUnitIdField = value;
				base.RaisePropertyChanged("BusinessUnitId");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public Guid OrganizationId
		{
			get
			{
				return this.organizationIdField;
			}
			set
			{
				this.organizationIdField = value;
				base.RaisePropertyChanged("OrganizationId");
			}
		}

		[XmlElement] //[XmlElement(Order=0)]
		public Guid UserId
		{
			get
			{
				return this.userIdField;
			}
			set
			{
				this.userIdField = value;
				base.RaisePropertyChanged("UserId");
			}
		}

		public WhoAmIResponse()
		{
		}
	}
}