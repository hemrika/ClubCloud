using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_ranglijst_deelgetal_dubbelspelRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_ranglijst_deelgetal_dubbelspelState sgt_toe_ranglijst_deelgetal_dubbelspelStateField;
		private int sgt_toe_ranglijst_deelgetal_dubbelspelStatusField;
		public Guid EntityId
		{
			get
			{
				return this.entityIdField;
			}
			set
			{
				this.entityIdField = value;
			}
		}
		public Sgt_toe_ranglijst_deelgetal_dubbelspelState Sgt_toe_ranglijst_deelgetal_dubbelspelState
		{
			get
			{
				return this.sgt_toe_ranglijst_deelgetal_dubbelspelStateField;
			}
			set
			{
				this.sgt_toe_ranglijst_deelgetal_dubbelspelStateField = value;
			}
		}
		public int Sgt_toe_ranglijst_deelgetal_dubbelspelStatus
		{
			get
			{
				return this.sgt_toe_ranglijst_deelgetal_dubbelspelStatusField;
			}
			set
			{
				this.sgt_toe_ranglijst_deelgetal_dubbelspelStatusField = value;
			}
		}
	}
}
