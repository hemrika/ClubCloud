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
	public class TargetUpdateSgt_toe_circuit_toernooionderdeel : TargetUpdate
	{
		private sgt_toe_circuit_toernooionderdeel sgt_toe_circuit_toernooionderdeelField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_toe_circuit_toernooionderdeel Sgt_toe_circuit_toernooionderdeel
		{
			get
			{
				return this.sgt_toe_circuit_toernooionderdeelField;
			}
			set
			{
				this.sgt_toe_circuit_toernooionderdeelField = value;
				base.RaisePropertyChanged("Sgt_toe_circuit_toernooionderdeel");
			}
		}

		public TargetUpdateSgt_toe_circuit_toernooionderdeel()
		{
		}
	}
}