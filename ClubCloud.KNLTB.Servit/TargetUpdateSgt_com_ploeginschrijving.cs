using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_com_ploeginschrijving : TargetUpdate
	{
		private sgt_com_ploeginschrijving sgt_com_ploeginschrijvingField;
		[XmlElement(Order = 0)]
		public sgt_com_ploeginschrijving Sgt_com_ploeginschrijving
		{
			get
			{
				return this.sgt_com_ploeginschrijvingField;
			}
			set
			{
				this.sgt_com_ploeginschrijvingField = value;
				base.RaisePropertyChanged("Sgt_com_ploeginschrijving");
			}
		}
	}
}
