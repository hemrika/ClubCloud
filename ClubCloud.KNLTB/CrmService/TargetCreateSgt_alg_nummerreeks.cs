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
	public class TargetCreateSgt_alg_nummerreeks : TargetCreate
	{
		private sgt_alg_nummerreeks sgt_alg_nummerreeksField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_alg_nummerreeks Sgt_alg_nummerreeks
		{
			get
			{
				return this.sgt_alg_nummerreeksField;
			}
			set
			{
				this.sgt_alg_nummerreeksField = value;
				base.RaisePropertyChanged("Sgt_alg_nummerreeks");
			}
		}

		public TargetCreateSgt_alg_nummerreeks()
		{
		}
	}
}