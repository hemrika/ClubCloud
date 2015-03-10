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
	public class SetStateSgt_bo_soort_examenRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_bo_soort_examenState sgt_bo_soort_examenStateField;

		private int sgt_bo_soort_examenStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_bo_soort_examenState Sgt_bo_soort_examenState
		{
			get
			{
				return this.sgt_bo_soort_examenStateField;
			}
			set
			{
				this.sgt_bo_soort_examenStateField = value;
				base.RaisePropertyChanged("Sgt_bo_soort_examenState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_bo_soort_examenStatus
		{
			get
			{
				return this.sgt_bo_soort_examenStatusField;
			}
			set
			{
				this.sgt_bo_soort_examenStatusField = value;
				base.RaisePropertyChanged("Sgt_bo_soort_examenStatus");
			}
		}

		public SetStateSgt_bo_soort_examenRequest()
		{
		}
	}
}