using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_alg_pb_interface_logboek_leden_export : TargetUpdate
	{
		private sgt_alg_pb_interface_logboek_leden_export sgt_alg_pb_interface_logboek_leden_exportField;
		[XmlElement(Order = 0)]
		public sgt_alg_pb_interface_logboek_leden_export Sgt_alg_pb_interface_logboek_leden_export
		{
			get
			{
				return this.sgt_alg_pb_interface_logboek_leden_exportField;
			}
			set
			{
				this.sgt_alg_pb_interface_logboek_leden_exportField = value;
				base.RaisePropertyChanged("Sgt_alg_pb_interface_logboek_leden_export");
			}
		}
	}
}
