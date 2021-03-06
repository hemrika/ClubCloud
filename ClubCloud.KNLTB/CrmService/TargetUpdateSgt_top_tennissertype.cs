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
	public class TargetUpdateSgt_top_tennissertype : TargetUpdate
	{
		private sgt_top_tennissertype sgt_top_tennissertypeField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_top_tennissertype Sgt_top_tennissertype
		{
			get
			{
				return this.sgt_top_tennissertypeField;
			}
			set
			{
				this.sgt_top_tennissertypeField = value;
				base.RaisePropertyChanged("Sgt_top_tennissertype");
			}
		}

		public TargetUpdateSgt_top_tennissertype()
		{
		}
	}
}