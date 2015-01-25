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
	public class TargetCreateSgt_alg_persoonlijke_relatie : TargetCreate
	{
		private sgt_alg_persoonlijke_relatie sgt_alg_persoonlijke_relatieField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_alg_persoonlijke_relatie Sgt_alg_persoonlijke_relatie
		{
			get
			{
				return this.sgt_alg_persoonlijke_relatieField;
			}
			set
			{
				this.sgt_alg_persoonlijke_relatieField = value;
				base.RaisePropertyChanged("Sgt_alg_persoonlijke_relatie");
			}
		}

		public TargetCreateSgt_alg_persoonlijke_relatie()
		{
		}
	}
}