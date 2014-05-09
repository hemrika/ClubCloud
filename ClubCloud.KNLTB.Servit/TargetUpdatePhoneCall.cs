using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdatePhoneCall : TargetUpdate
	{
		private phonecall phoneCallField;
		[XmlElement(Order = 0)]
		public phonecall PhoneCall
		{
			get
			{
				return this.phoneCallField;
			}
			set
			{
				this.phoneCallField = value;
				base.RaisePropertyChanged("PhoneCall");
			}
		}
	}
}
