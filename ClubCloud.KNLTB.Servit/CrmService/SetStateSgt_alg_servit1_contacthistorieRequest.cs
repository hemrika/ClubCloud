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
	public class SetStateSgt_alg_servit1_contacthistorieRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_servit1_contacthistorieState sgt_alg_servit1_contacthistorieStateField;

		private int sgt_alg_servit1_contacthistorieStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_servit1_contacthistorieState Sgt_alg_servit1_contacthistorieState
		{
			get
			{
				return this.sgt_alg_servit1_contacthistorieStateField;
			}
			set
			{
				this.sgt_alg_servit1_contacthistorieStateField = value;
				base.RaisePropertyChanged("Sgt_alg_servit1_contacthistorieState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_alg_servit1_contacthistorieStatus
		{
			get
			{
				return this.sgt_alg_servit1_contacthistorieStatusField;
			}
			set
			{
				this.sgt_alg_servit1_contacthistorieStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_servit1_contacthistorieStatus");
			}
		}

		public SetStateSgt_alg_servit1_contacthistorieRequest()
		{
		}
	}
}