using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_verzendwijzeRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_verzendwijzeState sgt_alg_verzendwijzeStateField;
		private int sgt_alg_verzendwijzeStatusField;
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
		public Sgt_alg_verzendwijzeState Sgt_alg_verzendwijzeState
		{
			get
			{
				return this.sgt_alg_verzendwijzeStateField;
			}
			set
			{
				this.sgt_alg_verzendwijzeStateField = value;
				base.RaisePropertyChanged("Sgt_alg_verzendwijzeState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_alg_verzendwijzeStatus
		{
			get
			{
				return this.sgt_alg_verzendwijzeStatusField;
			}
			set
			{
				this.sgt_alg_verzendwijzeStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_verzendwijzeStatus");
			}
		}
	}
}
