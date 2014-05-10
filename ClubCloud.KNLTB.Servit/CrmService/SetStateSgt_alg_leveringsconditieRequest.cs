using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_leveringsconditieRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_leveringsconditieState sgt_alg_leveringsconditieStateField;
		private int sgt_alg_leveringsconditieStatusField;
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
		public Sgt_alg_leveringsconditieState Sgt_alg_leveringsconditieState
		{
			get
			{
				return this.sgt_alg_leveringsconditieStateField;
			}
			set
			{
				this.sgt_alg_leveringsconditieStateField = value;
			}
		}
		public int Sgt_alg_leveringsconditieStatus
		{
			get
			{
				return this.sgt_alg_leveringsconditieStatusField;
			}
			set
			{
				this.sgt_alg_leveringsconditieStatusField = value;
			}
		}
	}
}
