using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_kenmerkRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_kenmerkState sgt_alg_kenmerkStateField;
		private int sgt_alg_kenmerkStatusField;
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
		public Sgt_alg_kenmerkState Sgt_alg_kenmerkState
		{
			get
			{
				return this.sgt_alg_kenmerkStateField;
			}
			set
			{
				this.sgt_alg_kenmerkStateField = value;
			}
		}
		public int Sgt_alg_kenmerkStatus
		{
			get
			{
				return this.sgt_alg_kenmerkStatusField;
			}
			set
			{
				this.sgt_alg_kenmerkStatusField = value;
			}
		}
	}
}
