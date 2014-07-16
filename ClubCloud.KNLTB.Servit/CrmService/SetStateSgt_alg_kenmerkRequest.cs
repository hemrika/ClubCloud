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
	public class SetStateSgt_alg_kenmerkRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_kenmerkState sgt_alg_kenmerkStateField;

		private int sgt_alg_kenmerkStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_kenmerkState Sgt_alg_kenmerkState
		{
			get
			{
				return this.sgt_alg_kenmerkStateField;
			}
			set
			{
				this.sgt_alg_kenmerkStateField = value;
				base.RaisePropertyChanged("Sgt_alg_kenmerkState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_alg_kenmerkStatus
		{
			get
			{
				return this.sgt_alg_kenmerkStatusField;
			}
			set
			{
				this.sgt_alg_kenmerkStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_kenmerkStatus");
			}
		}

		public SetStateSgt_alg_kenmerkRequest()
		{
		}
	}
}