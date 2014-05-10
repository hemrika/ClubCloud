using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_dss_speelsterkteRequest : Request
	{
		private Guid entityIdField;
		private Sgt_dss_speelsterkteState sgt_dss_speelsterkteStateField;
		private int sgt_dss_speelsterkteStatusField;
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
		public Sgt_dss_speelsterkteState Sgt_dss_speelsterkteState
		{
			get
			{
				return this.sgt_dss_speelsterkteStateField;
			}
			set
			{
				this.sgt_dss_speelsterkteStateField = value;
			}
		}
		public int Sgt_dss_speelsterkteStatus
		{
			get
			{
				return this.sgt_dss_speelsterkteStatusField;
			}
			set
			{
				this.sgt_dss_speelsterkteStatusField = value;
			}
		}
	}
}
