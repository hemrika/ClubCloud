using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_pastypeRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_pastypeState sgt_alg_pastypeStateField;
		private int sgt_alg_pastypeStatusField;
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
		public Sgt_alg_pastypeState Sgt_alg_pastypeState
		{
			get
			{
				return this.sgt_alg_pastypeStateField;
			}
			set
			{
				this.sgt_alg_pastypeStateField = value;
				base.RaisePropertyChanged("Sgt_alg_pastypeState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_alg_pastypeStatus
		{
			get
			{
				return this.sgt_alg_pastypeStatusField;
			}
			set
			{
				this.sgt_alg_pastypeStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_pastypeStatus");
			}
		}
	}
}
