using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_toe_leeftijdscategorie : TargetUpdate
	{
		private sgt_toe_leeftijdscategorie sgt_toe_leeftijdscategorieField;
		public sgt_toe_leeftijdscategorie Sgt_toe_leeftijdscategorie
		{
			get
			{
				return this.sgt_toe_leeftijdscategorieField;
			}
			set
			{
				this.sgt_toe_leeftijdscategorieField = value;
			}
		}
	}
}
