using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_toe_reden_dispensatie_toernooibijdrage : TargetCreate
	{
		private sgt_toe_reden_dispensatie_toernooibijdrage sgt_toe_reden_dispensatie_toernooibijdrageField;
		public sgt_toe_reden_dispensatie_toernooibijdrage Sgt_toe_reden_dispensatie_toernooibijdrage
		{
			get
			{
				return this.sgt_toe_reden_dispensatie_toernooibijdrageField;
			}
			set
			{
				this.sgt_toe_reden_dispensatie_toernooibijdrageField = value;
			}
		}
	}
}
