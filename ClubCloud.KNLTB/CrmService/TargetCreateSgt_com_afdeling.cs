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
	public class TargetCreateSgt_com_afdeling : TargetCreate
	{
		private sgt_com_afdeling sgt_com_afdelingField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_com_afdeling Sgt_com_afdeling
		{
			get
			{
				return this.sgt_com_afdelingField;
			}
			set
			{
				this.sgt_com_afdelingField = value;
				base.RaisePropertyChanged("Sgt_com_afdeling");
			}
		}

		public TargetCreateSgt_com_afdeling()
		{
		}
	}
}