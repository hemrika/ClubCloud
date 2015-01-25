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
	public class TargetCreateSgt_toe_post_in : TargetCreate
	{
		private sgt_toe_post_in sgt_toe_post_inField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_toe_post_in Sgt_toe_post_in
		{
			get
			{
				return this.sgt_toe_post_inField;
			}
			set
			{
				this.sgt_toe_post_inField = value;
				base.RaisePropertyChanged("Sgt_toe_post_in");
			}
		}

		public TargetCreateSgt_toe_post_in()
		{
		}
	}
}