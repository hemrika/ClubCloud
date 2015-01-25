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
	public class SetStateSgt_bo_cursistRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_bo_cursistState sgt_bo_cursistStateField;

		private int sgt_bo_cursistStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_bo_cursistState Sgt_bo_cursistState
		{
			get
			{
				return this.sgt_bo_cursistStateField;
			}
			set
			{
				this.sgt_bo_cursistStateField = value;
				base.RaisePropertyChanged("Sgt_bo_cursistState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_bo_cursistStatus
		{
			get
			{
				return this.sgt_bo_cursistStatusField;
			}
			set
			{
				this.sgt_bo_cursistStatusField = value;
				base.RaisePropertyChanged("Sgt_bo_cursistStatus");
			}
		}

		public SetStateSgt_bo_cursistRequest()
		{
		}
	}
}