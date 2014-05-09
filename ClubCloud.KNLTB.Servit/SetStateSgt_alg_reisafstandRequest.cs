using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_reisafstandRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_reisafstandState sgt_alg_reisafstandStateField;
		private int sgt_alg_reisafstandStatusField;
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
		public Sgt_alg_reisafstandState Sgt_alg_reisafstandState
		{
			get
			{
				return this.sgt_alg_reisafstandStateField;
			}
			set
			{
				this.sgt_alg_reisafstandStateField = value;
				base.RaisePropertyChanged("Sgt_alg_reisafstandState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_alg_reisafstandStatus
		{
			get
			{
				return this.sgt_alg_reisafstandStatusField;
			}
			set
			{
				this.sgt_alg_reisafstandStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_reisafstandStatus");
			}
		}
	}
}
