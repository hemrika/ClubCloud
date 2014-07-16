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
	public class SetStateSgt_bo_examenRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_bo_examenState sgt_bo_examenStateField;

		private int sgt_bo_examenStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_bo_examenState Sgt_bo_examenState
		{
			get
			{
				return this.sgt_bo_examenStateField;
			}
			set
			{
				this.sgt_bo_examenStateField = value;
				base.RaisePropertyChanged("Sgt_bo_examenState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_bo_examenStatus
		{
			get
			{
				return this.sgt_bo_examenStatusField;
			}
			set
			{
				this.sgt_bo_examenStatusField = value;
				base.RaisePropertyChanged("Sgt_bo_examenStatus");
			}
		}

		public SetStateSgt_bo_examenRequest()
		{
		}
	}
}