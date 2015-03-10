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
	public class TargetCreateSgt_alg_btw_code : TargetCreate
	{
		private sgt_alg_btw_code sgt_alg_btw_codeField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_alg_btw_code Sgt_alg_btw_code
		{
			get
			{
				return this.sgt_alg_btw_codeField;
			}
			set
			{
				this.sgt_alg_btw_codeField = value;
				base.RaisePropertyChanged("Sgt_alg_btw_code");
			}
		}

		public TargetCreateSgt_alg_btw_code()
		{
		}
	}
}