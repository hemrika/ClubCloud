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
	public class TargetUpdateSgt_toe_circuit_deelgetal : TargetUpdate
	{
		private sgt_toe_circuit_deelgetal sgt_toe_circuit_deelgetalField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_toe_circuit_deelgetal Sgt_toe_circuit_deelgetal
		{
			get
			{
				return this.sgt_toe_circuit_deelgetalField;
			}
			set
			{
				this.sgt_toe_circuit_deelgetalField = value;
				base.RaisePropertyChanged("Sgt_toe_circuit_deelgetal");
			}
		}

		public TargetUpdateSgt_toe_circuit_deelgetal()
		{
		}
	}
}