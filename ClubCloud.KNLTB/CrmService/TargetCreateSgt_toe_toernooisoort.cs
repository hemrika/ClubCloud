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
	public class TargetCreateSgt_toe_toernooisoort : TargetCreate
	{
		private sgt_toe_toernooisoort sgt_toe_toernooisoortField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_toe_toernooisoort Sgt_toe_toernooisoort
		{
			get
			{
				return this.sgt_toe_toernooisoortField;
			}
			set
			{
				this.sgt_toe_toernooisoortField = value;
				base.RaisePropertyChanged("Sgt_toe_toernooisoort");
			}
		}

		public TargetCreateSgt_toe_toernooisoort()
		{
		}
	}
}