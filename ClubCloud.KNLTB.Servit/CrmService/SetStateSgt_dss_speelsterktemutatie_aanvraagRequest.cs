using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_dss_speelsterktemutatie_aanvraagRequest : Request
	{
		private Guid entityIdField;
		private Sgt_dss_speelsterktemutatie_aanvraagState sgt_dss_speelsterktemutatie_aanvraagStateField;
		private int sgt_dss_speelsterktemutatie_aanvraagStatusField;
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
		public Sgt_dss_speelsterktemutatie_aanvraagState Sgt_dss_speelsterktemutatie_aanvraagState
		{
			get
			{
				return this.sgt_dss_speelsterktemutatie_aanvraagStateField;
			}
			set
			{
				this.sgt_dss_speelsterktemutatie_aanvraagStateField = value;
			}
		}
		public int Sgt_dss_speelsterktemutatie_aanvraagStatus
		{
			get
			{
				return this.sgt_dss_speelsterktemutatie_aanvraagStatusField;
			}
			set
			{
				this.sgt_dss_speelsterktemutatie_aanvraagStatusField = value;
			}
		}
	}
}
