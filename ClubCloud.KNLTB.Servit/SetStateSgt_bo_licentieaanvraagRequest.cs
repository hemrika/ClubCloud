using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_bo_licentieaanvraagRequest : Request
	{
		private Guid entityIdField;
		private Sgt_bo_licentieaanvraagState sgt_bo_licentieaanvraagStateField;
		private int sgt_bo_licentieaanvraagStatusField;
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
		public Sgt_bo_licentieaanvraagState Sgt_bo_licentieaanvraagState
		{
			get
			{
				return this.sgt_bo_licentieaanvraagStateField;
			}
			set
			{
				this.sgt_bo_licentieaanvraagStateField = value;
				base.RaisePropertyChanged("Sgt_bo_licentieaanvraagState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_bo_licentieaanvraagStatus
		{
			get
			{
				return this.sgt_bo_licentieaanvraagStatusField;
			}
			set
			{
				this.sgt_bo_licentieaanvraagStatusField = value;
				base.RaisePropertyChanged("Sgt_bo_licentieaanvraagStatus");
			}
		}
	}
}
