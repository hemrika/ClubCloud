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
	public class TargetCreateSgt_dynamicformentity : TargetCreate
	{
		private sgt_dynamicformentity sgt_dynamicformentityField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_dynamicformentity Sgt_dynamicformentity
		{
			get
			{
				return this.sgt_dynamicformentityField;
			}
			set
			{
				this.sgt_dynamicformentityField = value;
				base.RaisePropertyChanged("Sgt_dynamicformentity");
			}
		}

		public TargetCreateSgt_dynamicformentity()
		{
		}
	}
}