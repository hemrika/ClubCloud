using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_logboek_dcpRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_logboek_dcpState sgt_alg_logboek_dcpStateField;
		private int sgt_alg_logboek_dcpStatusField;
		[XmlElement(Order = 0)]
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
		[XmlElement(Order = 1)]
		public Sgt_alg_logboek_dcpState Sgt_alg_logboek_dcpState
		{
			get
			{
				return this.sgt_alg_logboek_dcpStateField;
			}
			set
			{
				this.sgt_alg_logboek_dcpStateField = value;
				base.RaisePropertyChanged("Sgt_alg_logboek_dcpState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_alg_logboek_dcpStatus
		{
			get
			{
				return this.sgt_alg_logboek_dcpStatusField;
			}
			set
			{
				this.sgt_alg_logboek_dcpStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_logboek_dcpStatus");
			}
		}
	}
}
