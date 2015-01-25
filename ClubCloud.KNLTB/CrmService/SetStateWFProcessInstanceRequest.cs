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
	public class SetStateWFProcessInstanceRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.WFProcessInstanceState wFProcessInstanceStateField;

		private int wFProcessInstanceStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.WFProcessInstanceState WFProcessInstanceState
		{
			get
			{
				return this.wFProcessInstanceStateField;
			}
			set
			{
				this.wFProcessInstanceStateField = value;
				base.RaisePropertyChanged("WFProcessInstanceState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int WFProcessInstanceStatus
		{
			get
			{
				return this.wFProcessInstanceStatusField;
			}
			set
			{
				this.wFProcessInstanceStatusField = value;
				base.RaisePropertyChanged("WFProcessInstanceStatus");
			}
		}

		public SetStateWFProcessInstanceRequest()
		{
		}
	}
}