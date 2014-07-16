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
	public class SetStateSgt_toe_basisschemaRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_basisschemaState sgt_toe_basisschemaStateField;

		private int sgt_toe_basisschemaStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_basisschemaState Sgt_toe_basisschemaState
		{
			get
			{
				return this.sgt_toe_basisschemaStateField;
			}
			set
			{
				this.sgt_toe_basisschemaStateField = value;
				base.RaisePropertyChanged("Sgt_toe_basisschemaState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_toe_basisschemaStatus
		{
			get
			{
				return this.sgt_toe_basisschemaStatusField;
			}
			set
			{
				this.sgt_toe_basisschemaStatusField = value;
				base.RaisePropertyChanged("Sgt_toe_basisschemaStatus");
			}
		}

		public SetStateSgt_toe_basisschemaRequest()
		{
		}
	}
}