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
	public class SetStateSgt_alg_logboek_ledenpas_een_berichtRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_logboek_ledenpas_een_berichtState sgt_alg_logboek_ledenpas_een_berichtStateField;

		private int sgt_alg_logboek_ledenpas_een_berichtStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_alg_logboek_ledenpas_een_berichtState Sgt_alg_logboek_ledenpas_een_berichtState
		{
			get
			{
				return this.sgt_alg_logboek_ledenpas_een_berichtStateField;
			}
			set
			{
				this.sgt_alg_logboek_ledenpas_een_berichtStateField = value;
				base.RaisePropertyChanged("Sgt_alg_logboek_ledenpas_een_berichtState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_alg_logboek_ledenpas_een_berichtStatus
		{
			get
			{
				return this.sgt_alg_logboek_ledenpas_een_berichtStatusField;
			}
			set
			{
				this.sgt_alg_logboek_ledenpas_een_berichtStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_logboek_ledenpas_een_berichtStatus");
			}
		}

		public SetStateSgt_alg_logboek_ledenpas_een_berichtRequest()
		{
		}
	}
}