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
	public class TargetCreateSgt_bo_vooropleiding : TargetCreate
	{
		private sgt_bo_vooropleiding sgt_bo_vooropleidingField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_bo_vooropleiding Sgt_bo_vooropleiding
		{
			get
			{
				return this.sgt_bo_vooropleidingField;
			}
			set
			{
				this.sgt_bo_vooropleidingField = value;
				base.RaisePropertyChanged("Sgt_bo_vooropleiding");
			}
		}

		public TargetCreateSgt_bo_vooropleiding()
		{
		}
	}
}