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
	public class TargetCreateSgt_toe_leeftijdscategorie : TargetCreate
	{
		private sgt_toe_leeftijdscategorie sgt_toe_leeftijdscategorieField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_toe_leeftijdscategorie Sgt_toe_leeftijdscategorie
		{
			get
			{
				return this.sgt_toe_leeftijdscategorieField;
			}
			set
			{
				this.sgt_toe_leeftijdscategorieField = value;
				base.RaisePropertyChanged("Sgt_toe_leeftijdscategorie");
			}
		}

		public TargetCreateSgt_toe_leeftijdscategorie()
		{
		}
	}
}