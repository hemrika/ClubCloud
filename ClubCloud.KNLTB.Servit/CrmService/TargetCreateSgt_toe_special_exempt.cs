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
	public class TargetCreateSgt_toe_special_exempt : TargetCreate
	{
		private sgt_toe_special_exempt sgt_toe_special_exemptField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_toe_special_exempt Sgt_toe_special_exempt
		{
			get
			{
				return this.sgt_toe_special_exemptField;
			}
			set
			{
				this.sgt_toe_special_exemptField = value;
				base.RaisePropertyChanged("Sgt_toe_special_exempt");
			}
		}

		public TargetCreateSgt_toe_special_exempt()
		{
		}
	}
}