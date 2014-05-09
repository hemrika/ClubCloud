using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_record_lock_maintenanceRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_record_lock_maintenanceState sgt_alg_record_lock_maintenanceStateField;
		private int sgt_alg_record_lock_maintenanceStatusField;
		[XmlElement(Order = 0)]
		public Guid EntityId
		{
			get
			{
				return this.entityIdField;
			}
			set
			{
				this.entityIdField = value;
				base.RaisePropertyChanged("EntityId");
			}
		}
		[XmlElement(Order = 1)]
		public Sgt_alg_record_lock_maintenanceState Sgt_alg_record_lock_maintenanceState
		{
			get
			{
				return this.sgt_alg_record_lock_maintenanceStateField;
			}
			set
			{
				this.sgt_alg_record_lock_maintenanceStateField = value;
				base.RaisePropertyChanged("Sgt_alg_record_lock_maintenanceState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_alg_record_lock_maintenanceStatus
		{
			get
			{
				return this.sgt_alg_record_lock_maintenanceStatusField;
			}
			set
			{
				this.sgt_alg_record_lock_maintenanceStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_record_lock_maintenanceStatus");
			}
		}
	}
}
