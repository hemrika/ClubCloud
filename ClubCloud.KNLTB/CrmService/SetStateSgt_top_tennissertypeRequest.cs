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
	public class SetStateSgt_top_tennissertypeRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_top_tennissertypeState sgt_top_tennissertypeStateField;

		private int sgt_top_tennissertypeStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_top_tennissertypeState Sgt_top_tennissertypeState
		{
			get
			{
				return this.sgt_top_tennissertypeStateField;
			}
			set
			{
				this.sgt_top_tennissertypeStateField = value;
				base.RaisePropertyChanged("Sgt_top_tennissertypeState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_top_tennissertypeStatus
		{
			get
			{
				return this.sgt_top_tennissertypeStatusField;
			}
			set
			{
				this.sgt_top_tennissertypeStatusField = value;
				base.RaisePropertyChanged("Sgt_top_tennissertypeStatus");
			}
		}

		public SetStateSgt_top_tennissertypeRequest()
		{
		}
	}
}