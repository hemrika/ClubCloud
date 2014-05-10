using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_toe_circuit_deelgetal : TargetUpdate
	{
		private sgt_toe_circuit_deelgetal sgt_toe_circuit_deelgetalField;
		public sgt_toe_circuit_deelgetal Sgt_toe_circuit_deelgetal
		{
			get
			{
				return this.sgt_toe_circuit_deelgetalField;
			}
			set
			{
				this.sgt_toe_circuit_deelgetalField = value;
			}
		}
	}
}
