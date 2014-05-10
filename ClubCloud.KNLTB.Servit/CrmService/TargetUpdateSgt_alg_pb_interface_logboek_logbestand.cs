using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_alg_pb_interface_logboek_logbestand : TargetUpdate
	{
		private sgt_alg_pb_interface_logboek_logbestand sgt_alg_pb_interface_logboek_logbestandField;
		public sgt_alg_pb_interface_logboek_logbestand Sgt_alg_pb_interface_logboek_logbestand
		{
			get
			{
				return this.sgt_alg_pb_interface_logboek_logbestandField;
			}
			set
			{
				this.sgt_alg_pb_interface_logboek_logbestandField = value;
			}
		}
	}
}
