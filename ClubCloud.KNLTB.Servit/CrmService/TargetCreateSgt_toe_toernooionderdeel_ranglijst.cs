using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_toe_toernooionderdeel_ranglijst : TargetCreate
	{
		private sgt_toe_toernooionderdeel_ranglijst sgt_toe_toernooionderdeel_ranglijstField;
		public sgt_toe_toernooionderdeel_ranglijst Sgt_toe_toernooionderdeel_ranglijst
		{
			get
			{
				return this.sgt_toe_toernooionderdeel_ranglijstField;
			}
			set
			{
				this.sgt_toe_toernooionderdeel_ranglijstField = value;
			}
		}
	}
}
