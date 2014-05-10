using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_toe_inschrijfmethode_per_toernooisoort : TargetCreate
	{
		private sgt_toe_inschrijfmethode_per_toernooisoort sgt_toe_inschrijfmethode_per_toernooisoortField;
		public sgt_toe_inschrijfmethode_per_toernooisoort Sgt_toe_inschrijfmethode_per_toernooisoort
		{
			get
			{
				return this.sgt_toe_inschrijfmethode_per_toernooisoortField;
			}
			set
			{
				this.sgt_toe_inschrijfmethode_per_toernooisoortField = value;
			}
		}
	}
}
