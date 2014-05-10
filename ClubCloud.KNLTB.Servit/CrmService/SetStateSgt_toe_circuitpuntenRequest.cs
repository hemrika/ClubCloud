using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_circuitpuntenRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_circuitpuntenState sgt_toe_circuitpuntenStateField;
		private int sgt_toe_circuitpuntenStatusField;
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
		public Sgt_toe_circuitpuntenState Sgt_toe_circuitpuntenState
		{
			get
			{
				return this.sgt_toe_circuitpuntenStateField;
			}
			set
			{
				this.sgt_toe_circuitpuntenStateField = value;
			}
		}
		public int Sgt_toe_circuitpuntenStatus
		{
			get
			{
				return this.sgt_toe_circuitpuntenStatusField;
			}
			set
			{
				this.sgt_toe_circuitpuntenStatusField = value;
			}
		}
	}
}
