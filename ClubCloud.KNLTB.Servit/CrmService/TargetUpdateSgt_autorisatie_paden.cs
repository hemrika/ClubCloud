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
	public class TargetUpdateSgt_autorisatie_paden : TargetUpdate
	{
		private sgt_autorisatie_paden sgt_autorisatie_padenField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_autorisatie_paden Sgt_autorisatie_paden
		{
			get
			{
				return this.sgt_autorisatie_padenField;
			}
			set
			{
				this.sgt_autorisatie_padenField = value;
				base.RaisePropertyChanged("Sgt_autorisatie_paden");
			}
		}

		public TargetUpdateSgt_autorisatie_paden()
		{
		}
	}
}