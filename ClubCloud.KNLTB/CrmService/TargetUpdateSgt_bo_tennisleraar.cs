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
	public class TargetUpdateSgt_bo_tennisleraar : TargetUpdate
	{
		private sgt_bo_tennisleraar sgt_bo_tennisleraarField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_bo_tennisleraar Sgt_bo_tennisleraar
		{
			get
			{
				return this.sgt_bo_tennisleraarField;
			}
			set
			{
				this.sgt_bo_tennisleraarField = value;
				base.RaisePropertyChanged("Sgt_bo_tennisleraar");
			}
		}

		public TargetUpdateSgt_bo_tennisleraar()
		{
		}
	}
}