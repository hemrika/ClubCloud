using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_functionarisRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_functionarisState sgt_alg_functionarisStateField;
		private int sgt_alg_functionarisStatusField;
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
		public Sgt_alg_functionarisState Sgt_alg_functionarisState
		{
			get
			{
				return this.sgt_alg_functionarisStateField;
			}
			set
			{
				this.sgt_alg_functionarisStateField = value;
				base.RaisePropertyChanged("Sgt_alg_functionarisState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_alg_functionarisStatus
		{
			get
			{
				return this.sgt_alg_functionarisStatusField;
			}
			set
			{
				this.sgt_alg_functionarisStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_functionarisStatus");
			}
		}
	}
}
