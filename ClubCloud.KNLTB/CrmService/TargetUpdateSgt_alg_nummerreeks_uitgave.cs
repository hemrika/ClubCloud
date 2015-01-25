using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[GeneratedCode("System.Xml", "4.0.30319.33440")]
	[Serializable]
	[XmlType(Namespace="http://schemas.microsoft.com/crm/2007/WebServices")]
	public class TargetUpdateSgt_alg_nummerreeks_uitgave : TargetUpdate
	{
		private sgt_alg_nummerreeks_uitgave sgt_alg_nummerreeks_uitgaveField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_alg_nummerreeks_uitgave Sgt_alg_nummerreeks_uitgave
		{
			get
			{
				return this.sgt_alg_nummerreeks_uitgaveField;
			}
			set
			{
				this.sgt_alg_nummerreeks_uitgaveField = value;
				base.RaisePropertyChanged("Sgt_alg_nummerreeks_uitgave");
			}
		}

		public TargetUpdateSgt_alg_nummerreeks_uitgave()
		{
		}
	}
}