using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_accommodatieRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_accommodatieState sgt_alg_accommodatieStateField;
		private int sgt_alg_accommodatieStatusField;
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
		public Sgt_alg_accommodatieState Sgt_alg_accommodatieState
		{
			get
			{
				return this.sgt_alg_accommodatieStateField;
			}
			set
			{
				this.sgt_alg_accommodatieStateField = value;
				base.RaisePropertyChanged("Sgt_alg_accommodatieState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_alg_accommodatieStatus
		{
			get
			{
				return this.sgt_alg_accommodatieStatusField;
			}
			set
			{
				this.sgt_alg_accommodatieStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_accommodatieStatus");
			}
		}
	}
}
