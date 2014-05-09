using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_abonneeRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_abonneeState sgt_alg_abonneeStateField;
		private int sgt_alg_abonneeStatusField;
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
		public Sgt_alg_abonneeState Sgt_alg_abonneeState
		{
			get
			{
				return this.sgt_alg_abonneeStateField;
			}
			set
			{
				this.sgt_alg_abonneeStateField = value;
				base.RaisePropertyChanged("Sgt_alg_abonneeState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_alg_abonneeStatus
		{
			get
			{
				return this.sgt_alg_abonneeStatusField;
			}
			set
			{
				this.sgt_alg_abonneeStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_abonneeStatus");
			}
		}
	}
}
