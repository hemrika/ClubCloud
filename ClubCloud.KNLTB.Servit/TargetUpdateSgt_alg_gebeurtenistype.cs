using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_alg_gebeurtenistype : TargetUpdate
	{
		private sgt_alg_gebeurtenistype sgt_alg_gebeurtenistypeField;
		[XmlElement(Order = 0)]
		public sgt_alg_gebeurtenistype Sgt_alg_gebeurtenistype
		{
			get
			{
				return this.sgt_alg_gebeurtenistypeField;
			}
			set
			{
				this.sgt_alg_gebeurtenistypeField = value;
				base.RaisePropertyChanged("Sgt_alg_gebeurtenistype");
			}
		}
	}
}
