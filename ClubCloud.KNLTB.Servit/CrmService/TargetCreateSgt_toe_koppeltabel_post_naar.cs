using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_toe_koppeltabel_post_naar : TargetCreate
	{
		private sgt_toe_koppeltabel_post_naar sgt_toe_koppeltabel_post_naarField;
		public sgt_toe_koppeltabel_post_naar Sgt_toe_koppeltabel_post_naar
		{
			get
			{
				return this.sgt_toe_koppeltabel_post_naarField;
			}
			set
			{
				this.sgt_toe_koppeltabel_post_naarField = value;
			}
		}
	}
}
