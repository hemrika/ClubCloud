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
	public class SetStateSgt_toe_zwaarte_op_toernooiniveauRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_zwaarte_op_toernooiniveauState sgt_toe_zwaarte_op_toernooiniveauStateField;

		private int sgt_toe_zwaarte_op_toernooiniveauStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_zwaarte_op_toernooiniveauState Sgt_toe_zwaarte_op_toernooiniveauState
		{
			get
			{
				return this.sgt_toe_zwaarte_op_toernooiniveauStateField;
			}
			set
			{
				this.sgt_toe_zwaarte_op_toernooiniveauStateField = value;
				base.RaisePropertyChanged("Sgt_toe_zwaarte_op_toernooiniveauState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_toe_zwaarte_op_toernooiniveauStatus
		{
			get
			{
				return this.sgt_toe_zwaarte_op_toernooiniveauStatusField;
			}
			set
			{
				this.sgt_toe_zwaarte_op_toernooiniveauStatusField = value;
				base.RaisePropertyChanged("Sgt_toe_zwaarte_op_toernooiniveauStatus");
			}
		}

		public SetStateSgt_toe_zwaarte_op_toernooiniveauRequest()
		{
		}
	}
}