using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_toe_toernooi_in_interface_logboek : TargetUpdate
	{
		private sgt_toe_toernooi_in_interface_logboek sgt_toe_toernooi_in_interface_logboekField;
		[XmlElement(Order = 0)]
		public sgt_toe_toernooi_in_interface_logboek Sgt_toe_toernooi_in_interface_logboek
		{
			get
			{
				return this.sgt_toe_toernooi_in_interface_logboekField;
			}
			set
			{
				this.sgt_toe_toernooi_in_interface_logboekField = value;
				base.RaisePropertyChanged("Sgt_toe_toernooi_in_interface_logboek");
			}
		}
	}
}
