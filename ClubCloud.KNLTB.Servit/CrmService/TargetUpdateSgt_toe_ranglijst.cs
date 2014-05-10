using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_toe_ranglijst : TargetUpdate
	{
		private sgt_toe_ranglijst sgt_toe_ranglijstField;
		public sgt_toe_ranglijst Sgt_toe_ranglijst
		{
			get
			{
				return this.sgt_toe_ranglijstField;
			}
			set
			{
				this.sgt_toe_ranglijstField = value;
			}
		}
	}
}
