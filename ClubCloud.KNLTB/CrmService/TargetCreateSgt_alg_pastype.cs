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
	public class TargetCreateSgt_alg_pastype : TargetCreate
	{
		private sgt_alg_pastype sgt_alg_pastypeField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_alg_pastype Sgt_alg_pastype
		{
			get
			{
				return this.sgt_alg_pastypeField;
			}
			set
			{
				this.sgt_alg_pastypeField = value;
				base.RaisePropertyChanged("Sgt_alg_pastype");
			}
		}

		public TargetCreateSgt_alg_pastype()
		{
		}
	}
}