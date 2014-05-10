using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_wt_opleidingsfase : TargetUpdate
	{
		private sgt_wt_opleidingsfase sgt_wt_opleidingsfaseField;
		public sgt_wt_opleidingsfase Sgt_wt_opleidingsfase
		{
			get
			{
				return this.sgt_wt_opleidingsfaseField;
			}
			set
			{
				this.sgt_wt_opleidingsfaseField = value;
			}
		}
	}
}
