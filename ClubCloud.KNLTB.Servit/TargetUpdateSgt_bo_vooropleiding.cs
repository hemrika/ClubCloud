using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_bo_vooropleiding : TargetUpdate
	{
		private sgt_bo_vooropleiding sgt_bo_vooropleidingField;
		[XmlElement(Order = 0)]
		public sgt_bo_vooropleiding Sgt_bo_vooropleiding
		{
			get
			{
				return this.sgt_bo_vooropleidingField;
			}
			set
			{
				this.sgt_bo_vooropleidingField = value;
				base.RaisePropertyChanged("Sgt_bo_vooropleiding");
			}
		}
	}
}
