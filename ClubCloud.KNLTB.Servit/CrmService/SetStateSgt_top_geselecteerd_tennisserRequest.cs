using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_top_geselecteerd_tennisserRequest : Request
	{
		private Guid entityIdField;
		private Sgt_top_geselecteerd_tennisserState sgt_top_geselecteerd_tennisserStateField;
		private int sgt_top_geselecteerd_tennisserStatusField;
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
		public Sgt_top_geselecteerd_tennisserState Sgt_top_geselecteerd_tennisserState
		{
			get
			{
				return this.sgt_top_geselecteerd_tennisserStateField;
			}
			set
			{
				this.sgt_top_geselecteerd_tennisserStateField = value;
			}
		}
		public int Sgt_top_geselecteerd_tennisserStatus
		{
			get
			{
				return this.sgt_top_geselecteerd_tennisserStatusField;
			}
			set
			{
				this.sgt_top_geselecteerd_tennisserStatusField = value;
			}
		}
	}
}
