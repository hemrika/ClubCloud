using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_toe_bericht_inschrijving_vereniging : TargetCreate
	{
		private sgt_toe_bericht_inschrijving_vereniging sgt_toe_bericht_inschrijving_verenigingField;
		public sgt_toe_bericht_inschrijving_vereniging Sgt_toe_bericht_inschrijving_vereniging
		{
			get
			{
				return this.sgt_toe_bericht_inschrijving_verenigingField;
			}
			set
			{
				this.sgt_toe_bericht_inschrijving_verenigingField = value;
			}
		}
	}
}