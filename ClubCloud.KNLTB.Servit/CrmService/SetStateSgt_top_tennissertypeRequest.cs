using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_top_tennissertypeRequest : Request
	{
		private Guid entityIdField;
		private Sgt_top_tennissertypeState sgt_top_tennissertypeStateField;
		private int sgt_top_tennissertypeStatusField;
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
		public Sgt_top_tennissertypeState Sgt_top_tennissertypeState
		{
			get
			{
				return this.sgt_top_tennissertypeStateField;
			}
			set
			{
				this.sgt_top_tennissertypeStateField = value;
			}
		}
		public int Sgt_top_tennissertypeStatus
		{
			get
			{
				return this.sgt_top_tennissertypeStatusField;
			}
			set
			{
				this.sgt_top_tennissertypeStatusField = value;
			}
		}
	}
}
