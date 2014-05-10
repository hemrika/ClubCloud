using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_toe_basisschema : TargetCreate
	{
		private sgt_toe_basisschema sgt_toe_basisschemaField;
		public sgt_toe_basisschema Sgt_toe_basisschema
		{
			get
			{
				return this.sgt_toe_basisschemaField;
			}
			set
			{
				this.sgt_toe_basisschemaField = value;
			}
		}
	}
}
