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
	public class SetStateSgt_bo_logboek_VNTRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_bo_logboek_VNTState sgt_bo_logboek_VNTStateField;

		private int sgt_bo_logboek_VNTStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_bo_logboek_VNTState Sgt_bo_logboek_VNTState
		{
			get
			{
				return this.sgt_bo_logboek_VNTStateField;
			}
			set
			{
				this.sgt_bo_logboek_VNTStateField = value;
				base.RaisePropertyChanged("Sgt_bo_logboek_VNTState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_bo_logboek_VNTStatus
		{
			get
			{
				return this.sgt_bo_logboek_VNTStatusField;
			}
			set
			{
				this.sgt_bo_logboek_VNTStatusField = value;
				base.RaisePropertyChanged("Sgt_bo_logboek_VNTStatus");
			}
		}

		public SetStateSgt_bo_logboek_VNTRequest()
		{
		}
	}
}