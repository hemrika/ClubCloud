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
	public class SetStateSgt_alg_certificaatRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_certificaatState sgt_alg_certificaatStateField;

		private int sgt_alg_certificaatStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_certificaatState Sgt_alg_certificaatState
		{
			get
			{
				return this.sgt_alg_certificaatStateField;
			}
			set
			{
				this.sgt_alg_certificaatStateField = value;
				base.RaisePropertyChanged("Sgt_alg_certificaatState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_alg_certificaatStatus
		{
			get
			{
				return this.sgt_alg_certificaatStatusField;
			}
			set
			{
				this.sgt_alg_certificaatStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_certificaatStatus");
			}
		}

		public SetStateSgt_alg_certificaatRequest()
		{
		}
	}
}