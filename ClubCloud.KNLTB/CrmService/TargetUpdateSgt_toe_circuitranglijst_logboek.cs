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
	public class TargetUpdateSgt_toe_circuitranglijst_logboek : TargetUpdate
	{
		private sgt_toe_circuitranglijst_logboek sgt_toe_circuitranglijst_logboekField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_toe_circuitranglijst_logboek Sgt_toe_circuitranglijst_logboek
		{
			get
			{
				return this.sgt_toe_circuitranglijst_logboekField;
			}
			set
			{
				this.sgt_toe_circuitranglijst_logboekField = value;
				base.RaisePropertyChanged("Sgt_toe_circuitranglijst_logboek");
			}
		}

		public TargetUpdateSgt_toe_circuitranglijst_logboek()
		{
		}
	}
}