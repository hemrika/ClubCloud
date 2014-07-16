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
	public class SetStateSgt_bo_licentiesoortRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_bo_licentiesoortState sgt_bo_licentiesoortStateField;

		private int sgt_bo_licentiesoortStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_bo_licentiesoortState Sgt_bo_licentiesoortState
		{
			get
			{
				return this.sgt_bo_licentiesoortStateField;
			}
			set
			{
				this.sgt_bo_licentiesoortStateField = value;
				base.RaisePropertyChanged("Sgt_bo_licentiesoortState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_bo_licentiesoortStatus
		{
			get
			{
				return this.sgt_bo_licentiesoortStatusField;
			}
			set
			{
				this.sgt_bo_licentiesoortStatusField = value;
				base.RaisePropertyChanged("Sgt_bo_licentiesoortStatus");
			}
		}

		public SetStateSgt_bo_licentiesoortRequest()
		{
		}
	}
}