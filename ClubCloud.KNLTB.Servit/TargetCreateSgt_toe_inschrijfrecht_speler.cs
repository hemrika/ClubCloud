using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_toe_inschrijfrecht_speler : TargetCreate
	{
		private sgt_toe_inschrijfrecht_speler sgt_toe_inschrijfrecht_spelerField;
		[XmlElement(Order = 0)]
		public sgt_toe_inschrijfrecht_speler Sgt_toe_inschrijfrecht_speler
		{
			get
			{
				return this.sgt_toe_inschrijfrecht_spelerField;
			}
			set
			{
				this.sgt_toe_inschrijfrecht_spelerField = value;
				base.RaisePropertyChanged("Sgt_toe_inschrijfrecht_speler");
			}
		}
	}
}
