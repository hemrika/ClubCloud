using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_toe_dagtoernooi : TargetCreate
	{
		private sgt_toe_dagtoernooi sgt_toe_dagtoernooiField;
		[XmlElement(Order = 0)]
		public sgt_toe_dagtoernooi Sgt_toe_dagtoernooi
		{
			get
			{
				return this.sgt_toe_dagtoernooiField;
			}
			set
			{
				this.sgt_toe_dagtoernooiField = value;
				base.RaisePropertyChanged("Sgt_toe_dagtoernooi");
			}
		}
	}
}
