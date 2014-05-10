using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_toernooionderdeelgeneratorRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_toernooionderdeelgeneratorState sgt_toe_toernooionderdeelgeneratorStateField;
		private int sgt_toe_toernooionderdeelgeneratorStatusField;
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
		public Sgt_toe_toernooionderdeelgeneratorState Sgt_toe_toernooionderdeelgeneratorState
		{
			get
			{
				return this.sgt_toe_toernooionderdeelgeneratorStateField;
			}
			set
			{
				this.sgt_toe_toernooionderdeelgeneratorStateField = value;
			}
		}
		public int Sgt_toe_toernooionderdeelgeneratorStatus
		{
			get
			{
				return this.sgt_toe_toernooionderdeelgeneratorStatusField;
			}
			set
			{
				this.sgt_toe_toernooionderdeelgeneratorStatusField = value;
			}
		}
	}
}
