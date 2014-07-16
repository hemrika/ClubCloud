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
	public class TargetCreateSgt_alg_baanblok : TargetCreate
	{
		private sgt_alg_baanblok sgt_alg_baanblokField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_alg_baanblok Sgt_alg_baanblok
		{
			get
			{
				return this.sgt_alg_baanblokField;
			}
			set
			{
				this.sgt_alg_baanblokField = value;
				base.RaisePropertyChanged("Sgt_alg_baanblok");
			}
		}

		public TargetCreateSgt_alg_baanblok()
		{
		}
	}
}