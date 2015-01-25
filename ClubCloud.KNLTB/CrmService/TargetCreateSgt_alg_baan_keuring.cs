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
	public class TargetCreateSgt_alg_baan_keuring : TargetCreate
	{
		private sgt_alg_baan_keuring sgt_alg_baan_keuringField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_alg_baan_keuring Sgt_alg_baan_keuring
		{
			get
			{
				return this.sgt_alg_baan_keuringField;
			}
			set
			{
				this.sgt_alg_baan_keuringField = value;
				base.RaisePropertyChanged("Sgt_alg_baan_keuring");
			}
		}

		public TargetCreateSgt_alg_baan_keuring()
		{
		}
	}
}