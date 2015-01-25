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
	public class TargetCreateSgt_com_ingedeelde_ploeg : TargetCreate
	{
		private sgt_com_ingedeelde_ploeg sgt_com_ingedeelde_ploegField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_com_ingedeelde_ploeg Sgt_com_ingedeelde_ploeg
		{
			get
			{
				return this.sgt_com_ingedeelde_ploegField;
			}
			set
			{
				this.sgt_com_ingedeelde_ploegField = value;
				base.RaisePropertyChanged("Sgt_com_ingedeelde_ploeg");
			}
		}

		public TargetCreateSgt_com_ingedeelde_ploeg()
		{
		}
	}
}