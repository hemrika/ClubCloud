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
	public class SetStateSgt_alg_baantypeRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_baantypeState sgt_alg_baantypeStateField;

		private int sgt_alg_baantypeStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_baantypeState Sgt_alg_baantypeState
		{
			get
			{
				return this.sgt_alg_baantypeStateField;
			}
			set
			{
				this.sgt_alg_baantypeStateField = value;
				base.RaisePropertyChanged("Sgt_alg_baantypeState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_alg_baantypeStatus
		{
			get
			{
				return this.sgt_alg_baantypeStatusField;
			}
			set
			{
				this.sgt_alg_baantypeStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_baantypeStatus");
			}
		}

		public SetStateSgt_alg_baantypeRequest()
		{
		}
	}
}