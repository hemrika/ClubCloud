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
	public class SetStateSgt_toe_spelersmemoRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_spelersmemoState sgt_toe_spelersmemoStateField;

		private int sgt_toe_spelersmemoStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_spelersmemoState Sgt_toe_spelersmemoState
		{
			get
			{
				return this.sgt_toe_spelersmemoStateField;
			}
			set
			{
				this.sgt_toe_spelersmemoStateField = value;
				base.RaisePropertyChanged("Sgt_toe_spelersmemoState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_toe_spelersmemoStatus
		{
			get
			{
				return this.sgt_toe_spelersmemoStatusField;
			}
			set
			{
				this.sgt_toe_spelersmemoStatusField = value;
				base.RaisePropertyChanged("Sgt_toe_spelersmemoStatus");
			}
		}

		public SetStateSgt_toe_spelersmemoRequest()
		{
		}
	}
}