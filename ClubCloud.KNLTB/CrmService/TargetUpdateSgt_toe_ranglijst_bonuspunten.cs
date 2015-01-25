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
	public class TargetUpdateSgt_toe_ranglijst_bonuspunten : TargetUpdate
	{
		private sgt_toe_ranglijst_bonuspunten sgt_toe_ranglijst_bonuspuntenField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_toe_ranglijst_bonuspunten Sgt_toe_ranglijst_bonuspunten
		{
			get
			{
				return this.sgt_toe_ranglijst_bonuspuntenField;
			}
			set
			{
				this.sgt_toe_ranglijst_bonuspuntenField = value;
				base.RaisePropertyChanged("Sgt_toe_ranglijst_bonuspunten");
			}
		}

		public TargetUpdateSgt_toe_ranglijst_bonuspunten()
		{
		}
	}
}