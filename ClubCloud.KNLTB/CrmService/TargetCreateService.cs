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
	public class TargetCreateService : TargetCreate
	{
		private service serviceField;

		[XmlElement] //[XmlElement(Order=0)]
		public service Service
		{
			get
			{
				return this.serviceField;
			}
			set
			{
				this.serviceField = value;
				base.RaisePropertyChanged("Service");
			}
		}

		public TargetCreateService()
		{
		}
	}
}