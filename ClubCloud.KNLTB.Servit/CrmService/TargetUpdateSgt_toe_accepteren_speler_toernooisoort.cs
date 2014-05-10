using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_toe_accepteren_speler_toernooisoort : TargetUpdate
	{
		private sgt_toe_accepteren_speler_toernooisoort sgt_toe_accepteren_speler_toernooisoortField;
		public sgt_toe_accepteren_speler_toernooisoort Sgt_toe_accepteren_speler_toernooisoort
		{
			get
			{
				return this.sgt_toe_accepteren_speler_toernooisoortField;
			}
			set
			{
				this.sgt_toe_accepteren_speler_toernooisoortField = value;
			}
		}
	}
}
