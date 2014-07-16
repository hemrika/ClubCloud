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
	public class TargetUpdateSgt_bo_soort_examen : TargetUpdate
	{
		private sgt_bo_soort_examen sgt_bo_soort_examenField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_bo_soort_examen Sgt_bo_soort_examen
		{
			get
			{
				return this.sgt_bo_soort_examenField;
			}
			set
			{
				this.sgt_bo_soort_examenField = value;
				base.RaisePropertyChanged("Sgt_bo_soort_examen");
			}
		}

		public TargetUpdateSgt_bo_soort_examen()
		{
		}
	}
}