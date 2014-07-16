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
	public class TargetUpdateSgt_autorisatie_entiteit_gekoppeld : TargetUpdate
	{
		private sgt_autorisatie_entiteit_gekoppeld sgt_autorisatie_entiteit_gekoppeldField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_autorisatie_entiteit_gekoppeld Sgt_autorisatie_entiteit_gekoppeld
		{
			get
			{
				return this.sgt_autorisatie_entiteit_gekoppeldField;
			}
			set
			{
				this.sgt_autorisatie_entiteit_gekoppeldField = value;
				base.RaisePropertyChanged("Sgt_autorisatie_entiteit_gekoppeld");
			}
		}

		public TargetUpdateSgt_autorisatie_entiteit_gekoppeld()
		{
		}
	}
}