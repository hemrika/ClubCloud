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
	public class TargetUpdateSgt_bo_licentiesoort : TargetUpdate
	{
		private sgt_bo_licentiesoort sgt_bo_licentiesoortField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_bo_licentiesoort Sgt_bo_licentiesoort
		{
			get
			{
				return this.sgt_bo_licentiesoortField;
			}
			set
			{
				this.sgt_bo_licentiesoortField = value;
				base.RaisePropertyChanged("Sgt_bo_licentiesoort");
			}
		}

		public TargetUpdateSgt_bo_licentiesoort()
		{
		}
	}
}