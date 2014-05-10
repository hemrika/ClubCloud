using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_toe_ranglijst_deelgetal_dubbelspel : TargetUpdate
	{
		private sgt_toe_ranglijst_deelgetal_dubbelspel sgt_toe_ranglijst_deelgetal_dubbelspelField;
		public sgt_toe_ranglijst_deelgetal_dubbelspel Sgt_toe_ranglijst_deelgetal_dubbelspel
		{
			get
			{
				return this.sgt_toe_ranglijst_deelgetal_dubbelspelField;
			}
			set
			{
				this.sgt_toe_ranglijst_deelgetal_dubbelspelField = value;
			}
		}
	}
}
