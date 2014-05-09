using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_toe_straf : TargetUpdate
	{
		private sgt_toe_straf sgt_toe_strafField;
		[XmlElement(Order = 0)]
		public sgt_toe_straf Sgt_toe_straf
		{
			get
			{
				return this.sgt_toe_strafField;
			}
			set
			{
				this.sgt_toe_strafField = value;
				base.RaisePropertyChanged("Sgt_toe_straf");
			}
		}
	}
}
