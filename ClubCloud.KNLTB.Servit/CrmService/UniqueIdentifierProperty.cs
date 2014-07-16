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
	[XmlType(Namespace="http://schemas.microsoft.com/crm/2006/WebServices")]
	public class UniqueIdentifierProperty : Property
	{
		private UniqueIdentifier valueField;

		[XmlElement] //[XmlElement(Order=0)]
		public UniqueIdentifier Value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
				base.RaisePropertyChanged("Value");
			}
		}

		public UniqueIdentifierProperty()
		{
		}
	}
}