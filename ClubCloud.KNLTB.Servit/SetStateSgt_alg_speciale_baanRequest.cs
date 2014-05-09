using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_speciale_baanRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_speciale_baanState sgt_alg_speciale_baanStateField;
		private int sgt_alg_speciale_baanStatusField;
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
		public Sgt_alg_speciale_baanState Sgt_alg_speciale_baanState
		{
			get
			{
				return this.sgt_alg_speciale_baanStateField;
			}
			set
			{
				this.sgt_alg_speciale_baanStateField = value;
				base.RaisePropertyChanged("Sgt_alg_speciale_baanState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_alg_speciale_baanStatus
		{
			get
			{
				return this.sgt_alg_speciale_baanStatusField;
			}
			set
			{
				this.sgt_alg_speciale_baanStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_speciale_baanStatus");
			}
		}
	}
}
