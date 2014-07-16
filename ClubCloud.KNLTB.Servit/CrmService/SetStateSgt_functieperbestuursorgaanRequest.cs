using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[GeneratedCode("System.Xml", "4.0.30319.33440")]
	[Serializable]
	[XmlType(Namespace="http://schemas.microsoft.com/crm/2007/WebServices")]
	public class SetStateSgt_functieperbestuursorgaanRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_functieperbestuursorgaanState sgt_functieperbestuursorgaanStateField;

		private int sgt_functieperbestuursorgaanStatusField;

		[XmlElement] //[XmlElement(Order=0)]
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

		[XmlElement] //[XmlElement(Order=1)]
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_functieperbestuursorgaanState Sgt_functieperbestuursorgaanState
		{
			get
			{
				return this.sgt_functieperbestuursorgaanStateField;
			}
			set
			{
				this.sgt_functieperbestuursorgaanStateField = value;
				base.RaisePropertyChanged("Sgt_functieperbestuursorgaanState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_functieperbestuursorgaanStatus
		{
			get
			{
				return this.sgt_functieperbestuursorgaanStatusField;
			}
			set
			{
				this.sgt_functieperbestuursorgaanStatusField = value;
				base.RaisePropertyChanged("Sgt_functieperbestuursorgaanStatus");
			}
		}

		public SetStateSgt_functieperbestuursorgaanRequest()
		{
		}
	}
}