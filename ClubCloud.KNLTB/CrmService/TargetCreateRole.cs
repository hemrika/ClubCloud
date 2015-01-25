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
	public class TargetCreateRole : TargetCreate
	{
		private role roleField;

		[XmlElement] //[XmlElement(Order=0)]
		public role Role
		{
			get
			{
				return this.roleField;
			}
			set
			{
				this.roleField = value;
				base.RaisePropertyChanged("Role");
			}
		}

		public TargetCreateRole()
		{
		}
	}
}