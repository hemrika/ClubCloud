using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_basisschema_partijRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_basisschema_partijState sgt_toe_basisschema_partijStateField;
		private int sgt_toe_basisschema_partijStatusField;
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
		public Sgt_toe_basisschema_partijState Sgt_toe_basisschema_partijState
		{
			get
			{
				return this.sgt_toe_basisschema_partijStateField;
			}
			set
			{
				this.sgt_toe_basisschema_partijStateField = value;
				base.RaisePropertyChanged("Sgt_toe_basisschema_partijState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_toe_basisschema_partijStatus
		{
			get
			{
				return this.sgt_toe_basisschema_partijStatusField;
			}
			set
			{
				this.sgt_toe_basisschema_partijStatusField = value;
				base.RaisePropertyChanged("Sgt_toe_basisschema_partijStatus");
			}
		}
	}
}
