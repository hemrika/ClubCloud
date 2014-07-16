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
	public class TargetUpdateSgt_toe_zwaarte : TargetUpdate
	{
		private sgt_toe_zwaarte sgt_toe_zwaarteField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_toe_zwaarte Sgt_toe_zwaarte
		{
			get
			{
				return this.sgt_toe_zwaarteField;
			}
			set
			{
				this.sgt_toe_zwaarteField = value;
				base.RaisePropertyChanged("Sgt_toe_zwaarte");
			}
		}

		public TargetUpdateSgt_toe_zwaarte()
		{
		}
	}
}