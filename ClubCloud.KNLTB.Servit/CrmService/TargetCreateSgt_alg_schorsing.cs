using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_alg_schorsing : TargetCreate
	{
		private sgt_alg_schorsing sgt_alg_schorsingField;
		public sgt_alg_schorsing Sgt_alg_schorsing
		{
			get
			{
				return this.sgt_alg_schorsingField;
			}
			set
			{
				this.sgt_alg_schorsingField = value;
			}
		}
	}
}
