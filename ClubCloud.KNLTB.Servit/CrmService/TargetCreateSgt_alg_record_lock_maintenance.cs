using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_alg_record_lock_maintenance : TargetCreate
	{
		private sgt_alg_record_lock_maintenance sgt_alg_record_lock_maintenanceField;
		public sgt_alg_record_lock_maintenance Sgt_alg_record_lock_maintenance
		{
			get
			{
				return this.sgt_alg_record_lock_maintenanceField;
			}
			set
			{
				this.sgt_alg_record_lock_maintenanceField = value;
			}
		}
	}
}
