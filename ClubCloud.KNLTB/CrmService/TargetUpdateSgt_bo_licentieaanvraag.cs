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
	public class TargetUpdateSgt_bo_licentieaanvraag : TargetUpdate
	{
		private sgt_bo_licentieaanvraag sgt_bo_licentieaanvraagField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_bo_licentieaanvraag Sgt_bo_licentieaanvraag
		{
			get
			{
				return this.sgt_bo_licentieaanvraagField;
			}
			set
			{
				this.sgt_bo_licentieaanvraagField = value;
				base.RaisePropertyChanged("Sgt_bo_licentieaanvraag");
			}
		}

		public TargetUpdateSgt_bo_licentieaanvraag()
		{
		}
	}
}