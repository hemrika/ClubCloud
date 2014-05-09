using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_toe_toernooi_op_toernooikalender : TargetCreate
	{
		private sgt_toe_toernooi_op_toernooikalender sgt_toe_toernooi_op_toernooikalenderField;
		[XmlElement(Order = 0)]
		public sgt_toe_toernooi_op_toernooikalender Sgt_toe_toernooi_op_toernooikalender
		{
			get
			{
				return this.sgt_toe_toernooi_op_toernooikalenderField;
			}
			set
			{
				this.sgt_toe_toernooi_op_toernooikalenderField = value;
				base.RaisePropertyChanged("Sgt_toe_toernooi_op_toernooikalender");
			}
		}
	}
}
