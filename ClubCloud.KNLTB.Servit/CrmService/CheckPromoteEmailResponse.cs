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
	public class CheckPromoteEmailResponse : Response
	{
		private bool shouldPromoteField;

		private int reasonCodeField;

		[XmlElement] //[XmlElement(Order=1)]
		public int ReasonCode
		{
			get
			{
				return this.reasonCodeField;
			}
			set
			{
				this.reasonCodeField = value;
				base.RaisePropertyChanged("ReasonCode");
			}
		}

		[XmlElement] //[XmlElement(Order=0)]
		public bool ShouldPromote
		{
			get
			{
				return this.shouldPromoteField;
			}
			set
			{
				this.shouldPromoteField = value;
				base.RaisePropertyChanged("ShouldPromote");
			}
		}

		public CheckPromoteEmailResponse()
		{
		}
	}
}