using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_toe_type_ranglijst : TargetUpdate
	{
		private sgt_toe_type_ranglijst sgt_toe_type_ranglijstField;
		[XmlElement(Order = 0)]
		public sgt_toe_type_ranglijst Sgt_toe_type_ranglijst
		{
			get
			{
				return this.sgt_toe_type_ranglijstField;
			}
			set
			{
				this.sgt_toe_type_ranglijstField = value;
				base.RaisePropertyChanged("Sgt_toe_type_ranglijst");
			}
		}
	}
}
