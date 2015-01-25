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
	public class SetStateSgt_alg_kvk_plaatsRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_kvk_plaatsState sgt_alg_kvk_plaatsStateField;

		private int sgt_alg_kvk_plaatsStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_kvk_plaatsState Sgt_alg_kvk_plaatsState
		{
			get
			{
				return this.sgt_alg_kvk_plaatsStateField;
			}
			set
			{
				this.sgt_alg_kvk_plaatsStateField = value;
				base.RaisePropertyChanged("Sgt_alg_kvk_plaatsState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_alg_kvk_plaatsStatus
		{
			get
			{
				return this.sgt_alg_kvk_plaatsStatusField;
			}
			set
			{
				this.sgt_alg_kvk_plaatsStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_kvk_plaatsStatus");
			}
		}

		public SetStateSgt_alg_kvk_plaatsRequest()
		{
		}
	}
}