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
	public class TargetUpdateSgt_com_verenigingsdispensatie : TargetUpdate
	{
		private sgt_com_verenigingsdispensatie sgt_com_verenigingsdispensatieField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_com_verenigingsdispensatie Sgt_com_verenigingsdispensatie
		{
			get
			{
				return this.sgt_com_verenigingsdispensatieField;
			}
			set
			{
				this.sgt_com_verenigingsdispensatieField = value;
				base.RaisePropertyChanged("Sgt_com_verenigingsdispensatie");
			}
		}

		public TargetUpdateSgt_com_verenigingsdispensatie()
		{
		}
	}
}