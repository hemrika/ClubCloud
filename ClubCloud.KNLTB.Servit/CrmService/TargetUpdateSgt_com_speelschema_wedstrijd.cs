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
	public class TargetUpdateSgt_com_speelschema_wedstrijd : TargetUpdate
	{
		private sgt_com_speelschema_wedstrijd sgt_com_speelschema_wedstrijdField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_com_speelschema_wedstrijd Sgt_com_speelschema_wedstrijd
		{
			get
			{
				return this.sgt_com_speelschema_wedstrijdField;
			}
			set
			{
				this.sgt_com_speelschema_wedstrijdField = value;
				base.RaisePropertyChanged("Sgt_com_speelschema_wedstrijd");
			}
		}

		public TargetUpdateSgt_com_speelschema_wedstrijd()
		{
		}
	}
}