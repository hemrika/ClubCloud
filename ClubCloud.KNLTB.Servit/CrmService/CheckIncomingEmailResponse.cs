using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class CheckIncomingEmailResponse : Response
	{
		private bool shouldDeliverField;
		private int reasonCodeField;
		public bool ShouldDeliver
		{
			get
			{
				return this.shouldDeliverField;
			}
			set
			{
				this.shouldDeliverField = value;
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
