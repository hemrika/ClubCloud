using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2006/Scheduling")]
	[Serializable]
	public class TraceInfo
	{
		private ErrorInfo[] errorInfoListField;
		public ErrorInfo[] ErrorInfoList
		{
			get
			{
				return this.errorInfoListField;
			}
			set
			{
				this.errorInfoListField = value;
			}
		}
	}
}
