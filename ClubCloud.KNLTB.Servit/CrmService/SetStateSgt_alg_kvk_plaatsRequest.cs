using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_kvk_plaatsRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_kvk_plaatsState sgt_alg_kvk_plaatsStateField;
		private int sgt_alg_kvk_plaatsStatusField;
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
		public Sgt_alg_kvk_plaatsState Sgt_alg_kvk_plaatsState
		{
			get
			{
				return this.sgt_alg_kvk_plaatsStateField;
			}
			set
			{
				this.sgt_alg_kvk_plaatsStateField = value;
			}
		}
		public int Sgt_alg_kvk_plaatsStatus
		{
			get
			{
				return this.sgt_alg_kvk_plaatsStatusField;
			}
			set
			{
				this.sgt_alg_kvk_plaatsStatusField = value;
			}
		}
	}
}
