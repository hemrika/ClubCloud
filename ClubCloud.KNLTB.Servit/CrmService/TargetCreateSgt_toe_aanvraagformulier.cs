using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_toe_aanvraagformulier : TargetCreate
	{
		private sgt_toe_aanvraagformulier sgt_toe_aanvraagformulierField;
		public sgt_toe_aanvraagformulier Sgt_toe_aanvraagformulier
		{
			get
			{
				return this.sgt_toe_aanvraagformulierField;
			}
			set
			{
				this.sgt_toe_aanvraagformulierField = value;
			}
		}
	}
}
