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
	public class TargetCreateSgt_alg_toplaag : TargetCreate
	{
		private sgt_alg_toplaag sgt_alg_toplaagField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_alg_toplaag Sgt_alg_toplaag
		{
			get
			{
				return this.sgt_alg_toplaagField;
			}
			set
			{
				this.sgt_alg_toplaagField = value;
				base.RaisePropertyChanged("Sgt_alg_toplaag");
			}
		}

		public TargetCreateSgt_alg_toplaag()
		{
		}
	}
}