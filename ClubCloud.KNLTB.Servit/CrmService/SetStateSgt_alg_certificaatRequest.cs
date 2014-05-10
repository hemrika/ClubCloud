using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_certificaatRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_certificaatState sgt_alg_certificaatStateField;
		private int sgt_alg_certificaatStatusField;
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
		public Sgt_alg_certificaatState Sgt_alg_certificaatState
		{
			get
			{
				return this.sgt_alg_certificaatStateField;
			}
			set
			{
				this.sgt_alg_certificaatStateField = value;
			}
		}
		public int Sgt_alg_certificaatStatus
		{
			get
			{
				return this.sgt_alg_certificaatStatusField;
			}
			set
			{
				this.sgt_alg_certificaatStatusField = value;
			}
		}
	}
}
