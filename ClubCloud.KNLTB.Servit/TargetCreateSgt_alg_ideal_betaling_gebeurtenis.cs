using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_alg_ideal_betaling_gebeurtenis : TargetCreate
	{
		private sgt_alg_ideal_betaling_gebeurtenis sgt_alg_ideal_betaling_gebeurtenisField;
		[XmlElement(Order = 0)]
		public sgt_alg_ideal_betaling_gebeurtenis Sgt_alg_ideal_betaling_gebeurtenis
		{
			get
			{
				return this.sgt_alg_ideal_betaling_gebeurtenisField;
			}
			set
			{
				this.sgt_alg_ideal_betaling_gebeurtenisField = value;
				base.RaisePropertyChanged("Sgt_alg_ideal_betaling_gebeurtenis");
			}
		}
	}
}
