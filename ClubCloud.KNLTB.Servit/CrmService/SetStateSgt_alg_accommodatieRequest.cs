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
	public class SetStateSgt_alg_accommodatieRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_accommodatieState sgt_alg_accommodatieStateField;

		private int sgt_alg_accommodatieStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_accommodatieState Sgt_alg_accommodatieState
		{
			get
			{
				return this.sgt_alg_accommodatieStateField;
			}
			set
			{
				this.sgt_alg_accommodatieStateField = value;
				base.RaisePropertyChanged("Sgt_alg_accommodatieState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_alg_accommodatieStatus
		{
			get
			{
				return this.sgt_alg_accommodatieStatusField;
			}
			set
			{
				this.sgt_alg_accommodatieStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_accommodatieStatus");
			}
		}

		public SetStateSgt_alg_accommodatieRequest()
		{
		}
	}
}