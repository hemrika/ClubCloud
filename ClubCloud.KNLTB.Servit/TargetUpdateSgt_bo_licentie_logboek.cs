using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_bo_licentie_logboek : TargetUpdate
	{
		private sgt_bo_licentie_logboek sgt_bo_licentie_logboekField;
		[XmlElement(Order = 0)]
		public sgt_bo_licentie_logboek Sgt_bo_licentie_logboek
		{
			get
			{
				return this.sgt_bo_licentie_logboekField;
			}
			set
			{
				this.sgt_bo_licentie_logboekField = value;
				base.RaisePropertyChanged("Sgt_bo_licentie_logboek");
			}
		}
	}
}
