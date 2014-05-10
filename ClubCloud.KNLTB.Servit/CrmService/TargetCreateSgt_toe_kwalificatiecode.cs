using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_toe_kwalificatiecode : TargetCreate
	{
		private sgt_toe_kwalificatiecode sgt_toe_kwalificatiecodeField;
		public sgt_toe_kwalificatiecode Sgt_toe_kwalificatiecode
		{
			get
			{
				return this.sgt_toe_kwalificatiecodeField;
			}
			set
			{
				this.sgt_toe_kwalificatiecodeField = value;
			}
		}
	}
}
