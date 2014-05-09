using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_alg_telmethode : TargetUpdate
	{
		private sgt_alg_telmethode sgt_alg_telmethodeField;
		[XmlElement(Order = 0)]
		public sgt_alg_telmethode Sgt_alg_telmethode
		{
			get
			{
				return this.sgt_alg_telmethodeField;
			}
			set
			{
				this.sgt_alg_telmethodeField = value;
				base.RaisePropertyChanged("Sgt_alg_telmethode");
			}
		}
	}
}
