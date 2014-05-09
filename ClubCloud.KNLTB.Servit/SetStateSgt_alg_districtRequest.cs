using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_districtRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_districtState sgt_alg_districtStateField;
		private int sgt_alg_districtStatusField;
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
		public Sgt_alg_districtState Sgt_alg_districtState
		{
			get
			{
				return this.sgt_alg_districtStateField;
			}
			set
			{
				this.sgt_alg_districtStateField = value;
				base.RaisePropertyChanged("Sgt_alg_districtState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_alg_districtStatus
		{
			get
			{
				return this.sgt_alg_districtStatusField;
			}
			set
			{
				this.sgt_alg_districtStatusField = value;
				base.RaisePropertyChanged("Sgt_alg_districtStatus");
			}
		}
	}
}
