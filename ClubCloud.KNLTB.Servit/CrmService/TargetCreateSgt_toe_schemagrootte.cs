using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_toe_schemagrootte : TargetCreate
	{
		private sgt_toe_schemagrootte sgt_toe_schemagrootteField;
		public sgt_toe_schemagrootte Sgt_toe_schemagrootte
		{
			get
			{
				return this.sgt_toe_schemagrootteField;
			}
			set
			{
				this.sgt_toe_schemagrootteField = value;
			}
		}
	}
}
