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
	public class SetStateSgt_alg_grootboekcodeRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_grootboekcodeState sgt_alg_grootboekcodeStateField;

		private int sgt_alg_grootboekcodeStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_grootboekcodeState Sgt_alg_grootboekcodeState
		{
			get
			{
				return this.sgt_alg_grootboekcodeStateField;
			}
			set
			{
				this.sgt_alg_grootboekcodeStateField = value;
				base.RaisePropertyChanged("Sgt_alg_grootboekcodeState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_alg_grootboekcodeStatus
		{
			get
			{
				return this.sgt_alg_grootboekcodeStatusField;
			}
			set
			{
				this.sgt_alg_grootboekcodeStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_grootboekcodeStatus");
			}
		}

		public SetStateSgt_alg_grootboekcodeRequest()
		{
		}
	}
}