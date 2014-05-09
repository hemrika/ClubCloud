using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_ledenpas_lidRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_ledenpas_lidState sgt_alg_ledenpas_lidStateField;
		private int sgt_alg_ledenpas_lidStatusField;
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
		public Sgt_alg_ledenpas_lidState Sgt_alg_ledenpas_lidState
		{
			get
			{
				return this.sgt_alg_ledenpas_lidStateField;
			}
			set
			{
				this.sgt_alg_ledenpas_lidStateField = value;
				base.RaisePropertyChanged("Sgt_alg_ledenpas_lidState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_alg_ledenpas_lidStatus
		{
			get
			{
				return this.sgt_alg_ledenpas_lidStatusField;
			}
			set
			{
				this.sgt_alg_ledenpas_lidStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_ledenpas_lidStatus");
			}
		}
	}
}
