using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_bo_cursist : TargetCreate
	{
		private sgt_bo_cursist sgt_bo_cursistField;
		public sgt_bo_cursist Sgt_bo_cursist
		{
			get
			{
				return this.sgt_bo_cursistField;
			}
			set
			{
				this.sgt_bo_cursistField = value;
			}
		}
	}
}
