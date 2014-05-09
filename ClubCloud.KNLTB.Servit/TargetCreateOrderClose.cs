using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateOrderClose : TargetCreate
	{
		private orderclose orderCloseField;
		[XmlElement(Order = 0)]
		public orderclose OrderClose
		{
			get
			{
				return this.orderCloseField;
			}
			set
			{
				this.orderCloseField = value;
				base.RaisePropertyChanged("OrderClose");
			}
		}
	}
}
