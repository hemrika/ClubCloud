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
	public class TargetUpdateSgt_fac_factuur_type : TargetUpdate
	{
		private sgt_fac_factuur_type sgt_fac_factuur_typeField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_fac_factuur_type Sgt_fac_factuur_type
		{
			get
			{
				return this.sgt_fac_factuur_typeField;
			}
			set
			{
				this.sgt_fac_factuur_typeField = value;
				base.RaisePropertyChanged("Sgt_fac_factuur_type");
			}
		}

		public TargetUpdateSgt_fac_factuur_type()
		{
		}
	}
}