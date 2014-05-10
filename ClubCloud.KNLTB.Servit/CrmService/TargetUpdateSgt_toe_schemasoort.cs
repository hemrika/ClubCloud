using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_toe_schemasoort : TargetUpdate
	{
		private sgt_toe_schemasoort sgt_toe_schemasoortField;
		public sgt_toe_schemasoort Sgt_toe_schemasoort
		{
			get
			{
				return this.sgt_toe_schemasoortField;
			}
			set
			{
				this.sgt_toe_schemasoortField = value;
			}
		}
	}
}
