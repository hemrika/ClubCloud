using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_dss_reden_speelsterktemutatieRequest : Request
	{
		private Guid entityIdField;
		private Sgt_dss_reden_speelsterktemutatieState sgt_dss_reden_speelsterktemutatieStateField;
		private int sgt_dss_reden_speelsterktemutatieStatusField;
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
		public Sgt_dss_reden_speelsterktemutatieState Sgt_dss_reden_speelsterktemutatieState
		{
			get
			{
				return this.sgt_dss_reden_speelsterktemutatieStateField;
			}
			set
			{
				this.sgt_dss_reden_speelsterktemutatieStateField = value;
			}
		}
		public int Sgt_dss_reden_speelsterktemutatieStatus
		{
			get
			{
				return this.sgt_dss_reden_speelsterktemutatieStatusField;
			}
			set
			{
				this.sgt_dss_reden_speelsterktemutatieStatusField = value;
			}
		}
	}
}
