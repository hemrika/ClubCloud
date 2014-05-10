using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_alg_postcode_import : TargetUpdate
	{
		private sgt_alg_postcode_import sgt_alg_postcode_importField;
		public sgt_alg_postcode_import Sgt_alg_postcode_import
		{
			get
			{
				return this.sgt_alg_postcode_importField;
			}
			set
			{
				this.sgt_alg_postcode_importField = value;
			}
		}
	}
}
