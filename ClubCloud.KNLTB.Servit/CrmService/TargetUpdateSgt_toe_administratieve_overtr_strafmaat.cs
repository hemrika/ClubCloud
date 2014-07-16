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
	public class TargetUpdateSgt_toe_administratieve_overtr_strafmaat : TargetUpdate
	{
		private sgt_toe_administratieve_overtr_strafmaat sgt_toe_administratieve_overtr_strafmaatField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_toe_administratieve_overtr_strafmaat Sgt_toe_administratieve_overtr_strafmaat
		{
			get
			{
				return this.sgt_toe_administratieve_overtr_strafmaatField;
			}
			set
			{
				this.sgt_toe_administratieve_overtr_strafmaatField = value;
				base.RaisePropertyChanged("Sgt_toe_administratieve_overtr_strafmaat");
			}
		}

		public TargetUpdateSgt_toe_administratieve_overtr_strafmaat()
		{
		}
	}
}