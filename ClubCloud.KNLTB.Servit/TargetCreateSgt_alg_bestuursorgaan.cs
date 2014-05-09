using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_alg_bestuursorgaan : TargetCreate
	{
		private sgt_alg_bestuursorgaan sgt_alg_bestuursorgaanField;
		[XmlElement(Order = 0)]
		public sgt_alg_bestuursorgaan Sgt_alg_bestuursorgaan
		{
			get
			{
				return this.sgt_alg_bestuursorgaanField;
			}
			set
			{
				this.sgt_alg_bestuursorgaanField = value;
				base.RaisePropertyChanged("Sgt_alg_bestuursorgaan");
			}
		}
	}
}
