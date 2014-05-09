using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_arb_arbitragebehoefte_toernooien : TargetCreate
	{
		private sgt_arb_arbitragebehoefte_toernooien sgt_arb_arbitragebehoefte_toernooienField;
		[XmlElement(Order = 0)]
		public sgt_arb_arbitragebehoefte_toernooien Sgt_arb_arbitragebehoefte_toernooien
		{
			get
			{
				return this.sgt_arb_arbitragebehoefte_toernooienField;
			}
			set
			{
				this.sgt_arb_arbitragebehoefte_toernooienField = value;
				base.RaisePropertyChanged("Sgt_arb_arbitragebehoefte_toernooien");
			}
		}
	}
}
