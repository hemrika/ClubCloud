using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_dynamicform : TargetCreate
	{
		private sgt_dynamicform sgt_dynamicformField;
		public sgt_dynamicform Sgt_dynamicform
		{
			get
			{
				return this.sgt_dynamicformField;
			}
			set
			{
				this.sgt_dynamicformField = value;
			}
		}
	}
}
