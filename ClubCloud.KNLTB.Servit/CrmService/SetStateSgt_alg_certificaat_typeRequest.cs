using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_certificaat_typeRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_certificaat_typeState sgt_alg_certificaat_typeStateField;
		private int sgt_alg_certificaat_typeStatusField;
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
		public Sgt_alg_certificaat_typeState Sgt_alg_certificaat_typeState
		{
			get
			{
				return this.sgt_alg_certificaat_typeStateField;
			}
			set
			{
				this.sgt_alg_certificaat_typeStateField = value;
			}
		}
		public int Sgt_alg_certificaat_typeStatus
		{
			get
			{
				return this.sgt_alg_certificaat_typeStatusField;
			}
			set
			{
				this.sgt_alg_certificaat_typeStatusField = value;
			}
		}
	}
}
