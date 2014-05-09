using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_circuit_bonuspuntenRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_circuit_bonuspuntenState sgt_toe_circuit_bonuspuntenStateField;
		private int sgt_toe_circuit_bonuspuntenStatusField;
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
		public Sgt_toe_circuit_bonuspuntenState Sgt_toe_circuit_bonuspuntenState
		{
			get
			{
				return this.sgt_toe_circuit_bonuspuntenStateField;
			}
			set
			{
				this.sgt_toe_circuit_bonuspuntenStateField = value;
				base.RaisePropertyChanged("Sgt_toe_circuit_bonuspuntenState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_toe_circuit_bonuspuntenStatus
		{
			get
			{
				return this.sgt_toe_circuit_bonuspuntenStatusField;
			}
			set
			{
				this.sgt_toe_circuit_bonuspuntenStatusField = value;
				base.RaisePropertyChanged("Sgt_toe_circuit_bonuspuntenStatus");
			}
		}
	}
}
