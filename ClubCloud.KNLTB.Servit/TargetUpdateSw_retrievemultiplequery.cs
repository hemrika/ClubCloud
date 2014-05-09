using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSw_retrievemultiplequery : TargetUpdate
	{
		private sw_retrievemultiplequery sw_retrievemultiplequeryField;
		[XmlElement(Order = 0)]
		public sw_retrievemultiplequery Sw_retrievemultiplequery
		{
			get
			{
				return this.sw_retrievemultiplequeryField;
			}
			set
			{
				this.sw_retrievemultiplequeryField = value;
				base.RaisePropertyChanged("Sw_retrievemultiplequery");
			}
		}
	}
}
