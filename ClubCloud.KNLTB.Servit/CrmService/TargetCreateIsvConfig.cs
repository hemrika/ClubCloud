using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateIsvConfig : TargetCreate
	{
		private isvconfig isvConfigField;
		public isvconfig IsvConfig
		{
			get
			{
				return this.isvConfigField;
			}
			set
			{
				this.isvConfigField = value;
			}
		}
	}
}
