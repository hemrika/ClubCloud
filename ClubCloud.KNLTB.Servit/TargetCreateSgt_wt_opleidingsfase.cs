using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_wt_opleidingsfase : TargetCreate
	{
		private sgt_wt_opleidingsfase sgt_wt_opleidingsfaseField;
		[XmlElement(Order = 0)]
		public sgt_wt_opleidingsfase Sgt_wt_opleidingsfase
		{
			get
			{
				return this.sgt_wt_opleidingsfaseField;
			}
			set
			{
				this.sgt_wt_opleidingsfaseField = value;
				base.RaisePropertyChanged("Sgt_wt_opleidingsfase");
			}
		}
	}
}
