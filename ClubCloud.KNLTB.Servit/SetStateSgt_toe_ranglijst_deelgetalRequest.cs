using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_ranglijst_deelgetalRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_ranglijst_deelgetalState sgt_toe_ranglijst_deelgetalStateField;
		private int sgt_toe_ranglijst_deelgetalStatusField;
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
		public Sgt_toe_ranglijst_deelgetalState Sgt_toe_ranglijst_deelgetalState
		{
			get
			{
				return this.sgt_toe_ranglijst_deelgetalStateField;
			}
			set
			{
				this.sgt_toe_ranglijst_deelgetalStateField = value;
				base.RaisePropertyChanged("Sgt_toe_ranglijst_deelgetalState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_toe_ranglijst_deelgetalStatus
		{
			get
			{
				return this.sgt_toe_ranglijst_deelgetalStatusField;
			}
			set
			{
				this.sgt_toe_ranglijst_deelgetalStatusField = value;
				base.RaisePropertyChanged("Sgt_toe_ranglijst_deelgetalStatus");
			}
		}
	}
}
