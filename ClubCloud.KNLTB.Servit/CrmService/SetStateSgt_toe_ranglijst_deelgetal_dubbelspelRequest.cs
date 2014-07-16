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
	public class SetStateSgt_toe_ranglijst_deelgetal_dubbelspelRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_ranglijst_deelgetal_dubbelspelState sgt_toe_ranglijst_deelgetal_dubbelspelStateField;

		private int sgt_toe_ranglijst_deelgetal_dubbelspelStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_toe_ranglijst_deelgetal_dubbelspelState Sgt_toe_ranglijst_deelgetal_dubbelspelState
		{
			get
			{
				return this.sgt_toe_ranglijst_deelgetal_dubbelspelStateField;
			}
			set
			{
				this.sgt_toe_ranglijst_deelgetal_dubbelspelStateField = value;
				base.RaisePropertyChanged("Sgt_toe_ranglijst_deelgetal_dubbelspelState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_toe_ranglijst_deelgetal_dubbelspelStatus
		{
			get
			{
				return this.sgt_toe_ranglijst_deelgetal_dubbelspelStatusField;
			}
			set
			{
				this.sgt_toe_ranglijst_deelgetal_dubbelspelStatusField = value;
				base.RaisePropertyChanged("Sgt_toe_ranglijst_deelgetal_dubbelspelStatus");
			}
		}

		public SetStateSgt_toe_ranglijst_deelgetal_dubbelspelRequest()
		{
		}
	}
}