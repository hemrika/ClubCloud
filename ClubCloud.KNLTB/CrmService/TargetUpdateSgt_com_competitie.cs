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
	public class TargetUpdateSgt_com_competitie : TargetUpdate
	{
		private sgt_com_competitie sgt_com_competitieField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_com_competitie Sgt_com_competitie
		{
			get
			{
				return this.sgt_com_competitieField;
			}
			set
			{
				this.sgt_com_competitieField = value;
				base.RaisePropertyChanged("Sgt_com_competitie");
			}
		}

		public TargetUpdateSgt_com_competitie()
		{
		}
	}
}