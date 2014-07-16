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
	public class HandleRequest : Request
	{
		private TargetQueued targetField;

		private Guid sourceQueueIdField;

		[XmlElement] //[XmlElement(Order=1)]
		public Guid SourceQueueId
		{
			get
			{
				return this.sourceQueueIdField;
			}
			set
			{
				this.sourceQueueIdField = value;
				base.RaisePropertyChanged("SourceQueueId");
			}
		}

		[XmlElement] //[XmlElement(Order=0)]
		public TargetQueued Target
		{
			get
			{
				return this.targetField;
			}
			set
			{
				this.targetField = value;
				base.RaisePropertyChanged("Target");
			}
		}

		public HandleRequest()
		{
		}
	}
}