using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_toernooi_aanvraagrechtRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_toernooi_aanvraagrechtState sgt_toe_toernooi_aanvraagrechtStateField;
		private int sgt_toe_toernooi_aanvraagrechtStatusField;
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
		public Sgt_toe_toernooi_aanvraagrechtState Sgt_toe_toernooi_aanvraagrechtState
		{
			get
			{
				return this.sgt_toe_toernooi_aanvraagrechtStateField;
			}
			set
			{
				this.sgt_toe_toernooi_aanvraagrechtStateField = value;
				base.RaisePropertyChanged("Sgt_toe_toernooi_aanvraagrechtState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_toe_toernooi_aanvraagrechtStatus
		{
			get
			{
				return this.sgt_toe_toernooi_aanvraagrechtStatusField;
			}
			set
			{
				this.sgt_toe_toernooi_aanvraagrechtStatusField = value;
				base.RaisePropertyChanged("Sgt_toe_toernooi_aanvraagrechtStatus");
			}
		}
	}
}
