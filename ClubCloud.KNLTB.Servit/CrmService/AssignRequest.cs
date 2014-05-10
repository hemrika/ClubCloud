using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class AssignRequest : Request
	{
		private TargetOwned targetField;
		private SecurityPrincipal assigneeField;
		public TargetOwned Target
		{
			get
			{
				return this.targetField;
			}
			set
			{
				this.targetField = value;
			}
		}
		public SecurityPrincipal Assignee
		{
			get
			{
				return this.assigneeField;
			}
			set
			{
				this.assigneeField = value;
			}
		}
	}
}
