using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_top_groep : TargetCreate
	{
		private sgt_top_groep sgt_top_groepField;
		public sgt_top_groep Sgt_top_groep
		{
			get
			{
				return this.sgt_top_groepField;
			}
			set
			{
				this.sgt_top_groepField = value;
			}
		}
	}
}
