using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_toe_special_exempt : TargetCreate
	{
		private sgt_toe_special_exempt sgt_toe_special_exemptField;
		public sgt_toe_special_exempt Sgt_toe_special_exempt
		{
			get
			{
				return this.sgt_toe_special_exemptField;
			}
			set
			{
				this.sgt_toe_special_exemptField = value;
			}
		}
	}
}
