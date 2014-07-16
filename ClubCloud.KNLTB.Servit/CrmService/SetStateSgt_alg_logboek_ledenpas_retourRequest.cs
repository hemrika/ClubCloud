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
	public class SetStateSgt_alg_logboek_ledenpas_retourRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_logboek_ledenpas_retourState sgt_alg_logboek_ledenpas_retourStateField;

		private int sgt_alg_logboek_ledenpas_retourStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_logboek_ledenpas_retourState Sgt_alg_logboek_ledenpas_retourState
		{
			get
			{
				return this.sgt_alg_logboek_ledenpas_retourStateField;
			}
			set
			{
				this.sgt_alg_logboek_ledenpas_retourStateField = value;
				base.RaisePropertyChanged("Sgt_alg_logboek_ledenpas_retourState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_alg_logboek_ledenpas_retourStatus
		{
			get
			{
				return this.sgt_alg_logboek_ledenpas_retourStatusField;
			}
			set
			{
				this.sgt_alg_logboek_ledenpas_retourStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_logboek_ledenpas_retourStatus");
			}
		}

		public SetStateSgt_alg_logboek_ledenpas_retourRequest()
		{
		}
	}
}