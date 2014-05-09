using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_pb_mutatie_toernooidefinitieRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_pb_mutatie_toernooidefinitieState sgt_toe_pb_mutatie_toernooidefinitieStateField;
		private int sgt_toe_pb_mutatie_toernooidefinitieStatusField;
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
		public Sgt_toe_pb_mutatie_toernooidefinitieState Sgt_toe_pb_mutatie_toernooidefinitieState
		{
			get
			{
				return this.sgt_toe_pb_mutatie_toernooidefinitieStateField;
			}
			set
			{
				this.sgt_toe_pb_mutatie_toernooidefinitieStateField = value;
				base.RaisePropertyChanged("Sgt_toe_pb_mutatie_toernooidefinitieState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_toe_pb_mutatie_toernooidefinitieStatus
		{
			get
			{
				return this.sgt_toe_pb_mutatie_toernooidefinitieStatusField;
			}
			set
			{
				this.sgt_toe_pb_mutatie_toernooidefinitieStatusField = value;
				base.RaisePropertyChanged("Sgt_toe_pb_mutatie_toernooidefinitieStatus");
			}
		}
	}
}
