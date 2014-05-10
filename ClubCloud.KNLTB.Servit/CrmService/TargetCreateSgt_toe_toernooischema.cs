using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_toe_toernooischema : TargetCreate
	{
		private sgt_toe_toernooischema sgt_toe_toernooischemaField;
		public sgt_toe_toernooischema Sgt_toe_toernooischema
		{
			get
			{
				return this.sgt_toe_toernooischemaField;
			}
			set
			{
				this.sgt_toe_toernooischemaField = value;
			}
		}
	}
}
