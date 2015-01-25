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
	public class TargetCreateSgt_bo_logboek_ecampus_resultaten : TargetCreate
	{
		private sgt_bo_logboek_ecampus_resultaten sgt_bo_logboek_ecampus_resultatenField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_bo_logboek_ecampus_resultaten Sgt_bo_logboek_ecampus_resultaten
		{
			get
			{
				return this.sgt_bo_logboek_ecampus_resultatenField;
			}
			set
			{
				this.sgt_bo_logboek_ecampus_resultatenField = value;
				base.RaisePropertyChanged("Sgt_bo_logboek_ecampus_resultaten");
			}
		}

		public TargetCreateSgt_bo_logboek_ecampus_resultaten()
		{
		}
	}
}