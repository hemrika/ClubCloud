using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_toe_post_in : TargetCreate
	{
		private sgt_toe_post_in sgt_toe_post_inField;
		public sgt_toe_post_in Sgt_toe_post_in
		{
			get
			{
				return this.sgt_toe_post_inField;
			}
			set
			{
				this.sgt_toe_post_inField = value;
			}
		}
	}
}
