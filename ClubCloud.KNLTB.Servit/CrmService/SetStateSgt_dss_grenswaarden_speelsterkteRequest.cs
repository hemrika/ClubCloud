using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_dss_grenswaarden_speelsterkteRequest : Request
	{
		private Guid entityIdField;
		private Sgt_dss_grenswaarden_speelsterkteState sgt_dss_grenswaarden_speelsterkteStateField;
		private int sgt_dss_grenswaarden_speelsterkteStatusField;
		public Guid EntityId
		{
			get
			{
				return this.entityIdField;
			}
			set
			{
				this.entityIdField = value;
			}
		}
		public Sgt_dss_grenswaarden_speelsterkteState Sgt_dss_grenswaarden_speelsterkteState
		{
			get
			{
				return this.sgt_dss_grenswaarden_speelsterkteStateField;
			}
			set
			{
				this.sgt_dss_grenswaarden_speelsterkteStateField = value;
			}
		}
		public int Sgt_dss_grenswaarden_speelsterkteStatus
		{
			get
			{
				return this.sgt_dss_grenswaarden_speelsterkteStatusField;
			}
			set
			{
				this.sgt_dss_grenswaarden_speelsterkteStatusField = value;
			}
		}
	}
}
