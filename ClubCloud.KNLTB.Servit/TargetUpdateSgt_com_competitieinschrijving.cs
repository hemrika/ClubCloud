using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_com_competitieinschrijving : TargetUpdate
	{
		private sgt_com_competitieinschrijving sgt_com_competitieinschrijvingField;
		[XmlElement(Order = 0)]
		public sgt_com_competitieinschrijving Sgt_com_competitieinschrijving
		{
			get
			{
				return this.sgt_com_competitieinschrijvingField;
			}
			set
			{
				this.sgt_com_competitieinschrijvingField = value;
				base.RaisePropertyChanged("Sgt_com_competitieinschrijving");
			}
		}
	}
}
