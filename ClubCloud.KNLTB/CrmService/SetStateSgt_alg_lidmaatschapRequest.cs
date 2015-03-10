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
	public class SetStateSgt_alg_lidmaatschapRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_lidmaatschapState sgt_alg_lidmaatschapStateField;

		private int sgt_alg_lidmaatschapStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_lidmaatschapState Sgt_alg_lidmaatschapState
		{
			get
			{
				return this.sgt_alg_lidmaatschapStateField;
			}
			set
			{
				this.sgt_alg_lidmaatschapStateField = value;
				base.RaisePropertyChanged("Sgt_alg_lidmaatschapState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_alg_lidmaatschapStatus
		{
			get
			{
				return this.sgt_alg_lidmaatschapStatusField;
			}
			set
			{
				this.sgt_alg_lidmaatschapStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_lidmaatschapStatus");
			}
		}

		public SetStateSgt_alg_lidmaatschapRequest()
		{
		}
	}
}