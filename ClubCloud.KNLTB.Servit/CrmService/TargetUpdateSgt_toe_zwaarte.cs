using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_toe_zwaarte : TargetUpdate
	{
		private sgt_toe_zwaarte sgt_toe_zwaarteField;
		public sgt_toe_zwaarte Sgt_toe_zwaarte
		{
			get
			{
				return this.sgt_toe_zwaarteField;
			}
			set
			{
				this.sgt_toe_zwaarteField = value;
			}
		}
	}
}
