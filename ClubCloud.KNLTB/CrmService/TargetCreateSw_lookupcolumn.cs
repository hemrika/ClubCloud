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
	public class TargetCreateSw_lookupcolumn : TargetCreate
	{
		private sw_lookupcolumn sw_lookupcolumnField;

		[XmlElement] //[XmlElement(Order=0)]
		public sw_lookupcolumn Sw_lookupcolumn
		{
			get
			{
				return this.sw_lookupcolumnField;
			}
			set
			{
				this.sw_lookupcolumnField = value;
				base.RaisePropertyChanged("Sw_lookupcolumn");
			}
		}

		public TargetCreateSw_lookupcolumn()
		{
		}
	}
}