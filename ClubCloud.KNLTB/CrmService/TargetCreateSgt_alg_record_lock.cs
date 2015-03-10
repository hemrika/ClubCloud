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
	public class TargetCreateSgt_alg_record_lock : TargetCreate
	{
		private sgt_alg_record_lock sgt_alg_record_lockField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_alg_record_lock Sgt_alg_record_lock
		{
			get
			{
				return this.sgt_alg_record_lockField;
			}
			set
			{
				this.sgt_alg_record_lockField = value;
				base.RaisePropertyChanged("Sgt_alg_record_lock");
			}
		}

		public TargetCreateSgt_alg_record_lock()
		{
		}
	}
}