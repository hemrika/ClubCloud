using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_com_ploegtoevoegingRequest : Request
	{
		private Guid entityIdField;
		private Sgt_com_ploegtoevoegingState sgt_com_ploegtoevoegingStateField;
		private int sgt_com_ploegtoevoegingStatusField;
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
		public Sgt_com_ploegtoevoegingState Sgt_com_ploegtoevoegingState
		{
			get
			{
				return this.sgt_com_ploegtoevoegingStateField;
			}
			set
			{
				this.sgt_com_ploegtoevoegingStateField = value;
			}
		}
		public int Sgt_com_ploegtoevoegingStatus
		{
			get
			{
				return this.sgt_com_ploegtoevoegingStatusField;
			}
			set
			{
				this.sgt_com_ploegtoevoegingStatusField = value;
			}
		}
	}
}
