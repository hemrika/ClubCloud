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
	public class TargetCreateUoM : TargetCreate
	{
		private uom uoMField;

		[XmlElement] //[XmlElement(Order=0)]
		public uom UoM
		{
			get
			{
				return this.uoMField;
			}
			set
			{
				this.uoMField = value;
				base.RaisePropertyChanged("UoM");
			}
		}

		public TargetCreateUoM()
		{
		}
	}
}