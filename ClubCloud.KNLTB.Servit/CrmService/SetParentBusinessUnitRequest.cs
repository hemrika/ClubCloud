using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetParentBusinessUnitRequest : Request
	{
		private Guid businessUnitIdField;
		private Guid parentIdField;
		public Guid BusinessUnitId
		{
			get
			{
				return this.businessUnitIdField;
			}
			set
			{
				this.businessUnitIdField = value;
			}
		}
		public Guid ParentId
		{
			get
			{
				return this.parentIdField;
			}
			set
			{
				this.parentIdField = value;
			}
		}
	}
}
