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
	public class TargetUpdateSgt_alg_vrij_bondsnummer : TargetUpdate
	{
		private sgt_alg_vrij_bondsnummer sgt_alg_vrij_bondsnummerField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_alg_vrij_bondsnummer Sgt_alg_vrij_bondsnummer
		{
			get
			{
				return this.sgt_alg_vrij_bondsnummerField;
			}
			set
			{
				this.sgt_alg_vrij_bondsnummerField = value;
				base.RaisePropertyChanged("Sgt_alg_vrij_bondsnummer");
			}
		}

		public TargetUpdateSgt_alg_vrij_bondsnummer()
		{
		}
	}
}