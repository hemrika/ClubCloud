using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_alg_baansoort : TargetCreate
	{
		private sgt_alg_baansoort sgt_alg_baansoortField;
		[XmlElement(Order = 0)]
		public sgt_alg_baansoort Sgt_alg_baansoort
		{
			get
			{
				return this.sgt_alg_baansoortField;
			}
			set
			{
				this.sgt_alg_baansoortField = value;
				base.RaisePropertyChanged("Sgt_alg_baansoort");
			}
		}
	}
}
