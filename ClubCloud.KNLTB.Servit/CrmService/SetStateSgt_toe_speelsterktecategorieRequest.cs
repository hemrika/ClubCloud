using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_speelsterktecategorieRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_speelsterktecategorieState sgt_toe_speelsterktecategorieStateField;
		private int sgt_toe_speelsterktecategorieStatusField;
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
		public Sgt_toe_speelsterktecategorieState Sgt_toe_speelsterktecategorieState
		{
			get
			{
				return this.sgt_toe_speelsterktecategorieStateField;
			}
			set
			{
				this.sgt_toe_speelsterktecategorieStateField = value;
			}
		}
		public int Sgt_toe_speelsterktecategorieStatus
		{
			get
			{
				return this.sgt_toe_speelsterktecategorieStatusField;
			}
			set
			{
				this.sgt_toe_speelsterktecategorieStatusField = value;
			}
		}
	}
}
