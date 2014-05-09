using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_alg_btw_code : TargetUpdate
	{
		private sgt_alg_btw_code sgt_alg_btw_codeField;
		[XmlElement(Order = 0)]
		public sgt_alg_btw_code Sgt_alg_btw_code
		{
			get
			{
				return this.sgt_alg_btw_codeField;
			}
			set
			{
				this.sgt_alg_btw_codeField = value;
				base.RaisePropertyChanged("Sgt_alg_btw_code");
			}
		}
	}
}
