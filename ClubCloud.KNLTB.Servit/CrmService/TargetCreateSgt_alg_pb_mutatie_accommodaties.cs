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
	public class TargetCreateSgt_alg_pb_mutatie_accommodaties : TargetCreate
	{
		private sgt_alg_pb_mutatie_accommodaties sgt_alg_pb_mutatie_accommodatiesField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_alg_pb_mutatie_accommodaties Sgt_alg_pb_mutatie_accommodaties
		{
			get
			{
				return this.sgt_alg_pb_mutatie_accommodatiesField;
			}
			set
			{
				this.sgt_alg_pb_mutatie_accommodatiesField = value;
				base.RaisePropertyChanged("Sgt_alg_pb_mutatie_accommodaties");
			}
		}

		public TargetCreateSgt_alg_pb_mutatie_accommodaties()
		{
		}
	}
}