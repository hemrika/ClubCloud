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
	public class TargetCreateSgt_toe_zwaarte_op_toernooiniveau : TargetCreate
	{
		private sgt_toe_zwaarte_op_toernooiniveau sgt_toe_zwaarte_op_toernooiniveauField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_toe_zwaarte_op_toernooiniveau Sgt_toe_zwaarte_op_toernooiniveau
		{
			get
			{
				return this.sgt_toe_zwaarte_op_toernooiniveauField;
			}
			set
			{
				this.sgt_toe_zwaarte_op_toernooiniveauField = value;
				base.RaisePropertyChanged("Sgt_toe_zwaarte_op_toernooiniveau");
			}
		}

		public TargetCreateSgt_toe_zwaarte_op_toernooiniveau()
		{
		}
	}
}