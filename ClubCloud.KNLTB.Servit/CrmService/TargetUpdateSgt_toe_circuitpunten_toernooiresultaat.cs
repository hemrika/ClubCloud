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
	public class TargetUpdateSgt_toe_circuitpunten_toernooiresultaat : TargetUpdate
	{
		private sgt_toe_circuitpunten_toernooiresultaat sgt_toe_circuitpunten_toernooiresultaatField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_toe_circuitpunten_toernooiresultaat Sgt_toe_circuitpunten_toernooiresultaat
		{
			get
			{
				return this.sgt_toe_circuitpunten_toernooiresultaatField;
			}
			set
			{
				this.sgt_toe_circuitpunten_toernooiresultaatField = value;
				base.RaisePropertyChanged("Sgt_toe_circuitpunten_toernooiresultaat");
			}
		}

		public TargetUpdateSgt_toe_circuitpunten_toernooiresultaat()
		{
		}
	}
}