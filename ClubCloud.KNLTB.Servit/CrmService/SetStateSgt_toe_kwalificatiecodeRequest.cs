using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_kwalificatiecodeRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_kwalificatiecodeState sgt_toe_kwalificatiecodeStateField;
		private int sgt_toe_kwalificatiecodeStatusField;
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
		public Sgt_toe_kwalificatiecodeState Sgt_toe_kwalificatiecodeState
		{
			get
			{
				return this.sgt_toe_kwalificatiecodeStateField;
			}
			set
			{
				this.sgt_toe_kwalificatiecodeStateField = value;
			}
		}
		public int Sgt_toe_kwalificatiecodeStatus
		{
			get
			{
				return this.sgt_toe_kwalificatiecodeStatusField;
			}
			set
			{
				this.sgt_toe_kwalificatiecodeStatusField = value;
			}
		}
	}
}
