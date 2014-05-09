using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetBusinessSystemUserRequest : Request
	{
		private Guid userIdField;
		private Guid businessIdField;
		private SecurityPrincipal reassignPrincipalField;
		[XmlElement(Order = 0)]
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
		[XmlElement(Order = 1)]
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
		[XmlElement(Order = 2)]
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
	}
}
