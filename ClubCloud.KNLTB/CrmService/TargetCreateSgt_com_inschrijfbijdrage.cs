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
	public class TargetCreateSgt_com_inschrijfbijdrage : TargetCreate
	{
		private sgt_com_inschrijfbijdrage sgt_com_inschrijfbijdrageField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_com_inschrijfbijdrage Sgt_com_inschrijfbijdrage
		{
			get
			{
				return this.sgt_com_inschrijfbijdrageField;
			}
			set
			{
				this.sgt_com_inschrijfbijdrageField = value;
				base.RaisePropertyChanged("Sgt_com_inschrijfbijdrage");
			}
		}

		public TargetCreateSgt_com_inschrijfbijdrage()
		{
		}
	}
}