using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_toe_circuitpunten_toernooiresultaat : TargetCreate
	{
		private sgt_toe_circuitpunten_toernooiresultaat sgt_toe_circuitpunten_toernooiresultaatField;
		public sgt_toe_circuitpunten_toernooiresultaat Sgt_toe_circuitpunten_toernooiresultaat
		{
			get
			{
				return this.sgt_toe_circuitpunten_toernooiresultaatField;
			}
			set
			{
				this.sgt_toe_circuitpunten_toernooiresultaatField = value;
			}
		}
	}
}
