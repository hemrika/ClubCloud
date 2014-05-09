using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_circuitpuntenRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_circuitpuntenState sgt_toe_circuitpuntenStateField;
		private int sgt_toe_circuitpuntenStatusField;
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
		public Sgt_toe_circuitpuntenState Sgt_toe_circuitpuntenState
		{
			get
			{
				return this.sgt_toe_circuitpuntenStateField;
			}
			set
			{
				this.sgt_toe_circuitpuntenStateField = value;
				base.RaisePropertyChanged("Sgt_toe_circuitpuntenState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_toe_circuitpuntenStatus
		{
			get
			{
				return this.sgt_toe_circuitpuntenStatusField;
			}
			set
			{
				this.sgt_toe_circuitpuntenStatusField = value;
				base.RaisePropertyChanged("Sgt_toe_circuitpuntenStatus");
			}
		}
	}
}
