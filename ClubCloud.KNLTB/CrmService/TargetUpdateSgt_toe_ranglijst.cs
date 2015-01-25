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
	public class TargetUpdateSgt_toe_ranglijst : TargetUpdate
	{
		private sgt_toe_ranglijst sgt_toe_ranglijstField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_toe_ranglijst Sgt_toe_ranglijst
		{
			get
			{
				return this.sgt_toe_ranglijstField;
			}
			set
			{
				this.sgt_toe_ranglijstField = value;
				base.RaisePropertyChanged("Sgt_toe_ranglijst");
			}
		}

		public TargetUpdateSgt_toe_ranglijst()
		{
		}
	}
}