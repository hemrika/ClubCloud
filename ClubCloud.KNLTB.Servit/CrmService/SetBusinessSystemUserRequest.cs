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
	public class SetBusinessSystemUserRequest : Request
	{
		private Guid userIdField;

		private Guid businessIdField;

		private SecurityPrincipal reassignPrincipalField;

		[XmlElement] //[XmlElement(Order=1)]
		public Guid BusinessId
		{
			get
			{
				return this.businessIdField;
			}
			set
			{
				this.businessIdField = value;
				base.RaisePropertyChanged("BusinessId");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public SecurityPrincipal ReassignPrincipal
		{
			get
			{
				return this.reassignPrincipalField;
			}
			set
			{
				this.reassignPrincipalField = value;
				base.RaisePropertyChanged("ReassignPrincipal");
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

		public SetBusinessSystemUserRequest()
		{
		}
	}
}