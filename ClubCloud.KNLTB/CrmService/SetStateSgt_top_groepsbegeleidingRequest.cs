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
	public class SetStateSgt_top_groepsbegeleidingRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_top_groepsbegeleidingState sgt_top_groepsbegeleidingStateField;

		private int sgt_top_groepsbegeleidingStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_top_groepsbegeleidingState Sgt_top_groepsbegeleidingState
		{
			get
			{
				return this.sgt_top_groepsbegeleidingStateField;
			}
			set
			{
				this.sgt_top_groepsbegeleidingStateField = value;
				base.RaisePropertyChanged("Sgt_top_groepsbegeleidingState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_top_groepsbegeleidingStatus
		{
			get
			{
				return this.sgt_top_groepsbegeleidingStatusField;
			}
			set
			{
				this.sgt_top_groepsbegeleidingStatusField = value;
				base.RaisePropertyChanged("Sgt_top_groepsbegeleidingStatus");
			}
		}

		public SetStateSgt_top_groepsbegeleidingRequest()
		{
		}
	}
}