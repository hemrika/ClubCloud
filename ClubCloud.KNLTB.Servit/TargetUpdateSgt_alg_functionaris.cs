using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_alg_functionaris : TargetUpdate
	{
		private sgt_alg_functionaris sgt_alg_functionarisField;
		[XmlElement(Order = 0)]
		public sgt_alg_functionaris Sgt_alg_functionaris
		{
			get
			{
				return this.sgt_alg_functionarisField;
			}
			set
			{
				this.sgt_alg_functionarisField = value;
				base.RaisePropertyChanged("Sgt_alg_functionaris");
			}
		}
	}
}
