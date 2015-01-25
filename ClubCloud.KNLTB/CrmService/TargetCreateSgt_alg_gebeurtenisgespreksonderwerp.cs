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
	public class TargetCreateSgt_alg_gebeurtenisgespreksonderwerp : TargetCreate
	{
		private sgt_alg_gebeurtenisgespreksonderwerp sgt_alg_gebeurtenisgespreksonderwerpField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_alg_gebeurtenisgespreksonderwerp Sgt_alg_gebeurtenisgespreksonderwerp
		{
			get
			{
				return this.sgt_alg_gebeurtenisgespreksonderwerpField;
			}
			set
			{
				this.sgt_alg_gebeurtenisgespreksonderwerpField = value;
				base.RaisePropertyChanged("Sgt_alg_gebeurtenisgespreksonderwerp");
			}
		}

		public TargetCreateSgt_alg_gebeurtenisgespreksonderwerp()
		{
		}
	}
}