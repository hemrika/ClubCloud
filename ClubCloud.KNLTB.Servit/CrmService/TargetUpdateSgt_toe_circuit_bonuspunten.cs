using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_toe_circuit_bonuspunten : TargetUpdate
	{
		private sgt_toe_circuit_bonuspunten sgt_toe_circuit_bonuspuntenField;
		public sgt_toe_circuit_bonuspunten Sgt_toe_circuit_bonuspunten
		{
			get
			{
				return this.sgt_toe_circuit_bonuspuntenField;
			}
			set
			{
				this.sgt_toe_circuit_bonuspuntenField = value;
			}
		}
	}
}
