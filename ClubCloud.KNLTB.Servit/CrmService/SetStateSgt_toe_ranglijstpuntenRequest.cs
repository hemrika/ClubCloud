using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_ranglijstpuntenRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_ranglijstpuntenState sgt_toe_ranglijstpuntenStateField;
		private int sgt_toe_ranglijstpuntenStatusField;
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
		public Sgt_toe_ranglijstpuntenState Sgt_toe_ranglijstpuntenState
		{
			get
			{
				return this.sgt_toe_ranglijstpuntenStateField;
			}
			set
			{
				this.sgt_toe_ranglijstpuntenStateField = value;
			}
		}
		public int Sgt_toe_ranglijstpuntenStatus
		{
			get
			{
				return this.sgt_toe_ranglijstpuntenStatusField;
			}
			set
			{
				this.sgt_toe_ranglijstpuntenStatusField = value;
			}
		}
	}
}
