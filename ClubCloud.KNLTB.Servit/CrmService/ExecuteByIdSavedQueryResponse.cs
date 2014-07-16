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
	public class ExecuteByIdSavedQueryResponse : Response
	{
		private string stringField;

		[XmlElement] //[XmlElement(Order=0)]
		public string String
		{
			get
			{
				return this.stringField;
			}
			set
			{
				this.stringField = value;
				base.RaisePropertyChanged("String");
			}
		}

		public ExecuteByIdSavedQueryResponse()
		{
		}
	}
}