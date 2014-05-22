using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_com_protest_mutatieRequest : Request
	{
		private Guid entityIdField;
		private Sgt_com_protest_mutatieState sgt_com_protest_mutatieStateField;
		private int sgt_com_protest_mutatieStatusField;
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
		public Sgt_com_protest_mutatieState Sgt_com_protest_mutatieState
		{
			get
			{
				return this.sgt_com_protest_mutatieStateField;
			}
			set
			{
				this.sgt_com_protest_mutatieStateField = value;
			}
		}
		public int Sgt_com_protest_mutatieStatus
		{
			get
			{
				return this.sgt_com_protest_mutatieStatusField;
			}
			set
			{
				this.sgt_com_protest_mutatieStatusField = value;
			}
		}
	}
}