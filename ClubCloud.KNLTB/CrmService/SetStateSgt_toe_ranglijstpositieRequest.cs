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
	public class SetStateSgt_toe_ranglijstpositieRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_ranglijstpositieState sgt_toe_ranglijstpositieStateField;

		private int sgt_toe_ranglijstpositieStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_ranglijstpositieState Sgt_toe_ranglijstpositieState
		{
			get
			{
				return this.sgt_toe_ranglijstpositieStateField;
			}
			set
			{
				this.sgt_toe_ranglijstpositieStateField = value;
				base.RaisePropertyChanged("Sgt_toe_ranglijstpositieState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_toe_ranglijstpositieStatus
		{
			get
			{
				return this.sgt_toe_ranglijstpositieStatusField;
			}
			set
			{
				this.sgt_toe_ranglijstpositieStatusField = value;
				base.RaisePropertyChanged("Sgt_toe_ranglijstpositieStatus");
			}
		}

		public SetStateSgt_toe_ranglijstpositieRequest()
		{
		}
	}
}