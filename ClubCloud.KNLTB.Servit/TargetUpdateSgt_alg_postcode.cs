using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_alg_postcode : TargetUpdate
	{
		private sgt_alg_postcode sgt_alg_postcodeField;
		[XmlElement(Order = 0)]
		public sgt_alg_postcode Sgt_alg_postcode
		{
			get
			{
				return this.sgt_alg_postcodeField;
			}
			set
			{
				this.sgt_alg_postcodeField = value;
				base.RaisePropertyChanged("Sgt_alg_postcode");
			}
		}
	}
}
