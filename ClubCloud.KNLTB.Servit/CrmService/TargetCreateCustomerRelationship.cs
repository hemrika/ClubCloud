using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateCustomerRelationship : TargetCreate
	{
		private customerrelationship customerRelationshipField;
		public customerrelationship CustomerRelationship
		{
			get
			{
				return this.customerRelationshipField;
			}
			set
			{
				this.customerRelationshipField = value;
			}
		}
	}
}
