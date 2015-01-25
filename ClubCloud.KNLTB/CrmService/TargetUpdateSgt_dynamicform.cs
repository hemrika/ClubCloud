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
	public class TargetUpdateSgt_dynamicform : TargetUpdate
	{
		private sgt_dynamicform sgt_dynamicformField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_dynamicform Sgt_dynamicform
		{
			get
			{
				return this.sgt_dynamicformField;
			}
			set
			{
				this.sgt_dynamicformField = value;
				base.RaisePropertyChanged("Sgt_dynamicform");
			}
		}

		public TargetUpdateSgt_dynamicform()
		{
		}
	}
}