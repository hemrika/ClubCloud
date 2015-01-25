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
	public class TargetUpdateSgt_com_ploeg : TargetUpdate
	{
		private sgt_com_ploeg sgt_com_ploegField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_com_ploeg Sgt_com_ploeg
		{
			get
			{
				return this.sgt_com_ploegField;
			}
			set
			{
				this.sgt_com_ploegField = value;
				base.RaisePropertyChanged("Sgt_com_ploeg");
			}
		}

		public TargetUpdateSgt_com_ploeg()
		{
		}
	}
}