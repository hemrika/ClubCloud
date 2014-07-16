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
	public class TargetCreateSgt_alg_type_bestuursorgaan : TargetCreate
	{
		private sgt_alg_type_bestuursorgaan sgt_alg_type_bestuursorgaanField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_alg_type_bestuursorgaan Sgt_alg_type_bestuursorgaan
		{
			get
			{
				return this.sgt_alg_type_bestuursorgaanField;
			}
			set
			{
				this.sgt_alg_type_bestuursorgaanField = value;
				base.RaisePropertyChanged("Sgt_alg_type_bestuursorgaan");
			}
		}

		public TargetCreateSgt_alg_type_bestuursorgaan()
		{
		}
	}
}