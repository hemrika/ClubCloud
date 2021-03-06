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
	public class TargetUpdateSgt_toe_reden_dispensatie_toernooibijdrage : TargetUpdate
	{
		private sgt_toe_reden_dispensatie_toernooibijdrage sgt_toe_reden_dispensatie_toernooibijdrageField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_toe_reden_dispensatie_toernooibijdrage Sgt_toe_reden_dispensatie_toernooibijdrage
		{
			get
			{
				return this.sgt_toe_reden_dispensatie_toernooibijdrageField;
			}
			set
			{
				this.sgt_toe_reden_dispensatie_toernooibijdrageField = value;
				base.RaisePropertyChanged("Sgt_toe_reden_dispensatie_toernooibijdrage");
			}
		}

		public TargetUpdateSgt_toe_reden_dispensatie_toernooibijdrage()
		{
		}
	}
}