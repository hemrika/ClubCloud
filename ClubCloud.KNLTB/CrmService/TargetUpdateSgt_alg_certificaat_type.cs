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
	public class TargetUpdateSgt_alg_certificaat_type : TargetUpdate
	{
		private sgt_alg_certificaat_type sgt_alg_certificaat_typeField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_alg_certificaat_type Sgt_alg_certificaat_type
		{
			get
			{
				return this.sgt_alg_certificaat_typeField;
			}
			set
			{
				this.sgt_alg_certificaat_typeField = value;
				base.RaisePropertyChanged("Sgt_alg_certificaat_type");
			}
		}

		public TargetUpdateSgt_alg_certificaat_type()
		{
		}
	}
}