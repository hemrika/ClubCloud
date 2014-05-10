using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_ranglijst_bonuspuntenRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_ranglijst_bonuspuntenState sgt_toe_ranglijst_bonuspuntenStateField;
		private int sgt_toe_ranglijst_bonuspuntenStatusField;
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
		public Sgt_toe_ranglijst_bonuspuntenState Sgt_toe_ranglijst_bonuspuntenState
		{
			get
			{
				return this.sgt_toe_ranglijst_bonuspuntenStateField;
			}
			set
			{
				this.sgt_toe_ranglijst_bonuspuntenStateField = value;
			}
		}
		public int Sgt_toe_ranglijst_bonuspuntenStatus
		{
			get
			{
				return this.sgt_toe_ranglijst_bonuspuntenStatusField;
			}
			set
			{
				this.sgt_toe_ranglijst_bonuspuntenStatusField = value;
			}
		}
	}
}
