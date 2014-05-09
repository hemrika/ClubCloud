using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_pb_mutaute_inschrijfcontrole_verRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_pb_mutaute_inschrijfcontrole_verState sgt_toe_pb_mutaute_inschrijfcontrole_verStateField;
		private int sgt_toe_pb_mutaute_inschrijfcontrole_verStatusField;
		[XmlElement(Order = 0)]
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
		[XmlElement(Order = 1)]
		public Sgt_toe_pb_mutaute_inschrijfcontrole_verState Sgt_toe_pb_mutaute_inschrijfcontrole_verState
		{
			get
			{
				return this.sgt_toe_pb_mutaute_inschrijfcontrole_verStateField;
			}
			set
			{
				this.sgt_toe_pb_mutaute_inschrijfcontrole_verStateField = value;
				base.RaisePropertyChanged("Sgt_toe_pb_mutaute_inschrijfcontrole_verState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_toe_pb_mutaute_inschrijfcontrole_verStatus
		{
			get
			{
				return this.sgt_toe_pb_mutaute_inschrijfcontrole_verStatusField;
			}
			set
			{
				this.sgt_toe_pb_mutaute_inschrijfcontrole_verStatusField = value;
				base.RaisePropertyChanged("Sgt_toe_pb_mutaute_inschrijfcontrole_verStatus");
			}
		}
	}
}
