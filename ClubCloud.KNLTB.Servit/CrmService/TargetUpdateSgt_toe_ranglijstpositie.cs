using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_toe_ranglijstpositie : TargetUpdate
	{
		private sgt_toe_ranglijstpositie sgt_toe_ranglijstpositieField;
		public sgt_toe_ranglijstpositie Sgt_toe_ranglijstpositie
		{
			get
			{
				return this.sgt_toe_ranglijstpositieField;
			}
			set
			{
				this.sgt_toe_ranglijstpositieField = value;
			}
		}
	}
}
