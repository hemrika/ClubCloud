using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateRole : TargetCreate
	{
		private role roleField;
		[XmlElement(Order = 0)]
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
	}
}
