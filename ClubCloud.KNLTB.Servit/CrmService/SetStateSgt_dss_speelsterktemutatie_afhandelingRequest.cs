using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_dss_speelsterktemutatie_afhandelingRequest : Request
	{
		private Guid entityIdField;
		private Sgt_dss_speelsterktemutatie_afhandelingState sgt_dss_speelsterktemutatie_afhandelingStateField;
		private int sgt_dss_speelsterktemutatie_afhandelingStatusField;
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
		public Sgt_dss_speelsterktemutatie_afhandelingState Sgt_dss_speelsterktemutatie_afhandelingState
		{
			get
			{
				return this.sgt_dss_speelsterktemutatie_afhandelingStateField;
			}
			set
			{
				this.sgt_dss_speelsterktemutatie_afhandelingStateField = value;
			}
		}
		public int Sgt_dss_speelsterktemutatie_afhandelingStatus
		{
			get
			{
				return this.sgt_dss_speelsterktemutatie_afhandelingStatusField;
			}
			set
			{
				this.sgt_dss_speelsterktemutatie_afhandelingStatusField = value;
			}
		}
	}
}