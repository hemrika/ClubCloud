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
	public class TargetCreateSgt_alg_rol_bij_functie : TargetCreate
	{
		private sgt_alg_rol_bij_functie sgt_alg_rol_bij_functieField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_alg_rol_bij_functie Sgt_alg_rol_bij_functie
		{
			get
			{
				return this.sgt_alg_rol_bij_functieField;
			}
			set
			{
				this.sgt_alg_rol_bij_functieField = value;
				base.RaisePropertyChanged("Sgt_alg_rol_bij_functie");
			}
		}

		public TargetCreateSgt_alg_rol_bij_functie()
		{
		}
	}
}