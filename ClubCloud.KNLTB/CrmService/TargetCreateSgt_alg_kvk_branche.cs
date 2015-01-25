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
	public class TargetCreateSgt_alg_kvk_branche : TargetCreate
	{
		private sgt_alg_kvk_branche sgt_alg_kvk_brancheField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_alg_kvk_branche Sgt_alg_kvk_branche
		{
			get
			{
				return this.sgt_alg_kvk_brancheField;
			}
			set
			{
				this.sgt_alg_kvk_brancheField = value;
				base.RaisePropertyChanged("Sgt_alg_kvk_branche");
			}
		}

		public TargetCreateSgt_alg_kvk_branche()
		{
		}
	}
}