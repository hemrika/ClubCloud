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
	public class TargetCreateSgt_com_controle_dispensatie : TargetCreate
	{
		private sgt_com_controle_dispensatie sgt_com_controle_dispensatieField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_com_controle_dispensatie Sgt_com_controle_dispensatie
		{
			get
			{
				return this.sgt_com_controle_dispensatieField;
			}
			set
			{
				this.sgt_com_controle_dispensatieField = value;
				base.RaisePropertyChanged("Sgt_com_controle_dispensatie");
			}
		}

		public TargetCreateSgt_com_controle_dispensatie()
		{
		}
	}
}