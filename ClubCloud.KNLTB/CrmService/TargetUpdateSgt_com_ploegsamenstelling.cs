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
	public class TargetUpdateSgt_com_ploegsamenstelling : TargetUpdate
	{
		private sgt_com_ploegsamenstelling sgt_com_ploegsamenstellingField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_com_ploegsamenstelling Sgt_com_ploegsamenstelling
		{
			get
			{
				return this.sgt_com_ploegsamenstellingField;
			}
			set
			{
				this.sgt_com_ploegsamenstellingField = value;
				base.RaisePropertyChanged("Sgt_com_ploegsamenstelling");
			}
		}

		public TargetUpdateSgt_com_ploegsamenstelling()
		{
		}
	}
}