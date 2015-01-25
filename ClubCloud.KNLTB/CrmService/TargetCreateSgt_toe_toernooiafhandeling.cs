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
	public class TargetCreateSgt_toe_toernooiafhandeling : TargetCreate
	{
		private sgt_toe_toernooiafhandeling sgt_toe_toernooiafhandelingField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_toe_toernooiafhandeling Sgt_toe_toernooiafhandeling
		{
			get
			{
				return this.sgt_toe_toernooiafhandelingField;
			}
			set
			{
				this.sgt_toe_toernooiafhandelingField = value;
				base.RaisePropertyChanged("Sgt_toe_toernooiafhandeling");
			}
		}

		public TargetCreateSgt_toe_toernooiafhandeling()
		{
		}
	}
}