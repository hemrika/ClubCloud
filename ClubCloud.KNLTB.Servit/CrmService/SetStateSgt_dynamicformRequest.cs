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
	public class SetStateSgt_dynamicformRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_dynamicformState sgt_dynamicformStateField;

		private int sgt_dynamicformStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_dynamicformState Sgt_dynamicformState
		{
			get
			{
				return this.sgt_dynamicformStateField;
			}
			set
			{
				this.sgt_dynamicformStateField = value;
				base.RaisePropertyChanged("Sgt_dynamicformState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_dynamicformStatus
		{
			get
			{
				return this.sgt_dynamicformStatusField;
			}
			set
			{
				this.sgt_dynamicformStatusField = value;
				base.RaisePropertyChanged("Sgt_dynamicformStatus");
			}
		}

		public SetStateSgt_dynamicformRequest()
		{
		}
	}
}