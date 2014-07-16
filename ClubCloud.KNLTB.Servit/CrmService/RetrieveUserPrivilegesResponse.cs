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
	public class RetrieveUserPrivilegesResponse : Response
	{
		private RolePrivilege[] rolePrivilegesField;

		[XmlArray] //[XmlArray(Order=0)]
		public RolePrivilege[] RolePrivileges
		{
			get
			{
				return this.rolePrivilegesField;
			}
			set
			{
				this.rolePrivilegesField = value;
				base.RaisePropertyChanged("RolePrivileges");
			}
		}

		public RetrieveUserPrivilegesResponse()
		{
		}
	}
}