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
	public class SetStateSgt_alg_btw_codeRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_btw_codeState sgt_alg_btw_codeStateField;

		private int sgt_alg_btw_codeStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_btw_codeState Sgt_alg_btw_codeState
		{
			get
			{
				return this.sgt_alg_btw_codeStateField;
			}
			set
			{
				this.sgt_alg_btw_codeStateField = value;
				base.RaisePropertyChanged("Sgt_alg_btw_codeState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_alg_btw_codeStatus
		{
			get
			{
				return this.sgt_alg_btw_codeStatusField;
			}
			set
			{
				this.sgt_alg_btw_codeStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_btw_codeStatus");
			}
		}

		public SetStateSgt_alg_btw_codeRequest()
		{
		}
	}
}