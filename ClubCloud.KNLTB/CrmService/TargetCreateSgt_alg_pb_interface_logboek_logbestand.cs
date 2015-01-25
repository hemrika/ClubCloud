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
	public class TargetCreateSgt_alg_pb_interface_logboek_logbestand : TargetCreate
	{
		private sgt_alg_pb_interface_logboek_logbestand sgt_alg_pb_interface_logboek_logbestandField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_alg_pb_interface_logboek_logbestand Sgt_alg_pb_interface_logboek_logbestand
		{
			get
			{
				return this.sgt_alg_pb_interface_logboek_logbestandField;
			}
			set
			{
				this.sgt_alg_pb_interface_logboek_logbestandField = value;
				base.RaisePropertyChanged("Sgt_alg_pb_interface_logboek_logbestand");
			}
		}

		public TargetCreateSgt_alg_pb_interface_logboek_logbestand()
		{
		}
	}
}