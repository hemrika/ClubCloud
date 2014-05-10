using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_wt_inschrijfformulier_vcl_vtlRequest : Request
	{
		private Guid entityIdField;
		private Sgt_wt_inschrijfformulier_vcl_vtlState sgt_wt_inschrijfformulier_vcl_vtlStateField;
		private int sgt_wt_inschrijfformulier_vcl_vtlStatusField;
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
		public Sgt_wt_inschrijfformulier_vcl_vtlState Sgt_wt_inschrijfformulier_vcl_vtlState
		{
			get
			{
				return this.sgt_wt_inschrijfformulier_vcl_vtlStateField;
			}
			set
			{
				this.sgt_wt_inschrijfformulier_vcl_vtlStateField = value;
			}
		}
		public int Sgt_wt_inschrijfformulier_vcl_vtlStatus
		{
			get
			{
				return this.sgt_wt_inschrijfformulier_vcl_vtlStatusField;
			}
			set
			{
				this.sgt_wt_inschrijfformulier_vcl_vtlStatusField = value;
			}
		}
	}
}
