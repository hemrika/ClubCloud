using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_functieRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_functieState sgt_alg_functieStateField;
		private int sgt_alg_functieStatusField;
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
		public Sgt_alg_functieState Sgt_alg_functieState
		{
			get
			{
				return this.sgt_alg_functieStateField;
			}
			set
			{
				this.sgt_alg_functieStateField = value;
				base.RaisePropertyChanged("Sgt_alg_functieState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_alg_functieStatus
		{
			get
			{
				return this.sgt_alg_functieStatusField;
			}
			set
			{
				this.sgt_alg_functieStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_functieStatus");
			}
		}
	}
}
