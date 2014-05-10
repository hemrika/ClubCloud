using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateBusinessUnitRequest : Request
	{
		private Guid entityIdField;
		private BusinessUnitState businessUnitStateField;
		private int businessUnitStatusField;
		public Guid EntityId
		{
			get
			{
				return this.entityIdField;
			}
			set
			{
				this.entityIdField = value;
			}
		}
		public BusinessUnitState BusinessUnitState
		{
			get
			{
				return this.businessUnitStateField;
			}
			set
			{
				this.businessUnitStateField = value;
			}
		}
		public int BusinessUnitStatus
		{
			get
			{
				return this.businessUnitStatusField;
			}
			set
			{
				this.businessUnitStatusField = value;
			}
		}
	}
}
