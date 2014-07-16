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
	public class TargetCreateSgt_toe_ranglijst_deelgetal_dubbelspel : TargetCreate
	{
		private sgt_toe_ranglijst_deelgetal_dubbelspel sgt_toe_ranglijst_deelgetal_dubbelspelField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_toe_ranglijst_deelgetal_dubbelspel Sgt_toe_ranglijst_deelgetal_dubbelspel
		{
			get
			{
				return this.sgt_toe_ranglijst_deelgetal_dubbelspelField;
			}
			set
			{
				this.sgt_toe_ranglijst_deelgetal_dubbelspelField = value;
				base.RaisePropertyChanged("Sgt_toe_ranglijst_deelgetal_dubbelspel");
			}
		}

		public TargetCreateSgt_toe_ranglijst_deelgetal_dubbelspel()
		{
		}
	}
}