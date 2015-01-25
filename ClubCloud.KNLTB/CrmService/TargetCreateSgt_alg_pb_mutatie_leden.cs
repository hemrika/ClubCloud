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
	public class TargetCreateSgt_alg_pb_mutatie_leden : TargetCreate
	{
		private sgt_alg_pb_mutatie_leden sgt_alg_pb_mutatie_ledenField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_alg_pb_mutatie_leden Sgt_alg_pb_mutatie_leden
		{
			get
			{
				return this.sgt_alg_pb_mutatie_ledenField;
			}
			set
			{
				this.sgt_alg_pb_mutatie_ledenField = value;
				base.RaisePropertyChanged("Sgt_alg_pb_mutatie_leden");
			}
		}

		public TargetCreateSgt_alg_pb_mutatie_leden()
		{
		}
	}
}