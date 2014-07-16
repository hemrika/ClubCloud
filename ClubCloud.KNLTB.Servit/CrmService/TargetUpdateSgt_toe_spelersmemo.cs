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
	public class TargetUpdateSgt_toe_spelersmemo : TargetUpdate
	{
		private sgt_toe_spelersmemo sgt_toe_spelersmemoField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_toe_spelersmemo Sgt_toe_spelersmemo
		{
			get
			{
				return this.sgt_toe_spelersmemoField;
			}
			set
			{
				this.sgt_toe_spelersmemoField = value;
				base.RaisePropertyChanged("Sgt_toe_spelersmemo");
			}
		}

		public TargetUpdateSgt_toe_spelersmemo()
		{
		}
	}
}