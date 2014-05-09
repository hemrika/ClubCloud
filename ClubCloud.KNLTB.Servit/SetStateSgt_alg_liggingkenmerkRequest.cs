using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_liggingkenmerkRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_liggingkenmerkState sgt_alg_liggingkenmerkStateField;
		private int sgt_alg_liggingkenmerkStatusField;
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
		public Sgt_alg_liggingkenmerkState Sgt_alg_liggingkenmerkState
		{
			get
			{
				return this.sgt_alg_liggingkenmerkStateField;
			}
			set
			{
				this.sgt_alg_liggingkenmerkStateField = value;
				base.RaisePropertyChanged("Sgt_alg_liggingkenmerkState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_alg_liggingkenmerkStatus
		{
			get
			{
				return this.sgt_alg_liggingkenmerkStatusField;
			}
			set
			{
				this.sgt_alg_liggingkenmerkStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_liggingkenmerkStatus");
			}
		}
	}
}
