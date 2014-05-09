using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_bo_voorkeur_testdagRequest : Request
	{
		private Guid entityIdField;
		private Sgt_bo_voorkeur_testdagState sgt_bo_voorkeur_testdagStateField;
		private int sgt_bo_voorkeur_testdagStatusField;
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
		public Sgt_bo_voorkeur_testdagState Sgt_bo_voorkeur_testdagState
		{
			get
			{
				return this.sgt_bo_voorkeur_testdagStateField;
			}
			set
			{
				this.sgt_bo_voorkeur_testdagStateField = value;
				base.RaisePropertyChanged("Sgt_bo_voorkeur_testdagState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_bo_voorkeur_testdagStatus
		{
			get
			{
				return this.sgt_bo_voorkeur_testdagStatusField;
			}
			set
			{
				this.sgt_bo_voorkeur_testdagStatusField = value;
				base.RaisePropertyChanged("Sgt_bo_voorkeur_testdagStatus");
			}
		}
	}
}
