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
	public class TargetCreateSgt_alg_gebeurtenis : TargetCreate
	{
		private sgt_alg_gebeurtenis sgt_alg_gebeurtenisField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_alg_gebeurtenis Sgt_alg_gebeurtenis
		{
			get
			{
				return this.sgt_alg_gebeurtenisField;
			}
			set
			{
				this.sgt_alg_gebeurtenisField = value;
				base.RaisePropertyChanged("Sgt_alg_gebeurtenis");
			}
		}

		public TargetCreateSgt_alg_gebeurtenis()
		{
		}
	}
}