using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_rol_bij_functieRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_rol_bij_functieState sgt_alg_rol_bij_functieStateField;
		private int sgt_alg_rol_bij_functieStatusField;
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
		public Sgt_alg_rol_bij_functieState Sgt_alg_rol_bij_functieState
		{
			get
			{
				return this.sgt_alg_rol_bij_functieStateField;
			}
			set
			{
				this.sgt_alg_rol_bij_functieStateField = value;
				base.RaisePropertyChanged("Sgt_alg_rol_bij_functieState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_alg_rol_bij_functieStatus
		{
			get
			{
				return this.sgt_alg_rol_bij_functieStatusField;
			}
			set
			{
				this.sgt_alg_rol_bij_functieStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_rol_bij_functieStatus");
			}
		}
	}
}
