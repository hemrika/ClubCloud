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
	public class TargetUpdateSgt_com_ploegtoevoeging : TargetUpdate
	{
		private sgt_com_ploegtoevoeging sgt_com_ploegtoevoegingField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_com_ploegtoevoeging Sgt_com_ploegtoevoeging
		{
			get
			{
				return this.sgt_com_ploegtoevoegingField;
			}
			set
			{
				this.sgt_com_ploegtoevoegingField = value;
				base.RaisePropertyChanged("Sgt_com_ploegtoevoeging");
			}
		}

		public TargetUpdateSgt_com_ploegtoevoeging()
		{
		}
	}
}