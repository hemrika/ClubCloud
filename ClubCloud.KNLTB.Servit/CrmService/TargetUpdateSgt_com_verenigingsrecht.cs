using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_com_verenigingsrecht : TargetUpdate
	{
		private sgt_com_verenigingsrecht sgt_com_verenigingsrechtField;
		public sgt_com_verenigingsrecht Sgt_com_verenigingsrecht
		{
			get
			{
				return this.sgt_com_verenigingsrechtField;
			}
			set
			{
				this.sgt_com_verenigingsrechtField = value;
			}
		}
	}
}
