using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateContact : TargetUpdate
	{
		private contact contactField;
		[XmlElement(Order = 0)]
		public contact Contact
		{
			get
			{
				return this.contactField;
			}
			set
			{
				this.contactField = value;
				base.RaisePropertyChanged("Contact");
			}
		}
	}
}
