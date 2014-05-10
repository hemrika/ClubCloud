using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_com_deelname_niet_knltb_lidRequest : Request
	{
		private Guid entityIdField;
		private Sgt_com_deelname_niet_knltb_lidState sgt_com_deelname_niet_knltb_lidStateField;
		private int sgt_com_deelname_niet_knltb_lidStatusField;
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
		public Sgt_com_deelname_niet_knltb_lidState Sgt_com_deelname_niet_knltb_lidState
		{
			get
			{
				return this.sgt_com_deelname_niet_knltb_lidStateField;
			}
			set
			{
				this.sgt_com_deelname_niet_knltb_lidStateField = value;
			}
		}
		public int Sgt_com_deelname_niet_knltb_lidStatus
		{
			get
			{
				return this.sgt_com_deelname_niet_knltb_lidStatusField;
			}
			set
			{
				this.sgt_com_deelname_niet_knltb_lidStatusField = value;
			}
		}
	}
}
