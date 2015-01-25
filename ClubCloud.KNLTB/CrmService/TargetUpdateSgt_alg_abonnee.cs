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
	public class TargetUpdateSgt_alg_abonnee : TargetUpdate
	{
		private sgt_alg_abonnee sgt_alg_abonneeField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_alg_abonnee Sgt_alg_abonnee
		{
			get
			{
				return this.sgt_alg_abonneeField;
			}
			set
			{
				this.sgt_alg_abonneeField = value;
				base.RaisePropertyChanged("Sgt_alg_abonnee");
			}
		}

		public TargetUpdateSgt_alg_abonnee()
		{
		}
	}
}