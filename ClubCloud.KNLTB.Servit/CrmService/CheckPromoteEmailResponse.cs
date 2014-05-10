using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class CheckPromoteEmailResponse : Response
	{
		private bool shouldPromoteField;
		private int reasonCodeField;
		public bool ShouldPromote
		{
			get
			{
				return this.shouldPromoteField;
			}
			set
			{
				this.shouldPromoteField = value;
			}
		}
		public int ReasonCode
		{
			get
			{
				return this.reasonCodeField;
			}
			set
			{
				this.reasonCodeField = value;
			}
		}
	}
}
