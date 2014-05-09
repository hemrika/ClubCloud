using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_bo_logboek_VNTRequest : Request
	{
		private Guid entityIdField;
		private Sgt_bo_logboek_VNTState sgt_bo_logboek_VNTStateField;
		private int sgt_bo_logboek_VNTStatusField;
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
		public Sgt_bo_logboek_VNTState Sgt_bo_logboek_VNTState
		{
			get
			{
				return this.sgt_bo_logboek_VNTStateField;
			}
			set
			{
				this.sgt_bo_logboek_VNTStateField = value;
				base.RaisePropertyChanged("Sgt_bo_logboek_VNTState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_bo_logboek_VNTStatus
		{
			get
			{
				return this.sgt_bo_logboek_VNTStatusField;
			}
			set
			{
				this.sgt_bo_logboek_VNTStatusField = value;
				base.RaisePropertyChanged("Sgt_bo_logboek_VNTStatus");
			}
		}
	}
}
