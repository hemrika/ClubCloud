using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateWizardAccessPrivilege : TargetUpdate
	{
		private wizardaccessprivilege wizardAccessPrivilegeField;
		public wizardaccessprivilege WizardAccessPrivilege
		{
			get
			{
				return this.wizardAccessPrivilegeField;
			}
			set
			{
				this.wizardAccessPrivilegeField = value;
			}
		}
	}
}
