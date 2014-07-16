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
	public class TargetCreateSgt_alg_schorsing : TargetCreate
	{
		private sgt_alg_schorsing sgt_alg_schorsingField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_alg_schorsing Sgt_alg_schorsing
		{
			get
			{
				return this.sgt_alg_schorsingField;
			}
			set
			{
				this.sgt_alg_schorsingField = value;
				base.RaisePropertyChanged("Sgt_alg_schorsing");
			}
		}

		public TargetCreateSgt_alg_schorsing()
		{
		}
	}
}