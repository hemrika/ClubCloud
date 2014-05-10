using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_bo_tennisleraar : TargetCreate
	{
		private sgt_bo_tennisleraar sgt_bo_tennisleraarField;
		public sgt_bo_tennisleraar Sgt_bo_tennisleraar
		{
			get
			{
				return this.sgt_bo_tennisleraarField;
			}
			set
			{
				this.sgt_bo_tennisleraarField = value;
			}
		}
	}
}
