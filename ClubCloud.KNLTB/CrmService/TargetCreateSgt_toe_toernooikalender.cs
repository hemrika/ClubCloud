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
	public class TargetCreateSgt_toe_toernooikalender : TargetCreate
	{
		private sgt_toe_toernooikalender sgt_toe_toernooikalenderField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_toe_toernooikalender Sgt_toe_toernooikalender
		{
			get
			{
				return this.sgt_toe_toernooikalenderField;
			}
			set
			{
				this.sgt_toe_toernooikalenderField = value;
				base.RaisePropertyChanged("Sgt_toe_toernooikalender");
			}
		}

		public TargetCreateSgt_toe_toernooikalender()
		{
		}
	}
}