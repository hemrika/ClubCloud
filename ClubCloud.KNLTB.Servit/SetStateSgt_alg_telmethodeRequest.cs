using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_telmethodeRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_telmethodeState sgt_alg_telmethodeStateField;
		private int sgt_alg_telmethodeStatusField;
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
		public Sgt_alg_telmethodeState Sgt_alg_telmethodeState
		{
			get
			{
				return this.sgt_alg_telmethodeStateField;
			}
			set
			{
				this.sgt_alg_telmethodeStateField = value;
				base.RaisePropertyChanged("Sgt_alg_telmethodeState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_alg_telmethodeStatus
		{
			get
			{
				return this.sgt_alg_telmethodeStatusField;
			}
			set
			{
				this.sgt_alg_telmethodeStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_telmethodeStatus");
			}
		}
	}
}
