using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_toe_toernooi_resultaten : TargetCreate
	{
		private sgt_toe_toernooi_resultaten sgt_toe_toernooi_resultatenField;
		[XmlElement(Order = 0)]
		public sgt_toe_toernooi_resultaten Sgt_toe_toernooi_resultaten
		{
			get
			{
				return this.sgt_toe_toernooi_resultatenField;
			}
			set
			{
				this.sgt_toe_toernooi_resultatenField = value;
				base.RaisePropertyChanged("Sgt_toe_toernooi_resultaten");
			}
		}
	}
}
