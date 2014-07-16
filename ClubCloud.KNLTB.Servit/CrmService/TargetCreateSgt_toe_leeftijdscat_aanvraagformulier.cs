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
	public class TargetCreateSgt_toe_leeftijdscat_aanvraagformulier : TargetCreate
	{
		private sgt_toe_leeftijdscat_aanvraagformulier sgt_toe_leeftijdscat_aanvraagformulierField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_toe_leeftijdscat_aanvraagformulier Sgt_toe_leeftijdscat_aanvraagformulier
		{
			get
			{
				return this.sgt_toe_leeftijdscat_aanvraagformulierField;
			}
			set
			{
				this.sgt_toe_leeftijdscat_aanvraagformulierField = value;
				base.RaisePropertyChanged("Sgt_toe_leeftijdscat_aanvraagformulier");
			}
		}

		public TargetCreateSgt_toe_leeftijdscat_aanvraagformulier()
		{
		}
	}
}