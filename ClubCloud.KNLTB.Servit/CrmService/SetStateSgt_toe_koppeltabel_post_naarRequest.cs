using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_koppeltabel_post_naarRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_koppeltabel_post_naarState sgt_toe_koppeltabel_post_naarStateField;
		private int sgt_toe_koppeltabel_post_naarStatusField;
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
		public Sgt_toe_koppeltabel_post_naarState Sgt_toe_koppeltabel_post_naarState
		{
			get
			{
				return this.sgt_toe_koppeltabel_post_naarStateField;
			}
			set
			{
				this.sgt_toe_koppeltabel_post_naarStateField = value;
			}
		}
		public int Sgt_toe_koppeltabel_post_naarStatus
		{
			get
			{
				return this.sgt_toe_koppeltabel_post_naarStatusField;
			}
			set
			{
				this.sgt_toe_koppeltabel_post_naarStatusField = value;
			}
		}
	}
}
