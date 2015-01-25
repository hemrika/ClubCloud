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
	public class TargetCreateSgt_alg_rechtsvorm : TargetCreate
	{
		private sgt_alg_rechtsvorm sgt_alg_rechtsvormField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_alg_rechtsvorm Sgt_alg_rechtsvorm
		{
			get
			{
				return this.sgt_alg_rechtsvormField;
			}
			set
			{
				this.sgt_alg_rechtsvormField = value;
				base.RaisePropertyChanged("Sgt_alg_rechtsvorm");
			}
		}

		public TargetCreateSgt_alg_rechtsvorm()
		{
		}
	}
}