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
	public class DetachFromQueueEmailRequest : Request
	{
		private Guid emailIdField;

		private Guid queueIdField;

		[XmlElement] //[XmlElement(Order=0)]
		public Guid EmailId
		{
			get
			{
				return this.emailIdField;
			}
			set
			{
				this.emailIdField = value;
				base.RaisePropertyChanged("EmailId");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public Guid QueueId
		{
			get
			{
				return this.queueIdField;
			}
			set
			{
				this.queueIdField = value;
				base.RaisePropertyChanged("QueueId");
			}
		}

		public DetachFromQueueEmailRequest()
		{
		}
	}
}