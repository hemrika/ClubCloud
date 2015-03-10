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
	public class TargetUpdateSgt_alg_activiteitenplan : TargetUpdate
	{
		private sgt_alg_activiteitenplan sgt_alg_activiteitenplanField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_alg_activiteitenplan Sgt_alg_activiteitenplan
		{
			get
			{
				return this.sgt_alg_activiteitenplanField;
			}
			set
			{
				this.sgt_alg_activiteitenplanField = value;
				base.RaisePropertyChanged("Sgt_alg_activiteitenplan");
			}
		}

		public TargetUpdateSgt_alg_activiteitenplan()
		{
		}
	}
}