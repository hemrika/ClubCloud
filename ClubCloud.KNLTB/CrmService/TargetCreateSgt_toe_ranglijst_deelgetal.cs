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
	public class TargetCreateSgt_toe_ranglijst_deelgetal : TargetCreate
	{
		private sgt_toe_ranglijst_deelgetal sgt_toe_ranglijst_deelgetalField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_toe_ranglijst_deelgetal Sgt_toe_ranglijst_deelgetal
		{
			get
			{
				return this.sgt_toe_ranglijst_deelgetalField;
			}
			set
			{
				this.sgt_toe_ranglijst_deelgetalField = value;
				base.RaisePropertyChanged("Sgt_toe_ranglijst_deelgetal");
			}
		}

		public TargetCreateSgt_toe_ranglijst_deelgetal()
		{
		}
	}
}