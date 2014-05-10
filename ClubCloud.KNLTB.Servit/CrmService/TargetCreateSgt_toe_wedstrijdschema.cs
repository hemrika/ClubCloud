using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_toe_wedstrijdschema : TargetCreate
	{
		private sgt_toe_wedstrijdschema sgt_toe_wedstrijdschemaField;
		public sgt_toe_wedstrijdschema Sgt_toe_wedstrijdschema
		{
			get
			{
				return this.sgt_toe_wedstrijdschemaField;
			}
			set
			{
				this.sgt_toe_wedstrijdschemaField = value;
			}
		}
	}
}
