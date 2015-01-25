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
	public class TargetCreateSgt_toe_straf : TargetCreate
	{
		private sgt_toe_straf sgt_toe_strafField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_toe_straf Sgt_toe_straf
		{
			get
			{
				return this.sgt_toe_strafField;
			}
			set
			{
				this.sgt_toe_strafField = value;
				base.RaisePropertyChanged("Sgt_toe_straf");
			}
		}

		public TargetCreateSgt_toe_straf()
		{
		}
	}
}