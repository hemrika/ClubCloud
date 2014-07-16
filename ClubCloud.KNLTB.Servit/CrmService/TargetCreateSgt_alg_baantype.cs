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
	public class TargetCreateSgt_alg_baantype : TargetCreate
	{
		private sgt_alg_baantype sgt_alg_baantypeField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_alg_baantype Sgt_alg_baantype
		{
			get
			{
				return this.sgt_alg_baantypeField;
			}
			set
			{
				this.sgt_alg_baantypeField = value;
				base.RaisePropertyChanged("Sgt_alg_baantype");
			}
		}

		public TargetCreateSgt_alg_baantype()
		{
		}
	}
}