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
	public class SetParentBusinessUnitRequest : Request
	{
		private Guid businessUnitIdField;

		private Guid parentIdField;

		[XmlElement] //[XmlElement(Order=0)]
		public Guid BusinessUnitId
		{
			get
			{
				return this.businessUnitIdField;
			}
			set
			{
				this.businessUnitIdField = value;
				base.RaisePropertyChanged("BusinessUnitId");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public Guid ParentId
		{
			get
			{
				return this.parentIdField;
			}
			set
			{
				this.parentIdField = value;
				base.RaisePropertyChanged("ParentId");
			}
		}

		public SetParentBusinessUnitRequest()
		{
		}
	}
}