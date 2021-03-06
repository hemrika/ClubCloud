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
	public class SetStateSgt_toe_wildcardRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_wildcardState sgt_toe_wildcardStateField;

		private int sgt_toe_wildcardStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_wildcardState Sgt_toe_wildcardState
		{
			get
			{
				return this.sgt_toe_wildcardStateField;
			}
			set
			{
				this.sgt_toe_wildcardStateField = value;
				base.RaisePropertyChanged("Sgt_toe_wildcardState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_toe_wildcardStatus
		{
			get
			{
				return this.sgt_toe_wildcardStatusField;
			}
			set
			{
				this.sgt_toe_wildcardStatusField = value;
				base.RaisePropertyChanged("Sgt_toe_wildcardStatus");
			}
		}

		public SetStateSgt_toe_wildcardRequest()
		{
		}
	}
}