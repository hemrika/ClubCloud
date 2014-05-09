using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_toe_pb_interface_logboek_toernooi_fout : TargetUpdate
	{
		private sgt_toe_pb_interface_logboek_toernooi_fout sgt_toe_pb_interface_logboek_toernooi_foutField;
		[XmlElement(Order = 0)]
		public sgt_toe_pb_interface_logboek_toernooi_fout Sgt_toe_pb_interface_logboek_toernooi_fout
		{
			get
			{
				return this.sgt_toe_pb_interface_logboek_toernooi_foutField;
			}
			set
			{
				this.sgt_toe_pb_interface_logboek_toernooi_foutField = value;
				base.RaisePropertyChanged("Sgt_toe_pb_interface_logboek_toernooi_fout");
			}
		}
	}
}
