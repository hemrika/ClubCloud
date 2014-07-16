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
	public class TargetUpdateSgt_toe_pb_mutaute_inschrijfcontrole_ver : TargetUpdate
	{
		private sgt_toe_pb_mutaute_inschrijfcontrole_ver sgt_toe_pb_mutaute_inschrijfcontrole_verField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_toe_pb_mutaute_inschrijfcontrole_ver Sgt_toe_pb_mutaute_inschrijfcontrole_ver
		{
			get
			{
				return this.sgt_toe_pb_mutaute_inschrijfcontrole_verField;
			}
			set
			{
				this.sgt_toe_pb_mutaute_inschrijfcontrole_verField = value;
				base.RaisePropertyChanged("Sgt_toe_pb_mutaute_inschrijfcontrole_ver");
			}
		}

		public TargetUpdateSgt_toe_pb_mutaute_inschrijfcontrole_ver()
		{
		}
	}
}