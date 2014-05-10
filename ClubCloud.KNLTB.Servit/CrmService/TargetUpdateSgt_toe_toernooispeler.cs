using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_toe_toernooispeler : TargetUpdate
	{
		private sgt_toe_toernooispeler sgt_toe_toernooispelerField;
		public sgt_toe_toernooispeler Sgt_toe_toernooispeler
		{
			get
			{
				return this.sgt_toe_toernooispelerField;
			}
			set
			{
				this.sgt_toe_toernooispelerField = value;
			}
		}
	}
}
