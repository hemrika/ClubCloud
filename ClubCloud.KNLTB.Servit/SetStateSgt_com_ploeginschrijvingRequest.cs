using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_com_ploeginschrijvingRequest : Request
	{
		private Guid entityIdField;
		private Sgt_com_ploeginschrijvingState sgt_com_ploeginschrijvingStateField;
		private int sgt_com_ploeginschrijvingStatusField;
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
		public Sgt_com_ploeginschrijvingState Sgt_com_ploeginschrijvingState
		{
			get
			{
				return this.sgt_com_ploeginschrijvingStateField;
			}
			set
			{
				this.sgt_com_ploeginschrijvingStateField = value;
				base.RaisePropertyChanged("Sgt_com_ploeginschrijvingState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_com_ploeginschrijvingStatus
		{
			get
			{
				return this.sgt_com_ploeginschrijvingStatusField;
			}
			set
			{
				this.sgt_com_ploeginschrijvingStatusField = value;
				base.RaisePropertyChanged("Sgt_com_ploeginschrijvingStatus");
			}
		}
	}
}
