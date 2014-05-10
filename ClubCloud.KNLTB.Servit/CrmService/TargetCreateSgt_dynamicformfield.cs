using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_dynamicformfield : TargetCreate
	{
		private sgt_dynamicformfield sgt_dynamicformfieldField;
		public sgt_dynamicformfield Sgt_dynamicformfield
		{
			get
			{
				return this.sgt_dynamicformfieldField;
			}
			set
			{
				this.sgt_dynamicformfieldField = value;
			}
		}
	}
}
