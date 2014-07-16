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
	public class SetStateSgt_top_soort_groepRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_top_soort_groepState sgt_top_soort_groepStateField;

		private int sgt_top_soort_groepStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_top_soort_groepState Sgt_top_soort_groepState
		{
			get
			{
				return this.sgt_top_soort_groepStateField;
			}
			set
			{
				this.sgt_top_soort_groepStateField = value;
				base.RaisePropertyChanged("Sgt_top_soort_groepState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_top_soort_groepStatus
		{
			get
			{
				return this.sgt_top_soort_groepStatusField;
			}
			set
			{
				this.sgt_top_soort_groepStatusField = value;
				base.RaisePropertyChanged("Sgt_top_soort_groepStatus");
			}
		}

		public SetStateSgt_top_soort_groepRequest()
		{
		}
	}
}