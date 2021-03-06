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
	public class TargetCreateSgt_toe_soortbal : TargetCreate
	{
		private sgt_toe_soortbal sgt_toe_soortbalField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_toe_soortbal Sgt_toe_soortbal
		{
			get
			{
				return this.sgt_toe_soortbalField;
			}
			set
			{
				this.sgt_toe_soortbalField = value;
				base.RaisePropertyChanged("Sgt_toe_soortbal");
			}
		}

		public TargetCreateSgt_toe_soortbal()
		{
		}
	}
}