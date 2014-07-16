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
	public class TargetUpdateSgt_toe_ranglijstpositie : TargetUpdate
	{
		private sgt_toe_ranglijstpositie sgt_toe_ranglijstpositieField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_toe_ranglijstpositie Sgt_toe_ranglijstpositie
		{
			get
			{
				return this.sgt_toe_ranglijstpositieField;
			}
			set
			{
				this.sgt_toe_ranglijstpositieField = value;
				base.RaisePropertyChanged("Sgt_toe_ranglijstpositie");
			}
		}

		public TargetUpdateSgt_toe_ranglijstpositie()
		{
		}
	}
}