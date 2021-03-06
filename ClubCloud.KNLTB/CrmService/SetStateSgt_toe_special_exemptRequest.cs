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
	public class SetStateSgt_toe_special_exemptRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_special_exemptState sgt_toe_special_exemptStateField;

		private int sgt_toe_special_exemptStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_special_exemptState Sgt_toe_special_exemptState
		{
			get
			{
				return this.sgt_toe_special_exemptStateField;
			}
			set
			{
				this.sgt_toe_special_exemptStateField = value;
				base.RaisePropertyChanged("Sgt_toe_special_exemptState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_toe_special_exemptStatus
		{
			get
			{
				return this.sgt_toe_special_exemptStatusField;
			}
			set
			{
				this.sgt_toe_special_exemptStatusField = value;
				base.RaisePropertyChanged("Sgt_toe_special_exemptStatus");
			}
		}

		public SetStateSgt_toe_special_exemptRequest()
		{
		}
	}
}