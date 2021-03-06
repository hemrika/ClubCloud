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
	public class TargetCreateSgt_toe_circuit_bonuspunten : TargetCreate
	{
		private sgt_toe_circuit_bonuspunten sgt_toe_circuit_bonuspuntenField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_toe_circuit_bonuspunten Sgt_toe_circuit_bonuspunten
		{
			get
			{
				return this.sgt_toe_circuit_bonuspuntenField;
			}
			set
			{
				this.sgt_toe_circuit_bonuspuntenField = value;
				base.RaisePropertyChanged("Sgt_toe_circuit_bonuspunten");
			}
		}

		public TargetCreateSgt_toe_circuit_bonuspunten()
		{
		}
	}
}