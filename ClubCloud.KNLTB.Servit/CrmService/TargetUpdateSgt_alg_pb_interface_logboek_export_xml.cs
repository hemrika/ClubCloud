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
	public class TargetUpdateSgt_alg_pb_interface_logboek_export_xml : TargetUpdate
	{
		private sgt_alg_pb_interface_logboek_export_xml sgt_alg_pb_interface_logboek_export_xmlField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_alg_pb_interface_logboek_export_xml Sgt_alg_pb_interface_logboek_export_xml
		{
			get
			{
				return this.sgt_alg_pb_interface_logboek_export_xmlField;
			}
			set
			{
				this.sgt_alg_pb_interface_logboek_export_xmlField = value;
				base.RaisePropertyChanged("Sgt_alg_pb_interface_logboek_export_xml");
			}
		}

		public TargetUpdateSgt_alg_pb_interface_logboek_export_xml()
		{
		}
	}
}