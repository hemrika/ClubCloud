using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_dynamicformentity : TargetCreate
	{
		private sgt_dynamicformentity sgt_dynamicformentityField;
		public sgt_dynamicformentity Sgt_dynamicformentity
		{
			get
			{
				return this.sgt_dynamicformentityField;
			}
			set
			{
				this.sgt_dynamicformentityField = value;
			}
		}
	}
}
