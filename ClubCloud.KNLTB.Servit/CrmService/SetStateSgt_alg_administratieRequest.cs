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
	public class SetStateSgt_alg_administratieRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_administratieState sgt_alg_administratieStateField;

		private int sgt_alg_administratieStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_administratieState Sgt_alg_administratieState
		{
			get
			{
				return this.sgt_alg_administratieStateField;
			}
			set
			{
				this.sgt_alg_administratieStateField = value;
				base.RaisePropertyChanged("Sgt_alg_administratieState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_alg_administratieStatus
		{
			get
			{
				return this.sgt_alg_administratieStatusField;
			}
			set
			{
				this.sgt_alg_administratieStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_administratieStatus");
			}
		}

		public SetStateSgt_alg_administratieRequest()
		{
		}
	}
}