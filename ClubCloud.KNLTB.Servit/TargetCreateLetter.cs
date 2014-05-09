using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateLetter : TargetCreate
	{
		private letter letterField;
		[XmlElement(Order = 0)]
		public letter Letter
		{
			get
			{
				return this.letterField;
			}
			set
			{
				this.letterField = value;
				base.RaisePropertyChanged("Letter");
			}
		}
	}
}
