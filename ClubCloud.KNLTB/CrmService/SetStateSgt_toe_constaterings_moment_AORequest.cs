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
	public class SetStateSgt_toe_constaterings_moment_AORequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_constaterings_moment_AOState sgt_toe_constaterings_moment_AOStateField;

		private int sgt_toe_constaterings_moment_AOStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_constaterings_moment_AOState Sgt_toe_constaterings_moment_AOState
		{
			get
			{
				return this.sgt_toe_constaterings_moment_AOStateField;
			}
			set
			{
				this.sgt_toe_constaterings_moment_AOStateField = value;
				base.RaisePropertyChanged("Sgt_toe_constaterings_moment_AOState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_toe_constaterings_moment_AOStatus
		{
			get
			{
				return this.sgt_toe_constaterings_moment_AOStatusField;
			}
			set
			{
				this.sgt_toe_constaterings_moment_AOStatusField = value;
				base.RaisePropertyChanged("Sgt_toe_constaterings_moment_AOStatus");
			}
		}

		public SetStateSgt_toe_constaterings_moment_AORequest()
		{
		}
	}
}