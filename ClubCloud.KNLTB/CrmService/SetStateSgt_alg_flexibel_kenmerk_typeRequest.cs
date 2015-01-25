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
	public class SetStateSgt_alg_flexibel_kenmerk_typeRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_flexibel_kenmerk_typeState sgt_alg_flexibel_kenmerk_typeStateField;

		private int sgt_alg_flexibel_kenmerk_typeStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_flexibel_kenmerk_typeState Sgt_alg_flexibel_kenmerk_typeState
		{
			get
			{
				return this.sgt_alg_flexibel_kenmerk_typeStateField;
			}
			set
			{
				this.sgt_alg_flexibel_kenmerk_typeStateField = value;
				base.RaisePropertyChanged("Sgt_alg_flexibel_kenmerk_typeState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_alg_flexibel_kenmerk_typeStatus
		{
			get
			{
				return this.sgt_alg_flexibel_kenmerk_typeStatusField;
			}
			set
			{
				this.sgt_alg_flexibel_kenmerk_typeStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_flexibel_kenmerk_typeStatus");
			}
		}

		public SetStateSgt_alg_flexibel_kenmerk_typeRequest()
		{
		}
	}
}