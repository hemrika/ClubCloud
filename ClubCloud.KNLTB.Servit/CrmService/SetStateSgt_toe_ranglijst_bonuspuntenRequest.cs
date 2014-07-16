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
	public class SetStateSgt_toe_ranglijst_bonuspuntenRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_ranglijst_bonuspuntenState sgt_toe_ranglijst_bonuspuntenStateField;

		private int sgt_toe_ranglijst_bonuspuntenStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_ranglijst_bonuspuntenState Sgt_toe_ranglijst_bonuspuntenState
		{
			get
			{
				return this.sgt_toe_ranglijst_bonuspuntenStateField;
			}
			set
			{
				this.sgt_toe_ranglijst_bonuspuntenStateField = value;
				base.RaisePropertyChanged("Sgt_toe_ranglijst_bonuspuntenState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_toe_ranglijst_bonuspuntenStatus
		{
			get
			{
				return this.sgt_toe_ranglijst_bonuspuntenStatusField;
			}
			set
			{
				this.sgt_toe_ranglijst_bonuspuntenStatusField = value;
				base.RaisePropertyChanged("Sgt_toe_ranglijst_bonuspuntenStatus");
			}
		}

		public SetStateSgt_toe_ranglijst_bonuspuntenRequest()
		{
		}
	}
}