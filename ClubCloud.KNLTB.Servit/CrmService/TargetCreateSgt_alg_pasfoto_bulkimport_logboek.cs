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
	public class TargetCreateSgt_alg_pasfoto_bulkimport_logboek : TargetCreate
	{
		private sgt_alg_pasfoto_bulkimport_logboek sgt_alg_pasfoto_bulkimport_logboekField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_alg_pasfoto_bulkimport_logboek Sgt_alg_pasfoto_bulkimport_logboek
		{
			get
			{
				return this.sgt_alg_pasfoto_bulkimport_logboekField;
			}
			set
			{
				this.sgt_alg_pasfoto_bulkimport_logboekField = value;
				base.RaisePropertyChanged("Sgt_alg_pasfoto_bulkimport_logboek");
			}
		}

		public TargetCreateSgt_alg_pasfoto_bulkimport_logboek()
		{
		}
	}
}