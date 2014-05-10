using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_administratieve_overtreding_mutatieRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_administratieve_overtreding_mutatieState sgt_toe_administratieve_overtreding_mutatieStateField;
		private int sgt_toe_administratieve_overtreding_mutatieStatusField;
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
		public Sgt_toe_administratieve_overtreding_mutatieState Sgt_toe_administratieve_overtreding_mutatieState
		{
			get
			{
				return this.sgt_toe_administratieve_overtreding_mutatieStateField;
			}
			set
			{
				this.sgt_toe_administratieve_overtreding_mutatieStateField = value;
			}
		}
		public int Sgt_toe_administratieve_overtreding_mutatieStatus
		{
			get
			{
				return this.sgt_toe_administratieve_overtreding_mutatieStatusField;
			}
			set
			{
				this.sgt_toe_administratieve_overtreding_mutatieStatusField = value;
			}
		}
	}
}
