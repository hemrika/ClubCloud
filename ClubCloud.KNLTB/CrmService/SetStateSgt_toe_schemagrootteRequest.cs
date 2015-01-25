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
	public class SetStateSgt_toe_schemagrootteRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_schemagrootteState sgt_toe_schemagrootteStateField;

		private int sgt_toe_schemagrootteStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_schemagrootteState Sgt_toe_schemagrootteState
		{
			get
			{
				return this.sgt_toe_schemagrootteStateField;
			}
			set
			{
				this.sgt_toe_schemagrootteStateField = value;
				base.RaisePropertyChanged("Sgt_toe_schemagrootteState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_toe_schemagrootteStatus
		{
			get
			{
				return this.sgt_toe_schemagrootteStatusField;
			}
			set
			{
				this.sgt_toe_schemagrootteStatusField = value;
				base.RaisePropertyChanged("Sgt_toe_schemagrootteStatus");
			}
		}

		public SetStateSgt_toe_schemagrootteRequest()
		{
		}
	}
}