using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_toe_circuit_toernooionderdeel : TargetUpdate
	{
		private sgt_toe_circuit_toernooionderdeel sgt_toe_circuit_toernooionderdeelField;
		public sgt_toe_circuit_toernooionderdeel Sgt_toe_circuit_toernooionderdeel
		{
			get
			{
				return this.sgt_toe_circuit_toernooionderdeelField;
			}
			set
			{
				this.sgt_toe_circuit_toernooionderdeelField = value;
			}
		}
	}
}
