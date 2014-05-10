using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_toe_toernooicircuit : TargetUpdate
	{
		private sgt_toe_toernooicircuit sgt_toe_toernooicircuitField;
		public sgt_toe_toernooicircuit Sgt_toe_toernooicircuit
		{
			get
			{
				return this.sgt_toe_toernooicircuitField;
			}
			set
			{
				this.sgt_toe_toernooicircuitField = value;
			}
		}
	}
}
