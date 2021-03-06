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
	public class SetStateSgt_toe_post_inRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_post_inState sgt_toe_post_inStateField;

		private int sgt_toe_post_inStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_post_inState Sgt_toe_post_inState
		{
			get
			{
				return this.sgt_toe_post_inStateField;
			}
			set
			{
				this.sgt_toe_post_inStateField = value;
				base.RaisePropertyChanged("Sgt_toe_post_inState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_toe_post_inStatus
		{
			get
			{
				return this.sgt_toe_post_inStatusField;
			}
			set
			{
				this.sgt_toe_post_inStatusField = value;
				base.RaisePropertyChanged("Sgt_toe_post_inStatus");
			}
		}

		public SetStateSgt_toe_post_inRequest()
		{
		}
	}
}