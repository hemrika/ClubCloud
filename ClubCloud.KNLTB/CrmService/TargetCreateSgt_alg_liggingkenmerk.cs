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
	public class TargetCreateSgt_alg_liggingkenmerk : TargetCreate
	{
		private sgt_alg_liggingkenmerk sgt_alg_liggingkenmerkField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_alg_liggingkenmerk Sgt_alg_liggingkenmerk
		{
			get
			{
				return this.sgt_alg_liggingkenmerkField;
			}
			set
			{
				this.sgt_alg_liggingkenmerkField = value;
				base.RaisePropertyChanged("Sgt_alg_liggingkenmerk");
			}
		}

		public TargetCreateSgt_alg_liggingkenmerk()
		{
		}
	}
}