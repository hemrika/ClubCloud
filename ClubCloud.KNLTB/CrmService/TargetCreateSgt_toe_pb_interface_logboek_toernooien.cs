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
	public class TargetCreateSgt_toe_pb_interface_logboek_toernooien : TargetCreate
	{
		private sgt_toe_pb_interface_logboek_toernooien sgt_toe_pb_interface_logboek_toernooienField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_toe_pb_interface_logboek_toernooien Sgt_toe_pb_interface_logboek_toernooien
		{
			get
			{
				return this.sgt_toe_pb_interface_logboek_toernooienField;
			}
			set
			{
				this.sgt_toe_pb_interface_logboek_toernooienField = value;
				base.RaisePropertyChanged("Sgt_toe_pb_interface_logboek_toernooien");
			}
		}

		public TargetCreateSgt_toe_pb_interface_logboek_toernooien()
		{
		}
	}
}