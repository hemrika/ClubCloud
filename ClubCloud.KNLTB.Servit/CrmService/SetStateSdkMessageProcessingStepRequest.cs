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
	public class SetStateSdkMessageProcessingStepRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.SdkMessageProcessingStepState sdkMessageProcessingStepStateField;

		private int sdkMessageProcessingStepStatusField;

		[XmlElement] //[XmlElement(Order=0)]
		public Guid EntityId
		{
			get
			{
				return this.entityIdField;
			}
			set
			{
				this.entityIdField = value;
				base.RaisePropertyChanged("EntityId");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public ClubCloud.KNLTB.ServIt.CrmService.SdkMessageProcessingStepState SdkMessageProcessingStepState
		{
			get
			{
				return this.sdkMessageProcessingStepStateField;
			}
			set
			{
				this.sdkMessageProcessingStepStateField = value;
				base.RaisePropertyChanged("SdkMessageProcessingStepState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int SdkMessageProcessingStepStatus
		{
			get
			{
				return this.sdkMessageProcessingStepStatusField;
			}
			set
			{
				this.sdkMessageProcessingStepStatusField = value;
				base.RaisePropertyChanged("SdkMessageProcessingStepStatus");
			}
		}

		public SetStateSdkMessageProcessingStepRequest()
		{
		}
	}
}