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
	public class GetAllTimeZonesWithDisplayNameRequest : Request
	{
		private int localeIdField;

		private bool returnDynamicEntitiesField;

		[XmlElement] //[XmlElement(Order=0)]
		public int LocaleId
		{
			get
			{
				return this.localeIdField;
			}
			set
			{
				this.localeIdField = value;
				base.RaisePropertyChanged("LocaleId");
			}
		}

		[XmlAttribute]
		public bool ReturnDynamicEntities
		{
			get
			{
				return this.returnDynamicEntitiesField;
			}
			set
			{
				this.returnDynamicEntitiesField = value;
				base.RaisePropertyChanged("ReturnDynamicEntities");
			}
		}

		public GetAllTimeZonesWithDisplayNameRequest()
		{
		}
	}
}