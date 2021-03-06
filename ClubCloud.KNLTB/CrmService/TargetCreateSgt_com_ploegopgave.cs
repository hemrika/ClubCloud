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
	public class TargetCreateSgt_com_ploegopgave : TargetCreate
	{
		private sgt_com_ploegopgave sgt_com_ploegopgaveField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_com_ploegopgave Sgt_com_ploegopgave
		{
			get
			{
				return this.sgt_com_ploegopgaveField;
			}
			set
			{
				this.sgt_com_ploegopgaveField = value;
				base.RaisePropertyChanged("Sgt_com_ploegopgave");
			}
		}

		public TargetCreateSgt_com_ploegopgave()
		{
		}
	}
}