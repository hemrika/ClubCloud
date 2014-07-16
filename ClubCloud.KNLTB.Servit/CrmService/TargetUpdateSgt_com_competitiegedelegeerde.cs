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
	public class TargetUpdateSgt_com_competitiegedelegeerde : TargetUpdate
	{
		private sgt_com_competitiegedelegeerde sgt_com_competitiegedelegeerdeField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_com_competitiegedelegeerde Sgt_com_competitiegedelegeerde
		{
			get
			{
				return this.sgt_com_competitiegedelegeerdeField;
			}
			set
			{
				this.sgt_com_competitiegedelegeerdeField = value;
				base.RaisePropertyChanged("Sgt_com_competitiegedelegeerde");
			}
		}

		public TargetUpdateSgt_com_competitiegedelegeerde()
		{
		}
	}
}