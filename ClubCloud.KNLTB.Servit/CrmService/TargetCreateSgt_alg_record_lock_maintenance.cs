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
	public class TargetCreateSgt_alg_record_lock_maintenance : TargetCreate
	{
		private sgt_alg_record_lock_maintenance sgt_alg_record_lock_maintenanceField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_alg_record_lock_maintenance Sgt_alg_record_lock_maintenance
		{
			get
			{
				return this.sgt_alg_record_lock_maintenanceField;
			}
			set
			{
				this.sgt_alg_record_lock_maintenanceField = value;
				base.RaisePropertyChanged("Sgt_alg_record_lock_maintenance");
			}
		}

		public TargetCreateSgt_alg_record_lock_maintenance()
		{
		}
	}
}