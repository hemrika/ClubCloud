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
	public class TargetUpdateSgt_bo_cursist : TargetUpdate
	{
		private sgt_bo_cursist sgt_bo_cursistField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_bo_cursist Sgt_bo_cursist
		{
			get
			{
				return this.sgt_bo_cursistField;
			}
			set
			{
				this.sgt_bo_cursistField = value;
				base.RaisePropertyChanged("Sgt_bo_cursist");
			}
		}

		public TargetUpdateSgt_bo_cursist()
		{
		}
	}
}