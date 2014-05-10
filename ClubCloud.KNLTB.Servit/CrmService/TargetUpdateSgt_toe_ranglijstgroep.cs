using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_toe_ranglijstgroep : TargetUpdate
	{
		private sgt_toe_ranglijstgroep sgt_toe_ranglijstgroepField;
		public sgt_toe_ranglijstgroep Sgt_toe_ranglijstgroep
		{
			get
			{
				return this.sgt_toe_ranglijstgroepField;
			}
			set
			{
				this.sgt_toe_ranglijstgroepField = value;
			}
		}
	}
}
