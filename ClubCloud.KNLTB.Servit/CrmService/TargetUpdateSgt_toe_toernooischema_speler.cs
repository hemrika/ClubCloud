using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_toe_toernooischema_speler : TargetUpdate
	{
		private sgt_toe_toernooischema_speler sgt_toe_toernooischema_spelerField;
		public sgt_toe_toernooischema_speler Sgt_toe_toernooischema_speler
		{
			get
			{
				return this.sgt_toe_toernooischema_spelerField;
			}
			set
			{
				this.sgt_toe_toernooischema_spelerField = value;
			}
		}
	}
}