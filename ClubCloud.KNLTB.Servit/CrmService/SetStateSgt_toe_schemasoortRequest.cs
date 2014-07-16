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
	public class SetStateSgt_toe_schemasoortRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_schemasoortState sgt_toe_schemasoortStateField;

		private int sgt_toe_schemasoortStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_schemasoortState Sgt_toe_schemasoortState
		{
			get
			{
				return this.sgt_toe_schemasoortStateField;
			}
			set
			{
				this.sgt_toe_schemasoortStateField = value;
				base.RaisePropertyChanged("Sgt_toe_schemasoortState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_toe_schemasoortStatus
		{
			get
			{
				return this.sgt_toe_schemasoortStatusField;
			}
			set
			{
				this.sgt_toe_schemasoortStatusField = value;
				base.RaisePropertyChanged("Sgt_toe_schemasoortStatus");
			}
		}

		public SetStateSgt_toe_schemasoortRequest()
		{
		}
	}
}