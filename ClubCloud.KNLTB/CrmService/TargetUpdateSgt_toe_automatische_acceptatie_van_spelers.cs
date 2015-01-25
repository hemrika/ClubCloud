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
	public class TargetUpdateSgt_toe_automatische_acceptatie_van_spelers : TargetUpdate
	{
		private sgt_toe_automatische_acceptatie_van_spelers sgt_toe_automatische_acceptatie_van_spelersField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_toe_automatische_acceptatie_van_spelers Sgt_toe_automatische_acceptatie_van_spelers
		{
			get
			{
				return this.sgt_toe_automatische_acceptatie_van_spelersField;
			}
			set
			{
				this.sgt_toe_automatische_acceptatie_van_spelersField = value;
				base.RaisePropertyChanged("Sgt_toe_automatische_acceptatie_van_spelers");
			}
		}

		public TargetUpdateSgt_toe_automatische_acceptatie_van_spelers()
		{
		}
	}
}