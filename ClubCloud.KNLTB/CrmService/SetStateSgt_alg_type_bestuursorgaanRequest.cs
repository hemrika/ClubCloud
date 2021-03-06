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
	public class SetStateSgt_alg_type_bestuursorgaanRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_type_bestuursorgaanState sgt_alg_type_bestuursorgaanStateField;

		private int sgt_alg_type_bestuursorgaanStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_type_bestuursorgaanState Sgt_alg_type_bestuursorgaanState
		{
			get
			{
				return this.sgt_alg_type_bestuursorgaanStateField;
			}
			set
			{
				this.sgt_alg_type_bestuursorgaanStateField = value;
				base.RaisePropertyChanged("Sgt_alg_type_bestuursorgaanState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_alg_type_bestuursorgaanStatus
		{
			get
			{
				return this.sgt_alg_type_bestuursorgaanStatusField;
			}
			set
			{
				this.sgt_alg_type_bestuursorgaanStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_type_bestuursorgaanStatus");
			}
		}

		public SetStateSgt_alg_type_bestuursorgaanRequest()
		{
		}
	}
}