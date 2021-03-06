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
	public class TargetUpdateSgt_com_competitierecht : TargetUpdate
	{
		private sgt_com_competitierecht sgt_com_competitierechtField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_com_competitierecht Sgt_com_competitierecht
		{
			get
			{
				return this.sgt_com_competitierechtField;
			}
			set
			{
				this.sgt_com_competitierechtField = value;
				base.RaisePropertyChanged("Sgt_com_competitierecht");
			}
		}

		public TargetUpdateSgt_com_competitierecht()
		{
		}
	}
}