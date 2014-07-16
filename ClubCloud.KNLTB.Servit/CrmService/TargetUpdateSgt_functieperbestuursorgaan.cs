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
	public class TargetUpdateSgt_functieperbestuursorgaan : TargetUpdate
	{
		private sgt_functieperbestuursorgaan sgt_functieperbestuursorgaanField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_functieperbestuursorgaan Sgt_functieperbestuursorgaan
		{
			get
			{
				return this.sgt_functieperbestuursorgaanField;
			}
			set
			{
				this.sgt_functieperbestuursorgaanField = value;
				base.RaisePropertyChanged("Sgt_functieperbestuursorgaan");
			}
		}

		public TargetUpdateSgt_functieperbestuursorgaan()
		{
		}
	}
}