using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_alg_pb_interface : TargetCreate
	{
		private sgt_alg_pb_interface sgt_alg_pb_interfaceField;
		public sgt_alg_pb_interface Sgt_alg_pb_interface
		{
			get
			{
				return this.sgt_alg_pb_interfaceField;
			}
			set
			{
				this.sgt_alg_pb_interfaceField = value;
			}
		}
	}
}