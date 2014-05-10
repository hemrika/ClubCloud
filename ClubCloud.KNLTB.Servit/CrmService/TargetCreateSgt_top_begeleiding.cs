using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_top_begeleiding : TargetCreate
	{
		private sgt_top_begeleiding sgt_top_begeleidingField;
		public sgt_top_begeleiding Sgt_top_begeleiding
		{
			get
			{
				return this.sgt_top_begeleidingField;
			}
			set
			{
				this.sgt_top_begeleidingField = value;
			}
		}
	}
}
