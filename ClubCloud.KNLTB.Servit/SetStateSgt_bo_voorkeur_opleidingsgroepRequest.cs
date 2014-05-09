using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_bo_voorkeur_opleidingsgroepRequest : Request
	{
		private Guid entityIdField;
		private Sgt_bo_voorkeur_opleidingsgroepState sgt_bo_voorkeur_opleidingsgroepStateField;
		private int sgt_bo_voorkeur_opleidingsgroepStatusField;
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
		public Sgt_bo_voorkeur_opleidingsgroepState Sgt_bo_voorkeur_opleidingsgroepState
		{
			get
			{
				return this.sgt_bo_voorkeur_opleidingsgroepStateField;
			}
			set
			{
				this.sgt_bo_voorkeur_opleidingsgroepStateField = value;
				base.RaisePropertyChanged("Sgt_bo_voorkeur_opleidingsgroepState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_bo_voorkeur_opleidingsgroepStatus
		{
			get
			{
				return this.sgt_bo_voorkeur_opleidingsgroepStatusField;
			}
			set
			{
				this.sgt_bo_voorkeur_opleidingsgroepStatusField = value;
				base.RaisePropertyChanged("Sgt_bo_voorkeur_opleidingsgroepStatus");
			}
		}
	}
}
