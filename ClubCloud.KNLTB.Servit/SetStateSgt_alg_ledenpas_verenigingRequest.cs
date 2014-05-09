using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_ledenpas_verenigingRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_ledenpas_verenigingState sgt_alg_ledenpas_verenigingStateField;
		private int sgt_alg_ledenpas_verenigingStatusField;
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
		public Sgt_alg_ledenpas_verenigingState Sgt_alg_ledenpas_verenigingState
		{
			get
			{
				return this.sgt_alg_ledenpas_verenigingStateField;
			}
			set
			{
				this.sgt_alg_ledenpas_verenigingStateField = value;
				base.RaisePropertyChanged("Sgt_alg_ledenpas_verenigingState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_alg_ledenpas_verenigingStatus
		{
			get
			{
				return this.sgt_alg_ledenpas_verenigingStatusField;
			}
			set
			{
				this.sgt_alg_ledenpas_verenigingStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_ledenpas_verenigingStatus");
			}
		}
	}
}
