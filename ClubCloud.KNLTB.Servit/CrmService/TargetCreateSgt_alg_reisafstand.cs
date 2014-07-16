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
	public class TargetCreateSgt_alg_reisafstand : TargetCreate
	{
		private sgt_alg_reisafstand sgt_alg_reisafstandField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_alg_reisafstand Sgt_alg_reisafstand
		{
			get
			{
				return this.sgt_alg_reisafstandField;
			}
			set
			{
				this.sgt_alg_reisafstandField = value;
				base.RaisePropertyChanged("Sgt_alg_reisafstand");
			}
		}

		public TargetCreateSgt_alg_reisafstand()
		{
		}
	}
}