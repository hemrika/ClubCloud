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
	public class TargetUpdateSgt_alg_kenmerk : TargetUpdate
	{
		private sgt_alg_kenmerk sgt_alg_kenmerkField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_alg_kenmerk Sgt_alg_kenmerk
		{
			get
			{
				return this.sgt_alg_kenmerkField;
			}
			set
			{
				this.sgt_alg_kenmerkField = value;
				base.RaisePropertyChanged("Sgt_alg_kenmerk");
			}
		}

		public TargetUpdateSgt_alg_kenmerk()
		{
		}
	}
}