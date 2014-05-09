using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_reset_passwordRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_reset_passwordState sgt_alg_reset_passwordStateField;
		private int sgt_alg_reset_passwordStatusField;
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
		public Sgt_alg_reset_passwordState Sgt_alg_reset_passwordState
		{
			get
			{
				return this.sgt_alg_reset_passwordStateField;
			}
			set
			{
				this.sgt_alg_reset_passwordStateField = value;
				base.RaisePropertyChanged("Sgt_alg_reset_passwordState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_alg_reset_passwordStatus
		{
			get
			{
				return this.sgt_alg_reset_passwordStatusField;
			}
			set
			{
				this.sgt_alg_reset_passwordStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_reset_passwordStatus");
			}
		}
	}
}
