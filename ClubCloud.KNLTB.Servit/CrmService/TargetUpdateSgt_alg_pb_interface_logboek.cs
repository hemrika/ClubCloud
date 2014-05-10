using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_alg_pb_interface_logboek : TargetUpdate
	{
		private sgt_alg_pb_interface_logboek sgt_alg_pb_interface_logboekField;
		public sgt_alg_pb_interface_logboek Sgt_alg_pb_interface_logboek
		{
			get
			{
				return this.sgt_alg_pb_interface_logboekField;
			}
			set
			{
				this.sgt_alg_pb_interface_logboekField = value;
			}
		}
	}
}
