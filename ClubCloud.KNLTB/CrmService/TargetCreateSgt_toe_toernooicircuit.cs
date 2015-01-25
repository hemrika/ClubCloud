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
	public class TargetCreateSgt_toe_toernooicircuit : TargetCreate
	{
		private sgt_toe_toernooicircuit sgt_toe_toernooicircuitField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_toe_toernooicircuit Sgt_toe_toernooicircuit
		{
			get
			{
				return this.sgt_toe_toernooicircuitField;
			}
			set
			{
				this.sgt_toe_toernooicircuitField = value;
				base.RaisePropertyChanged("Sgt_toe_toernooicircuit");
			}
		}

		public TargetCreateSgt_toe_toernooicircuit()
		{
		}
	}
}