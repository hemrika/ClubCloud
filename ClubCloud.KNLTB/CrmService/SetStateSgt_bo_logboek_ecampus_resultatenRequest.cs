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
	public class SetStateSgt_bo_logboek_ecampus_resultatenRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_bo_logboek_ecampus_resultatenState sgt_bo_logboek_ecampus_resultatenStateField;

		private int sgt_bo_logboek_ecampus_resultatenStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_bo_logboek_ecampus_resultatenState Sgt_bo_logboek_ecampus_resultatenState
		{
			get
			{
				return this.sgt_bo_logboek_ecampus_resultatenStateField;
			}
			set
			{
				this.sgt_bo_logboek_ecampus_resultatenStateField = value;
				base.RaisePropertyChanged("Sgt_bo_logboek_ecampus_resultatenState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_bo_logboek_ecampus_resultatenStatus
		{
			get
			{
				return this.sgt_bo_logboek_ecampus_resultatenStatusField;
			}
			set
			{
				this.sgt_bo_logboek_ecampus_resultatenStatusField = value;
				base.RaisePropertyChanged("Sgt_bo_logboek_ecampus_resultatenStatus");
			}
		}

		public SetStateSgt_bo_logboek_ecampus_resultatenRequest()
		{
		}
	}
}