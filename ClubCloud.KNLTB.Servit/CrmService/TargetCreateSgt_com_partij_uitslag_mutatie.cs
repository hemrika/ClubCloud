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
	public class TargetCreateSgt_com_partij_uitslag_mutatie : TargetCreate
	{
		private sgt_com_partij_uitslag_mutatie sgt_com_partij_uitslag_mutatieField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_com_partij_uitslag_mutatie Sgt_com_partij_uitslag_mutatie
		{
			get
			{
				return this.sgt_com_partij_uitslag_mutatieField;
			}
			set
			{
				this.sgt_com_partij_uitslag_mutatieField = value;
				base.RaisePropertyChanged("Sgt_com_partij_uitslag_mutatie");
			}
		}

		public TargetCreateSgt_com_partij_uitslag_mutatie()
		{
		}
	}
}